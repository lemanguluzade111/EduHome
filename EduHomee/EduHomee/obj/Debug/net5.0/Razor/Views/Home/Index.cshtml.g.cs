#pragma checksum "C:\Users\lqulu\OneDrive\Masaüstü\EduHome\EduHomee\EduHomee\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "a58355911645c84ccc7ee3b979cff59bf2618b0f"
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
#line 1 "C:\Users\lqulu\OneDrive\Masaüstü\EduHome\EduHomee\EduHomee\Views\_ViewImports.cshtml"
using EduHomee;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\lqulu\OneDrive\Masaüstü\EduHome\EduHomee\EduHomee\Views\_ViewImports.cshtml"
using EduHomee.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\lqulu\OneDrive\Masaüstü\EduHome\EduHomee\EduHomee\Views\_ViewImports.cshtml"
using EduHomee.ViewModels;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a58355911645c84ccc7ee3b979cff59bf2618b0f", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"da89ae741e260c365b0d52d20a200603399788b3", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<HomeVM>
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("alt", new global::Microsoft.AspNetCore.Html.HtmlString("about"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/img/icon/section1.png"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("alt", new global::Microsoft.AspNetCore.Html.HtmlString("section-title"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/img/icon/section.png"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("alt", new global::Microsoft.AspNetCore.Html.HtmlString("event"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/img/event/event3.jpg"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("alt", new global::Microsoft.AspNetCore.Html.HtmlString("testimonial"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_7 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("alt", new global::Microsoft.AspNetCore.Html.HtmlString("blog"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            WriteLiteral("<!-- Background Area Start -->\r\n<section id=\"slider-container\" class=\"slider-area two\">\r\n    <div class=\"slider-owl owl-theme owl-carousel\">\r\n");
#nullable restore
#line 5 "C:\Users\lqulu\OneDrive\Masaüstü\EduHome\EduHomee\EduHomee\Views\Home\Index.cshtml"
   foreach (Slider slider in Model.Sliders)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <!-- Start Slingle Slide -->\r\n            <div class=\"single-slide item\"");
            BeginWriteAttribute("style", " style=\"", 296, "\"", 354, 4);
            WriteAttributeValue("", 304, "background-image:", 304, 17, true);
            WriteAttributeValue(" ", 321, "url(../img/slider/", 322, 19, true);
#nullable restore
#line 8 "C:\Users\lqulu\OneDrive\Masaüstü\EduHome\EduHomee\EduHomee\Views\Home\Index.cshtml"
WriteAttributeValue("", 340, slider.Image, 340, 13, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 353, ")", 353, 1, true);
            EndWriteAttribute();
            WriteLiteral(@">
                <!-- Start Slider Content -->
                <div class=""slider-content-area"">
                    <div class=""container"">
                        <div class=""row"">
                            <div class=""col-md-10 col-md-offset-1"">
                                <div class=""slide-content-wrapper"">
                                    <div class=""slide-content text-center"">
                                        <h2>");
#nullable restore
#line 16 "C:\Users\lqulu\OneDrive\Masaüstü\EduHome\EduHomee\EduHomee\Views\Home\Index.cshtml"
                                       Write(slider.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral(" </h2>\r\n                                        <p>");
#nullable restore
#line 17 "C:\Users\lqulu\OneDrive\Masaüstü\EduHome\EduHomee\EduHomee\Views\Home\Index.cshtml"
                                      Write(slider.Description);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"  </p>
                                        <a class=""default-btn"" href=""about.html"">Learn more</a>
                                    </div>
                                </div>
                            </div>
                        </div>
                    </div>
                </div>
                <!-- Start Slider Content -->
            </div>
            <!-- End Slingle Slide -->
");
#nullable restore
#line 28 "C:\Users\lqulu\OneDrive\Masaüstü\EduHome\EduHomee\EduHomee\Views\Home\Index.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    \r\n    </div>\r\n</section>\r\n<!-- Background Area End -->\r\n<!-- Service Start -->\r\n<div class=\"service-area two pt-150 pb-150\">\r\n    <div class=\"container\">\r\n        <div class=\"row\">\r\n");
#nullable restore
#line 37 "C:\Users\lqulu\OneDrive\Masaüstü\EduHome\EduHomee\EduHomee\Views\Home\Index.cshtml"
             foreach (Service service in Model.Services)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <div class=\"col-md-4 col-sm-4 col-xs-12\">\r\n                    <div class=\"single-service\">\r\n                        <h3><a href=\"teacher.html\">");
#nullable restore
#line 41 "C:\Users\lqulu\OneDrive\Masaüstü\EduHome\EduHomee\EduHomee\Views\Home\Index.cshtml"
                                              Write(service.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a></h3>\r\n                        <p>");
#nullable restore
#line 42 "C:\Users\lqulu\OneDrive\Masaüstü\EduHome\EduHomee\EduHomee\Views\Home\Index.cshtml"
                      Write(service.Description);

#line default
#line hidden
#nullable disable
            WriteLiteral(" </p>\r\n                    </div>\r\n                </div>\r\n");
#nullable restore
#line 45 "C:\Users\lqulu\OneDrive\Masaüstü\EduHome\EduHomee\EduHomee\Views\Home\Index.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"            
        </div>
    </div>
</div>
<!-- Service End -->
<!-- About Start -->
<div class=""about-area pb-155"">
    <div class=""container"">
        <div class=""row"">
            <div class=""col-md-6 col-sm-6"">
                <div class=""about-content"">
                    <h2>");
#nullable restore
#line 57 "C:\Users\lqulu\OneDrive\Masaüstü\EduHome\EduHomee\EduHomee\Views\Home\Index.cshtml"
                   Write(Html.Raw(Model.About?.Title));

#line default
#line hidden
#nullable disable
            WriteLiteral("</h2>\r\n                    ");
#nullable restore
#line 58 "C:\Users\lqulu\OneDrive\Masaüstü\EduHome\EduHomee\EduHomee\Views\Home\Index.cshtml"
               Write(Html.Raw(Model.About?.Description));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    <a class=\"default-btn\" href=\"about.html\">view courses</a>\r\n                </div>\r\n            </div>\r\n            <div class=\"col-md-6 col-sm-6\">\r\n                <div class=\"about-img\">\r\n                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "a58355911645c84ccc7ee3b979cff59bf2618b0f11439", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 2505, "~/img/about/", 2505, 12, true);
#nullable restore
#line 64 "C:\Users\lqulu\OneDrive\Masaüstü\EduHome\EduHomee\EduHomee\Views\Home\Index.cshtml"
AddHtmlAttributeValue("", 2517, Model.About?.Image, 2517, 19, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
                </div>
            </div>
        </div>
    </div>
</div>
<!-- About End -->
<!-- Courses Area Start -->
<div class=""courses-area two pt-150 pb-150 text-center"">
    <div class=""container"">
        <div class=""row"">
            <div class=""col-xs-12"">
                <div class=""section-title"">
                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "a58355911645c84ccc7ee3b979cff59bf2618b0f13372", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                    <h2>COURSES WE OFFER</h2>\r\n                </div>\r\n            </div>\r\n        </div>\r\n        <div class=\"row\">\r\n            ");
#nullable restore
#line 83 "C:\Users\lqulu\OneDrive\Masaüstü\EduHome\EduHomee\EduHomee\Views\Home\Index.cshtml"
       Write(await Component.InvokeAsync("Courses", new {take=3}));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
        </div>
    </div>
</div>
<!-- Courses Area End -->
<!-- Notice Start -->
<section class=""notice-area two pt-140"">
    <div class=""container"">
        <div class=""row"">
            <div class=""col-md-6 col-sm-6 col-xs-12"">
                <div class=""notice-right-wrapper mb-25 pb-25"">
                    <h3>TAKE A VIDEO TOUR</h3>
                    <div class=""notice-video"">
                        <div class=""video-icon video-hover"">
                            <a class=""video-popup"" href=""https://www.youtube.com/watch?v=to6Ghf8UL7o"">
                                <i class=""zmdi zmdi-play""></i>
                            </a>
                        </div>
                    </div>
                </div>
            </div>
            <div class=""col-md-6 col-sm-6 col-xs-12"">
                <div class=""notice-left-wrapper"">
                    <h3>notice board</h3>
                    <div class=""notice-left"">
                        <div class=""single-notice-left mb-2");
            WriteLiteral(@"3 pb-20"">
                            <h4>5, June 2017</h4>
                            <p>I must explain to you how all this mistaken idea of denouncing plasure and praising pain was born and I will give you a complete </p>
                        </div>
                        <div class=""single-notice-left hidden-sm mb-23 pb-20"">
                            <h4>4, June 2017</h4>
                            <p>I must explain to you how all this mistaken idea of denouncing plasure and praising pain was born and I will give you a complete </p>
                        </div>
                        <div class=""single-notice-left pb-70"">
                            <h4>3, June 2017</h4>
                            <p>I must explain to you how all this mistaken idea of denouncing plasure and praising pain was born and I will give you a complete </p>
                        </div>
                        <div class=""single-notice-left mb-23 pb-20"">
                            <h4>5, June 2017</h4>
 ");
            WriteLiteral(@"                           <p>I must explain to you how all this mistaken idea of denouncing plasure and praising pain was born and I will give you a complete </p>
                        </div>
                        <div class=""single-notice-left hidden-sm mb-23 pb-20"">
                            <h4>4, June 2017</h4>
                            <p>I must explain to you how all this mistaken idea of denouncing plasure and praising pain was born and I will give you a complete </p>
                        </div>
                        <div class=""single-notice-left pb-70"">
                            <h4>3, June 2017</h4>
                            <p>I must explain to you how all this mistaken idea of denouncing plasure and praising pain was born and I will give you a complete </p>
                        </div>
                    </div>
                </div>
            </div>
        </div>
    </div>
</section>
<!-- Notice End -->
<!-- Event Area Start -->
<div class=""event-area tw");
            WriteLiteral("o text-center pt-100 pb-145\">\r\n    <div class=\"container\">\r\n        <div class=\"row\">\r\n            <div class=\"col-xs-12\">\r\n                <div class=\"section-title\">\r\n                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "a58355911645c84ccc7ee3b979cff59bf2618b0f18324", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                    <h2>UPCOMMING EVENTS</h2>\r\n                </div>\r\n            </div>\r\n        </div>\r\n        <div class=\"row\">\r\n");
#nullable restore
#line 151 "C:\Users\lqulu\OneDrive\Masaüstü\EduHome\EduHomee\EduHomee\Views\Home\Index.cshtml"
             foreach (Event events in Model.Events)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <div class=\"col-md-6 col-sm-12 col-xs-12\">\r\n                    <div class=\"single-event mb-35\">\r\n                        <div class=\"event-img\">\r\n                            <a href=\"event-details.html\">");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "a58355911645c84ccc7ee3b979cff59bf2618b0f20082", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 6901, "~/img/event/", 6901, 12, true);
#nullable restore
#line 156 "C:\Users\lqulu\OneDrive\Masaüstü\EduHome\EduHomee\EduHomee\Views\Home\Index.cshtml"
AddHtmlAttributeValue("", 6913, events.Image, 6913, 13, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("</a>\r\n                        </div>\r\n                        <div class=\"event-content text-left\">\r\n                            <h3>");
#nullable restore
#line 159 "C:\Users\lqulu\OneDrive\Masaüstü\EduHome\EduHomee\EduHomee\Views\Home\Index.cshtml"
                           Write(events.CreatedTime.ToString("MMMM dd,yyyy"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</h3>\r\n                            <h4><a href=\"event-details.html\">");
#nullable restore
#line 160 "C:\Users\lqulu\OneDrive\Masaüstü\EduHome\EduHomee\EduHomee\Views\Home\Index.cshtml"
                                                        Write(events.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a></h4>\r\n                            <ul>\r\n                                <li><i class=\"fa fa-clock-o\"></i>");
#nullable restore
#line 162 "C:\Users\lqulu\OneDrive\Masaüstü\EduHome\EduHomee\EduHomee\Views\Home\Index.cshtml"
                                                            Write(events.Time.ToString("hh:mm:tt"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</li>\r\n                                <li><i class=\"fa fa-map-marker\"></i>");
#nullable restore
#line 163 "C:\Users\lqulu\OneDrive\Masaüstü\EduHome\EduHomee\EduHomee\Views\Home\Index.cshtml"
                                                               Write(events.Location);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</li>
                            </ul>
                            <div class=""event-content-right"">
                                <a class=""default-btn"" href=""event-details.html"">join now</a>
                            </div>
                        </div>
                    </div>
                    <div class=""single-event hidden-sm hidden-xs"">
                        <div class=""event-img"">
                            <a href=""event-details.html"">");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "a58355911645c84ccc7ee3b979cff59bf2618b0f23675", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"</a>
                        </div>
                        <div class=""event-content text-left"">
                            <h3>16 June 2017</h3>
                            <h4><a href=""event-details.html"">learning english history</a></h4>
                            <ul>
                                <li><i class=""fa fa-clock-o""></i>9.00 AM - 4.45 PM</li>
                                <li><i class=""fa fa-map-marker""></i>New Yourk City</li>
                            </ul>
                            <div class=""event-content-right"">
                                <a class=""default-btn"" href=""event-details.html"">join now</a>
                            </div>
                        </div>
                    </div>
                </div>
");
#nullable restore
#line 187 "C:\Users\lqulu\OneDrive\Masaüstü\EduHome\EduHomee\EduHomee\Views\Home\Index.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"        </div>
    </div>
</div>
<!-- Event Area End -->
<!-- Testimonial Area Start -->
<div class=""testimonial-area pt-110 pb-105 text-center"">
    <div class=""container"">
        <div class=""row"">
            <div class=""testimonial-owl owl-theme owl-carousel"">
");
#nullable restore
#line 197 "C:\Users\lqulu\OneDrive\Masaüstü\EduHome\EduHomee\EduHomee\Views\Home\Index.cshtml"
                 foreach (Feedback feedback in Model.Feedbacks)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                    <div class=""col-md-8 col-md-offset-2 col-sm-12"">
                        <div class=""single-testimonial"">
                            <div class=""testimonial-info"">
                                <div class=""testimonial-img"">
                                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "a58355911645c84ccc7ee3b979cff59bf2618b0f26644", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 9391, "~/img/testimonial/", 9391, 18, true);
#nullable restore
#line 203 "C:\Users\lqulu\OneDrive\Masaüstü\EduHome\EduHomee\EduHomee\Views\Home\Index.cshtml"
AddHtmlAttributeValue("", 9409, feedback.Image, 9409, 15, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_6);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                                </div>\r\n                                <div class=\"testimonial-content\">\r\n                                    <p>");
#nullable restore
#line 206 "C:\Users\lqulu\OneDrive\Masaüstü\EduHome\EduHomee\EduHomee\Views\Home\Index.cshtml"
                                  Write(feedback.Description);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                                    <h4>");
#nullable restore
#line 207 "C:\Users\lqulu\OneDrive\Masaüstü\EduHome\EduHomee\EduHomee\Views\Home\Index.cshtml"
                                   Write(feedback.FullName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h4>\r\n                                    <h5>");
#nullable restore
#line 208 "C:\Users\lqulu\OneDrive\Masaüstü\EduHome\EduHomee\EduHomee\Views\Home\Index.cshtml"
                                   Write(feedback.Position);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h5>\r\n                                </div>\r\n                            </div>\r\n                        </div>\r\n                    </div>\r\n");
#nullable restore
#line 213 "C:\Users\lqulu\OneDrive\Masaüstü\EduHome\EduHomee\EduHomee\Views\Home\Index.cshtml"
                }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"            </div>
        </div>
    </div>
</div>
<!-- Testimonial Area End -->
<!-- Blog Area Start -->
<div class=""blog-area pt-150 pb-150"">
    <div class=""container"">
        <div class=""row"">
            <div class=""col-xs-12"">
                <div class=""section-title text-center"">
                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "a58355911645c84ccc7ee3b979cff59bf2618b0f29952", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                    <h2>LATEST FROM BLOG</h2>\r\n                </div>\r\n            </div>\r\n        </div>\r\n        <div class=\"row\">\r\n");
#nullable restore
#line 231 "C:\Users\lqulu\OneDrive\Masaüstü\EduHome\EduHomee\EduHomee\Views\Home\Index.cshtml"
            foreach (Blog blog in Model.Blogs)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <div class=\"col-md-4 col-sm-6 col-xs-12\">\r\n                    <div class=\"single-blog\">\r\n                        <div class=\"blog-img\">\r\n                            <a href=\"blog-details.html\">");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "a58355911645c84ccc7ee3b979cff59bf2618b0f31695", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 10698, "~/img/blog/", 10698, 11, true);
#nullable restore
#line 236 "C:\Users\lqulu\OneDrive\Masaüstü\EduHome\EduHomee\EduHomee\Views\Home\Index.cshtml"
AddHtmlAttributeValue("", 10709, blog.Image, 10709, 11, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_7);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"</a>
                            <div class=""blog-hover"">
                                <a href=""blog-details.html""><i class=""fa fa-link""></i></a>
                            </div>
                        </div>
                        <div class=""blog-content"">
                            <div class=""blog-top"">
                                <p>By ");
#nullable restore
#line 243 "C:\Users\lqulu\OneDrive\Masaüstü\EduHome\EduHomee\EduHomee\Views\Home\Index.cshtml"
                                 Write(blog.By);

#line default
#line hidden
#nullable disable
            WriteLiteral("  /  ");
#nullable restore
#line 243 "C:\Users\lqulu\OneDrive\Masaüstü\EduHome\EduHomee\EduHomee\Views\Home\Index.cshtml"
                                              Write(blog.CreatedTime.ToString("MMMM dd,yyyy"));

#line default
#line hidden
#nullable disable
            WriteLiteral("  /  <i class=\"fa fa-comments-o\"></i> 4</p>\r\n                            </div>\r\n                            <div class=\"blog-bottom\">\r\n                                <h2><a href=\"blog-details.html\">");
#nullable restore
#line 246 "C:\Users\lqulu\OneDrive\Masaüstü\EduHome\EduHomee\EduHomee\Views\Home\Index.cshtml"
                                                           Write(blog.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral(" </a></h2>\r\n                                <a href=\"blog-details.html\">read more</a>\r\n                            </div>\r\n                        </div>\r\n                    </div>\r\n                </div>\r\n");
#nullable restore
#line 252 "C:\Users\lqulu\OneDrive\Masaüstü\EduHome\EduHomee\EduHomee\Views\Home\Index.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("            \r\n        </div>\r\n    </div>\r\n</div>\r\n<!-- Blog Area End -->\r\n");
        }
        #pragma warning restore 1998
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<HomeVM> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
