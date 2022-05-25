# BlazorShop Simple Project

Simple Shop Ecommerce build with blazor WebAssembly

![Build Status](https://travis-ci.org/joemccann/dillinger.svg?branch=master)
 ![](https://img.shields.io/github/tag/pandao/editor.md.svg)  ![](https://img.shields.io/bower/v/editor.md.svg) 

![](https://miro.medium.com/max/800/1*c8sQqJ3p2z-WlKQTxjNgSw.png)
## :boy: Authors 
<table>
  <thead>
    <td>Student ID</td>
    <td>Full Name</td>
  </thead>
  <tbody>
    <tr>
      <td>3119410418</td>
      <td> <a href="https://github.com/devguy201-9">Trần Gia Thuân</a> </td>
    </tr>
    <tr>
      <td>3119410174</td>
      <td> <a href="https://github.com/latecomersSS">Nguyễn Thanh Hưng</a> </td>
    </tr>
    <tr>
      <td>3119410054</td>
      <td> <a href="https://github.com/HCCuong">Huỳnh Chí Cường</a> </td>
    </tr>
  </tbody>
</table>


## 🖥️: Try it out

Make sure you have the [.NET Core SDK](https://dotnet.microsoft.com/download) installed on your machine. Then do:

#### Create Database

```
Execute query script in file BlazorShopDb.sql from Microsoft SQL Server Management Studio
```

###### Or

```
git clone https://github.com/devguy201-9/BlazorCRUD.git
Update-Database
```
#### Start project

```
git clone https://github.com/devguy201-9/EC-BlazorShop.git
Change the DefaultConnection value with the ConnectionString retrieved from the Database Engine in the file ./BlazorShop.Web/Server/appsettings.json
dotnet run --project BlazorShop.Web/Server/BlazorShop.Web.Server.csproj
```
