# NityNiteCMS
Sample CMS Using C# .Net MVC and Entity Framework

![alt tag](https://cloud.githubusercontent.com/assets/26331976/23884101/1da7bbd4-0841-11e7-9a9c-28b9f71cef66.gif)


## Usage
1. page content management (http://url/Content/), using backend management to maintain page content
2. backend system for employee, client, product (http://url/Employee, http://url/Customer, http://url/Product)
3. modify web.config to your own connection string, code-first entity will create tables automatic.

## Prerequisites
Microsoft Visual Studio 2016
SQL Server 2015
.Net Framework 4.5.2

## Structure
<!-- language:console -->

    |-- project
        |-- Data Access Layer
          |-- DataAccessLayer
            |-- CMSDBDAL.cs                 # Initiate dataset using entity framework
            |-- DataBaseSettingse.cs        # Initiate setting database related
        |-- Models
          |-- BusinessEntities
             |-- AuthStatus.cs              # enum of authentication
             |-- BillingMethod.cs           # enum of payment method
             |-- Content.cs                 # class for page content business model
             |-- ContentStatus.cs           # enum of page type
             |-- Customer.cs                # class for customer business model
             |-- Employee.cs                # class for employee business model
             |-- Product.cs                 # class for product business model
             |-- ProductCategorie.cs          # enum for product categories
          |-- BusinessLayer
             |-- BusinessSettings.cs          # Any global like business function will be putting here
             |-- ContentBusinessLayer.cs      # Business layer for page content
             |-- CustomerBusinessLayer.cs     # Business layer for customer management for cms
             |-- EmployeeBusinessLayer.cs     # Business layer for employee management for cms
             |-- ProductBusinessLayer.cs      # Business layer for product management for cms
        |-- View And Controller
             |-- ...                          # MVC auto generated structure
             |-- ...                          # ... view, controllers, config, global, filter etc...
             |-- Filters                      # override default filters, exception filter, authentication filter etc...
             |-- ...
             |-- Log                          # Funtion to write exceptions into a local file (default location: c:\log\
             |-- ...
        |-- View Models
          |-- ViewModel
              |-- AccountViewModels.cs        # Authentication functions
              |-- EmployeeViewModel.cs        # Used for restructure data for views, such as combine firstname and lastname into name
              |-- ContentViewModel.cs         
              |-- CustomerViewModel.cs        
              |-- ProductViewModel.cs         

## History
Current release: including basic functions, a working example. Lots of more might be needed for real life situation. However, as long as following this basic structure, the project can be extended as big as possible.

## Next release:
1. Authentications
2. Blogs
3. Exception and error handling

## Screen Shots:


![alt tag](https://cloud.githubusercontent.com/assets/26331976/23883920/32c23e1e-0840-11e7-8371-37a18fe93e2c.jpg)


![alt tag](https://cloud.githubusercontent.com/assets/26331976/23883933/3ef2a570-0840-11e7-9a6e-8945763d0486.jpg)


![alt tag](https://cloud.githubusercontent.com/assets/26331976/23883937/41ec678e-0840-11e7-8a54-fa8b592a0e31.jpg)


![alt tag](https://cloud.githubusercontent.com/assets/26331976/23883944/4b550a4c-0840-11e7-8aa5-d2a1c6902c73.jpg)


![alt tag](https://cloud.githubusercontent.com/assets/26331976/23883954/53dba3f6-0840-11e7-8123-1d48c5ae24cd.jpg)


![alt tag](https://cloud.githubusercontent.com/assets/26331976/23883958/56781a22-0840-11e7-87e2-af4b96c2b211.jpg)


![alt tag](https://cloud.githubusercontent.com/assets/26331976/23883961/5826cada-0840-11e7-8501-c994d9793801.jpg)


![alt tag](https://cloud.githubusercontent.com/assets/26331976/23883966/5f16e064-0840-11e7-8fd7-6f7157ddf3a4.jpg)


![alt tag](https://cloud.githubusercontent.com/assets/26331976/23883968/613dd3ac-0840-11e7-9869-c3afeb7eb8aa.jpg)


![alt tag](https://cloud.githubusercontent.com/assets/26331976/23883972/6583c5a2-0840-11e7-8aa0-0c8d240a1304.jpg)
