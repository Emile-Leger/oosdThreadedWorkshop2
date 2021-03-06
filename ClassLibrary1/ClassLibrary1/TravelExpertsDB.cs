﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Coding Doug Sarega and Emile Leger

namespace TravelExpertsDB
{
    /// <summary>
    /// each database method on the form.
    /// </summary>
    public static class TravelExpertsDB
    {
                
        #region Packages
        public static List<Package> GetAllPackages()
        {
            // SELECT * FROM Packages (Table)
            // Get the List of all Packages from the Packages Table 
            // returns List<Package> 
            // throws SqlException and Exception
            // checked jan 13 DS
            List<Package> ListPkg = new List<Package>();
            string selectAll = "SELECT * FROM Packages";
            SqlConnection connection = MMATravelExperts.GetConnection();
            SqlCommand selectAllCmd = new SqlCommand(selectAll, connection);
            try
            {
                connection.Open();
                SqlDataReader reader = selectAllCmd.ExecuteReader();
                while(reader.Read())
                {
                    Package pkg = new Package();
                    pkg.PackageId = (int)reader["PackageId"];
                    pkg.PkgName = reader["PkgName"].ToString();
                    pkg.PkgStartDate = (DateTime)reader["PkgStartDate"];
                    pkg.PkgEndDate = (DateTime)reader["PkgEndDate"];
                    pkg.PkgDesc = reader["PkgDesc"].ToString();                    
                    pkg.PkgBasePrice = (decimal)reader["PkgBasePrice"];
                    pkg.PkgAgencyCommission = (decimal)reader["PkgAgencyCommission"];
                    if (!reader.IsDBNull(7))
                        pkg.PkgImg = (byte[])reader["PkgImg"];

                    ListPkg.Add(pkg);
                }
            }
            catch (SqlException SqlEx)
            {
                
                throw SqlEx;
            }
            catch (Exception Ex)
            {
                throw Ex;
            }
            finally
            {
                connection.Close();
            }
            return ListPkg;
        }

        /// <summary>
        /// Gets the package object from the package table
        /// </summary>
        /// <param name="PackageId"></param>
        /// <returns>package</returns>
        public static Package GetPackage(int PackageID)
        // Get the Package for a given PackageID from table Packages
        // PackageId is an int and the PK for Table Package
        // returns type Package containing 1 of package object, !!!! null if no package (only 4 packages) !!!!
        // throws SqlException and Exception
        // checked checked jan 13 DS
        {
            SqlConnection connection = MMATravelExperts.GetConnection();
            string selectStatement = "SELECT * FROM Packages WHERE PackageId=@PackageId";
            SqlCommand selectCommand = new SqlCommand(selectStatement, connection);
            selectCommand.Parameters.AddWithValue("@PackageId", PackageID);
            try
            {
                connection.Open();
                SqlDataReader pkgReader= selectCommand.ExecuteReader(CommandBehavior.SingleRow);
                if(pkgReader.Read())               
                {
                    Package pkg = new Package();
                    pkg.PackageId = (int)pkgReader["PackageId"];
                    pkg.PkgName = pkgReader["PkgName"].ToString();
                    pkg.PkgStartDate= (DateTime)pkgReader["PkgStartDate"];
                    pkg.PkgEndDate=(DateTime)pkgReader["PkgEndDate"];
                    pkg.PkgDesc=pkgReader["PkgDesc"].ToString();
                    pkg.PkgBasePrice=(Decimal)pkgReader["PkgBasePrice"];
                    pkg.PkgAgencyCommission=(Decimal)pkgReader["PkgAgencyCommission"];
                    return pkg;
                }
                else
                {
                    return null;  // no package returns null
                }
                  
            }
            catch (SqlException SqlEx)
            {
                throw SqlEx;
            }
            catch (Exception Ex)
            {
                throw Ex;
            }
            finally 
            {
                connection.Close();
            }
                   
        }
         //<summary>
         //Add a package object to the Package Table
         //</summary>
         //<param name="pkg">package</param>
         //<returns>PackageId (PK)</returns>
        public static int AddPackage(Package pkg)
        {
            // Add a Package to the Packages Table
            // package is the instance of Package class
            // returns the PackageId of the row inserted or -1 if not added to table
            // throws SqlException and Exception
            SqlConnection connection = MMATravelExperts.GetConnection();
            String insertStatement = "INSERT INTO Packages (PkgName, PkgStartDate, PkgEndDate, PkgDesc, PkgBasePrice, PkgAgencyCommission, PkgImg) " +
                "VALUES (@PkgName, @PkgStartDate, @PkgEndDate, @PkgDesc, @PkgBasePrice, @PkgAgencyCommission, @PkgImg)";                        
            SqlCommand insertCommand = new SqlCommand(insertStatement, connection);            
            insertCommand.Parameters.AddWithValue("@PkgName", pkg.PkgName);
            insertCommand.Parameters.AddWithValue("@PkgStartDate", pkg.PkgStartDate);
            insertCommand.Parameters.AddWithValue("@PkgEndDate", pkg.PkgEndDate);
            insertCommand.Parameters.AddWithValue("@PkgDesc", pkg.PkgDesc);
            insertCommand.Parameters.AddWithValue("@PkgBasePrice", pkg.PkgBasePrice);
            insertCommand.Parameters.AddWithValue("@PkgAgencyCommission", pkg.PkgAgencyCommission);
            if (pkg.PkgImg == null)
                insertCommand.Parameters.AddWithValue("@PkgImg", SqlDbType.VarBinary);
            else
                insertCommand.Parameters.AddWithValue("@PkgImg", pkg.PkgImg);
            try
            {
                connection.Open();
                int numRows = insertCommand.ExecuteNonQuery();
                if (numRows > 0)
                {
                    int prodIDcheck=0;
                    string selectStatement = "SELECT PackageId FROM Packages where PkgName=@PkgName and PkgStartDate=@PkgStartDate and PkgEndDate=@PkgEndDate "+
                                             "and PkgDesc=@PkgDesc and PkgBasePrice=@PkgBasePrice and PkgAgencyCommission=@PkgAgencyCommission";
                    SqlCommand selectCommand = new SqlCommand(selectStatement, connection);
                    selectCommand.Parameters.AddWithValue("@PkgName", pkg.PkgName);
                    selectCommand.Parameters.AddWithValue("@PkgStartDate", pkg.PkgStartDate);
                    selectCommand.Parameters.AddWithValue("@PkgEndDate", pkg.PkgEndDate);
                    selectCommand.Parameters.AddWithValue("@PkgDesc", pkg.PkgDesc);
                    selectCommand.Parameters.AddWithValue("@PkgBasePrice", pkg.PkgBasePrice);
                    selectCommand.Parameters.AddWithValue("@PkgAgencyCommission", pkg.PkgAgencyCommission);
                    SqlDataReader reader = selectCommand.ExecuteReader();
                    while (reader.Read())
                    {
                        prodIDcheck = Convert.ToInt32(reader["PackageId"]);
                    }                    
                    return prodIDcheck;
                }
                else
                {
                    return -1;
                }
            }
            catch (SqlException SqlEx)
            {
                throw SqlEx;
            }            
            finally
            {
                connection.Close();
            }
        }

