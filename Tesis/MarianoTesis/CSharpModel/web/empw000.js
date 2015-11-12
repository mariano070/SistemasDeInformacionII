/*
               File: EMPW000
        Description: Empresas con Acceso WEB
             Author: GeneXus C# Generator version 10_1_5-42940
       Generated on: 1/6/2014 11:8:39.49
       Program type: Callable routine
          Main DBMS: sqlserver
*/
gx.evt.autoSkip = false;
function empw000() {
   this.ServerClass =  "EMPW000" ;
   this.PackageName =  "GeneXus.Programs" ;
   this.setObjectType("trn");
   this.hasEnterEvent = true;
   this.SetStandaloneVars=function()
   {
      this.AV7EMPW_EMP=gx.fn.getIntegerValue("vEMPW_EMP",'.') ;
      this.Gx_mode=gx.fn.getControlValue("vMODE") ;
   };
   this.Valid_Empw_usu=function()
   {
      try {
         var gxballoon = gx.util.balloon.getNew("EMPW_USU");
         this.AnyError  = 0;

      }
      catch(e){}
      try {
         if (gxballoon == null) return true; return gxballoon.show();
      }
      catch(e){}
      return true ;
   }
   this.Valid_Empw_emp=function()
   {
      try {
         var gxballoon = gx.util.balloon.getNew("EMPW_EMP");
         this.AnyError  = 0;

      }
      catch(e){}
      try {
         if (gxballoon == null) return true; return gxballoon.show();
      }
      catch(e){}
      return true ;
   }
   this.e110i19_client=function()
   {
      this.executeServerEvent("ENTER", true);
   };
   this.e120i19_client=function()
   {
      this.executeServerEvent("CANCEL", true);
   };
   this.GXValidFnc = [];
   this.GXCtrlIds=[2,5,8,9,10,11,12,13,14,15,16,17,18,19,20,21,22,23,26,27,33,38,43,48,53];
   this.GXLastCtrlId =53;
   this.GXValidFnc[2]={fld:"TABLEMAIN",grid:0};
   this.GXValidFnc[5]={fld:"TABLETOOLBAR",grid:0};
   this.GXValidFnc[8]={fld:"BTN_FIRST",grid:0};
   this.GXValidFnc[9]={fld:"BTN_FIRST_SEPARATOR",grid:0};
   this.GXValidFnc[10]={fld:"BTN_PREVIOUS",grid:0};
   this.GXValidFnc[11]={fld:"BTN_PREVIOUS_SEPARATOR",grid:0};
   this.GXValidFnc[12]={fld:"BTN_NEXT",grid:0};
   this.GXValidFnc[13]={fld:"BTN_NEXT_SEPARATOR",grid:0};
   this.GXValidFnc[14]={fld:"BTN_LAST",grid:0};
   this.GXValidFnc[15]={fld:"BTN_LAST_SEPARATOR",grid:0};
   this.GXValidFnc[16]={fld:"BTN_SELECT",grid:0};
   this.GXValidFnc[17]={fld:"BTN_SELECT_SEPARATOR",grid:0};
   this.GXValidFnc[18]={fld:"BTN_ENTER2",grid:0};
   this.GXValidFnc[19]={fld:"BTN_ENTER2_SEPARATOR",grid:0};
   this.GXValidFnc[20]={fld:"BTN_CANCEL2",grid:0};
   this.GXValidFnc[21]={fld:"BTN_CANCEL2_SEPARATOR",grid:0};
   this.GXValidFnc[22]={fld:"BTN_DELETE2",grid:0};
   this.GXValidFnc[23]={fld:"BTN_DELETE2_SEPARATOR",grid:0};
   this.GXValidFnc[26]={fld:"GROUPDATA",grid:0};
   this.GXValidFnc[27]={fld:"TABLE1",grid:0};
   this.GXValidFnc[33]={fld:"TABLE2",grid:0};
   this.GXValidFnc[36]={fld:"TEXTBLOCKEMPW_USU", format:0,grid:0};
   this.GXValidFnc[38]={lvl:0,type:"char",len:16,dec:0,sign:false,ro:1,grid:0,gxgrid:null,fnc:this.Valid_Empw_usu,isvalid:null,fld:"EMPW_USU",gxz:"Z278EMPW_USU",gxold:"O278EMPW_USU",gxvar:"A278EMPW_USU",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",v2v:function(Value){gx.O.A278EMPW_USU=Value},v2z:function(Value){gx.O.Z278EMPW_USU=Value},v2c:function(){gx.fn.setControlValue("EMPW_USU",gx.O.A278EMPW_USU,0)},c2v:function(){gx.O.A278EMPW_USU=this.val()},val:function(){return gx.fn.getControlValue("EMPW_USU")},nac:function(){return  false }};
   this.GXValidFnc[41]={fld:"TEXTBLOCKEMPW_USD", format:0,grid:0};
   this.GXValidFnc[43]={lvl:0,type:"char",len:50,dec:0,sign:false,ro:1,grid:0,gxgrid:null,fnc:null,isvalid:null,fld:"EMPW_USD",gxz:"Z283EMPW_USD",gxold:"O283EMPW_USD",gxvar:"A283EMPW_USD",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",v2v:function(Value){gx.O.A283EMPW_USD=Value},v2z:function(Value){gx.O.Z283EMPW_USD=Value},v2c:function(){gx.fn.setControlValue("EMPW_USD",gx.O.A283EMPW_USD,0)},c2v:function(){gx.O.A283EMPW_USD=this.val()},val:function(){return gx.fn.getControlValue("EMPW_USD")},nac:function(){return  false }};
   this.GXValidFnc[46]={fld:"TEXTBLOCKEMPW_EMP", format:0,grid:0};
   this.GXValidFnc[48]={lvl:0,type:"int",len:8,dec:0,sign:true,pic:"ZZZZZZZ9",ro:0,grid:0,gxgrid:null,fnc:this.Valid_Empw_emp,isvalid:null,rgrid:[],fld:"EMPW_EMP",gxz:"Z279EMPW_EMP",gxold:"O279EMPW_EMP",gxvar:"A279EMPW_EMP",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",v2v:function(Value){gx.O.A279EMPW_EMP=gx.num.intval(Value)},v2z:function(Value){gx.O.Z279EMPW_EMP=gx.num.intval(Value)},v2c:function(){gx.fn.setControlValue("EMPW_EMP",gx.O.A279EMPW_EMP,0)},c2v:function(){gx.O.A279EMPW_EMP=this.val()},val:function(){return gx.fn.getIntegerValue("EMPW_EMP",'.')},nac:function(){return  false }};
   this.GXValidFnc[51]={fld:"TEXTBLOCKEMPW_EMD", format:0,grid:0};
   this.GXValidFnc[53]={lvl:0,type:"char",len:50,dec:0,sign:false,ro:0,grid:0,gxgrid:null,fnc:null,isvalid:null,fld:"EMPW_EMD",gxz:"Z281EMPW_EMD",gxold:"O281EMPW_EMD",gxvar:"A281EMPW_EMD",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",v2v:function(Value){gx.O.A281EMPW_EMD=Value},v2z:function(Value){gx.O.Z281EMPW_EMD=Value},v2c:function(){gx.fn.setControlValue("EMPW_EMD",gx.O.A281EMPW_EMD,0)},c2v:function(){gx.O.A281EMPW_EMD=this.val()},val:function(){return gx.fn.getControlValue("EMPW_EMD")},nac:function(){return  false }};
   this.A278EMPW_USU = "" ;
   this.Z278EMPW_USU = "" ;
   this.O278EMPW_USU = "" ;
   this.A283EMPW_USD = "" ;
   this.Z283EMPW_USD = "" ;
   this.O283EMPW_USD = "" ;
   this.A279EMPW_EMP = 0 ;
   this.Z279EMPW_EMP = 0 ;
   this.O279EMPW_EMP = 0 ;
   this.A281EMPW_EMD = "" ;
   this.Z281EMPW_EMD = "" ;
   this.O281EMPW_EMD = "" ;
   this.AV7EMPW_EMP = 0 ;
   this.Gx_mode = "" ;
   this.ServerEvents = ["e110i19_client" ,"e120i19_client"];
   this.EnterCtrl = ["BTN_ENTER"];
   this.VarControlMap["AV7EMPW_EMP"] = {id:"vEMPW_EMP",grid:0,type:"int"};
   this.VarControlMap["Gx_mode"] = {id:"vMODE",grid:0,type:"char"};
   this.SetStandaloneVars( );
}
empw000.prototype = new gx.GxObject;
gx.setParentObj(new empw000());
