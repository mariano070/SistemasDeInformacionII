gx.evt.autoSkip=false;function hcambio_password(){this.ServerClass="HCAMBIO_password";this.PackageName="GeneXus.Programs";this.setObjectType("web");this.hasEnterEvent=false;this.SetStandaloneVars=function(){};this.Valid_Usu_cod=function(){try{var a=gx.util.balloon.getNew("USU_COD");this.AnyError=0}catch(b){}try{if(a==null){return true}return a.show()}catch(b){}return true};this.e12242_client=function(){this.executeServerEvent("'CAMBIAR'",false)};this.e14242_client=function(){this.executeServerEvent("ENTER",true)
};this.e15242_client=function(){this.executeServerEvent("CANCEL",true)};this.GXValidFnc=[];this.GXCtrlIds=[3,6,10,13,21,27,33];this.GXLastCtrlId=33;this.GXValidFnc[3]={fld:"TABLE2",grid:0};this.GXValidFnc[6]={fld:"TABLE1",grid:0};this.GXValidFnc[9]={fld:"TEXTBLOCK4",format:0,grid:0};this.GXValidFnc[10]={lvl:0,type:"char",len:16,dec:0,sign:false,ro:1,grid:0,gxgrid:null,fnc:this.Valid_Usu_cod,isvalid:null,fld:"USU_COD",gxz:"Z6USU_COD",gxold:"O6USU_COD",gxvar:"A6USU_COD",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",v2v:function(a){gx.O.A6USU_COD=a
},v2z:function(a){gx.O.Z6USU_COD=a},v2c:function(){gx.fn.setControlValue("USU_COD",gx.O.A6USU_COD,0)},c2v:function(){gx.O.A6USU_COD=this.val()},val:function(){return gx.fn.getControlValue("USU_COD")},nac:function(){return false}};this.GXValidFnc[13]={lvl:0,type:"char",len:50,dec:0,sign:false,ro:1,grid:0,gxgrid:null,fnc:null,isvalid:null,fld:"USU_DES",gxz:"Z7USU_DES",gxold:"O7USU_DES",gxvar:"A7USU_DES",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",v2v:function(a){gx.O.A7USU_DES=a},v2z:function(a){gx.O.Z7USU_DES=a
},v2c:function(){gx.fn.setControlValue("USU_DES",gx.O.A7USU_DES,0)},c2v:function(){gx.O.A7USU_DES=this.val()},val:function(){return gx.fn.getControlValue("USU_DES")},nac:function(){return false}};this.GXValidFnc[19]={fld:"TEXTBLOCK1",format:0,grid:0};this.GXValidFnc[21]={lvl:0,type:"char",len:20,dec:0,sign:false,isPwd:true,ro:0,grid:0,gxgrid:null,fnc:null,isvalid:null,fld:"vUSU_CLA",gxz:"ZV11USU_CLA",gxold:"OV11USU_CLA",gxvar:"AV11USU_CLA",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",v2v:function(a){gx.O.AV11USU_CLA=a
},v2z:function(a){gx.O.ZV11USU_CLA=a},v2c:function(){gx.fn.setControlValue("vUSU_CLA",gx.O.AV11USU_CLA,0)},c2v:function(){gx.O.AV11USU_CLA=this.val()},val:function(){return gx.fn.getControlValue("vUSU_CLA")},nac:function(){return false}};this.GXValidFnc[25]={fld:"TEXTBLOCK2",format:0,grid:0};this.GXValidFnc[27]={lvl:0,type:"char",len:20,dec:0,sign:false,isPwd:true,ro:0,grid:0,gxgrid:null,fnc:null,isvalid:null,fld:"vUSUNCL",gxz:"ZV10USUNCL",gxold:"OV10USUNCL",gxvar:"AV10USUNCL",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",v2v:function(a){gx.O.AV10USUNCL=a
},v2z:function(a){gx.O.ZV10USUNCL=a},v2c:function(){gx.fn.setControlValue("vUSUNCL",gx.O.AV10USUNCL,0)},c2v:function(){gx.O.AV10USUNCL=this.val()},val:function(){return gx.fn.getControlValue("vUSUNCL")},nac:function(){return false}};this.GXValidFnc[31]={fld:"TEXTBLOCK3",format:0,grid:0};this.GXValidFnc[33]={lvl:0,type:"char",len:20,dec:0,sign:false,isPwd:true,ro:0,grid:0,gxgrid:null,fnc:null,isvalid:null,fld:"vUSU_CRT",gxz:"ZV12USU_CRT",gxold:"OV12USU_CRT",gxvar:"AV12USU_CRT",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",v2v:function(a){gx.O.AV12USU_CRT=a
},v2z:function(a){gx.O.ZV12USU_CRT=a},v2c:function(){gx.fn.setControlValue("vUSU_CRT",gx.O.AV12USU_CRT,0)},c2v:function(){gx.O.AV12USU_CRT=this.val()},val:function(){return gx.fn.getControlValue("vUSU_CRT")},nac:function(){return false}};this.A6USU_COD="";this.Z6USU_COD="";this.O6USU_COD="";this.A7USU_DES="";this.Z7USU_DES="";this.O7USU_DES="";this.AV11USU_CLA="";this.ZV11USU_CLA="";this.OV11USU_CLA="";this.AV10USUNCL="";this.ZV10USUNCL="";this.OV10USUNCL="";this.AV12USU_CRT="";this.ZV12USU_CRT="";
this.OV12USU_CRT="";this.A155USU_CLA="";this.ServerEvents=["e12242_client","e14242_client","e15242_client"];this.SetStandaloneVars()}hcambio_password.prototype=new gx.GxObject;gx.setParentObj(new hcambio_password());