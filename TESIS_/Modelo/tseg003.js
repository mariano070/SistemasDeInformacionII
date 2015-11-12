/*
               File: TSEG003
        Description: ACT. USUARIO/SISTEMA
             Author: GeneXus C# Generator version 10_1_5-42940
       Generated on: 1/6/2014 11:8:26.51
       Program type: Callable routine
          Main DBMS: sqlserver
*/
gx.evt.autoSkip = false;
function tseg003() {
   this.ServerClass =  "TSEG003" ;
   this.PackageName =  "GeneXus.Programs" ;
   this.setObjectType("trn");
   this.hasEnterEvent = true;
   this.SetStandaloneVars=function()
   {
      this.AV10USU_COD=gx.fn.getControlValue("vUSU_COD") ;
      this.AV11SIS_COD=gx.fn.getIntegerValue("vSIS_COD",'.') ;
      this.AV16Pgmname=gx.fn.getControlValue("vPGMNAME") ;
      this.Gx_mode=gx.fn.getControlValue("vMODE") ;
   };
   this.Valid_Usu_cod=function()
   {
      /*
         call server method valid_USU_COD
      */
      gx.ajax.validSrvEvt("dyncall","Valid_Usu_cod",["gx.O.A6USU_COD", "gx.O.A7USU_DES", "gx.O.A155USU_CLA"],["A7USU_DES", "A155USU_CLA"]);
      return true;
   }
   this.Valid_Sis_cod=function()
   {
      /*
         call server method valid_SIS_COD
      */
      gx.ajax.validSrvEvt("dyncall","Valid_Sis_cod",["gx.O.A116SIS_COD", "gx.O.A259SIS_DES"],["A259SIS_DES"]);
      return true;
   }
   this.e120g2_client=function()
   {
      this.executeServerEvent("AFTER TRN", true);
   };
   this.e130g16_client=function()
   {
      this.executeServerEvent("ENTER", true);
   };
   this.e140g16_client=function()
   {
      this.executeServerEvent("CANCEL", true);
   };
   this.GXValidFnc = [];
   this.GXCtrlIds=[2,8,13,18,23,28,34,37,47,48];
   this.GXLastCtrlId =48;
   this.GXValidFnc[2]={fld:"TABLE1",grid:0};
   this.GXValidFnc[8]={fld:"TABLE2",grid:0};
   this.GXValidFnc[11]={fld:"TEXTBLOCK1", format:0,grid:0};
   this.GXValidFnc[13]={lvl:0,type:"char",len:16,dec:0,sign:false,ro:0,grid:0,gxgrid:null,fnc:this.Valid_Usu_cod,isvalid:null,fld:"USU_COD",gxz:"Z6USU_COD",gxold:"O6USU_COD",gxvar:"A6USU_COD",ucs:[],op:[23,18],ip:[23,18,13],nacdep:[],ctrltype:"edit",v2v:function(Value){gx.O.A6USU_COD=Value},v2z:function(Value){gx.O.Z6USU_COD=Value},v2c:function(){gx.fn.setControlValue("USU_COD",gx.O.A6USU_COD,0)},c2v:function(){gx.O.A6USU_COD=this.val()},val:function(){return gx.fn.getControlValue("USU_COD")},nac:function(){return  ! (""==this.AV10USU_COD) }};
   this.GXValidFnc[16]={fld:"TEXTBLOCK2", format:0,grid:0};
   this.GXValidFnc[18]={lvl:0,type:"char",len:50,dec:0,sign:false,ro:1,grid:0,gxgrid:null,fnc:null,isvalid:null,fld:"USU_DES",gxz:"Z7USU_DES",gxold:"O7USU_DES",gxvar:"A7USU_DES",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",v2v:function(Value){gx.O.A7USU_DES=Value},v2z:function(Value){gx.O.Z7USU_DES=Value},v2c:function(){gx.fn.setControlValue("USU_DES",gx.O.A7USU_DES,0)},c2v:function(){gx.O.A7USU_DES=this.val()},val:function(){return gx.fn.getControlValue("USU_DES")},nac:function(){return  false }};
   this.GXValidFnc[21]={fld:"TEXTBLOCK3", format:0,grid:0};
   this.GXValidFnc[23]={lvl:0,type:"char",len:20,dec:0,sign:false,isPwd:true,ro:1,grid:0,gxgrid:null,fnc:null,isvalid:null,fld:"USU_CLA",gxz:"Z155USU_CLA",gxold:"O155USU_CLA",gxvar:"A155USU_CLA",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",v2v:function(Value){gx.O.A155USU_CLA=Value},v2z:function(Value){gx.O.Z155USU_CLA=Value},v2c:function(){gx.fn.setControlValue("USU_CLA",gx.O.A155USU_CLA,0)},c2v:function(){gx.O.A155USU_CLA=this.val()},val:function(){return gx.fn.getControlValue("USU_CLA")},nac:function(){return  false }};
   this.GXValidFnc[26]={fld:"TEXTBLOCK4", format:0,grid:0};
   this.GXValidFnc[28]={lvl:0,type:"int",len:3,dec:0,sign:false,pic:"ZZ9",ro:0,grid:0,gxgrid:null,fnc:this.Valid_Sis_cod,isvalid:null,rgrid:[],fld:"SIS_COD",gxz:"Z116SIS_COD",gxold:"O116SIS_COD",gxvar:"A116SIS_COD",ucs:[],op:[28,34],ip:[34,28],nacdep:[],ctrltype:"edit",v2v:function(Value){gx.O.A116SIS_COD=gx.num.intval(Value)},v2z:function(Value){gx.O.Z116SIS_COD=gx.num.intval(Value)},v2c:function(){gx.fn.setControlValue("SIS_COD",gx.O.A116SIS_COD,0)},c2v:function(){gx.O.A116SIS_COD=this.val()},val:function(){return gx.fn.getIntegerValue("SIS_COD",'.')},nac:function(){return  ! (0==this.AV11SIS_COD) }};
   this.GXValidFnc[32]={fld:"TEXTBLOCK5", format:0,grid:0};
   this.GXValidFnc[34]={lvl:0,type:"char",len:15,dec:0,sign:false,ro:1,grid:0,gxgrid:null,fnc:null,isvalid:null,fld:"SIS_DES",gxz:"Z259SIS_DES",gxold:"O259SIS_DES",gxvar:"A259SIS_DES",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",v2v:function(Value){gx.O.A259SIS_DES=Value},v2z:function(Value){gx.O.Z259SIS_DES=Value},v2c:function(){gx.fn.setControlValue("SIS_DES",gx.O.A259SIS_DES,0)},c2v:function(){gx.O.A259SIS_DES=this.val()},val:function(){return gx.fn.getControlValue("SIS_DES")},nac:function(){return  false }};
   this.GXValidFnc[37]={fld:"TABLE3",grid:0};
   this.GXValidFnc[47]={fld:"PROMPT_6",grid:16};
   this.GXValidFnc[48]={fld:"PROMPT_116",grid:16};
   this.A6USU_COD = "" ;
   this.Z6USU_COD = "" ;
   this.O6USU_COD = "" ;
   this.A7USU_DES = "" ;
   this.Z7USU_DES = "" ;
   this.O7USU_DES = "" ;
   this.A155USU_CLA = "" ;
   this.Z155USU_CLA = "" ;
   this.O155USU_CLA = "" ;
   this.A116SIS_COD = 0 ;
   this.Z116SIS_COD = 0 ;
   this.O116SIS_COD = 0 ;
   this.A259SIS_DES = "" ;
   this.Z259SIS_DES = "" ;
   this.O259SIS_DES = "" ;
   this.AV16Pgmname = "" ;
   this.AV13IsAuthorized = false ;
   this.AV14TrnContext = {} ;
   this.AV12Context = {} ;
   this.AV10USU_COD = "" ;
   this.AV11SIS_COD = 0 ;
   this.Gx_mode = "" ;
   this.ServerEvents = ["e120g2_client" ,"e130g16_client" ,"e140g16_client"];
   this.setPrompt("PROMPT_6", [13]);
   this.setPrompt("PROMPT_116", [28]);
   this.EnterCtrl = ["BTN_ENTER"];
   this.CheckCtrl = ["BTN_CHECK"];
   this.VarControlMap["AV10USU_COD"] = {id:"vUSU_COD",grid:0,type:"char"};
   this.VarControlMap["AV11SIS_COD"] = {id:"vSIS_COD",grid:0,type:"int"};
   this.VarControlMap["AV16Pgmname"] = {id:"vPGMNAME",grid:0,type:"char"};
   this.VarControlMap["Gx_mode"] = {id:"vMODE",grid:0,type:"char"};
   this.SetStandaloneVars( );
}
tseg003.prototype = new gx.GxObject;
gx.setParentObj(new tseg003());
