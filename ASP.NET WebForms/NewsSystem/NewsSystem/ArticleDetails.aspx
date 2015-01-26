<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="ArticleDetails.aspx.cs" Inherits="NewsSystem.ArticleDetails" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">

    <asp:FormView runat="server" ID="FormViewArticleDetails" ItemType="NewsSystem.Models.Article" SelectMethod="FormViewArticleDetails_GetItem">
        <ItemTemplate> 
            
			<div>			
				<div class="like-control col-md-1">
					<div>Likes</div>
					<div>
						<a class="btn btn-default glyphicon glyphicon-chevron-up" href="#"></a>
						<span class="like-value"><%#: Item.Likes %></span>
						<a class="btn btn-default glyphicon glyphicon-chevron-down" href="#"></a>
					</div>
				</div>    
			</div>
			<h2><%#: Item.Title %> <small>Category: <%#: Item.Category.Name %></small></h2>
			<p><%#: Item.Content %></p>
			<p>
				<span>Author: <%# Item.Author %></span>
				<span class="pull-right"><%# Item.DateCreated %> AM</span>
			</p>
        </ItemTemplate>
    </asp:FormView>

</asp:Content>