        /// <summary>
        /// Delete a package from Packages Table
        /// </summary>
        /// <param name="pkg">package</param>
        /// <returns>bool</returns>
        public static bool DeletePackage(int PackageId)
        // Deletes the package object from Packages Table
        // pkg is the instance of entity Package class
        // returns an int 1+ for rows changed and 0 for no rows
        // throws SqlException and Exception
        {
            SqlConnection connection = MMATravelExperts.GetConnection();
            

            string deleteStatement = "DELETE FROM Packages WHERE PackageId=@PackageId";
            //and "+
            //    "PkgName=@PkgName and PkgStartDate=@PkgStartDate and "+
            //    "PkgEndDate=@PkgEndDdate and PkgDesc=@PkgDesc and "+
            //    "PkgBasePrice=@PkgBasePrice and PkgAgencyCommission=@PkgAgencyCommission";
           
            SqlCommand deleteCommand = new SqlCommand(deleteStatement, connection);
            deleteCommand.Parameters.AddWithValue("@PackageId",PackageId);
            
            //deleteCommand.Parameters.AddWithValue("@PkgName",pkg.PkgName);
            //deleteCommand.Parameters.AddWithValue("@PkgStartDate",pkg.PkgStartDate);
            //deleteCommand.Parameters.AddWithValue("@PkgEndDdate",pkg.PkgEndDate);
            //deleteCommand.Parameters.AddWithValue("@PkgDesc",pkg.PkgDesc);
            //deleteCommand.Parameters.AddWithValue("@PkgBasePrice",pkg.PkgBasePrice);
            //deleteCommand.Parameters.AddWithValue("@PkgAgencyCommission",pkg.PkgAgencyCommission);
            try
            {
                connection.Open();
                
                int count = deleteCommand.ExecuteNonQuery(); // count the number of row affected
                //System.Environment.Exit(1);
                if (count > 0)
                {
                    return true; // row(s) deleted
                }
                else
                {
                    return false; // no row deleted
                }
            }
            catch (SqlException SqlEx)
            {
                throw SqlEx;
            }
            catch (Exception Ex)
            {
                throw Ex;
            }
        }
         //<summary>
         //Updates a package in the Packages Table
         //</summary>
         //<param name="oldPkg">old package</param>
         //<param name="newPkg">new package</param>
         //<returns></returns>
        public static bool UpdatePackage(Package oldPkg, Package newPkg)
        {
            // Updates the Packages Table 
            // parameter oldPkg ... the old row as an instance of Package class
            // parameter newPkg ... the new row as an instance of Package class
            // returns true row updated, false row not updated
            // throws SqlException and Exception
            SqlConnection connection = MMATravelExperts.GetConnection();
            string updateStatement="UPDATE Packages SET PkgName=@newPkgName, "+
                                   "PkgStartDate=@newPkgStartDate, PkgEndDate=@newPkgEndDate, "+
                                   "PkgDesc=@newPkgDesc, PkgBasePrice=@newPkgBasePrice, PkgAgencyCommission=@newPkgAgencyCommission, PkgImg=@newPkgImg " +
                                   "WHERE PackageId=@oldPackageId and PkgName=@oldPkgName and PkgStartDate=@oldPkgStartDate and "+
                                   "PkgEndDate=@oldPkgEndDate and PkgDesc=@oldPkgDesc and PkgBasePrice=@oldPkgBasePrice and "+
                                   "PkgAgencyCommission=@oldPkgAgencyCommission";
            SqlCommand updateCommand = new SqlCommand(updateStatement,connection);
            // new package listing
            updateCommand.Parameters.AddWithValue("@newPackageId",newPkg.PackageId);
            updateCommand.Parameters.AddWithValue("@newPkgName",newPkg.PkgName);
            updateCommand.Parameters.AddWithValue("@newPkgStartDate",newPkg.PkgStartDate);
            updateCommand.Parameters.AddWithValue("@newPkgEndDate",newPkg.PkgEndDate);
            updateCommand.Parameters.AddWithValue("@newPkgDesc",newPkg.PkgDesc);
            updateCommand.Parameters.AddWithValue("@newPkgBasePrice",newPkg.PkgBasePrice);
            updateCommand.Parameters.AddWithValue("@newPkgAgencyCommission",newPkg.PkgAgencyCommission);
            if (newPkg.PkgImg == null)
                updateCommand.Parameters.AddWithValue("@newPkgImg", SqlDbType.VarBinary);
            else
                updateCommand.Parameters.AddWithValue("@newPkgImg", newPkg.PkgImg);
            // old package listing
            updateCommand.Parameters.AddWithValue("@oldPackageId",oldPkg.PackageId);
            updateCommand.Parameters.AddWithValue("@oldPkgName",oldPkg.PkgName);
            updateCommand.Parameters.AddWithValue("@oldPkgStartDate",oldPkg.PkgStartDate);
            updateCommand.Parameters.AddWithValue("@oldPkgEndDate",oldPkg.PkgEndDate);
            updateCommand.Parameters.AddWithValue("@oldPkgDesc",oldPkg.PkgDesc);
            updateCommand.Parameters.AddWithValue("@oldPkgBasePrice",oldPkg.PkgBasePrice);
            updateCommand.Parameters.AddWithValue("@oldPkgAgencyCommission",oldPkg.PkgAgencyCommission);
            try
            {
                connection.Open();
                int count = updateCommand.ExecuteNonQuery();
                if (count>0)
                {
                    return true; // rows updated
                }
                else
                {
                    return false; //rows not updated
                }
            }
            catch (SqlException SqlEx)
            {
                throw SqlEx;
            }
            catch (Exception Ex)
            {
                throw Ex;
            }
            finally
            {
                connection.Close();
            }
        }
        #endregion

