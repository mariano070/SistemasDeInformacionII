gx.evt.autoSkip=false;function seg008(){this.ServerClass="SEG008";this.PackageName="GeneXus.Programs";this.setObjectType("trn");this.hasEnterEvent=true;this.SetStandaloneVars=function(){this.AV11PRG_COD=gx.fn.getIntegerValue("vPRG_COD",".");this.AV12MNU_NIV=gx.fn.getIntegerValue("vMNU_NIV",".");this.A362MNU_LINK=gx.fn.getControlValue("MNU_LINK");this.AV13Pgmname=gx.fn.getControlValue("vPGMNAME");this.Gx_mode=gx.fn.getControlValue("vMODE")};this.Valid_Prg_cod=function(){gx.ajax.validSrvEvt("dyncall","Valid_Prg_cod",["gx.O.A126PRG_COD","gx.O.A127PRG_DES"],["A127PRG_DES"]);
return true};this.Valid_Mnu_niv=function(){try{var a=gx.util.balloon.getNew("MNU_NIV");this.AnyError=0}catch(b){}try{if(a==null){return true}return a.show()}catch(b){}return true};this.e120t2_client=function(){this.executeServerEvent("AFTER TRN",true)};this.e130t28_client=function(){this.executeServerEvent("ENTER",true)};this.e140t28_client=function(){this.executeServerEvent("CANCEL",true)};this.GXValidFnc=[];this.GXCtrlIds=[2,5,8,9,10,11,12,13,14,15,16,17,18,19,20,21,22,23,26,27,33,38,43,48,53,59];
this.GXLastCtrlId=59;this.GXValidFnc[2]={fld:"TABLEMAIN",grid:0};this.GXValidFnc[5]={fld:"TABLETOOLBAR",grid:0};this.GXValidFnc[8]={fld:"BTN_FIRST",grid:0};this.GXValidFnc[9]={fld:"BTN_FIRST_SEPARATOR",grid:0};this.GXValidFnc[10]={fld:"BTN_PREVIOUS",grid:0};this.GXValidFnc[11]={fld:"BTN_PREVIOUS_SEPARATOR",grid:0};this.GXValidFnc[12]={fld:"BTN_NEXT",grid:0};this.GXValidFnc[13]={fld:"BTN_NEXT_SEPARATOR",grid:0};this.GXValidFnc[14]={fld:"BTN_LAST",grid:0};this.GXValidFnc[15]={fld:"BTN_LAST_SEPARATOR",grid:0};
this.GXValidFnc[16]={fld:"BTN_SELECT",grid:0};this.GXValidFnc[17]={fld:"BTN_SELECT_SEPARATOR",grid:0};this.GXValidFnc[18]={fld:"BTN_ENTER2",grid:0};this.GXValidFnc[19]={fld:"BTN_ENTER2_SEPARATOR",grid:0};this.GXValidFnc[20]={fld:"BTN_CANCEL2",grid:0};this.GXValidFnc[21]={fld:"BTN_CANCEL2_SEPARATOR",grid:0};this.GXValidFnc[22]={fld:"BTN_DELETE2",grid:0};this.GXValidFnc[23]={fld:"BTN_DELETE2_SEPARATOR",grid:0};this.GXValidFnc[26]={fld:"GROUPDATA",grid:0};this.GXValidFnc[27]={fld:"TABLE1",grid:0};this.GXValidFnc[33]={fld:"TABLE2",grid:0};
this.GXValidFnc[36]={fld:"TEXTBLOCKPRG_COD",format:0,grid:0};this.GXValidFnc[38]={lvl:0,type:"int",len:4,dec:0,sign:false,pic:"ZZZ9",ro:0,grid:0,gxgrid:null,fnc:this.Valid_Prg_cod,isvalid:null,rgrid:[],fld:"PRG_COD",gxz:"Z126PRG_COD",gxold:"O126PRG_COD",gxvar:"A126PRG_COD",ucs:[],op:[43],ip:[43,38],nacdep:[],ctrltype:"edit",v2v:function(a){gx.O.A126PRG_COD=gx.num.intval(a)},v2z:function(a){gx.O.Z126PRG_COD=gx.num.intval(a)},v2c:function(){gx.fn.setControlValue("PRG_COD",gx.O.A126PRG_COD,0)},c2v:function(){gx.O.A126PRG_COD=this.val()
},val:function(){return gx.fn.getIntegerValue("PRG_COD",".")},nac:function(){return !(0==this.AV11PRG_COD)}};this.GXValidFnc[41]={fld:"TEXTBLOCKPRG_DES",format:0,grid:0};this.GXValidFnc[43]={lvl:0,type:"char",len:30,dec:0,sign:false,ro:1,grid:0,gxgrid:null,fnc:null,isvalid:null,fld:"PRG_DES",gxz:"Z127PRG_DES",gxold:"O127PRG_DES",gxvar:"A127PRG_DES",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",v2v:function(a){gx.O.A127PRG_DES=a},v2z:function(a){gx.O.Z127PRG_DES=a},v2c:function(){gx.fn.setControlValue("PRG_DES",gx.O.A127PRG_DES,0)
},c2v:function(){gx.O.A127PRG_DES=this.val()},val:function(){return gx.fn.getControlValue("PRG_DES")},nac:function(){return false}};this.GXValidFnc[46]={fld:"TEXTBLOCKMNU_NIV",format:0,grid:0};this.GXValidFnc[48]={lvl:0,type:"int",len:6,dec:0,sign:true,pic:"ZZZZZ9",ro:0,grid:0,gxgrid:null,fnc:this.Valid_Mnu_niv,isvalid:null,rgrid:[],fld:"MNU_NIV",gxz:"Z361MNU_NIV",gxold:"O361MNU_NIV",gxvar:"A361MNU_NIV",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",v2v:function(a){gx.O.A361MNU_NIV=gx.num.intval(a)
},v2z:function(a){gx.O.Z361MNU_NIV=gx.num.intval(a)},v2c:function(){gx.fn.setControlValue("MNU_NIV",gx.O.A361MNU_NIV,0)},c2v:function(){gx.O.A361MNU_NIV=this.val()},val:function(){return gx.fn.getIntegerValue("MNU_NIV",".")},nac:function(){return !(0==this.AV12MNU_NIV)}};this.GXValidFnc[51]={fld:"TEXTBLOCKMNU_NID",format:0,grid:0};this.GXValidFnc[53]={lvl:0,type:"char",len:100,dec:0,sign:false,ro:0,grid:0,gxgrid:null,fnc:null,isvalid:null,fld:"MNU_NID",gxz:"Z129MNU_NID",gxold:"O129MNU_NID",gxvar:"A129MNU_NID",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",v2v:function(a){gx.O.A129MNU_NID=a
},v2z:function(a){gx.O.Z129MNU_NID=a},v2c:function(){gx.fn.setControlValue("MNU_NID",gx.O.A129MNU_NID,0)},c2v:function(){gx.O.A129MNU_NID=this.val()},val:function(){return gx.fn.getControlValue("MNU_NID")},nac:function(){return false}};this.GXValidFnc[59]={fld:"PROMPT_126",grid:28};this.A126PRG_COD=0;this.Z126PRG_COD=0;this.O126PRG_COD=0;this.A127PRG_DES="";this.Z127PRG_DES="";this.O127PRG_DES="";this.A361MNU_NIV=0;this.Z361MNU_NIV=0;this.O361MNU_NIV=0;this.A129MNU_NID="";this.Z129MNU_NID="";this.O129MNU_NID="";
this.AV13Pgmname="";this.AV8IsAuthorized=false;this.AV9TrnContext={};this.AV7Context={};this.AV11PRG_COD=0;this.AV12MNU_NIV=0;this.A362MNU_LINK="";this.Gx_mode="";this.ServerEvents=["e120t2_client","e130t28_client","e140t28_client"];this.setPrompt("PROMPT_126",[38]);this.EnterCtrl=["BTN_ENTER"];this.VarControlMap.AV11PRG_COD={id:"vPRG_COD",grid:0,type:"int"};this.VarControlMap.AV12MNU_NIV={id:"vMNU_NIV",grid:0,type:"int"};this.VarControlMap.A362MNU_LINK={id:"MNU_LINK",grid:0,type:"svchar"};this.VarControlMap.AV13Pgmname={id:"vPGMNAME",grid:0,type:"char"};
this.VarControlMap.Gx_mode={id:"vMODE",grid:0,type:"char"};this.SetStandaloneVars()}seg008.prototype=new gx.GxObject;gx.setParentObj(new seg008());