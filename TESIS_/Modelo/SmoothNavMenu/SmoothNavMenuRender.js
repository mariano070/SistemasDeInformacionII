function SmoothNavMenu()
{
	this.MenuData;
	this.SelectedItem;
	this.Width;
	this.Height;
	this.Orientation;
	this.NormalBackground;
	this.HoverBackground;
	// Databinding for property MenuData
	this.SetMenuData = function(data)
	{
		///UserCodeRegionStart:[SetMenuData] (do not remove this comment.)
		this.MenuData = data;
		///UserCodeRegionEnd: (do not remove this comment.)
	}
	// Databinding for property MenuData
	this.GetMenuData = function()
	{
		///UserCodeRegionStart:[GetMenuData] (do not remove this comment.)
		return this.MenuData;		
		///UserCodeRegionEnd: (do not remove this comment.)
	}
	// Databinding for property SelectedItem
	this.SetSelectedItem = function(data)
	{
		///UserCodeRegionStart:[SetSelectedItem] (do not remove this comment.)
		this.SelectedItem = data;
		///UserCodeRegionEnd: (do not remove this comment.)
	}
	// Databinding for property SelectedItem
	this.GetSelectedItem = function()
	{
		///UserCodeRegionStart:[GetSelectedItem] (do not remove this comment.)
		return this.SelectedItem;
		///UserCodeRegionEnd: (do not remove this comment.)
	}
	this.show = function()
	{
		///UserCodeRegionStart:[show] (do not remove this comment.)
		if (!this.IsPostBack)
		{
			var buffer = new gx.text.stringBuffer();
			buffer.clear();
			
			var _class = this.Orientation=="h"?_class="ddsmoothmenu":_class="ddsmoothmenu-v";
			buffer.append('<div id="' + this.ControlName + '" class="' + _class + '">');
			buffer.append('<ul>');
			var markup = this.loadSmoothMenuData(this.MenuData);
			buffer.append(markup);
			buffer.append('</ul>');
			buffer.append('</div>');
			this.setHtml(buffer.toString());
			this.initSmoothNavMenu();
		}
		///UserCodeRegionEnd: (do not remove this comment.)
	}
	///UserCodeRegionStart:[User Functions] (do not remove this comment.)
	this.tmpbuffer = new gx.text.stringBuffer();
	this.tmpbuffer.clear();
	this.loadSmoothMenuData = function(data) {
	    var i = 0;
	    for (i = 0; data[i] != undefined; i++) {
	        if (data[i].Items != undefined && data[i].Items.toString() != "") {
	            this.tmpbuffer.append('<li>');
	            data[i].LinkTarget != undefined ? data[i].LinkTarget : "_self";
	            this.tmpbuffer.append('<a href="' + data[i].Link + '" target="' + data[i].LinkTarget + '" onclick="' + this.me() + '.SmoothNavMenuOnClick(\'' + data[i].Id + '\',\'' + data[i].Title + '\',\'' + data[i].Description + '\',\'' + data[i].Link + '\');" >' + data[i].Title + '</a>');
	            this.tmpbuffer.append('<ul>');
	            this.loadSmoothMenuData(data[i].Items);
	            this.tmpbuffer.append('</ul>');
	            this.tmpbuffer.append('</li>');
	        } else {
	            this.tmpbuffer.append('<li>');
	            data[i].LinkTarget != undefined || data[i].LinkTarget == "" ? data[i].LinkTarget : "_self";
	            this.tmpbuffer.append('<a href="' + data[i].Link + '" target="' + data[i].LinkTarget + '" onclick="' + this.me() + '.SmoothNavMenuOnClick(\'' + data[i].Id + '\',\'' + data[i].Title + '\',\'' + data[i].Description + '\',\'' + data[i].Link + '\');" >' + data[i].Title + '</a>');
	            this.tmpbuffer.append('</li>');
	        }
	    }
	    return this.tmpbuffer;
	}
	this.SmoothNavMenuOnClick = function(id, title, description, link) {
		if (typeof(this.OnClick) == 'function') {
			this.SelectedItem.Id = id;
			this.SelectedItem.Title = title;
			this.SelectedItem.Description = description;
			this.SelectedItem.Link = link;
			this.OnClick();
		}
	}
	this.initSmoothNavMenu = function(){
		var ctheme = new Array(this.NormalBackground.Html, this.HoverBackground.Html);
		var options = {mainmenuid:this.ControlName, orientation:this.Orientation,classname:this.Orientation=="h"?"ddsmoothmenu":"ddsmoothmenu-v",customtheme:ctheme,contentsource: "markup"};
		ddsmoothmenu.init(options);
	}
	///UserCodeRegionEnd: (do not remove this comment.):
}