        #region Packages_Products_Suppliers

        /// <summary>
        /// Add a package_product_supplier to the Packages_Products_Suppliers table
        /// </summary>
        /// <param name="prod">Package_Product_Supplier instance</param>
        /// <returns>PackageId</returns>
        public static int AddPackages_Products_Suppliers(Package_Product_Supplier pps)
        {
            // Add a package_product_supplier to the Packages_Products_Suppliers Table
            // pps is the instance of Product class
            // returns the ProductId of the row inserted or -1 if not added to table
            // throws SqlException and Exception
            SqlConnection connection = MMATravelExperts.GetConnection();
            String insertStatement = "INSERT INTO Products (PackageId, ProductSupplierId) VALUES (@PackageId, @ProductSupplierId)";
            SqlCommand insertCommand = new SqlCommand(insertStatement, connection);
            insertCommand.Parameters.AddWithValue("@PackageId", pps.PackageId);
            insertCommand.Parameters.AddWithValue("@ProductSupplierId", pps.ProductSupplierId);
            try
            {
                connection.Open();
                int numRows = insertCommand.ExecuteNonQuery();
                if (numRows > 0)
                {
                    string selectStatement = "SELECT IDENT_CURRENT('PackageId') FROM Packages_Products_Suppliers";
                    SqlCommand selectCommand = new SqlCommand(selectStatement, connection);
                    int packageId = (int)(selectCommand.ExecuteScalar());
                    return packageId;
                }
                else
                {
                    return -1;
                }
            }
            catch (SqlException SqlEx)
            {
                throw SqlEx;
            }
            catch (Exception Ex)
            {
                throw Ex;
            }
            finally
            {
                connection.Close();
            }
        }

