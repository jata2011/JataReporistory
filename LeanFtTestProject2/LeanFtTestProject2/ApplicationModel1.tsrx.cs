//----------------------------------------------------------------------------------------------------
// <auto-generated>
//
//		This code was automatically generated by the LeanFT Application Model code generator.
//
//		Changes to this file may cause incorrect behavior and will be lost 
//		when the code is regenerated.
//
// </auto-generated>
//----------------------------------------------------------------------------------------------------
using System;
using HP.LFT.SDK;  
using System.Collections.Generic;

namespace LeanFtTestProject2
{
	[global::System.CodeDom.Compiler.GeneratedCodeAttribute("This class is automatically generated by the LeanFT Application Model code generator.", "14.00")]
	public class ApplicationModel1 : AppModelBase
	{
		#region Constructors

		public ApplicationModel1(ITestObject contextTestObject)
		{
			Name = @"ApplicationModel1";
			GoogleSearchButton = new GoogleSearchButtonNode(contextTestObject, this);
			SearchEditField = new SearchEditFieldNode(contextTestObject, this);
			RebuildDescriptions();
			
		}

		#endregion

		#region Test Objects
	
		public GoogleSearchButtonNode GoogleSearchButton { get; private set; }
		public SearchEditFieldNode SearchEditField { get; private set; }
	
		#endregion
	
		#region Inner Classes
	
		public sealed class GoogleSearchButtonNode : ButtonNodeBase
		{
			#region Constructors
		
			public GoogleSearchButtonNode(ITestObject parent, AppModelBase applicationModel) : base(parent, applicationModel)
			{
				DisplayName = @"Google Search";
			}
		
			#endregion
		
			#region Description
		
			protected override HP.LFT.SDK.Web.ButtonDescription CreateDescription()
			{
				return new HP.LFT.SDK.Web.ButtonDescription
				{
					ButtonType = @"submit",
					AccessibilityName = @"Google Search",
					XPath = @"//FORM[@id=""tsf""]/DIV[2]/DIV[3]/CENTER[1]/INPUT[1]"
				};
			}
		
			#endregion
		
		}

		public sealed class SearchEditFieldNode : EditFieldNodeBase
		{
			#region Constructors
		
			public SearchEditFieldNode(ITestObject parent, AppModelBase applicationModel) : base(parent, applicationModel)
			{
				DisplayName = @"Search";
			}
		
			#endregion
		
			#region Description
		
			protected override HP.LFT.SDK.Web.EditFieldDescription CreateDescription()
			{
				return new HP.LFT.SDK.Web.EditFieldDescription
				{
					Type = @"text",
					AccessibilityName = @"Search",
					TagName = @"INPUT",
					Title = @"Search"
				};
			}
		
			#endregion
		
		}

		#endregion

		#region Base Classes

		public abstract class EditFieldNodeBase : AppModelNodeBase<HP.LFT.SDK.Web.IEditField, HP.LFT.SDK.Web.EditFieldDescription>, HP.LFT.SDK.Web.IEditField
		{
			public EditFieldNodeBase(ITestObject parent, AppModelBase applicationModel) : base(parent, applicationModel) { }

			#region Public Methods
	
			public void SetSecure(string encodedText)
			{
				 Concrete.SetSecure(encodedText);
			}
	
			public void SetValue(string text)
			{
				 Concrete.SetValue(text);
			}
	
			public void DoubleClick()
			{
				 Concrete.DoubleClick();
			}
	
			public void DoubleClick(HP.LFT.SDK.Web.WebDoubleClickArgs args)
			{
				 Concrete.DoubleClick(args);
			}
	
			public void HoverTap()
			{
				 Concrete.HoverTap();
			}
	
			public void HoverTap(HP.LFT.SDK.Location location)
			{
				 Concrete.HoverTap(location);
			}
	
			public void FireEvent(HP.LFT.SDK.Web.EventInfo eventInfo)
			{
				 Concrete.FireEvent(eventInfo);
			}
	
			public void LongPress()
			{
				 Concrete.LongPress();
			}
	
