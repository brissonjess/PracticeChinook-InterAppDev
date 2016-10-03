<%@ Page Title="" Language="C#" MasterPageFile="~/Site.master" AutoEventWireup="true" CodeFile="RepresentiveCustomers.aspx.cs" Inherits="Queries_RepresentiveCustomers" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" Runat="Server">
    
    <h3>Grid view</h3>
    <%-- drodown list retrieves the names of the employees --%>
    <asp:DropDownList 
        ID="EmployeeList" 
        runat="server" 
        DataSourceID="EmployeeListODS" 
        DataTextField="Name" 
        DataValueField="EmployeeId">

    </asp:DropDownList>
    <%-- this ODS loads the list of employees, based off their relation to the employee ID --%>
    <asp:ObjectDataSource ID="EmployeeListODS" 
        runat="server" 
        OldValuesParameterFormatString="original_{0}" 
        SelectMethod="EmployeeNameList_Get" 
        TypeName="ChinookSystem.BLL.EmployeeController">
    </asp:ObjectDataSource>
    <%-- buttons sends reloads the page so the data can be sent --%>
    <asp:Button ID="SubmitQuery" runat="server" Text="Search" />
    
    <h3>Display Data</h3>
    <%-- this ODS loads the list of customers based off the employee's id --%>
    <asp:ObjectDataSource ID="RepCustomerODS" 
                          runat="server" 
                          OldValuesParameterFormatString="original_{0}" 
                          SelectMethod="RepresentitiveCustomers_Get" 
                          TypeName="ChinookSystem.BLL.CustomerController">

        <SelectParameters>
            <asp:ControlParameter ControlID="EmployeeList" 
                                  PropertyName="SelectedValue" 
                                  Name="employeeid" 
                                  Type="Int32">

            </asp:ControlParameter>
        </SelectParameters>
    </asp:ObjectDataSource>
    <%-- the grid view displays the results on the page --%>
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

