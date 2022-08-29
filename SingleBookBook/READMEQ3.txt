SingleBook is a simple project in C#. It is done using file handling mechanism in C#. The record of the customer can be added, updated, searched and deleted. It is a simple project made using console application of C#. This means, no graphics component are added. 

This repo contains basic and first version of blueprint for single ledger book keeping system. 

Few Understanding 

as of now base class is focus on main class of domain. rest other class like login/oauth related stuff are keep away so that we can focus on actual domain 

LedgerEntry.cs
 * this file contains all fields that we need to consider in order to build ledger system
 * as of now system will build on simple file system( may be CSV or parquet)
 * Later on we will migrate this domain to sophisticated database 
 * Class have basic validation code, we can add more validation on later phase 


