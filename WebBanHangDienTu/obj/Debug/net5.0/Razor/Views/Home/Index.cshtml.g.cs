#pragma checksum "C:\Users\PC\source\repos\WebBanHangDienTu\WebBanHangDienTu\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "a05a91c97823922a0ea386c86962df4ecb90b049"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Index), @"mvc.1.0.view", @"/Views/Home/Index.cshtml")]
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
#line 1 "C:\Users\PC\source\repos\WebBanHangDienTu\WebBanHangDienTu\Views\_ViewImports.cshtml"
using WebBanHangDienTu;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\PC\source\repos\WebBanHangDienTu\WebBanHangDienTu\Views\_ViewImports.cshtml"
using WebBanHangDienTu.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a05a91c97823922a0ea386c86962df4ecb90b049", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"20f223dd158bdbc106567169795728baf4aa91dd", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<WebBanHangDienTu.ModelViews.HomeViewVM>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString("width:80%;height:auto"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/assets/images/about/intro/icon/1-1-170x165.png"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("width", new global::Microsoft.AspNetCore.Html.HtmlString("200"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("height", new global::Microsoft.AspNetCore.Html.HtmlString("200"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("img-full"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/assets/js/main.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        #pragma warning restore 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __backed__tagHelperScopeManager = null;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __tagHelperScopeManager
        {
            get
            {
                if (__backed__tagHelperScopeManager == null)
                {
                    __backed__tagHelperScopeManager = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager(StartTagHelperWritingScope, EndTagHelperWritingScope);
                }
                return __backed__tagHelperScopeManager;
            }
        }
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\PC\source\repos\WebBanHangDienTu\WebBanHangDienTu\Views\Home\Index.cshtml"
  
    ViewData["Title"] = "Trang chủ";
    Layout = "~/Views/Shared/_Layout.cshtml";
    List<Product> allProduct = ViewBag.AllProducts;

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<!-- Begin Slider Area -->
<div class=""slider-area"">

    <!-- Main Slider -->
    <div class=""swiper-container main-slider swiper-arrow with-bg_white"">
        <div class=""swiper-wrapper"">
            <div class=""swiper-slide animation-style-01"">
                <div class=""slide-inner bg-height"" data-bg-image=""/assets/images/slider/bg/1-1.jpg"">
                    <div class=""parallax-img-wrap"">
                        <div class=""chilly"">
                            <div class=""scene fill"">
                                <div class=""expand-width"" data-depth=""0.2"">
                                    <img src=""/assets/images/slider/inner-img/ot.png"" alt=""Inner Image"">
                                </div>
                            </div>
                        </div>
                        <div class=""avocado"">
                            <div class=""scene fill"">
                                <div class=""expand-width"" data-depth=""0.5"">
                                    <img sr");
            WriteLiteral(@"c=""/assets/images/slider/inner-img/qua-bo.png"" alt=""Inner Image"">
                                </div>
                            </div>
                        </div>
                    </div>
                    <div class=""container"">
                        <div class=""parallax-with-content"">
                            <div class=""slide-content"">
                                <span class=""sub-title mb-3"">Natural & Organic</span>
                                <h2 class=""title mb-9"">Hân hạnh được phục vụ</h2>
                                <div class=""button-wrap"">
                                    <a class=""btn btn-custom-size lg-size btn-primary btn-white-hover rounded-0"" href=""shop.html"">Mua ngay</a>
                                </div>
                            </div>
                            <div class=""parallax-img-wrap"">
                                <div class=""tomatoes"">
                                    <div class=""scene fill"">
                              ");
            WriteLiteral(@"          <div class=""expand-width"" data-depth=""0.5"">
                                            <img src=""/assets/images/slider/inner-img/otchuong.png"" alt=""Inner Image"">
                                        </div>
                                    </div>
                                </div>
                            </div>
                        </div>
                    </div>
                </div>
            </div>
            <div class=""swiper-slide animation-style-01"">
                <div class=""slide-inner bg-height"" data-bg-image=""/assets/images/slider/bg/1-1.jpg"">
                    <div class=""parallax-img-wrap"">
                        <div class=""chilly"">
                            <div class=""scene fill"">
                                <div class=""expand-width"" data-depth=""0.2"">
                                    <img src=""/assets/images/slider/inner-img/ot.png"" alt=""Inner Image"">
                                </div>
                            </div>
    ");
            WriteLiteral(@"                    </div>
                        <div class=""avocado"">
                            <div class=""scene fill"">
                                <div class=""expand-width"" data-depth=""0.5"">
                                    <img src=""/assets/images/slider/inner-img/qua-bo.png"" alt=""Inner Image"">
                                </div>
                            </div>
                        </div>
                    </div>
                    <div class=""container"">
                        <div class=""parallax-with-content"">
                            <div class=""slide-content"">
                                <span class=""sub-title mb-3"">Natural & Organic</span>
                                <h2 class=""title mb-9"">Hân hạnh được phục vụ</h2>
                                <div class=""button-wrap"">
                                    <a class=""btn btn-custom-size lg-size btn-primary btn-white-hover rounded-0"" href=""shop.html"">Mua ngay</a>
                                </di");
            WriteLiteral(@"v>
                            </div>
                            <div class=""parallax-img-wrap"">
                                <div class=""tomatoes"">
                                    <div class=""scene fill"">
                                        <div class=""expand-width"" data-depth=""0.5"">
                                            <img src=""/assets/images/slider/inner-img/otchuongdo.png"" alt=""Inner Image"">
                                        </div>
                                    </div>
                                </div>
                            </div>
                        </div>
                    </div>
                </div>
            </div>
        </div>
        <!-- Add Pagination -->
        <div class=""swiper-pagination with-bg d-md-none""></div>

        <!-- Add Arrows -->
        <div class=""swiper-button-next""></div>
        <div class=""swiper-button-prev""></div>
    </div>

</div>
<!-- Slider Area End Here -->
<!-- Begin Shipping Area -->
<d");
            WriteLiteral(@"iv class=""shipping-area section-space-top-100"">
    <div class=""container"">
        <div class=""row"">
            <div class=""col-lg-4 col-md-6"">
                <div class=""shipping-item"">
                    <div class=""shipping-img"">
                        <img src=""/assets/images/shipping/icon/plane.png"" alt=""Shipping Icon"">
                    </div>
                    <div class=""shipping-content"">
                        <h5 class=""title"">Giao hàng miễn phí</h5>
                        <p class=""short-desc mb-0"">Với đơn hàng từ 500k</p>
                    </div>
                </div>
            </div>
            <div class=""col-lg-4 col-md-6 pt-6 pt-md-0"">
                <div class=""shipping-item"">
                    <div class=""shipping-img"">
                        <img src=""/assets/images/shipping/icon/earphones.png"" alt=""Shipping Icon"">
                    </div>
                    <div class=""shipping-content"">
                        <h5 class=""title"">Hỗ trợ 24/7</h5>");
            WriteLiteral(@"
                        <p class=""short-desc mb-0"">Hotline: <strong>0963102916</strong></p>
                    </div>
                </div>
            </div>
            <div class=""col-lg-4 col-md-6 pt-6 pt-lg-0"">
                <div class=""shipping-item"">
                    <div class=""shipping-img"">
                        <img src=""/assets/images/shipping/icon/shield.png"" alt=""Shipping Icon"">
                    </div>
                    <div class=""shipping-content"">
                        <h5 class=""title"">Giờ làm việc</h5>
                        <p class=""short-desc mb-0"">Từ 6h00 - 19h30 hàng ngày</p>
                    </div>
                </div>
            </div>
        </div>
    </div>
</div>
<!-- Shipping Area End Here -->
<!-- Begin Product Area -->
<div class=""product-area section-space-top-100"">
    <div class=""container"">
        <div class=""row"">
            <div class=""col-lg-12"">
                <ul class=""nav product-tab-nav pb-10"" id=""myTab"" role=""ta");
            WriteLiteral(@"blist"">
                    <li class=""nav-item"" role=""presentation"">
                        <a class=""active"" id=""all-items-tab"" data-bs-toggle=""tab"" href=""#all-items"" role=""tab"" aria-controls=""all-items"" aria-selected=""true"">
                            <div class=""product-tab-icon"">
                                <img src=""/assets/images/product/icon/1.png"" alt=""Product Icon"">
                            </div>
                            Tất cả sản phẩm
                        </a>
                    </li>
");
#nullable restore
#line 160 "C:\Users\PC\source\repos\WebBanHangDienTu\WebBanHangDienTu\Views\Home\Index.cshtml"
                     foreach (var item in Model.Products)
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <li class=\"nav-item\" role=\"presentation\">\r\n                            <a id=\"fresh-fruits-tab\" data-bs-toggle=\"tab\"");
            BeginWriteAttribute("href", " href=\"", 8110, "\"", 8138, 2);
            WriteAttributeValue("", 8117, "#", 8117, 1, true);
#nullable restore
#line 163 "C:\Users\PC\source\repos\WebBanHangDienTu\WebBanHangDienTu\Views\Home\Index.cshtml"
WriteAttributeValue("", 8118, item.category.Alias, 8118, 20, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" role=\"tab\" aria-controls=\"fresh-fruits\" aria-selected=\"false\">\r\n                                <div class=\"product-tab-icon\">\r\n                                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "a05a91c97823922a0ea386c86962df4ecb90b04914778", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "alt", 1, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
#nullable restore
#line 165 "C:\Users\PC\source\repos\WebBanHangDienTu\WebBanHangDienTu\Views\Home\Index.cshtml"
AddHtmlAttributeValue("", 8399, item.category.Title, 8399, 20, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                                </div>\r\n                                ");
#nullable restore
#line 167 "C:\Users\PC\source\repos\WebBanHangDienTu\WebBanHangDienTu\Views\Home\Index.cshtml"
                           Write(item.category.CatName);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                            </a>\r\n                        </li>\r\n");
#nullable restore
#line 170 "C:\Users\PC\source\repos\WebBanHangDienTu\WebBanHangDienTu\Views\Home\Index.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral("                </ul>\r\n                <div class=\"tab-content\" id=\"myTabContent\">\r\n                    <div class=\"tab-pane fade show active\" id=\"all-items\" role=\"tabpanel\" aria-labelledby=\"all-items-tab\">\r\n                        ");
#nullable restore
#line 174 "C:\Users\PC\source\repos\WebBanHangDienTu\WebBanHangDienTu\Views\Home\Index.cshtml"
                   Write(await Html.PartialAsync("_ListProductPartialView", allProduct));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </div>\r\n");
#nullable restore
#line 176 "C:\Users\PC\source\repos\WebBanHangDienTu\WebBanHangDienTu\Views\Home\Index.cshtml"
                     foreach (var item in Model.Products)
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <div class=\"tab-pane fade\"");
            BeginWriteAttribute("id", " id=\"", 9044, "\"", 9069, 1);
#nullable restore
#line 178 "C:\Users\PC\source\repos\WebBanHangDienTu\WebBanHangDienTu\Views\Home\Index.cshtml"
WriteAttributeValue("", 9049, item.category.Alias, 9049, 20, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" role=\"tabpanel\" aria-labelledby=\"fresh-fruits-tab\">\r\n                            ");
#nullable restore
#line 179 "C:\Users\PC\source\repos\WebBanHangDienTu\WebBanHangDienTu\Views\Home\Index.cshtml"
                       Write(await Html.PartialAsync("_ListProductPartialView", item.lsProducts));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </div>");
#nullable restore
#line 180 "C:\Users\PC\source\repos\WebBanHangDienTu\WebBanHangDienTu\Views\Home\Index.cshtml"
                              }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"

                </div>
            </div>
        </div>
    </div>
</div>

<!-- Product Area End Here -->


<div class=""banner-area banner-style-2 section-space-y-axis-100"" data-bg-image=""/assets/images/product/pngtree.jpg"">
    <div class=""container"">
        <div class=""row"">
            <div class=""col-lg-12"">
                <div class=""banner-content"">
                    <div class=""section-title"">
                        <span class=""sub-title text-danger"">Khuyến mãi đặc biệt</span>
                        <h3 class=""title font-size-40 mb-7 text-success"">Giảm giá 20% các loại trong tháng 4</h3>
                    </div>

                    <div class=""countdown-wrap with-dark-border"">
                        <div class=""countdown item-4"" data-countdown=""2022/04/01"" data-format=""short"">
                            <div class=""countdown__item me-3"">
                                <span class=""countdown__time daysLeft""></span>
                                <span class=""cou");
            WriteLiteral(@"ntdown__text "">Ngày</span>
                            </div>
                            <div class=""countdown__item me-3"">
                                <span class=""countdown__time hoursLeft""></span>
                                <span class=""countdown__text "">Giờ</span>
                            </div>
                            <div class=""countdown__item me-3"">
                                <span class=""countdown__time minsLeft""></span>
                                <span class=""countdown__text "">Phút</span>
                            </div>
                            <div class=""countdown__item"">
                                <span class=""countdown__time secsLeft""></span>
                                <span class=""countdown__text"">Giây</span>
                            </div>
                        </div>
                    </div>
                    <div class=""button-wrap pt-10"">
                        <a class=""btn btn-custom-size lg-size btn-primary btn-dark-ho");
            WriteLiteral("ver rounded-0\" href=\"shop.html\">Mua hàng ngay</a>\r\n                    </div>\r\n                </div>\r\n            </div>\r\n        </div>\r\n    </div>\r\n</div>\r\n\r\n\r\n\r\n<!-- Begin Blog Area -->\r\n");
#nullable restore
#line 234 "C:\Users\PC\source\repos\WebBanHangDienTu\WebBanHangDienTu\Views\Home\Index.cshtml"
 if (Model.TinTucs != null && Model.TinTucs.Count() > 0)
{

#line default
#line hidden
#nullable disable
            WriteLiteral(@"    <div class=""blog-area section-space-y-axis-100"">
        <div class=""container"">
            <div class=""section-title text-center pb-55"">

                <h2>Tin tức</h2>
            </div>
            <div class=""row"">
                <div class=""col-lg-12"">
                    <div class=""swiper-container blog-slider"">
                        <div class=""swiper-wrapper"">
");
#nullable restore
#line 246 "C:\Users\PC\source\repos\WebBanHangDienTu\WebBanHangDienTu\Views\Home\Index.cshtml"
                             foreach (var item in Model.TinTucs)
                            {
                                string url = $"/tin-tuc/{item.Alias}-{item.PostId}.html";

#line default
#line hidden
#nullable disable
            WriteLiteral("                                <div class=\"swiper-slide\">\r\n                                    <div class=\"blog-item\">\r\n                                        <div class=\"blog-img img-zoom-effect\">\r\n                                            <a");
            BeginWriteAttribute("href", " href=\"", 12382, "\"", 12393, 1);
#nullable restore
#line 252 "C:\Users\PC\source\repos\WebBanHangDienTu\WebBanHangDienTu\Views\Home\Index.cshtml"
WriteAttributeValue("", 12389, url, 12389, 4, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n                                                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "a05a91c97823922a0ea386c86962df4ecb90b04922986", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 12497, "~/images/news/", 12497, 14, true);
#nullable restore
#line 253 "C:\Users\PC\source\repos\WebBanHangDienTu\WebBanHangDienTu\Views\Home\Index.cshtml"
AddHtmlAttributeValue("", 12511, item.Thumb, 12511, 11, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "alt", 1, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
#nullable restore
#line 253 "C:\Users\PC\source\repos\WebBanHangDienTu\WebBanHangDienTu\Views\Home\Index.cshtml"
AddHtmlAttributeValue("", 12529, item.Title, 12529, 11, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
                                            </a>
                                        </div>
                                        <div class=""blog-content"">
                                            <div class=""blog-meta text-dim-gray pb-3"">
                                                <ul>
                                                    <li class=""date""><i class=""fa fa-calendar-o me-2""></i>");
#nullable restore
#line 259 "C:\Users\PC\source\repos\WebBanHangDienTu\WebBanHangDienTu\Views\Home\Index.cshtml"
                                                                                                     Write(item.CreatedDate);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</li>
                                                    <li>
                                                        <span class=""comments me-3"">
                                                            <a href=""javascript:void(0)"">2 Comments</a>
                                                        </span>
                                                        <span class=""link-share"">
                                                            <a href=""javascript:void(0)"">Chia sẻ</a>
                                                        </span>
                                                    </li>
                                                </ul>
                                            </div>
                                            <h5 class=""title mb-4"">
                                                <a");
            BeginWriteAttribute("href", " href=\"", 13831, "\"", 13842, 1);
#nullable restore
#line 271 "C:\Users\PC\source\repos\WebBanHangDienTu\WebBanHangDienTu\Views\Home\Index.cshtml"
WriteAttributeValue("", 13838, url, 13838, 4, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 271 "C:\Users\PC\source\repos\WebBanHangDienTu\WebBanHangDienTu\Views\Home\Index.cshtml"
                                                          Write(item.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a>\r\n                                            </h5>\r\n                                            <p class=\"short-desc mb-5\">");
#nullable restore
#line 273 "C:\Users\PC\source\repos\WebBanHangDienTu\WebBanHangDienTu\Views\Home\Index.cshtml"
                                                                  Write(item.Scontents);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</p>
                                            <div class=""button-wrap"">
                                                <a class=""btn btn-custom-size btn-dark btn-lg rounded-0"" href=""blog-detail-left-sidebar.html"">Đọc thêm</a>
                                            </div>
                                        </div>
                                    </div>
                                </div>");
#nullable restore
#line 279 "C:\Users\PC\source\repos\WebBanHangDienTu\WebBanHangDienTu\Views\Home\Index.cshtml"
                                      }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"

                        </div>
                        <!-- Add Arrows -->
                        <div class=""swiper-button-next""></div>
                        <div class=""swiper-button-prev""></div>
                    </div>
                </div>
            </div>
        </div>
    </div>");
#nullable restore
#line 290 "C:\Users\PC\source\repos\WebBanHangDienTu\WebBanHangDienTu\Views\Home\Index.cshtml"
          }

#line default
#line hidden
#nullable disable
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "a05a91c97823922a0ea386c86962df4ecb90b04929011", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<WebBanHangDienTu.ModelViews.HomeViewVM> Html { get; private set; }
    }
}
#pragma warning restore 1591