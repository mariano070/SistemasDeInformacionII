gx.util.balloon={balloons:[],timerOn:false,impl:function(){this.init=function(a){this.hide();this.id=a;this.balloonid=a+"_Balloon";this.hasMessage=false;this.messageErr="";this.messageWar="";this.isError=false};this.setMessage=function(a){this.messageWar+=a+"<BR>";this.hasMessage=true};this.setError=function(a){this.messageErr+=a+"<BR>";this.isError=true;this.hasMessage=true};this.show=function(){if(document.readyState!=undefined&&document.readyState!="complete"){return}try{if(this.hasMessage==false){return true}var g=gx.dom.el(this.balloonid);var a=gx.dom.el(this.id);if((a==null)&&(gx.csv.validatingUC!=null)){a=gx.csv.validatingUC.getContainerControl()}if(a.type=="hidden"){var b=gx.dom.el("span_"+this.id);if(b!=null){a=b}}if(g==null){g=document.createElement("SPAN");BalloonControlShadow=document.createElement("SPAN");BalloonControlShadow2=document.createElement("SPAN");IFrameControl=document.createElement("IFRAME");g.id=this.balloonid;BalloonControlShadow.id=this.balloonid+"Shadow";BalloonControlShadow2.id=this.balloonid+"Shadow2";IFrameControl.id=this.balloonid+"GXiFrameIEHack";IFrameControl.src="javascript:undefined";IFrameControl.style.zIndex=1;IFrameControl.style.visibility="hidden";IFrameControl.style.position="absolute";IFrameControl.frameBorder="0";document.body.appendChild(g);document.body.appendChild(BalloonControlShadow);document.body.appendChild(BalloonControlShadow2);document.body.appendChild(IFrameControl)}var d=gx.dom.position(a);if(d.x==0&&d.y==0&&a.parentNode){d=gx.dom.position(a.parentNode)}var c=parseInt(d.x);var h=parseInt(d.y);if(c<=0){c=10}if(h<=0){h=20}var f="<span style='white-space:nowrap;position: absolute; top:"+h+"px; left:"+c+"px;z-index:1003' >";if(this.messageErr.length>0){f+="<div class='ErrorMessages'>";f+=this.messageErr;f+="</div><span style='height:4px;overflow:hidden'></span>"}if(this.messageWar.length>0){f+="<div class='WarningMessages'>";f+=this.messageWar;f+="</div>"}f+="</span>";g.innerHTML=f;var e=2;h-=g.lastChild.offsetHeight-e;f="<span style='white-space:nowrap;position: absolute; top:"+h+"px; left:"+c+"px;z-index:1003' >";if(this.messageErr.length>0){f+="<div class='ErrorMessages'>";f+=this.messageErr;f+="</div><span style='height:4px;overflow:hidden'></span>"}if(this.messageWar.length>0){f+="<div class='WarningMessages'>";f+=this.messageWar;f+="</div>"}f+="</span>";g.innerHTML=f;IFrameControl.style.visibility="visible";IFrameControl.style.height=g.firstChild.firstChild.offsetHeight;IFrameControl.style.width=g.lastChild.offsetWidth;IFrameControl.style.top=h;IFrameControl.style.left=c;h+=e;c+=e;if(this.messageErr.length>0){f="<span style='position: absolute;border-style:none;";f+="top:"+h+"px; left:"+c+"px;";f+="width:"+g.lastChild.offsetWidth+"px; height:"+g.firstChild.firstChild.offsetHeight+"px;";f+="z-index:1002;background-color:ThreeDDarkShadow;' class='ErrorMessages'></span>";BalloonControlShadow.innerHTML=f;h+=g.firstChild.firstChild.offsetHeight+4}if(this.messageWar.length>0){f="<span style='position: absolute;border-style:none;";
f+="top:"+h+"px; left:"+c+"px;";f+="width:"+g.lastChild.offsetWidth+"px; height:"+g.firstChild.lastChild.offsetHeight+"px;";f+="z-index:1002;background-color:ThreeDDarkShadow;' class='ErrorMessages'></span>";BalloonControlShadow2.innerHTML=f}if(gx.util.balloon.timerOn==false){gx.util.balloon.timerOn=true;this.timerId=setTimeout(function(){gx.util.balloon.hideOnTime()},4000)}}catch(i){gx.dbg.logEx(i,"gxballoon.js","show")}return !this.isError};this.hide=function(){try{ctrl=gx.dom.byId(this.balloonid+"Shadow");if(ctrl!=null){gx.dom.removeControl(ctrl)}ctrl=gx.dom.byId(this.balloonid+"Shadow2");if(ctrl!=null){gx.dom.removeControl(ctrl)}ctrl=gx.dom.byId(this.balloonid);if(ctrl!=null){gx.dom.removeControl(ctrl)}ctrl=gx.dom.byId(this.balloonid+"GXiFrameIEHack");if(ctrl!=null){gx.dom.removeControl(ctrl)}}catch(a){gx.dbg.logEx(a,"gxballoon.js","hide")}}},hideOnTime:function(){this.timerOn=false;while(DelBalloon=this.balloons.pop()){DelBalloon.hide()}},getNew:function(c,d){if(typeof(d)!="undefined"){c=c+"_"+d}try{c=gx.csv.ctxControlId(gx.fn.screen_CtrlRef(c).id)}catch(f){gx.dbg.logEx(f,"gxballoon.js","getNew")}var a=new this.impl();this.balloons.push(a);a.init(c);return a}};gx.ajax={reqHeader:"GxAjaxRequest",resourceProvider:"",dfTimer:null,securityLevels:{low:0,medium:1,high:2},maxGETLength:function(a){return(a.AjaxSecurity>=gx.ajax.securityLevels.medium)?600:1350},getImageUrl:function(a){try{if(!gx.lang.emptyObject(this.resourceProvider)){var b=gx.ajax.objectUrl(this.resourceProvider)+"?image,"+encodeURIComponent(a)+",,"+encodeURIComponent(gx.theme);gx.http.callBackend("",b,")",true,gx.http.modes.none,true,"GET",null,true);return gx.util.resourceUrl(gx.basePath+gx.staticDirectory+gx.http.lastResponse,true)}}catch(c){gx.dbg.logEx(c,"gxcallrpc.js","getImageUrl")}return a},encryptParms:function(b,a){return((b.AjaxSecurity>=gx.ajax.securityLevels.medium)?gx.sec.encrypt(a):a)},doPost:function(a,c){if(gx.evt.processing&&!gx.csv.validating){return}gx.evt.setProcessing(true);gx.ajax.disableForm();gx.fx.obs.notify("gx.onbeforeevent",[a,c]);gx.fn.objectOnpost();gx.http.saveState();gx.fn.forceEnableControls(false);var b=this.getPostInfo(a,c);gx.http.doCall(b)},getPostInfo:function(a,e){var d=gx.ajax.selfUrl();var c=/\?(.*)/;if(c.test(d)){d=d.replace(c,"?"+a+",$1")}else{d+="?"+a}var b={};b.url=d;b.formNode=gx.dom.form();b.method="POST";b.encoding="UTF-8";b.useCash=false;if(e==true){b.sync=true}b.handler=gx.http.postHandler;this.multipartInfo(b);return b},multipartInfo:function(c){var e=false;var b=c.formNode.getElementsByTagName("input");var a=b.length;if(!a){return}for(var d=0;d<a;d++){if(b[d].getAttribute("type")=="file"){e=true;break}}if(e){c.multipart=true;c.mimetype="text/html";c.formNode.encoding="multipart/form-data"}},dispatchCommands:function(h){if(h&&h.length>0){var e=h.length;for(var d=0;d<e;d++){var a=h[d];if(a.redirect!=undefined){a.redirect=gx.ajax.removeGXParms(a.redirect)}if(a.print){gx.printing.print(a.print)}if(a.close){var b=[];if(a.close instanceof Array){b=a.close
}gx.fn.closeWindow(b)}if(typeof(a.refresh)!="undefined"){if(a.refresh=="GET"){gx.http.reload()}else{var f="RFR";if(gx.O.IsMasterPage){f=f+"_MPAGE"}gx.O.executeServerEvent(f,true)}}if(a.redirect){gx.http.redirect(a.redirect)}if(a.popup){if(h.length>d+1){a.popup[7]=h.slice(d+1)}gx.popup.open(a.popup);break}if(a.ucmethod){var c=gx.getObj(a.ucmethod.CmpContext,a.ucmethod.IsMasterPage);if(c){var g=gx.O;gx.setGxO(c.CmpContext,c.IsMasterPage);var j=gx.O.getUserControl(a.ucmethod.Control);if(j){if(typeof(j[a.ucmethod.Method])=="function"){j[a.ucmethod.Method].apply(j,a.ucmethod.Parms)}}gx.setGxO(g.CmpContext,g.IsMasterPage)}}}}},willLeavePage:function(b){if(b){var a=b.length;for(var c=0;c<a;c++){var d=b[c];if(d.close){return true}}}return false},hasRedirectCommand:function(b){if(b){var a=b.length;for(var c=0;c<a;c++){var d=b[c];if(d.redirect){return true}}}return false},setPostResponse:function(a){var b=gx.fn;var c=gx.lang.doCall;if(this.hasRedirectCommand(a.gxCommands)){c(gx.ajax.dispatchCommands,a.gxCommands);setTimeout(function(){gx.ajax.enableForm()},200)}else{if(this.willLeavePage(a.gxCommands)){gx.evt.setProcessing(true);c(gx.ajax.dispatchCommands,a.gxCommands);setTimeout(function(){gx.evt.setProcessing(false);gx.ajax.enableForm()},200)}else{c(b.setPostHiddens,a.gxHiddens);c(b.setPostComponents,a.gxComponents,a.DynComponentMap,a.gxHiddens,function(){gx.http.loadStyles();c(b.setPostValues,a.gxValues);c(b.setPostProperties,a.gxProps);c(b.setErrorViewer,a.gxMessages);b.enableDisableDelete();c(b.loadPostGrids,a.gxGrids);b.objectPostback();b.setFocusAfterLoad();gx.ajax.enableForm();gx.dom.indexElements();c(gx.ajax.dispatchCommands,a.gxCommands)})}}},disableForm:function(){if(this.dfTimer){clearTimeout(this.dfTimer)}this.dfTimer=setTimeout(gx.http.notification.show,200)},enableForm:function(){if(this.dfTimer){clearTimeout(this.dfTimer)}gx.http.notification.hide()},executeCliEvent:function(f,d){try{var c=undefined;var b=gx.lang.emptyObject;if(!b(d)){var a=gx.fn.rowGridId(d);if(!b(a)){var h=gx.fn.getGridObj(a);if(!b(h)){c=gx.fn.controlRowId(d)||gx.fn.currentGridRowImpl(a)||"0001";h.instanciateRow(c)}}}gx.O[f].call(gx.O,c)}catch(g){gx.dbg.logEx(g,"gxcallrpc.js","executeCliEvent")}},suggest:function(a,b,f,g,i,h){var d=b;var c=new gx.fx.suggestProvider(a,b,f);var e=new gx.fx.autoSuggestControl(gx.fn.screen_CtrlRef(b),c,d,g,i,h)},hideCode:function(InputParms,ControlId,ControlRefresh){var backcall="gx.fn.setVarValues("+gx.lang.arrayToSource(ControlRefresh)+",";var sURL=this.objectUrl()+"?";var sParms="gxajaxHideCode_"+ControlId;var len=InputParms.length;for(var i=0;i<len;i++){sParms+=","+encodeURIComponent(eval(InputParms[i]))}sURL+=gx.ajax.encryptParms(gx.O,sParms);gx.http.callBackend(backcall,sURL,")",true,gx.http.modes.retval);return this.lastStatus},callCrl:function(b,c,f){var h=f?"gx.fn.setGridComboValues":"gx.fn.setComboValues";var a=f?c:gx.fn.screen_CtrlRef(c).name;var d=h+"('"+a+"',";var e=this.objectUrl()+"?";var g="gxajaxCallCrl_"+c+",";g+=this.arrayToUrl(b);
e+=gx.ajax.encryptParms(gx.O,g);gx.http.callBackend(d,e,")",true,gx.http.modes.retval)},refreshGrid:function(h,c){var m="";var j=this.objectUrl()+"?";var k="gxajaxGridRefresh_"+h.gridName+","+c;if(k.length>gx.ajax.maxGETLength(gx.O)){var a=["GXEvent="+gx.ajax.encryptParms(gx.O,"gxajaxGridRefresh_"+h.gridName)];var d=c.split(",");for(var f=0,g=d.length;f<g;f++){a.push("GXParm"+f+"="+d[f])}gx.http.callBackend(m,j,")",false,gx.http.modes.none,false,"POST",a.join("&"))}else{var e=gx.ajax.encryptParms(gx.O,k);gx.http.callBackend(m,j+e,")",false,gx.http.modes.none)}var b=gx.http.lastResponse;if((b!=undefined)&&(b!="")){var l=gx.json.evalJSON(b);h.loadAfterRefresh(l);h.updatePropsHidden(b)}},newRows:function(j,l,a,f,g,m,e,p){var o="gx.fn.gridObj('"+j+"','"+a+"',"+l.toString()+"').setNewRows(";var h=this.objectUrl()+"?";var n="gxajaxNewRow_"+a+","+f+","+g+","+m;var a=(e!="")?(a+"_"+e):a;var b=gx.fn.gridObj(j,a,l);for(var d=0;d<b.postingVariables.length;d++){n+=","+encodeURIComponent(b.parentObject[b.postingVariables[d]])}if(gx.O.IsComponent){n+=","+gx.O.CmpContext}h+=gx.ajax.encryptParms(gx.O,n);gx.http.callBackend(o,h,")",true,gx.http.modes.none);var c=gx.http.lastResponse;if(c){var k=gx.json.evalJSON(c);p.call(b,k)}},loadCrl:function(d,b,a){if(gx.fn.getControlValue("IsConfirmed")=="1"){this.lastStatus=0;return}var c="gx.fn.setVarValues("+gx.lang.arrayToSource(a)+",";var e=this.objectUrl()+"?";var f="gxajaxExecAct_"+d+",";f+=this.arrayToUrl(b);e+=gx.ajax.encryptParms(gx.O,f);gx.http.callBackend(c,e,")",true,gx.http.modes.retval)},udp:function(c,a,e){var b="gx.fn.setVarValues("+gx.lang.arrayToSource(e)+",";var d=this.objectUrl()+"?";var f=c+",";f+=this.arrayToUrl(a);d+=gx.ajax.encryptParms(gx.O,f);gx.http.callBackend(b,d,")",true,gx.http.modes.retval)},srvEvt:function(c,d,a,f){var b="gx.fn.setVarValues("+gx.lang.arrayToSource(f)+",";var e=this.objectUrl()+"?";var g=c+","+d+",";g+=this.arrayToUrl(a);e+=gx.ajax.encryptParms(gx.O,g);gx.http.callBackend(b,e,")",true,gx.http.modes.full)},validSrvEvt:function(c,d,a,f){var b="gx.csv.setValidValues("+gx.lang.arrayToSource(f)+",";var e=this.objectUrl();var g=c+","+d+","+this.arrayToUrl(a,true);if(g.length>this.maxGETLength(gx.O)){this.validAsPost(e,b,c,d,a)}else{e+="?"+gx.ajax.encryptParms(gx.O,g);gx.http.callBackend(b,e,")",true,gx.http.modes.call)}},validAsPost:function(f,d,c,e,a){var b="GXEvent="+gx.ajax.encryptParms(gx.O,c)+"&GXAction="+e;if(a.length>0){b+="&"+this.getParmsPostData(a)}gx.http.callBackend(d,f,")",true,gx.http.modes.call,false,"POST",b)},getParmsPostData:function(a){var c="";for(var b=0;b<a.length;b++){if(b>0){c+="&"}c+="GXParm"+b+"="+this.parmToUrl(a[b],true)}return c},pushReferer:function(c){var a=this.objectUrl()+"?";var b="dyncall,PushReferer,"+encodeURIComponent(location.href);a+=gx.ajax.encryptParms(gx.O,b);gx.http.callBackend("",a,"",true,gx.http.modes.none,true)},windowClosed:function(d){var a="";if(d==-1){a=",PopReferer"}else{a=",DeleteReferer,"+d.toString()}var b=this.objectUrl()+"?";var c="dyncall"+a;
b+=gx.ajax.encryptParms(gx.O,c);gx.http.callBackend("",b,"",true,gx.http.modes.none,true)},aggSel:function(d,f,a){var c=this.objectUrl()+"?";var e="gxajaxAggSel"+f+"_"+d+",";e+=this.arrayToUrl(a);c+=gx.ajax.encryptParms(gx.O,e);var b=gx.http.callBackend(null,c,"",false,gx.http.modes.retval);return b[0]},aggSelDecimal:function(d,e,c,b,a){return gx.num.parseFloat(this.aggSel(d,e,a),c,b)},aggSelInteger:function(b,c,a){return parseInt(this.aggSel(b,c,a),10)},dynComponent:function(d,f,h,a){d=d.toLowerCase();var b=d;if(gx.gen.isDotNet()){b+=".aspx"}var g=gx.ajax.objectUrl(b)+"?";var j="dyncomponent,"+encodeURIComponent(h)+","+encodeURIComponent(a);var e=f.length;for(var c=0;c<e;c++){j+=","+encodeURIComponent(f[c])}g+=gx.ajax.encryptParms(gx.O,j);gx.http.callBackend("",g,")",true,gx.http.modes.none,true);return gx.json.evalJSON(gx.http.lastResponse)},selfUrl:function(){return location.href.replace(/#[\s\S]*$/,"")},removeGXParms:function(a){return a.replace(/\?gxajaxEvt,?|\?gxportlet,?/,"?")},arrayToUrl:function(c,b){var e="";var a=c.length;for(var d=0;d<a;d++){e+=this.parmToUrl(c[d],b)+","}return e},parmToUrl:function(Parm,serializeControls){var value=eval(Parm);if(value instanceof Array&&value.length==2&&typeof(value[0])=="string"&&typeof(value[1])=="string"){var validStruct=gx.fn.vStructForVar(value[0]);if(validStruct!=null){value=gx.fn.getGridCtrlProperty(validStruct.grid,validStruct.fld,value[1])}}if(serializeControls){var vStruct=gx.fn.vStructForVar(gx.unprefixVar(Parm));if(vStruct!=null){if(gx.html.controls.isMultiSelection(vStruct.ctrltype)){var ctrl=gx.fn.getControlGridRef(vStruct.fld,vStruct.grid);if(ctrl){var ctrlJSON=gx.dom.comboBoxToObj(ctrl,value);if(ctrlJSON){value=ctrlJSON}}}}}if(typeof(value)=="object"){value=gx.json.serializeJson(value)}if(typeof(value)=="undefined"||value==null){var setted=false;if(Parm){var gxoIdx=Parm.indexOf("gx.O.");if(gxoIdx==0){Parm=gx.unprefixVar(Parm);var hidVal=gx.fn.getHidden(gx.O.CmpContext+Parm);if(hidVal!=null&&typeof(hidVal)!="undefined"){value=hidVal;setted=true}}}if(!setted){value=""}}return encodeURIComponent(value)},objectUrl:function(a){var c=location.pathname;var b="";if(a!=undefined){b=a}else{if(gx.csv.cmpCtx!=""){b=gx.fn.getControlValue(gx.csv.cmpCtx+"_CMPPGM")}else{b=gx.ajax.selfUrl()}if(b!=null){b=b.replace(/\?.*/,"");b=b.replace(/#[\s\S]*$/,"")}b=this.objnameFromUrl(b)}return this.absoluteurl(this.objToRelativeUrl(b))},objToRelativeUrl:function(c){var e=location.pathname;if(c!=null){var d=location.pathname.split("/");e="";var a=d.length;for(var b=1;b<a-1;b++){e+="/"+d[b]}e+="/"+c}return e},isabsoluteurl:function(a){return(a.search("://")!=-1)},absoluteurl:function(a){if(!this.isabsoluteurl(a)){if(a.charAt(0)!="/"){var d="";var c=location.pathname.split("/");for(var b=1;b<c.length-1;b++){d+="/"+c[b]}return location.protocol+"//"+location.host+d+"/"+a}else{return location.protocol+"//"+location.host+a}}return a},objnameFromUrl:function(b){if(b.indexOf("?")>=0){b=b.split("?")[0]}var c=b.split("/");
var a=c.length;if(a==0){return b}return c[a-1]},_init:function(){this.resourceProvider=gx.fn.getHidden("GX_RES_PROVIDER")}};gx._init();