﻿<%@ Page Title="" Language="C#" MasterPageFile="~/Site.master" AutoEventWireup="true" CodeFile="RepresentiveCustomers.aspx.cs" Inherits="Queries_RepresentiveCustomers" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" Runat="Server">
    <h3>Rep Customer ODS</h3>
    <asp:ObjectDataSource ID="RepCustomerODS" runat="server" OldValuesParameterFormatString="original_{0}" SelectMethod="RepresentitiveCustomers_Get" TypeName="ChinookSystem.BLL.CustomerController"></asp:ObjectDataSource>

    <h3>Grid view</h3>
    <asp:GridView ID="RepCustomerList" runat="server" AutoGenerateColumns="False" DataSourceID="RepCustomerODS" AllowPaging="True">
        <Columns>
            <asp:BoundField DataField="Name" HeaderText="Name" SortExpression="Name"></asp:BoundField>
            <asp:BoundField DataField="City" HeaderText="City" SortExpression="City"></asp:BoundField>
            <asp:BoundField DataField="State" HeaderText="State" SortExpression="State"></asp:BoundField>
            <asp:BoundField DataField="Phone" HeaderText="Phone" SortExpression="Phone"></asp:BoundField>
            <asp:BoundField DataField="Email" HeaderText="Email" SortExpression="Email"></asp:BoundField>
        </Columns>
    </asp:GridView>
</asp:Content>