			public void LongPress(HP.LFT.SDK.Web.WebLongPressArgs args)
			{
				 Concrete.LongPress(args);
			}
	
			public void Pan(long deltaX, long deltaY)
			{
				 Concrete.Pan(deltaX, deltaY);
			}
	
			public void Pan(HP.LFT.SDK.Web.WebPanArgs args)
			{
				 Concrete.Pan(args);
			}
	
			public void Pinch(double scale)
			{
				 Concrete.Pinch(scale);
			}
	
			public void Pinch(HP.LFT.SDK.Web.WebPinchArgs args)
			{
				 Concrete.Pinch(args);
			}
	
			public void Swipe(HP.LFT.SDK.SwipeDirection direction)
			{
				 Concrete.Swipe(direction);
			}
	
			public void Swipe(HP.LFT.SDK.Web.WebSwipeArgs args)
			{
				 Concrete.Swipe(args);
			}
	
			public HP.LFT.SDK.IDescription GetDescription()
			{
				return Concrete.GetDescription();
			}
	
			public TChild[] FindChildren<TChild>(HP.LFT.SDK.IDescription selector)  where TChild:class, HP.LFT.SDK.ITestObject
			{
				return Concrete.FindChildren<TChild>(selector);
			}
	
			public bool Exists()
			{
				return Concrete.Exists();
			}
	
			public bool Exists(uint timeout)
			{
				return Concrete.Exists(timeout);
			}
	
			public System.Drawing.Image GetSnapshot()
			{
				return Concrete.GetSnapshot();
			}
	
			public void Highlight()
			{
				 Concrete.Highlight();
			}
	
			public uint HighlightMatches<TChild>(HP.LFT.SDK.IDescription description)  where TChild:class, HP.LFT.SDK.ITestObject
			{
				return Concrete.HighlightMatches<TChild>(description);
			}
	
			public System.Drawing.Rectangle[] GetTextLocations(string textToFind)
			{
				return Concrete.GetTextLocations(textToFind);
			}
	
			public System.Drawing.Rectangle[] GetTextLocations(string textToFind, System.Drawing.Rectangle textArea)
			{
				return Concrete.GetTextLocations(textToFind, textArea);
			}
	
			public string GetVisibleText()
			{
				return Concrete.GetVisibleText();
			}
	
			public string GetVisibleText(System.Drawing.Rectangle textArea)
			{
				return Concrete.GetVisibleText(textArea);
			}
	
			public System.Nullable<System.Drawing.Point> VerifyImageExists(System.Drawing.Image imageToFind, byte similarity = 100)
			{
				return Concrete.VerifyImageExists(imageToFind, similarity);
			}
	
			public bool VerifyImageMatch(System.Drawing.Image expectedImage, byte pixelTolerance = 0, byte rgbTolerance = 0)
			{
				return Concrete.VerifyImageMatch(expectedImage, pixelTolerance, rgbTolerance);
			}
	
			public bool VerifyImageMatch(System.Drawing.Image expectedImage, HP.LFT.SDK.Utils.ImageMaskArea maskArea, byte pixelTolerance = 0, byte rgbTolerance = 0)
			{
				return Concrete.VerifyImageMatch(expectedImage, maskArea, pixelTolerance, rgbTolerance);
			}
	
			public TChild Describe<TChild>(HP.LFT.SDK.IDescription description)  where TChild:class, HP.LFT.SDK.ITestObject
			{
				return Concrete.Describe<TChild>(description);
			}
	
			public void Click(HP.LFT.SDK.MouseButton button = HP.LFT.SDK.MouseButton.Left)
			{
				 Concrete.Click(button);
			}
	
			public void Click(HP.LFT.SDK.ClickArgs args)
			{
				 Concrete.Click(args);
			}
	
			public string GetAttribute(string attributeName)
			{
				return Concrete.GetAttribute(attributeName);
			}
	
			public string GetComputedStyle(string styleProperty)
			{
				return Concrete.GetComputedStyle(styleProperty);
			}
	
