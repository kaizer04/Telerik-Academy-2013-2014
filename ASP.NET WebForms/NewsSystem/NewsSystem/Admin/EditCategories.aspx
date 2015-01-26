<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="EditCategories.aspx.cs" Inherits="NewsSystem.Admin.EditCategories" %>

<asp:Content ID="ContentBody" ContentPlaceHolderID="MainContent" runat="server">

    <asp:ListView runat="server" ID="ListViewCategories" ItemType="NewsSystem.Models.Category" SelectMethod="ListViewCategories_GetData" DeleteMethod="ListViewCategories_DeleteItem" UpdateMethod="ListViewCategories_UpdateItem" DataKeyNames="ID" InsertMethod="ListViewCategories_InsertItem" InsertItemPosition="LastItem">
        <LayoutTemplate>
            <div class="row">
                <asp:LinkButton Text="Category Name" runat="server" ID="LinkButtonSortByCategory" CommandName="Sort" CommandArgument="Name" CssClass="btn btn-default"/>
		    </div>
            <asp:PlaceHolder runat="server" ID="itemPlaceHolder"></asp:PlaceHolder>  
            
            <div class="row">
			    <asp:DataPager runat="server" ID="DataPagerCategories" PagedControlID="ListViewCategories" PageSize="5">
                    <Fields>
                        <asp:NextPreviousPagerField />
                        <asp:NumericPagerField />
                        <%--<asp:TemplatePagerField></asp:TemplatePagerField>--%>
                    </Fields>
                </asp:DataPager>
		    </div>
        </LayoutTemplate>
        <ItemTemplate> 
            <div class="row">
			    <div class="col-md-3"><%#: Item.Name %></div>
                <asp:LinkButton runat="server" ID="LinkButtonEdit" Text="Edit" CommandName="Edit" CssClass="btn btn-info" />
                <asp:LinkButton runat="server" ID="LinkButtonDelete" Text="Delete" CommandName="Delete" CssClass="btn btn-danger" />
			    
		    </div>
        </ItemTemplate>
        <EditItemTemplate>
            <div class="row">
			    <div class="col-md-3">
                    <asp:TextBox runat="server" ID="TextBoxName" Text="<%#: BindItem.Name %>"/>  
			    </div>
                <asp:LinkButton runat="server" ID="LinkButtonEdit" Text="Save" CommandName="Update" CssClass="btn btn-info" />
                <asp:LinkButton runat="server" ID="LinkButtonDelete" Text="Cancel" CommandName="Cancel" CssClass="btn btn-danger" />
			    
		    </div>
        </EditItemTemplate>
        <InsertItemTemplate>
            <div class="row">
			    <div class="col-md-3">
                    <asp:TextBox runat="server" ID="TextBoxName" Text="<%#: BindItem.Name %>"/>  
			    </div>
                <asp:LinkButton runat="server" ID="LinkButtonEdit" Text="Save" CommandName="Insert" CssClass="btn btn-info" />
                <asp:LinkButton runat="server" ID="LinkButtonDelete" Text="Cancel" CommandName="Cancel" CssClass="btn btn-danger" />
            </div>
        </InsertItemTemplate>
    </asp:ListView>

</asp:Content>
