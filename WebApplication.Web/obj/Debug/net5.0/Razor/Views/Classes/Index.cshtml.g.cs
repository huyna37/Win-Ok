#pragma checksum "C:\Users\admin\OneDrive\Tài liệu\Máy tính\Win-Ok\WebApplication.Web\Views\Classes\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "3cf3649663f400be2472008edf7804cf13ffabd5"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Classes_Index), @"mvc.1.0.view", @"/Views/Classes/Index.cshtml")]
namespace AspNetCore
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#nullable restore
#line 1 "C:\Users\admin\OneDrive\Tài liệu\Máy tính\Win-Ok\WebApplication.Web\Views\_ViewImports.cshtml"
using WebApplication.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\admin\OneDrive\Tài liệu\Máy tính\Win-Ok\WebApplication.Web\Views\_ViewImports.cshtml"
using WebApplication.Web.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3cf3649663f400be2472008edf7804cf13ffabd5", @"/Views/Classes/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"55dcb12be480a17ed0836b14daa9689fbfa158f6", @"/Views/_ViewImports.cshtml")]
    public class Views_Classes_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 4 "C:\Users\admin\OneDrive\Tài liệu\Máy tính\Win-Ok\WebApplication.Web\Views\Classes\Index.cshtml"
  
    ViewData["Title"] = "Classes";
    Layout = "~/Views/Shared/_Layout_admin.cshtml";
    ViewData["head-title"] = "Class Control";

