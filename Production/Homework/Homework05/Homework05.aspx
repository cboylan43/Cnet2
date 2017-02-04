<%@ Page Title="Homework 05" Language="C#" MasterPageFile="~/Master/Main.master" AutoEventWireup="true" CodeFile="Homework05.aspx.cs" Inherits="Homework_Homework05_Homework05" %>

<%--//Class: ASP.NET with C# 2
//Author: Chris Boylan
//Abstract: Homework 5--%>
<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="cpMainContent" Runat="Server">
    <div id="main" class="ltgreybox">
        <div id="Step1" class="step1">
            <label>Step One</label>
            <table class="table">
                <tr>
                    <td colspan="3">
                        Sentence:<asp:TextBox ID="txtSentence" runat="server"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td>
                        <asp:Button ID="btnCountVowels" runat="server" OnClick="btnCountVowels_Click" CssClass="btn btn-block" Text="Count Vowels" AccessKey="v" />
                    </td>
                    <td>
                        <asp:Button ID="btnCountWords" runat="server" OnClick="btnCountWords_Click" CssClass="btn btn-block" Text="Count Words" AccessKey="w" />
                    </td>
                    <td>
                        <asp:Button ID="btnReverse" runat="server" OnClick="btnReverse_Click" CssClass="btn btn-block" Text="Reverse" AccessKey="r" />
                    </td>
                </tr>
            </table>
        </div>
        <div id="step2" class="step2">
            <label>Step Two</label>
            <table class="table">
                <tr>
                    <td colspan="4">
                        Record:<asp:TextBox ID="txtRecord" runat="server"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td colspan="2">
                        <asp:Button ID="btnBreak" runat="server" OnClick="btnBreak_Click" CssClass="btn-block right" Text="Break Apart" AccessKey="b" />
                    </td>
                    <td colspan="2">
                        <asp:Button ID="btnRejoin" runat="server" OnClick="btnRejoin_Click" CssClass="btn-block left" Text="Put Together"  AccessKey="t" />
                    </td>
                </tr>
                <tr>
                    <td>Field 1:</td>
                    <td>
                        <asp:TextBox ID="txtField1" runat="server"></asp:TextBox>
                    </td>
                    <td>Field 2:</td>
                    <td>
                        <asp:TextBox ID="txtField2" runat="server"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td>Field 3:</td>
                    <td>
                        <asp:TextBox ID="txtField3" runat="server"></asp:TextBox>
                    </td>
                    <td>Field 4:</td>
                    <td>
                        <asp:TextBox ID="txtField4" runat="server"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td>Field 5:</td>
                    <td>
                        <asp:TextBox ID="txtField5" runat="server"></asp:TextBox>
                    </td>
                    <td>Field 6:</td>
                    <td>
                        <asp:TextBox ID="txtField6" runat="server"></asp:TextBox>
                    </td>
                </tr>

            </table>


        </div>
        <div id="extracredit" class="step3">
            <label>Extra Credit</label>
            <table class="table">
                <tr>
                    <td><label>Phone Number :</label></td>
                    <td><asp:TextBox ID="txtPhoneNumber" runat="server"></asp:TextBox></td>
                </tr>
                <tr>
                    <td><label>Formatted Phone Number :</label></td>
                    <td><asp:TextBox ID="txtPhoneOut" runat="server" ReadOnly="true"></asp:TextBox></td>
                </tr>
                <tr>
                    <td colspan="2">
                        <asp:Button ID="btnPhone" runat="server" OnClick="btnPhone_Click" CssClass="btn-block left" Text="Format Phone Number"  AccessKey="f" />
                    
                    </td>
                </tr>

            </table>
            
        </div>
            

    </div>
    





</asp:Content>