        public static bool UpdatePackages_Products_Suppliers(Package_Product_Supplier oldPps, Package_Product_Supplier newPps)
        {
            // Updates the Packages_Products_Suppliers Table 
            // parameter oldPos ... the old row as an instance of Package_Product_Supplier class
            // parameter newPps ... the new row as an instance of Package_Product_Supplier class
            // returns true row updated, false row not updated
            // throws SqlException and Exception
            SqlConnection connection = MMATravelExperts.GetConnection();
            string updateStatement = "UPDATE Products SET PackageId=@newPackageId, ProductSupplierId=@newProductSupplierId, " +
                    "WHERE PackageId=@oldPackageId and ProductSupplierId=@oldProductSupplierId";
            SqlCommand updateCommand = new SqlCommand(updateStatement, connection);
            // new product listing
            updateCommand.Parameters.AddWithValue("@newnewPackageId", newPps.PackageId);
            updateCommand.Parameters.AddWithValue("@newProductSupplierId", newPps.ProductSupplierId);

            // old product listing
            updateCommand.Parameters.AddWithValue("@oldPackageId", oldPps.PackageId);
            updateCommand.Parameters.AddWithValue("@oldProductSupplierId", oldPps.ProductSupplierId);

            try
            {
                connection.Open();
                int count = updateCommand.ExecuteNonQuery();
                if (count > 0)
                {
                    return true; // rows updated
                }
                else
                {
                    return false; //rows not updated
                }
            }
            catch (SqlException SqlEx)
            {
                throw SqlEx;
            }
            catch (Exception Ex)
            {
                throw Ex;
            }
            finally
            {
                connection.Close();
            }
        }
        #endregion

        #region Products

        /// <summary>
        /// Add a product to the Products table 
        /// bugfix E.L.
        /// </summary>
        /// <param name="prod">product instance</param>
        /// <returns>ProductId</returns>
        public static int AddProduct(Product prod)
        {
            // Add a Product to the products Table
            // prod is the instance of Product class
            // returns the ProductId of the row inserted or -1 if not added to table
            // throws SqlException and Exception
            SqlConnection connection = MMATravelExperts.GetConnection();
            string insertStatement = "INSERT INTO Products (ProdName) VALUES (@ProdName)";
            SqlCommand insertCommand = new SqlCommand(insertStatement, connection);            
            insertCommand.Parameters.AddWithValue("@ProdName", prod.ProdName);
            try
            {
                connection.Open();
                int numRows = insertCommand.ExecuteNonQuery();
                if (numRows>0)
                {
                    string selectStatement="SELECT ProductId FROM Products where ProdName=@ProdName";
                    SqlCommand selectCommand = new SqlCommand(selectStatement, connection);
                    selectCommand.Parameters.AddWithValue("@ProdName", prod.ProdName);
                    int prodId = (int)(selectCommand.ExecuteScalar());
                    return prodId;
                }
                else
                {
                    return -1;
                }
            }
            catch (SqlException SqlEx)
            {
                throw SqlEx;  
            }
            catch (Exception Ex)
            {
                throw Ex;
            }
            finally 
            {
                connection.Close();
            }
        }

