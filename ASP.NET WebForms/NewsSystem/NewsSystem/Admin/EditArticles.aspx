<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="EditArticles.aspx.cs" Inherits="NewsSystem.Admin.EditArticles" %>

<asp:Content ID="ContentBody" ContentPlaceHolderID="MainContent" runat="server">

    <asp:ListView runat="server" ID="ListViewArticles" ItemType="NewsSystem.Models.Article" SelectMethod="ListViewArticles_GetData">
        <LayoutTemplate>
            <div class="row">
                <asp:LinkButton Text="Sort by Title" runat="server" ID="LinkButtonSortByTitle" CommandName="Sort" CommandArgument="Title" CssClass="btn btn-default"/>
                <asp:LinkButton Text="Sort by Date" runat="server" ID="LinkButtonSortByDate" CommandName="Sort" CommandArgument="DateCreated" CssClass="btn btn-default"/>
                <asp:LinkButton Text="Sort by Category" runat="server" ID="LinkButtonSortByCategory" CommandName="Sort" CommandArgument="CategoryID" CssClass="btn btn-default"/>
                <asp:LinkButton Text="Sort by Likes" runat="server" ID="LinkButtonSortByLikes" CommandName="Sort" CommandArgument="Likes" CssClass="btn btn-default"/>
			    <%--<a class="col-md-2 btn btn-default">Sort by Title</a>
			    <a class="col-md-2 btn btn-default">Sort by Date</a>
			    <a class="col-md-2 btn btn-default">Sort by Category</a>
			    <a class="col-md-2 btn btn-default">Sort by Likes</a>--%>
		    </div>
            <asp:PlaceHolder runat="server" ID="itemPlaceHolder"></asp:PlaceHolder>
            <div class="row">
			    <asp:DataPager runat="server" ID="DataPagerArticles" PagedControlID="ListViewArticles" PageSize="5">
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
			<h3><%#: Item.Title %>
				<asp:LinkButton runat="server" ID="LinkButtonEdit" Text="Edit" CommandName="Edit" CssClass="btn btn-info" />
                <asp:LinkButton runat="server" ID="LinkButtonDelete" Text="Delete" CommandName="Delete" CssClass="btn btn-danger" />
			</h3>
			<p>Category: <%#: Item.Category.Name %></p>
			<p>
				<%#: Item.Content %>
			</p>
			<p>Likes count: <%#: Item.Likes %></p>
			<div>
				<i>by <%#: Item.Author %></i>
				<i>created on: <%#: Item.DateCreated %></i>
			</div>
		</div>
        </ItemTemplate>
    </asp:ListView>
        

</asp:Content>