			public TChild Describe<TChild>(HP.LFT.SDK.Web.XPathDescription xpath)  where TChild:class, HP.LFT.SDK.Web.IWebElement
			{
				return Concrete.Describe<TChild>(xpath);
			}
	
			public TChild Describe<TChild>(HP.LFT.SDK.Web.CSSDescription cssSelector)  where TChild:class, HP.LFT.SDK.Web.IWebElement
			{
				return Concrete.Describe<TChild>(cssSelector);
			}
	
			public void DragAndDropOn(HP.LFT.SDK.ISupportDragAndDrop dropTarget)
			{
				 Concrete.DragAndDropOn(dropTarget);
			}
	
			public void DragAndDropOn(HP.LFT.SDK.ISupportDragAndDrop dropTarget, HP.LFT.SDK.DragAndDropArgs dragAndDropArgs)
			{
				 Concrete.DragAndDropOn(dropTarget, dragAndDropArgs);
			}
	
			#endregion
	
			#region Public Properties
	
			public string DefaultValue
			{
				get { return Concrete.DefaultValue; }		
			}
	
			public int MaxLength
			{
				get { return Concrete.MaxLength; }		
			}
	
			public string Pattern
			{
				get { return Concrete.Pattern; }		
			}
	
			public uint RowsCount
			{
				get { return Concrete.RowsCount; }		
			}
	
			public string Type
			{
				get { return Concrete.Type; }		
			}
	
			public string Value
			{
				get { return Concrete.Value; }		
			}
	
			public bool IsReadOnly
			{
				get { return Concrete.IsReadOnly; }		
			}
	
			public bool IsRequired
			{
				get { return Concrete.IsRequired; }		
			}
	
			public uint MaxCharsInLine
			{
				get { return Concrete.MaxCharsInLine; }		
			}
	
			public string XPath
			{
				get { return Concrete.XPath; }		
			}
	
			public string AccessibilityName
			{
				get { return Concrete.AccessibilityName; }		
			}
	
			public string CSSSelector
			{
				get { return Concrete.CSSSelector; }		
			}
	
			public string Role
			{
				get { return Concrete.Role; }		
			}
	
			public string DisplayName
			{
				get { return Concrete.DisplayName; }		
				set { Concrete.DisplayName = value; }
			}
	
			public string ClassName
			{
				get { return Concrete.ClassName; }		
			}
	
			public string Id
			{
				get { return Concrete.Id; }		
			}
	
			public string TagName
			{
				get { return Concrete.TagName; }		
			}
	
			public string InnerHTML
			{
				get { return Concrete.InnerHTML; }		
			}
	
			public string OuterHTML
			{
				get { return Concrete.OuterHTML; }		
			}
	
			public string InnerText
			{
				get { return Concrete.InnerText; }		
			}
	
			public string OuterText
			{
				get { return Concrete.OuterText; }		
			}
	
			public string Name
			{
				get { return Concrete.Name; }		
			}
	
			public string Title
			{
				get { return Concrete.Title; }		
			}
	
			public bool IsVisible
			{
				get { return Concrete.IsVisible; }		
			}
	
			public System.Collections.Generic.IReadOnlyDictionary<string, string> Attributes
			{
				get { return Concrete.Attributes; }		
			}
	
			public System.Collections.Generic.IReadOnlyDictionary<string, string> Styles
			{
				get { return Concrete.Styles; }		
			}
	
			public System.Drawing.Point Location
			{
				get { return Concrete.Location; }		
			}
	
			public System.Drawing.Point AbsoluteLocation
			{
				get { return Concrete.AbsoluteLocation; }		
			}
	
			public System.Drawing.Size Size
			{
				get { return Concrete.Size; }		
			}
	
			public dynamic NativeObject
			{
				get { return Concrete.NativeObject; }		
			}
	
			#endregion
		}

		public abstract class ButtonNodeBase : AppModelNodeBase<HP.LFT.SDK.Web.IButton, HP.LFT.SDK.Web.ButtonDescription>, HP.LFT.SDK.Web.IButton
		{
			public ButtonNodeBase(ITestObject parent, AppModelBase applicationModel) : base(parent, applicationModel) { }