        public static bool UpdateProduct(Product oldProd,Product newProd)
        {
            // Updates the Products Table 
            // parameter oldProd ... the old row as an instance of Product class
            // parameter newProd ... the new row as an instance of Product class
            // returns true row updated, false row not updated
            // throws SqlException and Exception
            SqlConnection connection = MMATravelExperts.GetConnection();
            string updateStatement="UPDATE Products SET ProdName=@newProdName "+
                    "WHERE ProductId=@oldProductId and ProdName=@oldProdName";
            SqlCommand updateCommand = new SqlCommand(updateStatement,connection);
            // new product listing
            updateCommand.Parameters.AddWithValue("@newProductId",newProd.ProductId);
            updateCommand.Parameters.AddWithValue("@newProdName",newProd.ProdName);

            // old product listing
            updateCommand.Parameters.AddWithValue("@oldProductId",oldProd.ProductId);
            updateCommand.Parameters.AddWithValue("@oldProdName",oldProd.ProdName);

            try
            {
                connection.Open();
                int count = updateCommand.ExecuteNonQuery();
                if (count>0)
                {
                    return true; // rows updated
                }
                else
                {
                    return false; //rows not updated
                }
            }
            catch (SqlException SqlEx)
            {
                throw SqlEx;
            }
            catch (Exception Ex)
            {
                throw Ex;
            }
            finally
            {
                connection.Close();
            }
        }
        /// <summary>
        /// retrieves each product from the products table
        /// </summary>
        /// <returns>the complete list of Products</returns>
        public static List<Product> GetAllProducts()
        {
            List<Product> products = new List<Product>();
            SqlConnection connection = MMATravelExperts.GetConnection();
            string selectString = "select * from products";
            SqlCommand selectCommand = new SqlCommand(selectString,connection);
            try
            {
                connection.Open();
                SqlDataReader reader = selectCommand.ExecuteReader();
                while (reader.Read())
                {
                    Product p = new Product();
                    p.ProductId = Convert.ToInt32(reader["ProductId"]);
                    p.ProdName = Convert.ToString(reader["ProdName"]);
                    products.Add(p);
                }
                return products;
            }
            catch(SqlException ex)
            {
                throw ex;
            }
            finally
            {
                connection.Close();
            }
        }
        public static List<Product> GetProductsFromSupplierId(int SupplierId)
        // Get the List of products from Procts Table for a given SupplierId from Table Suppliers
        // SupplierId is an int and the PK for Table Package
        // returns List type Product, null if no product or exception
        // throws SqlException and Exception
        // checked Jan 17/16 DS
        {
            SqlConnection connection = MMATravelExperts.GetConnection();
            List<Product> products = new List<Product>();
            string selectStatement = "SELECT p.ProductID, p.ProdName FROM Products p, " +
                                     "Products_Suppliers ps, Suppliers s " +
                                     "WHERE p.ProductId=ps.ProductId and ps.SupplierId=s.SupplierId and " +
                                     "s.SupplierId=@SupplierId";
            //SELECT s.SupplierId, s.SupName FROM [dbo].[Suppliers] s, [dbo].[Products_Suppliers] ps, [dbo].[Products] p
            //WHERE s.SupplierId=ps.SupplierId and p.ProductId=ps.ProductId and p.ProductId=2
            SqlCommand selectCommand = new SqlCommand(selectStatement, connection);
            selectCommand.Parameters.AddWithValue("@SupplierId", SupplierId);
            try
            {
                connection.Open();
                SqlDataReader pkgReader = selectCommand.ExecuteReader();
                while (pkgReader.Read())
                {
                    Product prod = new Product();
                    prod.ProdName = Convert.ToString(pkgReader["ProdName"]);
                    prod.ProductId = (int)pkgReader["ProductId"];
                    products.Add(prod);
                }
            }
            catch (SqlException SqlEx)
            {
                throw SqlEx;
            }
            catch (Exception Ex)
            {
                throw Ex;
            }
            finally
            {
                connection.Close();
            }
            return products;  // return the list of products
        }

        // select the list of products for each package given the PackageId from table Packages
        public static List<Product> GetProductsFromPackageId(int PackageId)
        // Get the Lsit of products from Products Table for a given PackageID from Table Packages
        // PackageId is an int and the PK for Table Package
        // returns List type Package, null if no package or exceptio
        // throws SqlException and Exception
        // checked Jan 16 DS
        {
            SqlConnection connection = MMATravelExperts.GetConnection();
            List<Product> ListProducts = new List<Product>();
            string selectStatement = "SELECT p.ProductID, p.ProdName FROM Packages pack, " +
                    "Packages_Products_Suppliers pps, Products_Suppliers ps, Products p " +
                    "WHERE pack.PackageId=pps.PackageId and pps.ProductSupplierId=ps.ProductSupplierId and " +
                    "p.ProductId=ps.ProductId and pack.PackageId=@PackageId";
            //SELECT p.ProductID, p.ProdName FROM Packages pack, 
            //       Packages_Products_Suppliers pps, Products_Suppliers ps, Products p 
            //       WHERE pack.PackageId=pps.PackageId and pps.ProductSupplierId=ps.ProductSupplierId and 
            //       p.ProductId=ps.ProductId and pack.PackageId=1
            SqlCommand selectCommand = new SqlCommand(selectStatement, connection);
            selectCommand.Parameters.AddWithValue("@PackageId", PackageId);
            try
            {
                connection.Open();
                SqlDataReader pkgReader = selectCommand.ExecuteReader();
                while (pkgReader.Read())
                {
                    Product prod = new Product();
                    prod.ProdName = Convert.ToString(pkgReader["ProdName"]);
                    prod.ProductId = (int)pkgReader["ProductId"];
                    ListProducts.Add(prod);
                }
            }
            catch (SqlException SqlEx)
            {
                throw SqlEx;
            }
            catch (Exception Ex)
            {
                throw Ex;
            }
            finally
            {
                connection.Close();
            }
            return ListProducts;  // return the list of products
        }
        #endregion

        #region Suppliers

        public static int AddSupplier(Supplier supp)
        {
            // Add a Supplier to the Suppliers Table
            // supp is the instance of Supplier class
            // returns the SupplierId of the row inserted or -1 if not added to table
            // throws SqlException and Exception
            SqlConnection connection = MMATravelExperts.GetConnection();
            String insertStatement = "INSERT INTO Suppliers (SupplierId,SupName) VALUES (@SupplierId, @SupName)";
            SqlCommand insertCommand = new SqlCommand(insertStatement, connection);
            insertCommand.Parameters.AddWithValue("@SupplierId", supp.SupplierID);
            insertCommand.Parameters.AddWithValue("@SupName", supp.SupName);
            try
            {
                connection.Open();
                int numRows = insertCommand.ExecuteNonQuery();
                return numRows;
            }
            catch (SqlException SqlEx)
            {
                throw SqlEx;
            }
            catch (Exception Ex)
            {
                throw Ex;
            }
            finally
            {
                connection.Close();
            }
        }

