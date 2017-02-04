<%@ Page Title="Homework03" Language="C#" MasterPageFile="~/Master/Main.master" AutoEventWireup="true" CodeFile="Homework03.aspx.cs" Inherits="Homework_Homework03_Homework03" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
    Homework 03
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="cpMainContent" Runat="Server">
    <div id="imagebox" class="imagebox" >
        <div id="innerbox" class="innerbox" >
        <img alt="triangle" class="center-block" src="../../Images/triangle.gif" /><br />
            <p class="center-block text-center width60" >
                Enter the width and the height of your triangle to calculate the area.
            </p>
            
            <table id="tblInput" runat="server" class="table center-block width250" >
                <tr>
                    <td class="width60">Width (b):</td>
                    <td class="width40 ">
                        <asp:TextBox  runat="server" id="txtWidth" type="text" required="true" /></td>
                    

                </tr>
                <tr>
                    <td >Height (h):</td>
                    <td ><asp:TextBox runat="server" id="txtHeight" required="true"  /></td>
                </tr>

            </table>

            
            <asp:Button ID="btnSubmit" runat="server" Text="Calculate area" onclick="btnSubmit_Click" class="center-block img-rounded" />
            <br />
            <div id="BlueLine" class="center-block blueline" ></div>
        <table id="tblResults" runat="server" class="table center-block width250" >
                <tr>
                    <td class="width60" >The area is:</td>
                    <td >
                        <asp:TextBox ID="txtResults" runat="server" class="input-sm width100" ReadOnly="True" ></asp:TextBox>

                    </td>
                   
                </tr>
                

            </table>
            <p class="text-center">
            <asp:RangeValidator ID="rvalWidth" runat="server" ControlToValidate="txtWidth"
                        ErrorMessage="You must enter a  width greater than or equal to zero."
                         Type="Double" 
                        MinimumValue="0" MaximumValue="99999999" SetFocusOnError="True" CssClass="alert-danger"
                ></asp:RangeValidator> <br />
            <asp:RangeValidator ID="rvalHreight" runat="server" ControlToValidate="txtHeight"
                        ErrorMessage="You must enter a  Height greater than or equal to  zero."
                         Type="Double" 
                        MinimumValue="0"  MaximumValue="99999999"
                        SetFocusOnError="True" CssClass="alert-danger"
                ></asp:RangeValidator>
          </p>
        
        </div>  <%--innerbox  div--%>
    </div> <%--imagebox  div--%>
</asp:Content>

