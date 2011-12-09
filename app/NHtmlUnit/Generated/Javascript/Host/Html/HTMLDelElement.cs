// Generated class v4, don't modify

using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;

namespace NHtmlUnit.Javascript.Host.Html
{
   public partial class HTMLDelElement : NHtmlUnit.Javascript.Host.Html.HTMLElement, NHtmlUnit.Javascript.IScriptableWithFallbackGetter
   {
      static HTMLDelElement()
      {
         ObjectWrapper.RegisterWrapperCreator((com.gargoylesoftware.htmlunit.javascript.host.html.HTMLDelElement o) =>
            new HTMLDelElement(o));
      }

      public HTMLDelElement(com.gargoylesoftware.htmlunit.javascript.host.html.HTMLDelElement wrappedObject) : base(wrappedObject) {}

      public new com.gargoylesoftware.htmlunit.javascript.host.html.HTMLDelElement WObj
      {
         get { return (com.gargoylesoftware.htmlunit.javascript.host.html.HTMLDelElement)WrappedObject; }
      }

      public HTMLDelElement()
         : this(new com.gargoylesoftware.htmlunit.javascript.host.html.HTMLDelElement()) {}

// Generating method code for jsxGet_cite
      public virtual string JsxGet_cite()
      {
         return WObj.jsxGet_cite();
      }

// Generating method code for jsxSet_cite
      public virtual void JsxSet_cite(string cite)
      {
         WObj.jsxSet_cite(cite);
      }

// Generating method code for jsxGet_dateTime
      public virtual string JsxGet_dateTime()
      {
         return WObj.jsxGet_dateTime();
      }

// Generating method code for jsxSet_dateTime
      public virtual void JsxSet_dateTime(string dateTime)
      {
         WObj.jsxSet_dateTime(dateTime);
      }

   }


}