			#region Public Methods
	
			public void DoubleClick()
			{
				 Concrete.DoubleClick();
			}
	
			public void DoubleClick(HP.LFT.SDK.Web.WebDoubleClickArgs args)
			{
				 Concrete.DoubleClick(args);
			}
	
			public void HoverTap()
			{
				 Concrete.HoverTap();
			}
	
			public void HoverTap(HP.LFT.SDK.Location location)
			{
				 Concrete.HoverTap(location);
			}
	
			public void FireEvent(HP.LFT.SDK.Web.EventInfo eventInfo)
			{
				 Concrete.FireEvent(eventInfo);
			}
	
			public void LongPress()
			{
				 Concrete.LongPress();
			}
	
			public void LongPress(HP.LFT.SDK.Web.WebLongPressArgs args)
			{
				 Concrete.LongPress(args);
			}
	
			public void Pan(long deltaX, long deltaY)
			{
				 Concrete.Pan(deltaX, deltaY);
			}
	
			public void Pan(HP.LFT.SDK.Web.WebPanArgs args)
			{
				 Concrete.Pan(args);
			}
	
			public void Pinch(double scale)
			{
				 Concrete.Pinch(scale);
			}
	
			public void Pinch(HP.LFT.SDK.Web.WebPinchArgs args)
			{
				 Concrete.Pinch(args);
			}
	
			public void Swipe(HP.LFT.SDK.SwipeDirection direction)
			{
				 Concrete.Swipe(direction);
			}
	
			public void Swipe(HP.LFT.SDK.Web.WebSwipeArgs args)
			{
				 Concrete.Swipe(args);
			}
	
			public HP.LFT.SDK.IDescription GetDescription()
			{
				return Concrete.GetDescription();
			}
	
			public TChild[] FindChildren<TChild>(HP.LFT.SDK.IDescription selector)  where TChild:class, HP.LFT.SDK.ITestObject
			{
				return Concrete.FindChildren<TChild>(selector);
			}
	
			public bool Exists()
			{
				return Concrete.Exists();
			}
	
			public bool Exists(uint timeout)
			{
				return Concrete.Exists(timeout);
			}
	
			public System.Drawing.Image GetSnapshot()
			{
				return Concrete.GetSnapshot();
			}
	
			public void Highlight()
			{
				 Concrete.Highlight();
			}
	
			public uint HighlightMatches<TChild>(HP.LFT.SDK.IDescription description)  where TChild:class, HP.LFT.SDK.ITestObject
			{
				return Concrete.HighlightMatches<TChild>(description);
			}
	
			public System.Drawing.Rectangle[] GetTextLocations(string textToFind)
			{
				return Concrete.GetTextLocations(textToFind);
			}
	
			public System.Drawing.Rectangle[] GetTextLocations(string textToFind, System.Drawing.Rectangle textArea)
			{
				return Concrete.GetTextLocations(textToFind, textArea);
			}
	
			public string GetVisibleText()
			{
				return Concrete.GetVisibleText();
			}
	
			public string GetVisibleText(System.Drawing.Rectangle textArea)
			{
				return Concrete.GetVisibleText(textArea);
			}
	
			public System.Nullable<System.Drawing.Point> VerifyImageExists(System.Drawing.Image imageToFind, byte similarity = 100)
			{
				return Concrete.VerifyImageExists(imageToFind, similarity);
			}
	
			public bool VerifyImageMatch(System.Drawing.Image expectedImage, byte pixelTolerance = 0, byte rgbTolerance = 0)
			{
				return Concrete.VerifyImageMatch(expectedImage, pixelTolerance, rgbTolerance);
			}
	
			public bool VerifyImageMatch(System.Drawing.Image expectedImage, HP.LFT.SDK.Utils.ImageMaskArea maskArea, byte pixelTolerance = 0, byte rgbTolerance = 0)
			{
				return Concrete.VerifyImageMatch(expectedImage, maskArea, pixelTolerance, rgbTolerance);
			}
	
