gx.evt.autoSkip=false;function wcseguridad(a){this.ServerClass="WCSEGURIDAD";this.PackageName="GeneXus.Programs";this.setObjectType("web");this.setCmpContext(a);this.ReadonlyForm=true;this.hasEnterEvent=true;this.SetStandaloneVars=function(){this.AV8PRG_WEB=gx.fn.getControlValue("vPRG_WEB")};this.Validv_Usuario=function(){try{var b=gx.util.balloon.getNew("vUSUARIO");this.AnyError=0}catch(c){}try{if(b==null){return true}return b.show()}catch(c){}return true};this.e12252_client=function(){this.executeServerEvent("ENTER",true)
};this.e14252_client=function(){this.executeServerEvent("CANCEL",true)};this.GXValidFnc=[];this.GXCtrlIds=[2,5,11,16];this.GXLastCtrlId=16;this.GXValidFnc[2]={fld:"TABLE1",grid:0};this.GXValidFnc[5]={fld:"TABLA_SISTEMAS",grid:0};this.GXValidFnc[6]={fld:"TEXTBLOCK1",format:0,grid:0};this.GXValidFnc[9]={fld:"TEXTBLOCK10",format:0,grid:0};this.GXValidFnc[11]={lvl:0,type:"char",len:16,dec:0,sign:false,ro:0,grid:0,gxgrid:null,fnc:this.Validv_Usuario,isvalid:null,fld:"vUSUARIO",gxz:"ZV6USUARIO",gxold:"OV6USUARIO",gxvar:"AV6USUARIO",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",v2v:function(b){gx.O.AV6USUARIO=b
},v2z:function(b){gx.O.ZV6USUARIO=b},v2c:function(){gx.fn.setControlValue("vUSUARIO",gx.O.AV6USUARIO,0)},c2v:function(){gx.O.AV6USUARIO=this.val()},val:function(){return gx.fn.getControlValue("vUSUARIO")},nac:function(){return false}};this.GXValidFnc[14]={fld:"TEXTBLOCK11",format:0,grid:0};this.GXValidFnc[16]={lvl:0,type:"char",len:20,dec:0,sign:false,isPwd:true,ro:0,grid:0,gxgrid:null,fnc:null,isvalid:null,fld:"vUSU_CLA",gxz:"ZV7USU_CLA",gxold:"OV7USU_CLA",gxvar:"AV7USU_CLA",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",v2v:function(b){gx.O.AV7USU_CLA=b
},v2z:function(b){gx.O.ZV7USU_CLA=b},v2c:function(){gx.fn.setControlValue("vUSU_CLA",gx.O.AV7USU_CLA,0)},c2v:function(){gx.O.AV7USU_CLA=this.val()},val:function(){return gx.fn.getControlValue("vUSU_CLA")},nac:function(){return false}};this.AV6USUARIO="";this.ZV6USUARIO="";this.OV6USUARIO="";this.AV7USU_CLA="";this.ZV7USU_CLA="";this.OV7USU_CLA="";this.AV8PRG_WEB="";this.A117PRG_WEB="";this.A127PRG_DES="";this.A126PRG_COD=0;this.A164PRG_SIS=0;this.A116SIS_COD=0;this.A569USU_COD_="";this.A6USU_COD="";
this.A7USU_DES="";this.A155USU_CLA="";this.ServerEvents=["e12252_client","e14252_client"];this.VarControlMap.AV8PRG_WEB={id:"vPRG_WEB",grid:0,type:"char"};this.SetStandaloneVars();this.setComponent({id:"WC_SEGURIDAD",GXClass:"hsi_habilitado",Prefix:"W0019",lvl:1})}gx.setExecutableComponent("wcseguridad");