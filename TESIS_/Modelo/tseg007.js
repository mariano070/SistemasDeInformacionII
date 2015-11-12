/*
               File: TSEG007
        Description: PROGRAMAS ACCEDIDOS POR SESION
             Author: GeneXus C# Generator version 10_1_5-42940
       Generated on: 1/6/2014 11:8:17.77
       Program type: Callable routine
          Main DBMS: sqlserver
*/
gx.evt.autoSkip = false;
function tseg007() {
   this.ServerClass =  "TSEG007" ;
   this.PackageName =  "GeneXus.Programs" ;
   this.setObjectType("trn");
   this.hasEnterEvent = true;
   this.SetStandaloneVars=function()
   {
      this.AV9PRGCOD=gx.fn.getIntegerValue("vPRGCOD",'.') ;
      this.Gx_mode=gx.fn.getControlValue("vMODE") ;
      this.AV7SISTEMA=gx.fn.getControlValue("vSISTEMA") ;
      this.AV8USUARIO=gx.fn.getControlValue("vUSUARIO") ;
   };
   this.Valid_Usu_cod=function()
   {
      try {
         var gxballoon = gx.util.balloon.getNew("USU_COD");
         this.AnyError  = 0;

      }
      catch(e){}
      try {
         if (gxballoon == null) return true; return gxballoon.show();
      }
      catch(e){}
      return true ;
   }
   this.Valid_Sis_cod=function()
   {
      try {
         var gxballoon = gx.util.balloon.getNew("SIS_COD");
         this.AnyError  = 0;

      }
      catch(e){}
      try {
         if (gxballoon == null) return true; return gxballoon.show();
      }
      catch(e){}
      return true ;
   }
   this.Valid_Prg_cod=function()
   {
      /*
         call server method valid_PRG_COD
      */
      gx.ajax.validSrvEvt("dyncall","Valid_Prg_cod",["gx.O.A126PRG_COD", "gx.O.A6USU_COD", "gx.O.A116SIS_COD", "gx.O.A127PRG_DES", "gx.O.A289PRG_NFI", "gx.O.A290USU_CNT"],["A127PRG_DES", "A289PRG_NFI", "A290USU_CNT"]);
      return true;
   }
   this.Valid_Prs_nro=function()
   {
      /*
         call server method valid_PRS_NRO
      */
      gx.ajax.validSrvEvt("dyncall","Valid_Prs_nro",["gx.O.A6USU_COD", "gx.O.A116SIS_COD", "gx.O.A126PRG_COD", "gx.O.A118PRS_NRO", 'gx.date.urlDateTime(gx.O.A166PRS_INI,"DMY4")', "gx.O.A404PRS_UOB", "gx.O.A405PRS_UDE", "gx.O.A406PRS_ULNK", 'gx.date.urlDateTime(gx.O.A165PRS_CAD,"DMY4")'],["A166PRS_INI", "A404PRS_UOB", "A405PRS_UDE", "A406PRS_ULNK", "A165PRS_CAD"]);
      return true;
   }
   this.Valid_Prs_ord=function()
   {
      try {
         var gxballoon = gx.util.balloon.getNew("PRS_ORD");
         this.AnyError  = 0;

      }
      catch(e){}
      try {
         if (gxballoon == null) return true; return gxballoon.show();
      }
      catch(e){}
      return true ;
   }
   this.e111135_client=function()
   {
      this.executeServerEvent("ENTER", true);
   };
   this.e121135_client=function()
   {
      this.executeServerEvent("CANCEL", true);
   };
   this.GXValidFnc = [];
   this.GXCtrlIds=[2,15,20,25,30,35,40,45,50,55,60,65,70,75,80,85,90,95,101,106,114,115];
   this.GXLastCtrlId =115;
   this.GXValidFnc[2]={fld:"TABLE1",grid:0};
   this.GXValidFnc[15]={fld:"TABLE2",grid:0};
   this.GXValidFnc[18]={fld:"TEXTBLOCK1", format:0,grid:0};
   this.GXValidFnc[20]={lvl:0,type:"char",len:16,dec:0,sign:false,ro:1,grid:0,gxgrid:null,fnc:this.Valid_Usu_cod,isvalid:null,fld:"USU_COD",gxz:"Z6USU_COD",gxold:"O6USU_COD",gxvar:"A6USU_COD",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",v2v:function(Value){gx.O.A6USU_COD=Value},v2z:function(Value){gx.O.Z6USU_COD=Value},v2c:function(){gx.fn.setControlValue("USU_COD",gx.O.A6USU_COD,0)},c2v:function(){gx.O.A6USU_COD=this.val()},val:function(){return gx.fn.getControlValue("USU_COD")},nac:function(){return  false }};
   this.GXValidFnc[23]={fld:"TEXTBLOCK2", format:0,grid:0};
   this.GXValidFnc[25]={lvl:0,type:"char",len:50,dec:0,sign:false,ro:1,grid:0,gxgrid:null,fnc:null,isvalid:null,fld:"USU_DES",gxz:"Z7USU_DES",gxold:"O7USU_DES",gxvar:"A7USU_DES",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",v2v:function(Value){gx.O.A7USU_DES=Value},v2z:function(Value){gx.O.Z7USU_DES=Value},v2c:function(){gx.fn.setControlValue("USU_DES",gx.O.A7USU_DES,0)},c2v:function(){gx.O.A7USU_DES=this.val()},val:function(){return gx.fn.getControlValue("USU_DES")},nac:function(){return  false }};
   this.GXValidFnc[28]={fld:"TEXTBLOCK3", format:0,grid:0};
   this.GXValidFnc[30]={lvl:0,type:"char",len:20,dec:0,sign:false,isPwd:true,ro:1,grid:0,gxgrid:null,fnc:null,isvalid:null,fld:"USU_CLA",gxz:"Z155USU_CLA",gxold:"O155USU_CLA",gxvar:"A155USU_CLA",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",v2v:function(Value){gx.O.A155USU_CLA=Value},v2z:function(Value){gx.O.Z155USU_CLA=Value},v2c:function(){gx.fn.setControlValue("USU_CLA",gx.O.A155USU_CLA,0)},c2v:function(){gx.O.A155USU_CLA=this.val()},val:function(){return gx.fn.getControlValue("USU_CLA")},nac:function(){return  false }};
   this.GXValidFnc[33]={fld:"TEXTBLOCK4", format:0,grid:0};
   this.GXValidFnc[35]={lvl:0,type:"int",len:3,dec:0,sign:false,pic:"ZZ9",ro:1,grid:0,gxgrid:null,fnc:this.Valid_Sis_cod,isvalid:null,rgrid:[],fld:"SIS_COD",gxz:"Z116SIS_COD",gxold:"O116SIS_COD",gxvar:"A116SIS_COD",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",v2v:function(Value){gx.O.A116SIS_COD=gx.num.intval(Value)},v2z:function(Value){gx.O.Z116SIS_COD=gx.num.intval(Value)},v2c:function(){gx.fn.setControlValue("SIS_COD",gx.O.A116SIS_COD,0)},c2v:function(){gx.O.A116SIS_COD=this.val()},val:function(){return gx.fn.getIntegerValue("SIS_COD",'.')},nac:function(){return  false }};
   this.GXValidFnc[38]={fld:"TEXTBLOCK5", format:0,grid:0};
   this.GXValidFnc[40]={lvl:0,type:"char",len:15,dec:0,sign:false,ro:1,grid:0,gxgrid:null,fnc:null,isvalid:null,fld:"SIS_DES",gxz:"Z259SIS_DES",gxold:"O259SIS_DES",gxvar:"A259SIS_DES",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",v2v:function(Value){gx.O.A259SIS_DES=Value},v2z:function(Value){gx.O.Z259SIS_DES=Value},v2c:function(){gx.fn.setControlValue("SIS_DES",gx.O.A259SIS_DES,0)},c2v:function(){gx.O.A259SIS_DES=this.val()},val:function(){return gx.fn.getControlValue("SIS_DES")},nac:function(){return  false }};
   this.GXValidFnc[43]={fld:"TEXTBLOCK6", format:0,grid:0};
   this.GXValidFnc[45]={lvl:0,type:"int",len:4,dec:0,sign:false,pic:"ZZZ9",ro:0,grid:0,gxgrid:null,fnc:this.Valid_Prg_cod,isvalid:null,rgrid:[],fld:"PRG_COD",gxz:"Z126PRG_COD",gxold:"O126PRG_COD",gxvar:"A126PRG_COD",ucs:[],op:[45,60,55,50],ip:[60,55,50,35,20,45],nacdep:[],ctrltype:"edit",v2v:function(Value){gx.O.A126PRG_COD=gx.num.intval(Value)},v2z:function(Value){gx.O.Z126PRG_COD=gx.num.intval(Value)},v2c:function(){gx.fn.setControlValue("PRG_COD",gx.O.A126PRG_COD,0)},c2v:function(){gx.O.A126PRG_COD=this.val()},val:function(){return gx.fn.getIntegerValue("PRG_COD",'.')},nac:function(){return  (this.Gx_mode == 'UPD') }};
   this.GXValidFnc[48]={fld:"TEXTBLOCK7", format:0,grid:0};
   this.GXValidFnc[50]={lvl:0,type:"char",len:30,dec:0,sign:false,ro:1,grid:0,gxgrid:null,fnc:null,isvalid:null,fld:"PRG_DES",gxz:"Z127PRG_DES",gxold:"O127PRG_DES",gxvar:"A127PRG_DES",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",v2v:function(Value){gx.O.A127PRG_DES=Value},v2z:function(Value){gx.O.Z127PRG_DES=Value},v2c:function(){gx.fn.setControlValue("PRG_DES",gx.O.A127PRG_DES,0)},c2v:function(){gx.O.A127PRG_DES=this.val()},val:function(){return gx.fn.getControlValue("PRG_DES")},nac:function(){return  false }};
   this.GXValidFnc[53]={fld:"TEXTBLOCK8", format:0,grid:0};
   this.GXValidFnc[55]={lvl:0,type:"char",len:8,dec:0,sign:false,ro:1,grid:0,gxgrid:null,fnc:null,isvalid:null,fld:"PRG_NFI",gxz:"Z289PRG_NFI",gxold:"O289PRG_NFI",gxvar:"A289PRG_NFI",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",v2v:function(Value){gx.O.A289PRG_NFI=Value},v2z:function(Value){gx.O.Z289PRG_NFI=Value},v2c:function(){gx.fn.setControlValue("PRG_NFI",gx.O.A289PRG_NFI,0)},c2v:function(){gx.O.A289PRG_NFI=this.val()},val:function(){return gx.fn.getControlValue("PRG_NFI")},nac:function(){return  false }};
   this.GXValidFnc[58]={fld:"TEXTBLOCK9", format:0,grid:0};
   this.GXValidFnc[60]={lvl:0,type:"char",len:1,dec:0,sign:false,ro:1,grid:0,gxgrid:null,fnc:null,isvalid:null,fld:"USU_CNT",gxz:"Z290USU_CNT",gxold:"O290USU_CNT",gxvar:"A290USU_CNT",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",v2v:function(Value){gx.O.A290USU_CNT=Value},v2z:function(Value){gx.O.Z290USU_CNT=Value},v2c:function(){gx.fn.setControlValue("USU_CNT",gx.O.A290USU_CNT,0)},c2v:function(){gx.O.A290USU_CNT=this.val()},val:function(){return gx.fn.getControlValue("USU_CNT")},nac:function(){return  false }};
   this.GXValidFnc[63]={fld:"TEXTBLOCK10", format:0,grid:0};
   this.GXValidFnc[65]={lvl:0,type:"int",len:8,dec:0,sign:false,pic:"ZZZZZZZ9",ro:0,grid:0,gxgrid:null,fnc:this.Valid_Prs_nro,isvalid:null,rgrid:[],fld:"PRS_NRO",gxz:"Z118PRS_NRO",gxold:"O118PRS_NRO",gxvar:"A118PRS_NRO",ucs:[],op:[90,85,80,75,70],ip:[90,85,80,75,70,65,45,35,20],nacdep:[],ctrltype:"edit",v2v:function(Value){gx.O.A118PRS_NRO=gx.num.intval(Value)},v2z:function(Value){gx.O.Z118PRS_NRO=gx.num.intval(Value)},v2c:function(){gx.fn.setControlValue("PRS_NRO",gx.O.A118PRS_NRO,0)},c2v:function(){gx.O.A118PRS_NRO=this.val()},val:function(){return gx.fn.getIntegerValue("PRS_NRO",'.')},nac:function(){return  false }};
   this.GXValidFnc[68]={fld:"TEXTBLOCK11", format:0,grid:0};
   this.GXValidFnc[70]={lvl:0,type:"dtime",len:8,dec:5,sign:false,ro:1,grid:0,gxgrid:null,fnc:null,isvalid:null,fld:"PRS_INI",gxz:"Z166PRS_INI",gxold:"O166PRS_INI",gxvar:"A166PRS_INI",dp:{f:0,st:true,wn:false,mf:false,pic:"99/99/99 99:99",dec:5},ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",v2v:function(Value){gx.O.A166PRS_INI=gx.fn.toDatetimeValue(Value)},v2z:function(Value){gx.O.Z166PRS_INI=gx.fn.toDatetimeValue(Value)},v2c:function(){gx.fn.setControlValue("PRS_INI",gx.O.A166PRS_INI,0)},c2v:function(){gx.O.A166PRS_INI=this.val()},val:function(){return gx.fn.getControlValue("PRS_INI")},nac:function(){return  false }};
   this.GXValidFnc[73]={fld:"TEXTBLOCK12", format:0,grid:0};
   this.GXValidFnc[75]={lvl:0,type:"char",len:20,dec:0,sign:false,ro:1,grid:0,gxgrid:null,fnc:null,isvalid:null,fld:"PRS_UOB",gxz:"Z404PRS_UOB",gxold:"O404PRS_UOB",gxvar:"A404PRS_UOB",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",v2v:function(Value){gx.O.A404PRS_UOB=Value},v2z:function(Value){gx.O.Z404PRS_UOB=Value},v2c:function(){gx.fn.setControlValue("PRS_UOB",gx.O.A404PRS_UOB,0)},c2v:function(){gx.O.A404PRS_UOB=this.val()},val:function(){return gx.fn.getControlValue("PRS_UOB")},nac:function(){return  false }};
   this.GXValidFnc[78]={fld:"TEXTBLOCK13", format:0,grid:0};
   this.GXValidFnc[80]={lvl:0,type:"char",len:30,dec:0,sign:false,ro:1,grid:0,gxgrid:null,fnc:null,isvalid:null,fld:"PRS_UDE",gxz:"Z405PRS_UDE",gxold:"O405PRS_UDE",gxvar:"A405PRS_UDE",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",v2v:function(Value){gx.O.A405PRS_UDE=Value},v2z:function(Value){gx.O.Z405PRS_UDE=Value},v2c:function(){gx.fn.setControlValue("PRS_UDE",gx.O.A405PRS_UDE,0)},c2v:function(){gx.O.A405PRS_UDE=this.val()},val:function(){return gx.fn.getControlValue("PRS_UDE")},nac:function(){return  false }};
   this.GXValidFnc[83]={fld:"TEXTBLOCK14", format:0,grid:0};
   this.GXValidFnc[85]={lvl:0,type:"vchar",len:300,dec:0,sign:false,ro:1,grid:0,gxgrid:null,fnc:null,isvalid:null,fld:"PRS_ULNK",gxz:"Z406PRS_ULNK",gxold:"O406PRS_ULNK",gxvar:"A406PRS_ULNK",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",v2v:function(Value){gx.O.A406PRS_ULNK=Value},v2z:function(Value){gx.O.Z406PRS_ULNK=Value},v2c:function(){gx.fn.setControlValue("PRS_ULNK",gx.O.A406PRS_ULNK,0)},c2v:function(){gx.O.A406PRS_ULNK=this.val()},val:function(){return gx.fn.getControlValue("PRS_ULNK")},nac:function(){return  false }};
   this.GXValidFnc[88]={fld:"TEXTBLOCK15", format:0,grid:0};
   this.GXValidFnc[90]={lvl:0,type:"dtime",len:8,dec:5,sign:false,ro:1,grid:0,gxgrid:null,fnc:null,isvalid:null,fld:"PRS_CAD",gxz:"Z165PRS_CAD",gxold:"O165PRS_CAD",gxvar:"A165PRS_CAD",dp:{f:0,st:true,wn:false,mf:false,pic:"99/99/99 99:99",dec:5},ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",v2v:function(Value){gx.O.A165PRS_CAD=gx.fn.toDatetimeValue(Value)},v2z:function(Value){gx.O.Z165PRS_CAD=gx.fn.toDatetimeValue(Value)},v2c:function(){gx.fn.setControlValue("PRS_CAD",gx.O.A165PRS_CAD,0)},c2v:function(){gx.O.A165PRS_CAD=this.val()},val:function(){return gx.fn.getControlValue("PRS_CAD")},nac:function(){return  false }};
   this.GXValidFnc[93]={fld:"TEXTBLOCK16", format:0,grid:0};
   this.GXValidFnc[95]={lvl:0,type:"int",len:3,dec:0,sign:false,pic:"ZZ9",ro:0,grid:0,gxgrid:null,fnc:this.Valid_Prs_ord,isvalid:null,rgrid:[],fld:"PRS_ORD",gxz:"Z407PRS_ORD",gxold:"O407PRS_ORD",gxvar:"A407PRS_ORD",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",v2v:function(Value){gx.O.A407PRS_ORD=gx.num.intval(Value)},v2z:function(Value){gx.O.Z407PRS_ORD=gx.num.intval(Value)},v2c:function(){gx.fn.setControlValue("PRS_ORD",gx.O.A407PRS_ORD,0)},c2v:function(){gx.O.A407PRS_ORD=this.val()},val:function(){return gx.fn.getIntegerValue("PRS_ORD",'.')},nac:function(){return  false }};
   this.GXValidFnc[99]={fld:"TEXTBLOCK17", format:0,grid:0};
   this.GXValidFnc[101]={lvl:0,type:"char",len:30,dec:0,sign:false,ro:0,grid:0,gxgrid:null,fnc:null,isvalid:null,fld:"PRS_DES",gxz:"Z408PRS_DES",gxold:"O408PRS_DES",gxvar:"A408PRS_DES",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",v2v:function(Value){gx.O.A408PRS_DES=Value},v2z:function(Value){gx.O.Z408PRS_DES=Value},v2c:function(){gx.fn.setControlValue("PRS_DES",gx.O.A408PRS_DES,0)},c2v:function(){gx.O.A408PRS_DES=this.val()},val:function(){return gx.fn.getControlValue("PRS_DES")},nac:function(){return  false }};
   this.GXValidFnc[104]={fld:"TEXTBLOCK18", format:0,grid:0};
   this.GXValidFnc[106]={lvl:0,type:"vchar",len:300,dec:0,sign:false,ro:0,grid:0,gxgrid:null,fnc:null,isvalid:null,fld:"PRS_LINK",gxz:"Z409PRS_LINK",gxold:"O409PRS_LINK",gxvar:"A409PRS_LINK",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",v2v:function(Value){gx.O.A409PRS_LINK=Value},v2z:function(Value){gx.O.Z409PRS_LINK=Value},v2c:function(){gx.fn.setControlValue("PRS_LINK",gx.O.A409PRS_LINK,0)},c2v:function(){gx.O.A409PRS_LINK=this.val()},val:function(){return gx.fn.getControlValue("PRS_LINK")},nac:function(){return  false }};
   this.GXValidFnc[114]={fld:"PROMPT_126",grid:35};
   this.GXValidFnc[115]={fld:"PROMPT_118",grid:35};
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
   this.A126PRG_COD = 0 ;
   this.Z126PRG_COD = 0 ;
   this.O126PRG_COD = 0 ;
   this.A127PRG_DES = "" ;
   this.Z127PRG_DES = "" ;
   this.O127PRG_DES = "" ;
   this.A289PRG_NFI = "" ;
   this.Z289PRG_NFI = "" ;
   this.O289PRG_NFI = "" ;
   this.A290USU_CNT = "" ;
   this.Z290USU_CNT = "" ;
   this.O290USU_CNT = "" ;
   this.A118PRS_NRO = 0 ;
   this.Z118PRS_NRO = 0 ;
   this.O118PRS_NRO = 0 ;
   this.A166PRS_INI = gx.date.nullDate() ;
   this.Z166PRS_INI = gx.date.nullDate() ;
   this.O166PRS_INI = gx.date.nullDate() ;
   this.A404PRS_UOB = "" ;
   this.Z404PRS_UOB = "" ;
   this.O404PRS_UOB = "" ;
   this.A405PRS_UDE = "" ;
   this.Z405PRS_UDE = "" ;
   this.O405PRS_UDE = "" ;
   this.A406PRS_ULNK = "" ;
   this.Z406PRS_ULNK = "" ;
   this.O406PRS_ULNK = "" ;
   this.A165PRS_CAD = gx.date.nullDate() ;
   this.Z165PRS_CAD = gx.date.nullDate() ;
   this.O165PRS_CAD = gx.date.nullDate() ;
   this.A407PRS_ORD = 0 ;
   this.Z407PRS_ORD = 0 ;
   this.O407PRS_ORD = 0 ;
   this.A408PRS_DES = "" ;
   this.Z408PRS_DES = "" ;
   this.O408PRS_DES = "" ;
   this.A409PRS_LINK = "" ;
   this.Z409PRS_LINK = "" ;
   this.O409PRS_LINK = "" ;
   this.AV9PRGCOD = 0 ;
   this.AV7SISTEMA = "" ;
   this.AV8USUARIO = "" ;
   this.Gx_mode = "" ;
   this.ServerEvents = ["e111135_client" ,"e121135_client"];
   this.setPrompt("PROMPT_126", [45]);
   this.setPrompt("PROMPT_118", [65]);
   this.EnterCtrl = ["BTN_ENTER"];
   this.CheckCtrl = ["BTN_CHECK"];
   this.VarControlMap["AV9PRGCOD"] = {id:"vPRGCOD",grid:0,type:"int"};
   this.VarControlMap["Gx_mode"] = {id:"vMODE",grid:0,type:"char"};
   this.VarControlMap["AV7SISTEMA"] = {id:"vSISTEMA",grid:0,type:"char"};
   this.VarControlMap["AV8USUARIO"] = {id:"vUSUARIO",grid:0,type:"char"};
   this.SetStandaloneVars( );
}
tseg007.prototype = new gx.GxObject;
gx.setParentObj(new tseg007());
