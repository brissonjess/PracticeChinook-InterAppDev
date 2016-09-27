<%@ Page Title="" Language="C#" MasterPageFile="~/Site.master" AutoEventWireup="true" CodeFile="FirstSample.aspx.cs" Inherits="Queries_FirstSample" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" Runat="Server">
    <h1>Entity vs Linq Entity Query</h1>
    <h3>Dump the entire contents of a table from the DB</h3>
    <asp:GridView ID="EntityFramworkList" runat="server" AutoGenerateColumns="False" DataSourceID="EntityFrameworkODS" AllowPaging="True">
        <Columns>
            <asp:BoundField DataField="ArtistId" HeaderText="ArtistId" SortExpression="ArtistId"></asp:BoundField>
            <asp:BoundField DataField="Name" HeaderText="Name" SortExpression="Name"></asp:BoundField>
        </Columns>
    </asp:GridView>
    <h3>Get specific data based on your LINQ query</h3>
    <asp:GridView ID="LinqToEntityList" runat="server" AutoGenerateColumns="False" DataSourceID="LinqToEntityODS" AllowPaging="True">
        <Columns>
            <asp:BoundField DataField="Name" HeaderText="Name" SortExpression="Name"></asp:BoundField>
            <asp:BoundField DataField="Title" HeaderText="Title" SortExpression="Title"></asp:BoundField>
        </Columns>
    </asp:GridView>
    <asp:ObjectDataSource ID="EntityFrameworkODS" runat="server" OldValuesParameterFormatString="original_{0}" SelectMethod="Artist_ListAll" TypeName="ChinookSystem.BLL.ArtistController"></asp:ObjectDataSource>
    <asp:ObjectDataSource ID="LinqToEntityODS" runat="server" OldValuesParameterFormatString="original_{0}" SelectMethod="Artist_Albums_Get" TypeName="ChinookSystem.BLL.ArtistController"></asp:ObjectDataSource>
</asp:Content>