			public TChild Describe<TChild>(HP.LFT.SDK.IDescription description)  where TChild:class, HP.LFT.SDK.ITestObject
			{
				return Concrete.Describe<TChild>(description);
			}
	
			public void Click(HP.LFT.SDK.MouseButton button = HP.LFT.SDK.MouseButton.Left)
			{
				 Concrete.Click(button);
			}
	
			public void Click(HP.LFT.SDK.ClickArgs args)
			{
				 Concrete.Click(args);
			}
	
			public string GetAttribute(string attributeName)
			{
				return Concrete.GetAttribute(attributeName);
			}
	
			public string GetComputedStyle(string styleProperty)
			{
				return Concrete.GetComputedStyle(styleProperty);
			}
	
			public TChild Describe<TChild>(HP.LFT.SDK.Web.XPathDescription xpath)  where TChild:class, HP.LFT.SDK.Web.IWebElement
			{
				return Concrete.Describe<TChild>(xpath);
			}
	
			public TChild Describe<TChild>(HP.LFT.SDK.Web.CSSDescription cssSelector)  where TChild:class, HP.LFT.SDK.Web.IWebElement
			{
				return Concrete.Describe<TChild>(cssSelector);
			}
	
			public void DragAndDropOn(HP.LFT.SDK.ISupportDragAndDrop dropTarget)
			{
				 Concrete.DragAndDropOn(dropTarget);
			}
	
			public void DragAndDropOn(HP.LFT.SDK.ISupportDragAndDrop dropTarget, HP.LFT.SDK.DragAndDropArgs dragAndDropArgs)
			{
				 Concrete.DragAndDropOn(dropTarget, dragAndDropArgs);
			}
	
			#endregion
	
			#region Public Properties
	
			public string ButtonType
			{
				get { return Concrete.ButtonType; }		
			}
	
			public bool IsEnabled
			{
				get { return Concrete.IsEnabled; }		
			}
	
			public string Text
			{
				get { return Concrete.Text; }		
			}
	
			public string XPath
			{
				get { return Concrete.XPath; }		
			}
	
			public string AccessibilityName
			{
				get { return Concrete.AccessibilityName; }		
			}
	
			public string CSSSelector
			{
				get { return Concrete.CSSSelector; }		
			}
	
			public string Role
			{
				get { return Concrete.Role; }		
			}
	
			public string DisplayName
			{
				get { return Concrete.DisplayName; }		
				set { Concrete.DisplayName = value; }
			}
	
			public string ClassName
			{
				get { return Concrete.ClassName; }		
			}
	
			public string Id
			{
				get { return Concrete.Id; }		
			}
	
			public string TagName
			{
				get { return Concrete.TagName; }		
			}
	
			public string InnerHTML
			{
				get { return Concrete.InnerHTML; }		
			}
	
			public string OuterHTML
			{
				get { return Concrete.OuterHTML; }		
			}
	
			public string InnerText
			{
				get { return Concrete.InnerText; }		
			}
	
			public string OuterText
			{
				get { return Concrete.OuterText; }		
			}
	
			public string Name
			{
				get { return Concrete.Name; }		
			}
	
			public string Title
			{
				get { return Concrete.Title; }		
			}
	
			public bool IsVisible
			{
				get { return Concrete.IsVisible; }		
			}
	
			public System.Collections.Generic.IReadOnlyDictionary<string, string> Attributes
			{
				get { return Concrete.Attributes; }		
			}
	
			public System.Collections.Generic.IReadOnlyDictionary<string, string> Styles
			{
				get { return Concrete.Styles; }		
			}
	
			public System.Drawing.Point Location
			{
				get { return Concrete.Location; }		
			}
	
			public System.Drawing.Point AbsoluteLocation
			{
				get { return Concrete.AbsoluteLocation; }		
			}
	
			public System.Drawing.Size Size
			{
				get { return Concrete.Size; }		
			}
	
			public dynamic NativeObject
			{
				get { return Concrete.NativeObject; }		
			}
	
			#endregion
		}

		#endregion
	}
}