#line default
#line hidden
#nullable disable
            DefineSection("Scripts", async() => {
                WriteLiteral(@"
    <script>
        let currentPage = 1;
        function getAllClass(filter, page) {
            let html = """";
            currentPage = page;
            $.ajax({
                url: `https://localhost:5001/api/Classes?SkipCount=1&MaxResultCount=10&Filter=t`,
                type: ""GET"",
                beforeSend: function (xhr) {
                    xhr.setRequestHeader(""Authorization"", ""Bearer "" + user.accessToken);
                },
                success: datas => {
                    console.log(datas.totalCount)
                    renderPagination(datas.totalCount, page);
                    for (var data of datas.items) {
                        const updateTime = data.updateTime == null ? ""No Time Update"" : moment(data.updateTime).format(""DD/MM/YYY"");
                        html += `<tr>
                                                                         <th scope=""row"">`+ data.name + `</th>
                                                                         <t");
                WriteLiteral(@"d>`+ data.description + `</td>
                                                                         <td>`+ moment(data.createTime).format(""DD/MM/YYY"") + `</td>
                                                                         <td>`+ updateTime + `</td>
                                                                         <td class='action-center' scope=""col"">
                                                                            <div class=""btn-group"">
                                                                                <button type=""button"" class=""btn btn-danger dropdown-toggle"" data-toggle=""dropdown"" aria-expanded=""false"">
                                                                                    Action
                                                                                </button>
                                                                                <div class=""dropdown-menu"">
                                                               ");
                WriteLiteral(@"                     <a class=""dropdown-item"" onclick='detailClass(${JSON.stringify(data)})'>Detail</a>
                                                                                    <a class=""dropdown-item"" onclick='showModalUpdate(${JSON.stringify(data)})'>Update</a>
                                                                                    <a class=""dropdown-item"" onclick='deleteClass(${JSON.stringify(data.id)})'>Delete</a>
                                                                                    <div class=""dropdown-divider""></div>
                                                                                    <a class=""dropdown-item"" href=""#"">Separated link</a>
                                                                                </div>
                                                                            </div>
                                                                           </td>
                                                              ");
                WriteLiteral(@"             </tr>`;
                    }
                    $(""#body-class"").html(html);
                    $(""#tableclass"").removeClass(""d-none"");
                    $(""#spinLoaded"").hide();
                }
            })
        }
        getAllClass('', currentPage);

        //Delete

        function deleteClass(id) {
            currentIdelete = id;
            $(""#deleteModal"").modal(""show"");
        }
        function confirmDelete() {
            $.ajax({
                url: ""https://localhost:5001/api/Classes/"" + currentIdelete,
                type: ""DELETE"",
                beforeSend: function (xhr) {
                    xhr.setRequestHeader(""Authorization"", ""Bearer "" + user.accessToken);
                },
                success: response => {
                    swal({
                        title: ""Delete Success"",
                        text: ""Hihi!"",
                        icon: ""success"",
                        type: ""OK""
                    })
   ");
                WriteLiteral(@"                 $(""#deleteModal"").modal(""hide"");
                    getAllClass('', currentPage);
                }
            })
        }
        let currentIdelete;


        function detailClass(data) {
            $(""#ClassDetail"").modal(""show"");
            let htmlDetailClass = """";
            console.log(data.user)
            for (let i of data.user) {
                console.log(i);
                htmlDetailClass += `<tr><td>${i.fullName}</td><td>${i.email}</td><td><div class='btn btn-danger d-flex justify-content-center'><i class=""fas fa-trash-alt""></i></td></tr>`
            }
            $(""#listClass"").html(htmlDetailClass)
        }
    </script>
");
            }
            );
            WriteLiteral(@"
<h2 onclick=""getListClass(true)"" data-toggle=""modal"" data-target=""#createModal"">Create</h2>
<div class=""justify-content-center"" style=""display:flex"" id=""spinLoaded"">
    <div class=""spinner-border text-success "" role=""status"">
        <span class=""sr-only"">Loading...</span>
    </div>
</div>
<table id=""tableclass"" class=""d-none table table-striped table-hover"">
    <thead style="" background: rebeccapurple;"">
        <tr>
            <th scope=""col"">Class Name</th>
            <th scope=""col"">Class Description</th>
            <th scope=""col"">Create Time</th>
            <th scope=""col"">Update Time</th>
            <th scope=""col"" class=""text-center"">Action</th>
        </tr>
    </thead>
    <tbody id=""body-class"">
    </tbody>
</table>
<nav aria-label=""Page navigation example"">
    <ul class=""pagination"" id=""paginationTopic"">
    </ul>
</nav>

<!-- Delete -->
<div class=""modal fade"" id=""deleteModal"" tabindex=""-1"" role=""dialog"" aria-labelledby=""exampleModalLabel""
     aria-hidden=""");
            WriteLiteral(@"true"">
    <div class=""modal-dialog"" role=""document"">
        <div class=""modal-content"">
            <div class=""modal-header"">
                <h5 class=""modal-title"" id=""exampleModalLabel"">Do you want delete it ??</h5>
                <button class=""close"" type=""button"" data-dismiss=""modal"" aria-label=""Close"">
                    <span aria-hidden=""true"">×</span>
                </button>
            </div>
            <div class=""modal-body"">
                <h2>Alert!!!!</h2>
            </div>
            <div class=""modal-footer"">
                <button class=""btn btn-secondary"" type=""button"" data-dismiss=""modal"">Cancel</button>
                <button class=""btn btn-danger"" id=""update"" onclick=""confirmDelete()"" type=""button"">Delete</button>
            </div>
        </div>
    </div>
</div>



<div class=""modal fade"" id=""ClassDetail"" tabindex=""-1"" role=""dialog"" aria-labelledby=""exampleModalLabel""
     aria-hidden=""true"">
    <div class=""modal-dialog"" role=""document"">
       ");
            WriteLiteral(@" <div class=""modal-content"">
            <div class=""modal-header"">
                <h5 class=""modal-title"" id=""modallabelTopic"">Role Assign</h5>
                <button class=""close"" type=""button"" data-dismiss=""modal"" aria-label=""Close"">
                    <span aria-hidden=""true"">×</span>
                </button>
            </div>
            <div class=""modal-body"" >
                <table class=""table"">
                    <tr>
                        <th>Tên Học sinh</th>
                        <th>Mail</th>
                        <th class=""text-center"">Action</th>
                    </tr>
                    <tbody id=""listClass"">

                    </tbody>
                </table>
            </div>
            <div class=""modal-footer"">
                <button class=""btn btn-secondary"" type=""button"" data-dismiss=""modal"">Cancel</button>
            </div>
        </div>
    </div>
</div>");
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591