<%@ Page Title="Edit Categories" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="EditCategories.aspx.cs" Inherits="LibrarySystem.Admin.EditCategories" %>
<asp:Content ID="ContentBody" ContentPlaceHolderID="MainContent" runat="server">
    
    <asp:ListView runat="server" ID="ListViewCategories" ItemType="LibrarySystem.Models.Category">
        <LayoutTemplate>
            <table class="gridview" cellspacing="0" rules="all" border="1" id="MainContent_GridViewCategories" style="border-collapse:collapse;">
		        <tbody>
                    <tr>
			            <th scope="col">
                            <asp:LinkButton Text="Category Name" runat="server" ID="LinkButtonSortByCategory" CommandName="Sort" CommandArgument="Name" />
			            </th>
                        <th scope="col">Action</th>
		            </tr>
                    <asp:PlaceHolder runat="server" ID="itemPlaceHolder"></asp:PlaceHolder>
			        <tr>
			            <td colspan="2">
                            <asp:DataPager runat="server" ID="DataPagerCategories" PagedControlID="ListViewCategories" PageSize="3">
                                <Fields>
                                    <asp:NumericPagerField />
                                </Fields>
                            </asp:DataPager>
                        </td>
		            </tr>
	            </tbody>
            </table> 
        </LayoutTemplate>
        <ItemTemplate>
            <tr>
                <td><%#: Item.Name %></td>
                <td>
                    <asp:LinkButton runat="server" ID="LinkButtonEdit" Text="Edit" CommandName="Edit" />
                    <asp:LinkButton runat="server" ID="LinkButtonDelete" Text="Delete" CommandName="Delete" />
                </td>
            </tr>
        </ItemTemplate>
    </asp:ListView>

</asp:Content>