        public static bool UpdateSupplier(Supplier oldSupp, Supplier newSupp)
        {
            // Updates the Suppliers Table 
            // parameter oldSupp ... the old row as an instance of Supplier class
            // parameter newSupp ... the new row as an instance of Supplier class
            // returns true row updated, false row not updated
            // throws SqlException and Exception
            SqlConnection connection = MMATravelExperts.GetConnection();
            string updateStatement = "UPDATE Suppliers SET SupName=@newSupName " +
                    "WHERE SupplierId=@oldSupplierId and SupName=@oldSupName";
            SqlCommand updateCommand = new SqlCommand(updateStatement, connection);
            // new supplier listing
            updateCommand.Parameters.AddWithValue("@newSupplierId", newSupp.SupplierID);
            updateCommand.Parameters.AddWithValue("@newSupName", newSupp.SupName);

            // old supplier listing
            updateCommand.Parameters.AddWithValue("@oldSupplierId", oldSupp.SupplierID);
            updateCommand.Parameters.AddWithValue("@oldSupName", oldSupp.SupName);

            try
            {
                connection.Open();
                int count = updateCommand.ExecuteNonQuery();
                if (count > 0)
                {
                    return true; // rows updated
                }
                else
                {
                    return false; //rows not updated
                }
            }
            catch (SqlException SqlEx)
            {
                throw SqlEx;
            }
            catch (Exception Ex)
            {
                throw Ex;
            }
            finally
            {
                connection.Close();
            }
        }
        /// <summary>
        /// retrieves each product from the products table
        /// </summary>
        /// <returns>the complete list of Products</returns>
        public static List<Supplier> GetAllSuppliers()
        {
            List<Supplier> products = new List<Supplier>();
            SqlConnection connection = MMATravelExperts.GetConnection();
            string selectString = "select * from Suppliers";
            SqlCommand selectCommand = new SqlCommand(selectString, connection);
            try
            {
                connection.Open();
                SqlDataReader reader = selectCommand.ExecuteReader();
                while (reader.Read())
                {
                    Supplier s = new Supplier();
                    s.SupplierID= Convert.ToInt32(reader["SupplierId"]);
                    s.SupName = Convert.ToString(reader["SupName"]);
                    products.Add(s);
                }
                return products;
            }
            catch (SqlException ex)
            {
                throw ex;
            }
            finally
            {
                connection.Close();
            }
        }
        public static List<Supplier> GetSuppliersFromProductId(int ProductId)
        // Get the List of suppliers from Suppliers Table for a given ProductId from Table Products
        // SupplierId is an int and the PK for Table Package
        // returns List type Product, null if no product or exception
        // throws SqlException and Exception
        // checked Jan 17/16 DS
        {
            SqlConnection connection = MMATravelExperts.GetConnection();
            List<Supplier> ListSupplier = new List<Supplier>();
            string selectStatement = "SELECT s.SupplierId, s.SupName FROM Products p, " +
                                     "Products_Suppliers ps, Suppliers s " +
                                     "WHERE p.ProductId=ps.ProductId and ps.SupplierId=s.SupplierId and " +
                                     "p.ProductId=@ProductId";
            //SELECT p.ProductId, p.ProdName, s.SupName 
            //    FROM [dbo].[Suppliers] s, [dbo].[Products_Suppliers] ps, [dbo].[Products] p
            //    WHERE s.SupplierId=ps.SupplierId and p.ProductId=ps.ProductId and s.SupplierId=1713
            SqlCommand selectCommand = new SqlCommand(selectStatement, connection);
            selectCommand.Parameters.AddWithValue("@ProductId", ProductId);
            try
            {
                connection.Open();
                SqlDataReader pkgReader = selectCommand.ExecuteReader();
                while (pkgReader.Read())
                {
                    Supplier supp = new Supplier();
                    supp.SupName = Convert.ToString(pkgReader["SupName"]);
                    supp.SupplierID = (int)pkgReader["SupplierId"];
                    ListSupplier.Add(supp);
                }
            }
            catch (SqlException SqlEx)
            {
                throw SqlEx;
            }
            catch (Exception Ex)
            {
                throw Ex;
            }
            finally
            {
                connection.Close();
            }
            return ListSupplier;  // return the list of suppliers
        }
        #endregion

        #region ProductSuppliers

