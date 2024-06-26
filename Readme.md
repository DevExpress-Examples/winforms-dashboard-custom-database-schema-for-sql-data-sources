<!-- default badges list -->
![](https://img.shields.io/endpoint?url=https://codecentral.devexpress.com/api/v1/VersionRange/128581398/19.1.3%2B)
[![](https://img.shields.io/badge/Open_in_DevExpress_Support_Center-FF7200?style=flat-square&logo=DevExpress&logoColor=white)](https://supportcenter.devexpress.com/ticket/details/E5051)
[![](https://img.shields.io/badge/📖_How_to_use_DevExpress_Examples-e9f6fc?style=flat-square)](https://docs.devexpress.com/GeneralInformation/403183)
[![](https://img.shields.io/badge/💬_Leave_Feedback-feecdd?style=flat-square)](#does-this-example-address-your-development-requirementsobjectives)
<!-- default badges end -->
# Dashboard for WinForms - How to customize a database schema for SQL data sources

This example demonstrates how to customize a database schema to to restrict fields in [Query Builder](https://docs.devexpress.com/Dashboard/117275/winforms-dashboard/winforms-designer/ui-elements-and-customization/dialogs-and-wizards/query-builder?p=netframework) for a dashboard data source that uses a connection to the _nwind.mdb_ database.

A **CustomDBSchemaProvider** class implements the  [IDBSchemaProviderEx](https://docs.devexpress.com/CoreLibraries/DevExpress.DataAccess.Sql.IDBSchemaProviderEx) interface. It defines a custom database schema that contains three related tables and eight fields.

Click the _Use Custom DBSchema Provider_ button to assign a CustomDBSchemaProvider instance to the  [DashboardDesigner.CustomDBSchemaProviderEx](https://docs.devexpress.com/Dashboard/DevExpress.DashboardWin.DashboardDesigner.CustomDBSchemaProviderEx) property. 

To see the result, add a new query or edit the existing query. The [Query Builder](https://docs.devexpress.com/Dashboard/117275) window contains only fields and tables that the **CustomDBSchemaProvider** supplies.

![](/images/screenshot.png)

## Files to Look At:

* [Form1.cs](./CS/Dashboard_CustomSchemaProvider/Form1.cs) (VB: [Form1.vb](./VB/Dashboard_CustomSchemaProvider/Form1.vb))
* [CustomDBSchemaProvider.cs](./CS/Dashboard_CustomSchemaProvider/CustomDBSchemaProvider.cs) (VB: [FormCustomDBSchemaProvider1.vb](./VB/Dashboard_CustomSchemaProvider/CustomDBSchemaProvider.vb))

## Documentation

- [SQL Data Source](https://docs.devexpress.com/Dashboard/16151)
- [Use the Query Builder](http://docs.devexpress.com/Dashboard/16152)
<!-- feedback -->
## Does this example address your development requirements/objectives?

[<img src="https://www.devexpress.com/support/examples/i/yes-button.svg"/>](https://www.devexpress.com/support/examples/survey.xml?utm_source=github&utm_campaign=winforms-dashboard-custom-database-schema-for-sql-data-sources&~~~was_helpful=yes) [<img src="https://www.devexpress.com/support/examples/i/no-button.svg"/>](https://www.devexpress.com/support/examples/survey.xml?utm_source=github&utm_campaign=winforms-dashboard-custom-database-schema-for-sql-data-sources&~~~was_helpful=no)

(you will be redirected to DevExpress.com to submit your response)
<!-- feedback end -->
