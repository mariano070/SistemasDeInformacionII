function Fisheye()
{
	this.FisheyeData;
	this.Width;
	this.Height;
	this.MaxWidth;
	this.MaxHeight;
	this.Orientation;
	this.EffectUnits;
	this.ItemPadding;
	this.AttachEdge;
	this.LabelEdge;
	this.SelectedImageId;
	this.ConservativeTrigger;

	// Databinding for property FisheyeData
	this.SetFisheyeData = function(data)
	{
		///UserCodeRegionStart:[SetFisheyeData] (do not remove this comment.)
		this.FisheyeData = data;
		
		
		///UserCodeRegionEnd: (do not remove this comment.)
	}

	// Databinding for property FisheyeData
	this.GetFisheyeData = function()
	{
		///UserCodeRegionStart:[GetFisheyeData] (do not remove this comment.)
		return this.FisheyeData;
		
		
		///UserCodeRegionEnd: (do not remove this comment.)
	}

	this.show = function()
	{
		///UserCodeRegionStart:[show] (do not remove this comment.)
		// Variables
		var buffer = '';
		var dojoStartupTag = '';
		var dojoItemTag = '';
		var dojoItemTags = '';
		var dojoEndTag = '</div>';
		var imgsDir = gx.staticDirectory;
		var basePath = gx.basePath;
		var startupPath = basePath + imgsDir;
		var loadingAni = '';
		var title = '';
		outerMe = this.me();
		// Startup tag
		dojoStartupTag += '<div class="dojo-FisheyeList" ';
		dojoStartupTag += 'itemWidth="' + this.Width  + '" ';
		dojoStartupTag += 'itemHeight="' + this.Height  + '" ';
		dojoStartupTag += 'itemMaxWidth="' + this.MaxWidth  + '" ';
		dojoStartupTag += 'itemMaxHeight="' + this.MaxHeight  + '" ';
		dojoStartupTag += 'orientation="' + this.Orientation  + '" ';
		dojoStartupTag += 'effectUnits="' + this.EffectUnits  + '" ';
		dojoStartupTag += 'itemPadding="' + this.ItemPadding  + '" ';
		dojoStartupTag += 'attachEdge="' + this.AttachEdge  + '" ';
		dojoStartupTag += 'labelEdge="' + this.LabelEdge  + '" ';
		dojoStartupTag += 'conservativeTrigger="' + this.ConservativeTrigger  + '" ';
		dojoStartupTag += '>';			
		// Loop for Images, Create FisheyeListItem's
		for(var i=0;this.FisheyeData[i]!=undefined;i++)
		{
			loadingAni = this.FisheyeData[i].Image;
			title = this.FisheyeData[i].Description;
			// Item Tag
			dojoItemTag = '<div class="dojo-FisheyeListItem" ';
			dojoItemTag += 'id="' + i + '" ';			
			dojoItemTag += 'onclick="' + outerMe + '.nodeClicked(' + i + ');"';
			dojoItemTag += 'caption="' + title + '" ';
			dojoItemTag += 'iconSrc="' + loadingAni + '" ';
			dojoItemTag += '>';
			dojoItemTag += dojoEndTag;
			dojoItemTags += dojoItemTag; // Add FisheyeItem to the List
		}
		// Set Div Tag
		buffer = dojoStartupTag + dojoItemTags + dojoEndTag;
		this.setHtml(buffer);
		// Update Dojo Widget
		dojo.hostenv.makeWidgets();
		
		///UserCodeRegionEnd: (do not remove this comment.)
	}
	///UserCodeRegionStart:[User Functions] (do not remove this comment.)

	this.nodeClicked = function(javascriptindex)
	{
		var sdtindex = 0;
		sdtindex = javascriptindex + 1; // (0:n-1) JavascriptIndex to (1:n) SDTIndex 
		this.SelectedImageId = sdtindex; // Set parameters, Selected Image Index
		this.OnClick(); // Trigger 'OnClick' User Control Event
	}
	
	///UserCodeRegionEnd: (do not remove this comment.):
}
