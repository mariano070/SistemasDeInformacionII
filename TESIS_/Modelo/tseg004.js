gx.evt.autoSkip=false;function tseg004(){this.ServerClass="TSEG004";this.PackageName="GeneXus.Programs";this.setObjectType("trn");this.hasEnterEvent=true;this.SetStandaloneVars=function(){this.Gx_mode=gx.fn.getControlValue("vMODE")};this.Valid_Usu_cod_=function(){try{var a=gx.util.balloon.getNew("USU_COD_");this.AnyError=0}catch(b){}try{if(a==null){return true}return a.show()}catch(b){}return true};this.Valid_Sis_cod=function(){try{var a=gx.util.balloon.getNew("SIS_COD");this.AnyError=0}catch(b){}try{if(a==null){return true
}return a.show()}catch(b){}return true};this.Valid_Prg_cod=function(){gx.ajax.validSrvEvt("dyncall","Valid_Prg_cod",["gx.O.A569USU_COD_","gx.O.A116SIS_COD","gx.O.A126PRG_COD","gx.O.A259SIS_DES","gx.O.A127PRG_DES"],["A259SIS_DES","A127PRG_DES","Gx_mode","Z569USU_COD_","Z116SIS_COD","Z126PRG_COD","Z259SIS_DES","Z127PRG_DES",["BTN_ENTER2","Enabled"]]);return true};this.e11172_client=function(){this.executeServerEvent("AFTER TRN",true)};this.e121742_client=function(){this.executeServerEvent("ENTER",true)
};this.e131742_client=function(){this.executeServerEvent("CANCEL",true)};this.GXValidFnc=[];this.GXCtrlIds=[2,5,8,9,10,11,12,13,14,15,16,17,18,19,20,21,22,23,26,27,33,38,43,48,53,58,64];this.GXLastCtrlId=64;this.GXValidFnc[2]={fld:"TABLEMAIN",grid:0};this.GXValidFnc[5]={fld:"TABLETOOLBAR",grid:0};this.GXValidFnc[8]={fld:"BTN_FIRST",grid:0};this.GXValidFnc[9]={fld:"BTN_FIRST_SEPARATOR",grid:0};this.GXValidFnc[10]={fld:"BTN_PREVIOUS",grid:0};this.GXValidFnc[11]={fld:"BTN_PREVIOUS_SEPARATOR",grid:0};
this.GXValidFnc[12]={fld:"BTN_NEXT",grid:0};this.GXValidFnc[13]={fld:"BTN_NEXT_SEPARATOR",grid:0};this.GXValidFnc[14]={fld:"BTN_LAST",grid:0};this.GXValidFnc[15]={fld:"BTN_LAST_SEPARATOR",grid:0};this.GXValidFnc[16]={fld:"BTN_SELECT",grid:0};this.GXValidFnc[17]={fld:"BTN_SELECT_SEPARATOR",grid:0};this.GXValidFnc[18]={fld:"BTN_ENTER2",grid:0};this.GXValidFnc[19]={fld:"BTN_ENTER2_SEPARATOR",grid:0};this.GXValidFnc[20]={fld:"BTN_CANCEL2",grid:0};this.GXValidFnc[21]={fld:"BTN_CANCEL2_SEPARATOR",grid:0};
this.GXValidFnc[22]={fld:"BTN_DELETE2",grid:0};this.GXValidFnc[23]={fld:"BTN_DELETE2_SEPARATOR",grid:0};this.GXValidFnc[26]={fld:"GROUPDATA",grid:0};this.GXValidFnc[27]={fld:"TABLE1",grid:0};this.GXValidFnc[33]={fld:"TABLE2",grid:0};this.GXValidFnc[36]={fld:"TEXTBLOCKUSU_COD_",format:0,grid:0};this.GXValidFnc[38]={lvl:0,type:"char",len:16,dec:0,sign:false,ro:0,grid:0,gxgrid:null,fnc:this.Valid_Usu_cod_,isvalid:null,fld:"USU_COD_",gxz:"Z569USU_COD_",gxold:"O569USU_COD_",gxvar:"A569USU_COD_",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",v2v:function(a){gx.O.A569USU_COD_=a
},v2z:function(a){gx.O.Z569USU_COD_=a},v2c:function(){gx.fn.setControlValue("USU_COD_",gx.O.A569USU_COD_,0)},c2v:function(){gx.O.A569USU_COD_=this.val()},val:function(){return gx.fn.getControlValue("USU_COD_")},nac:function(){return false}};this.GXValidFnc[41]={fld:"TEXTBLOCKSIS_COD",format:0,grid:0};this.GXValidFnc[43]={lvl:0,type:"int",len:3,dec:0,sign:false,pic:"ZZ9",ro:0,grid:0,gxgrid:null,fnc:this.Valid_Sis_cod,isvalid:null,rgrid:[],fld:"SIS_COD",gxz:"Z116SIS_COD",gxold:"O116SIS_COD",gxvar:"A116SIS_COD",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",v2v:function(a){gx.O.A116SIS_COD=gx.num.intval(a)
},v2z:function(a){gx.O.Z116SIS_COD=gx.num.intval(a)},v2c:function(){gx.fn.setControlValue("SIS_COD",gx.O.A116SIS_COD,0)},c2v:function(){gx.O.A116SIS_COD=this.val()},val:function(){return gx.fn.getIntegerValue("SIS_COD",".")},nac:function(){return false}};this.GXValidFnc[46]={fld:"TEXTBLOCKSIS_DES",format:0,grid:0};this.GXValidFnc[48]={lvl:0,type:"char",len:15,dec:0,sign:false,ro:1,grid:0,gxgrid:null,fnc:null,isvalid:null,fld:"SIS_DES",gxz:"Z259SIS_DES",gxold:"O259SIS_DES",gxvar:"A259SIS_DES",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",v2v:function(a){gx.O.A259SIS_DES=a
},v2z:function(a){gx.O.Z259SIS_DES=a},v2c:function(){gx.fn.setControlValue("SIS_DES",gx.O.A259SIS_DES,0)},c2v:function(){gx.O.A259SIS_DES=this.val()},val:function(){return gx.fn.getControlValue("SIS_DES")},nac:function(){return false}};this.GXValidFnc[51]={fld:"TEXTBLOCKPRG_COD",format:0,grid:0};this.GXValidFnc[53]={lvl:0,type:"int",len:4,dec:0,sign:false,pic:"ZZZ9",ro:0,grid:0,gxgrid:null,fnc:this.Valid_Prg_cod,isvalid:null,rgrid:[],fld:"PRG_COD",gxz:"Z126PRG_COD",gxold:"O126PRG_COD",gxvar:"A126PRG_COD",ucs:[],op:[58,48],ip:[58,48,53,43,38],nacdep:[],ctrltype:"edit",v2v:function(a){gx.O.A126PRG_COD=gx.num.intval(a)
},v2z:function(a){gx.O.Z126PRG_COD=gx.num.intval(a)},v2c:function(){gx.fn.setControlValue("PRG_COD",gx.O.A126PRG_COD,0)},c2v:function(){gx.O.A126PRG_COD=this.val()},val:function(){return gx.fn.getIntegerValue("PRG_COD",".")},nac:function(){return false}};this.GXValidFnc[56]={fld:"TEXTBLOCKPRG_DES",format:0,grid:0};this.GXValidFnc[58]={lvl:0,type:"char",len:30,dec:0,sign:false,ro:1,grid:0,gxgrid:null,fnc:null,isvalid:null,fld:"PRG_DES",gxz:"Z127PRG_DES",gxold:"O127PRG_DES",gxvar:"A127PRG_DES",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",v2v:function(a){gx.O.A127PRG_DES=a
},v2z:function(a){gx.O.Z127PRG_DES=a},v2c:function(){gx.fn.setControlValue("PRG_DES",gx.O.A127PRG_DES,0)},c2v:function(){gx.O.A127PRG_DES=this.val()},val:function(){return gx.fn.getControlValue("PRG_DES")},nac:function(){return false}};this.GXValidFnc[64]={fld:"PROMPT_126",grid:42};this.A569USU_COD_="";this.Z569USU_COD_="";this.O569USU_COD_="";this.A116SIS_COD=0;this.Z116SIS_COD=0;this.O116SIS_COD=0;this.A259SIS_DES="";this.Z259SIS_DES="";this.O259SIS_DES="";this.A126PRG_COD=0;this.Z126PRG_COD=0;
this.O126PRG_COD=0;this.A127PRG_DES="";this.Z127PRG_DES="";this.O127PRG_DES="";this.AV10Context={};this.ServerEvents=["e11172_client","e121742_client","e131742_client"];this.setPrompt("PROMPT_126",[53]);this.EnterCtrl=["BTN_ENTER"];this.VarControlMap.Gx_mode={id:"vMODE",grid:0,type:"char"};this.SetStandaloneVars()}tseg004.prototype=new gx.GxObject;gx.setParentObj(new tseg004());