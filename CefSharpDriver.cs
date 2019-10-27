using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using CefSharp.Wpf;
using Codeer.Friendly;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Html5;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Internal;
using OpenQA.Selenium.Remote;

namespace CefSharpDriver
{
    public class CefSharpDriver : IWebDriver,
                                    ISearchContext,
                                    IDisposable,
                                    IJavaScriptExecutor,
                                    IFindsById,
                                    IFindsByClassName,
                                    IFindsByLinkText,
                                    IFindsByName,
                                    IFindsByTagName,
                                    IFindsByXPath,
                                    IFindsByPartialLinkText,
                                    IFindsByCssSelector,
                                    ITakesScreenshot,
                                    IHasCapabilities,
                                    IHasWebStorage,
                                    IHasLocationContext,
                                    IHasApplicationCache,
                                    IAllowsFileDetection,
                                    IHasSessionId,
                                    IActionExecutor,
                                    IAppVarOwner
    {
        public AppVar AppVar { get; }

        public string Url { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }


        public string Title => throw new NotImplementedException();

        public string PageSource => throw new NotImplementedException();

        public string CurrentWindowHandle => throw new NotImplementedException();

        public ReadOnlyCollection<string> WindowHandles => throw new NotImplementedException();

        public ICapabilities Capabilities {get; }

        public bool HasWebStorage => this.WebStorage != null;

        public IWebStorage WebStorage {get; }

        public bool HasLocationContext => this.LocationContext != null;

        public ILocationContext LocationContext { get; }

        public bool HasApplicationCache => this.ApplicationCache != null;

        public IApplicationCache ApplicationCache { get; }

        public IFileDetector FileDetector { get ; set; }

        public SessionId SessionId { get; }

        public bool IsActionExecutor { get { return true; } }


        public CefSharpDriver(AppVar appVar)
        {
            AppVar = appVar;
        }

        public void Close()
        {
            AppVar.Dispose();
        }

        public void Quit()
        {
            AppVar.Dispose();
        }

        public IOptions Manage()
        {
            throw new NotImplementedException();
        }

        public INavigation Navigate()
        {
            throw new NotImplementedException();
        }

        public ITargetLocator SwitchTo()
        {
            throw new NotImplementedException();
        }

        public IWebElement FindElement(By by)
        {
            return by.FindElement(this);
        }

        public ReadOnlyCollection<IWebElement> FindElements(By by)
        {
            return by.FindElements(this);
        }

        public void Dispose()
        {
            AppVar.Dispose();
        }

        public object ExecuteScript(string script, params object[] args)
        {
            throw new NotImplementedException();
        }

        public object ExecuteAsyncScript(string script, params object[] args)
        {
            throw new NotImplementedException();
        }

        public IWebElement FindElementById(string id)
        {
            return this.FindElement(By.Id(id));
        }

        public ReadOnlyCollection<IWebElement> FindElementsById(string id)
        {
            return this.FindElements(By.Id(id));
        }

        public IWebElement FindElementByClassName(string className)
        {
            return this.FindElement(By.ClassName(className));
        }

        public ReadOnlyCollection<IWebElement> FindElementsByClassName(string className)
        {
            return this.FindElements(By.ClassName(className));
        }

        public IWebElement FindElementByLinkText(string linkText)
        {
            return this.FindElement(By.LinkText(linkText));
        }

        public ReadOnlyCollection<IWebElement> FindElementsByLinkText(string linkText)
        {
            return this.FindElements(By.LinkText(linkText));
        }

        public IWebElement FindElementByName(string name)
        {
            return this.FindElement(By.Name(name));
        }

        public ReadOnlyCollection<IWebElement> FindElementsByName(string name)
        {
            return this.FindElements(By.Name(name));
        }

        public IWebElement FindElementByTagName(string tagName)
        {
            return this.FindElement(By.TagName(tagName));
        }

        public ReadOnlyCollection<IWebElement> FindElementsByTagName(string tagName)
        {
            return this.FindElements(By.TagName(tagName));
        }

        public IWebElement FindElementByXPath(string xpath)
        {
            return this.FindElement(By.XPath(xpath));
        }

        public ReadOnlyCollection<IWebElement> FindElementsByXPath(string xpath)
        {
            return this.FindElements(By.XPath(xpath));
        }

        public IWebElement FindElementByPartialLinkText(string partialLinkText)
        {
            return this.FindElement(By.PartialLinkText(partialLinkText));
        }

        public ReadOnlyCollection<IWebElement> FindElementsByPartialLinkText(string partialLinkText)
        {
            return this.FindElements(By.PartialLinkText(partialLinkText));
        }

        public IWebElement FindElementByCssSelector(string cssSelector)
        {
            return this.FindElement(By.CssSelector(cssSelector));
        }

        public ReadOnlyCollection<IWebElement> FindElementsByCssSelector(string cssSelector)
        {
            return this.FindElements(By.CssSelector(cssSelector));
        }

        public Screenshot GetScreenshot()
        {
            throw new NotImplementedException();
        }

        public void PerformActions(IList<ActionSequence> actionSequenceList)
        {
            throw new NotImplementedException();
        }

        public void ResetInputState()
        {
            throw new NotImplementedException();
        }
    }
}