        public static int AddProduct_Supplier(Product_Supplier prodSupp)
        {
            // Add a Product_Supplier instance to the Product_Suppliers Table
            // ProdSupp is the instance of Product_Supplier class
            // returns the ProductSupplierId (pk) of the row inserted or -1 if not added to table
            // throws SqlException and Exception
            SqlConnection connection = MMATravelExperts.GetConnection();
            String insertStatement = "INSERT INTO Products_Suppliers (ProductId, SupplierID) " +
                                     "VALUES (@ProductId, @SupplierId)";
            SqlCommand insertCommand = new SqlCommand(insertStatement, connection);            
            insertCommand.Parameters.AddWithValue("@ProductId", prodSupp.ProductId);
            insertCommand.Parameters.AddWithValue("@SupplierId", prodSupp.SupplierId);
            try
            {
                connection.Open();
                int numRows = insertCommand.ExecuteNonQuery();
                if (numRows > 0)
                {
                    string selectStatement = "SELECT ProductSupplierId FROM Products_Suppliers where ProductId=@ProductId and SupplierID=@SupplierID";
                    SqlCommand selectCommand = new SqlCommand(selectStatement, connection);
                    selectCommand.Parameters.AddWithValue("@ProductId",prodSupp.ProductId);
                    selectCommand.Parameters.AddWithValue("@SupplierID",prodSupp.SupplierId);
                    int suppId = (int)(selectCommand.ExecuteScalar());
                    return suppId;
                }
                else
                {
                    return -1;
                }
            }
            catch (SqlException SqlEx)
            {
                throw SqlEx;
            }
            catch (Exception Ex)
            {
                throw Ex;
            }
            finally
            {
                connection.Close();
            }
        }

        public static bool UpdateProduct_Supplier(Product_Supplier oldSupp, Product_Supplier newSupp)
        {
            // Updates the Product_Suppliers Table 
            // parameter oldProdSupp ... the old row as an instance of Product_Supplier class
            // parameter newProdSupp ... the new row as an instance of Product_Supplier class
            // returns true row updated, false row not updated
            // throws SqlException and Exception
            SqlConnection connection = MMATravelExperts.GetConnection();
            string updateStatement = "UPDATE Products_Suppliers SET ProductSupplierId=@newProductSupplierId, ProductId=@newSupplierId, "+
                    "SupplierID=@newSupplierId WHERE "+
                    "ProductSupplierId=@oldProductSupplierId and ProductId=@newProductId and SupplierId=@oldSupplierId";
            SqlCommand updateCommand = new SqlCommand(updateStatement, connection);
            // new products_supplier listing
            updateCommand.Parameters.AddWithValue("@newProductSupplierId", newSupp.ProductSupplierId);
            updateCommand.Parameters.AddWithValue("@newProductId", newSupp.ProductId);
            updateCommand.Parameters.AddWithValue("@newSupplierId", newSupp.SupplierId);

            // old products_supplier listing
            updateCommand.Parameters.AddWithValue("@oldProductSupplierId", oldSupp.ProductSupplierId);
            updateCommand.Parameters.AddWithValue("@newProductId", oldSupp.ProductId);
            updateCommand.Parameters.AddWithValue("@oldSupplierId", oldSupp.SupplierId);
            try
            {
                connection.Open();
                int count = updateCommand.ExecuteNonQuery();
                if (count > 0)
                {
                    return true; // rows updated
                }
                else
                {
                    return false; //rows not updated
                }
            }
            catch (SqlException SqlEx)
            {
                throw SqlEx;
            }
            catch (Exception Ex)
            {
                throw Ex;
            }
            finally
            {
                connection.Close();
            }
        }

