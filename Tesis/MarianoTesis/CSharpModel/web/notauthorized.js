gx.evt.autoSkip=false;function notauthorized(){this.ServerClass="NotAuthorized";this.PackageName="GeneXus.Programs";this.setObjectType("web");this.hasEnterEvent=false;this.autoRefresh=true;this.SetStandaloneVars=function(){this.GxObject=gx.fn.getControlValue("vGXOBJECT")};this.e13042_client=function(){this.executeServerEvent("ENTER",true)};this.e14042_client=function(){this.executeServerEvent("CANCEL",true)};this.GXValidFnc=[];this.GXCtrlIds=[4,13,18,23,24,27];this.GXLastCtrlId=27;this.GXValidFnc[4]={fld:"TABLE2",grid:0};
this.GXValidFnc[7]={fld:"TITLETEXT",format:0,grid:0};this.GXValidFnc[13]={fld:"TABLE1",grid:0};this.GXValidFnc[16]={fld:"TEXTBLOCK1",format:0,grid:0};this.GXValidFnc[18]={lvl:0,type:"char",len:16,dec:0,sign:false,ro:0,grid:0,gxgrid:null,fnc:null,isvalid:null,fld:"vUSUARIO",gxz:"ZV7USUARIO",gxold:"OV7USUARIO",gxvar:"AV7USUARIO",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",v2v:function(a){gx.O.AV7USUARIO=a},v2z:function(a){gx.O.ZV7USUARIO=a},v2c:function(){gx.fn.setControlValue("vUSUARIO",gx.O.AV7USUARIO,0)
},c2v:function(){gx.O.AV7USUARIO=this.val()},val:function(){return gx.fn.getControlValue("vUSUARIO")},nac:function(){return false}};this.GXValidFnc[21]={fld:"TEXTBLOCK2",format:0,grid:0};this.GXValidFnc[23]={lvl:0,type:"char",len:8,dec:0,sign:false,ro:0,grid:0,gxgrid:null,fnc:null,isvalid:null,fld:"vPASSWORD",gxz:"ZV6PASSWORD",gxold:"OV6PASSWORD",gxvar:"AV6PASSWORD",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",v2v:function(a){gx.O.AV6PASSWORD=a},v2z:function(a){gx.O.ZV6PASSWORD=a},v2c:function(){gx.fn.setControlValue("vPASSWORD",gx.O.AV6PASSWORD,0)
},c2v:function(){gx.O.AV6PASSWORD=this.val()},val:function(){return gx.fn.getControlValue("vPASSWORD")},nac:function(){return false}};this.GXValidFnc[24]={fld:"TABLE3",grid:0};this.GXValidFnc[27]={fld:"TABLE4",grid:0};this.AV7USUARIO="";this.ZV7USUARIO="";this.OV7USUARIO="";this.AV6PASSWORD="";this.ZV6PASSWORD="";this.OV6PASSWORD="";this.GxObject="";this.ServerEvents=["e13042_client","e14042_client"];this.VarControlMap.GxObject={id:"vGXOBJECT",grid:0,type:"svchar"};this.SetStandaloneVars();this.setComponent({id:"HEADERBC",GXClass:null,Prefix:"W0002",lvl:1});
this.setComponent({id:"RECENTLINKS",GXClass:null,Prefix:"W0003",lvl:1})}notauthorized.prototype=new gx.GxObject;gx.setParentObj(new notauthorized());