<%@ Page Title="Homework06" Language="C#" MasterPageFile="~/Master/Main.master" AutoEventWireup="true" CodeFile="Homework06.aspx.cs" Inherits="Homework_Homework06_Homework06" %>
<%--//Class: ASP.NET with C# 2
//Author: Chris Boylan
//Abstract: Homework 6--%>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="cpMainContent" Runat="Server">
    <h1>List of all Sales Representatives</h1>
    <asp:DropDownList ID="ddlSaleReps" runat="server" DataSourceID="dsSQL_SaleRepList" DataTextField="Full Name" DataValueField="EmployeeID"></asp:DropDownList>
    <h1>List of all the wonderful seafood stuff you can buy</h1>
    <asp:DropDownList ID="ddlSeaFood" runat="server" DataSourceID="dsSQL_Products_Seafood" DataTextField="ProductName" DataValueField="ProductID" ></asp:DropDownList>
    <asp:SqlDataSource ID="dsSQL_SaleRepList" runat="server" ConnectionString="<%$ ConnectionStrings:SQL_ITD2_C2_BoylanC %>" SelectCommand="SELECT LastName + ', ' + FirstName AS [Full Name], EmployeeID FROM dbo.Employees WHERE (Title LIKE N'Sales rep%') AND (HireDate &gt; CONVERT (DATETIME, '1993-01-01 00:00:00', 102))"></asp:SqlDataSource>
    <asp:SqlDataSource ID="dsSQL_Products_Seafood" runat="server" ConnectionString="<%$ ConnectionStrings:SQL_ITD2_C2_BoylanC %>" SelectCommand="SELECT [ProductName], [ProductID] FROM [Products] WHERE ([CategoryID] = @CategoryID)">
        <SelectParameters>
            <asp:Parameter DefaultValue="8" Name="CategoryID" Type="Int32" />
        </SelectParameters>
    </asp:SqlDataSource>
</asp:Content>