        /// <summary>
        /// query for the Product and supplier names on a given Package ID
        /// Emile,  debugged and working
        /// </summary>
        /// <param name="packageId">the Package id</param>
        /// <returns> list of productsupplier object containing the names of the products and suppliers</returns>
        public static List<Product_Supplier> getProductSuppliers(int packageId)
        {            
            
            SqlConnection connection = MMATravelExperts.GetConnection();
            string selectStatement = "select Products_Suppliers.ProductSupplierId, ProdName, SupName, Products.ProductId, Suppliers.SupplierId from Products_Suppliers, Packages_Products_Suppliers, Products, Suppliers " +
                                     "where Packages_Products_Suppliers.PackageId = @PackageId and "+
                                     "Packages_Products_Suppliers.ProductSupplierId = Products_Suppliers.ProductSupplierId and "+
                                     "Products.ProductId = Products_Suppliers.ProductId and "+
                                     "Suppliers.SupplierId = Products_Suppliers.SupplierId";
            SqlCommand selectCommand = new SqlCommand(selectStatement, connection);
            selectCommand.Parameters.AddWithValue("@PackageId", packageId);
            try
            {
                connection.Open();
                SqlDataReader reader = selectCommand.ExecuteReader();
                
                List<Product_Supplier> productSuppliersList = new List<Product_Supplier>();
                while (reader.Read())
                {                    
                    Product_Supplier myPS = new Product_Supplier();
                    myPS.ProductSupplierId = (int)reader["ProductSupplierId"];
                    myPS.ProductName = reader["ProdName"].ToString();
                    myPS.ProductId = (int)reader["ProductID"];
                    myPS.SupName = reader["SupName"].ToString();
                    myPS.SupplierId = (int)reader["SupplierID"];
                    productSuppliersList.Add(myPS);
                }
                return productSuppliersList;
            }
            catch (SqlException ex)
            {
                throw ex;
            }
            finally
            {
                connection.Close();
            }
        }
        /// <summary>
        /// Retrieves each Product Supplier in a list
        /// </summary>
        /// <returns></returns>
        public static List<Product_Supplier> getAllProductSuppliers()
        {

            SqlConnection connection = MMATravelExperts.GetConnection();
            string selectStatement = "select ProdName, SupName, Products.ProductId, Suppliers.SupplierId, ProductSupplierId from Products_Suppliers, Products, Suppliers "+
                                     "where Products.ProductId=Products_Suppliers.ProductId AND Suppliers.SupplierId=Products_Suppliers.SupplierId";
                                     
            SqlCommand selectCommand = new SqlCommand(selectStatement, connection);            
            try
            {
                connection.Open();
                SqlDataReader reader = selectCommand.ExecuteReader();

                List<Product_Supplier> productSuppliersList = new List<Product_Supplier>();
                while (reader.Read())
                {
                    Product_Supplier myPS = new Product_Supplier();
                    myPS.ProductSupplierId = (int)reader["ProductSupplierId"];
                    myPS.ProductName = reader["ProdName"].ToString();
                    myPS.ProductId = (int)reader["ProductID"];
                    myPS.SupName = reader["SupName"].ToString();
                    myPS.SupplierId = (int)reader["SupplierID"];
                    productSuppliersList.Add(myPS);
                }
                return productSuppliersList;
            }
            catch (SqlException ex)
            {
                throw ex;
            }
            finally
            {
                connection.Close();
            }
        }

        /// <summary>
        /// Removes a product supplier from a package. the method will delete a row from the Packages_Products_Suppliers table.
        /// </summary>
        /// <param name="productSupplierId">the productSupplier to be deleted</param>
        /// <param name="PackageId">the package to delete from</param>
        /// <returns>true if the delete was successful</returns>
        public static bool removeProductSupplier(int productSupplierId, int PackageId)
        {
            SqlConnection connection = MMATravelExperts.GetConnection();
            string deleteString = "delete from Packages_Products_Suppliers where ProductSupplierId=@ProductSupplierId and PackageId=@PackageId";
            SqlCommand deleteCommand = new SqlCommand(deleteString, connection);
            deleteCommand.Parameters.AddWithValue("@ProductSupplierId", productSupplierId);
            deleteCommand.Parameters.AddWithValue("@PackageId", PackageId);
            try
            {
                connection.Open();
                int result = deleteCommand.ExecuteNonQuery();
                if (result == 1)
                    return true;
                else
                    return false;
            }
            catch (SqlException ex)
            {
                throw ex;
            }
            finally
            {
                connection.Close();
            }
        }

        public static int RemoveAllProductSuppliersFromPackage(int packageID)
        {
            int results;
            SqlConnection connection = MMATravelExperts.GetConnection();
            string deleteStatement = "Delete from Packages_Products_Suppliers where PackageId=@PackageId";
            SqlCommand deleteCommand = new SqlCommand(deleteStatement, connection);
            deleteCommand.Parameters.AddWithValue("@PackageId",packageID);
            try
            {
                connection.Open();
                results = deleteCommand.ExecuteNonQuery();
                return results;
            }
            catch (SqlException ex)
            {
                throw ex;
            }
            finally
            {
                connection.Close();
            }
        }
        /// <summary>
        /// Adds the input product supplier to the input package with a new row inserted into the packages_products_suppliers table
        /// </summary>
        /// <param name="ps">the product-supplier to add</param>
        /// <param name="pack">the package to add to</param>
        /// <returns>true if successful, false if fail</returns>
        public static bool addProductSupplierToPackage(Product_Supplier ps, Package pack)
        {
            SqlConnection connection = MMATravelExperts.GetConnection();
            string insertStatement = "Insert into Packages_Products_Suppliers values (@packageId,@productSupplierId)";
            SqlCommand insertCommand = new SqlCommand(insertStatement, connection);
            insertCommand.Parameters.AddWithValue("@PackageId", pack.PackageId);
            insertCommand.Parameters.AddWithValue("@productSupplierId", ps.ProductSupplierId);
            try
            {
                connection.Open();
                int result = insertCommand.ExecuteNonQuery();
                if (result == 1)
                    return true;
                else
                    return false;
            }
            catch (SqlException ex)
            {
                throw ex;
            }
            finally
            {
                connection.Close();
            }
        }
    }
                                #endregion    
}
