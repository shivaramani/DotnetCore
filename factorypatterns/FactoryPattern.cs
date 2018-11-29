/*
Factory pattern provides a definition of an interface/abstract class (ex: Database class)
and lets the implementing class decide which one to instantiate

creational pattern - lets the class postpone instantiation to sub class
ex: to create MSSQLfactory or PostgreSqlFactory

Product - Database class
ConcreteProduct - Implementing classes - MSSqlDatabase, PostgreSqlDatabase
Creator - class which returns the type of the product. ex: DatabaseFactory returns an object of type product
ConcreteCreator - Factory implementor that returns a concrete product

 */

using System;

public abstract class DataBase{
    public abstract string DBName {get;}
    public abstract string connectionString {get;set;}
    // similarly others etc., 
    // public abstract string timeout {get;set;}
}

public class MSSqlDatabase: DataBase{
    private readonly string _DBName;
     private  string _connectionString;

     public MSSqlDatabase(string connectionString){
         _DBName = "MSSQL";
        _connectionString = connectionString;
        //Console.WriteLine("MSSqlDatabase Constructor");
     }

     public override string DBName{
         get{
             return _DBName;
         }
     }
    public override string connectionString{
        get {
            return _connectionString;
        }
        set{
            _connectionString = value;
        }
    }
}


public class PostgreSqlDatabase: DataBase{
     private readonly string _DBName;
    private string _connectionString;

    public PostgreSqlDatabase(string connectionstring){
        _DBName = "PostgreSql";
        _connectionString = connectionString;
        //Console.WriteLine("PostgreSqlDatabase Constructor - ");
    }
     public override string DBName{
         get{
             return _DBName;
         }
     }

    public override string connectionString{
        get {
            return _connectionString;
        }
        set{
            _connectionString = value;
        }
    }
}

public abstract class DatabaseFactory{
    public abstract DataBase GetDatabase(); 
}

public class PostgreSqlDatabaseFactory : DatabaseFactory
{
    private string _connectionString;
    public PostgreSqlDatabaseFactory(string connectionString){
        //Console.WriteLine("PostgreSqlDatabaseFactory");
        _connectionString = connectionString;
    }
    public override DataBase GetDatabase()
    {
        //Console.WriteLine("PostgreSqlDatabaseFactory - GetDatabase- " + _connectionString);
        return new PostgreSqlDatabase(_connectionString);
    }
}


public class MSSqlDatabaseFactory : DatabaseFactory
{
    private string _connectionString;
    public MSSqlDatabaseFactory(string connectionString){
        //Console.WriteLine("MSSqlDatabaseFactory");
        _connectionString = connectionString;
    }
    public override DataBase GetDatabase()
    {
        //Console.WriteLine("MSSqlDatabaseFactory GetDatabase - " + _connectionString);
        return new MSSqlDatabase(_connectionString);
    }
}

public class FactoryCaller{
    
    public void InvokePattern(){
        Console.WriteLine("Invoking Factory Pattern - ");

        DatabaseFactory factory = null;
        DataBase database = null;

        factory = new MSSqlDatabaseFactory("localhost");
        database = factory.GetDatabase();
        Console.WriteLine("Connection Details DBName and ConnectionString - {0}, {1}", database.DBName, database.connectionString);

        factory = new PostgreSqlDatabaseFactory("pg-localhost");
        database = factory.GetDatabase();
        Console.WriteLine("Connection Details DBName and ConnectionString - {0}, {1}", database.DBName, database.connectionString);

        Console.WriteLine();

    }
    
}