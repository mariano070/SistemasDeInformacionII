gx.evt.autoSkip=false;function hseg000r(){this.ServerClass="HSEG000R";this.PackageName="GeneXus.Programs";this.setObjectType("web");this.hasEnterEvent=false;this.SetStandaloneVars=function(){this.AV6SISTEMA=gx.fn.getControlValue("vSISTEMA");this.AV5USUARIO=gx.fn.getControlValue("vUSUARIO")};this.e134y2_client=function(){this.clearMessages();this.AV14WINDOW.Url=gx.http.formatLink("aseg017.aspx",[]);this.AV14WINDOW.Height=500;this.AV14WINDOW.Width=700;gx.popup.open(this.AV14WINDOW);this.refreshOutputs([{ctrl:"vWINDOW",prop:"Width"},{ctrl:"vWINDOW",prop:"Height"},{ctrl:"vWINDOW",prop:"Object"}])
};this.e144y2_client=function(){this.clearMessages();this.AV14WINDOW.Url=gx.http.formatLink("aseg018.aspx",[" "]);this.AV14WINDOW.ReturnParms=[""];this.AV14WINDOW.Height=500;this.AV14WINDOW.Width=700;gx.popup.open(this.AV14WINDOW);this.refreshOutputs([{ctrl:"vWINDOW",prop:"Width"},{ctrl:"vWINDOW",prop:"Height"},{ctrl:"vWINDOW",prop:"Object"}])};this.e154y2_client=function(){this.clearMessages();this.AV14WINDOW.Url=gx.http.formatLink("aseg018.aspx",["A"]);this.AV14WINDOW.ReturnParms=[""];this.AV14WINDOW.Height=500;
this.AV14WINDOW.Width=700;gx.popup.open(this.AV14WINDOW);this.refreshOutputs([{ctrl:"vWINDOW",prop:"Width"},{ctrl:"vWINDOW",prop:"Height"},{ctrl:"vWINDOW",prop:"Object"}])};this.e164y2_client=function(){this.executeServerEvent("ENTER",true)};this.e174y2_client=function(){this.executeServerEvent("CANCEL",true)};this.GXValidFnc=[];this.GXCtrlIds=[3,24,27,30,33];this.GXLastCtrlId=33;this.GXValidFnc[3]={fld:"TABLE1",grid:0};this.GXValidFnc[24]={fld:"TABLE2",grid:0};this.GXValidFnc[27]={lvl:0,type:"int",len:8,dec:0,sign:false,pic:"ZZZZZZZ9",ro:1,grid:0,gxgrid:null,fnc:null,isvalid:null,rgrid:[],fld:"vID_SESION",gxz:"ZV9ID_SESION",gxold:"OV9ID_SESION",gxvar:"AV9ID_SESION",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",v2v:function(a){gx.O.AV9ID_SESION=gx.num.intval(a)
},v2z:function(a){gx.O.ZV9ID_SESION=gx.num.intval(a)},v2c:function(){gx.fn.setControlValue("vID_SESION",gx.O.AV9ID_SESION,0)},c2v:function(){gx.O.AV9ID_SESION=this.val()},val:function(){return gx.fn.getIntegerValue("vID_SESION",".")},nac:function(){return false}};this.GXValidFnc[30]={lvl:0,type:"char",len:30,dec:0,sign:false,ro:0,grid:0,gxgrid:null,fnc:null,isvalid:null,fld:"vNOM_COOKIE",gxz:"ZV11NOM_COOKIE",gxold:"OV11NOM_COOKIE",gxvar:"AV11NOM_COOKIE",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",v2v:function(a){gx.O.AV11NOM_COOKIE=a
},v2z:function(a){gx.O.ZV11NOM_COOKIE=a},v2c:function(){gx.fn.setControlValue("vNOM_COOKIE",gx.O.AV11NOM_COOKIE,0)},c2v:function(){gx.O.AV11NOM_COOKIE=this.val()},val:function(){return gx.fn.getControlValue("vNOM_COOKIE")},nac:function(){return false}};this.GXValidFnc[33]={lvl:0,type:"int",len:8,dec:0,sign:false,pic:"ZZZZZZZ9",ro:0,grid:0,gxgrid:null,fnc:null,isvalid:null,rgrid:[],fld:"vID_SESIONCK",gxz:"ZV13ID_SESIONCK",gxold:"OV13ID_SESIONCK",gxvar:"AV13ID_SESIONCK",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",v2v:function(a){gx.O.AV13ID_SESIONCK=gx.num.intval(a)
},v2z:function(a){gx.O.ZV13ID_SESIONCK=gx.num.intval(a)},v2c:function(){gx.fn.setControlValue("vID_SESIONCK",gx.O.AV13ID_SESIONCK,0)},c2v:function(){gx.O.AV13ID_SESIONCK=this.val()},val:function(){return gx.fn.getIntegerValue("vID_SESIONCK",".")},nac:function(){return false}};this.AV9ID_SESION=0;this.ZV9ID_SESION=0;this.OV9ID_SESION=0;this.AV11NOM_COOKIE="";this.ZV11NOM_COOKIE="";this.OV11NOM_COOKIE="";this.AV13ID_SESIONCK=0;this.ZV13ID_SESIONCK=0;this.OV13ID_SESIONCK=0;this.AV6SISTEMA="";this.AV5USUARIO="";
this.AV14WINDOW={};this.ServerEvents=["e164y2_client","e174y2_client"];this.VarControlMap.AV6SISTEMA={id:"vSISTEMA",grid:0,type:"char"};this.VarControlMap.AV5USUARIO={id:"vUSUARIO",grid:0,type:"char"};this.SetStandaloneVars()}hseg000r.prototype=new gx.GxObject;gx.setParentObj(new hseg000r());