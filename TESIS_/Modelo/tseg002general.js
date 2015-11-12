/*
               File: TSEG002General
        Description: TSEG002 General
             Author: GeneXus C# Generator version 10_1_5-42940
       Generated on: 1/6/2014 11:8:23.71
       Program type: Callable routine
          Main DBMS: sqlserver
*/
gx.evt.autoSkip = false;
function tseg002general(CmpContext) {
   this.ServerClass =  "TSEG002General" ;
   this.PackageName =  "GeneXus.Programs" ;
   this.setObjectType("web");
   this.setCmpContext(CmpContext);
   this.ReadonlyForm = true;
   this.hasEnterEvent = false;
   this.autoRefresh = true;
   this.SetStandaloneVars=function()
   {
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
   this.e130g2_client=function()
   {
      this.executeServerEvent("'DOUPDATE'", false);
   };
   this.e140g2_client=function()
   {
      this.executeServerEvent("'DODELETE'", false);
   };
   this.e150g2_client=function()
   {
      this.executeServerEvent("ENTER", true);
   };
   this.e160g2_client=function()
   {
      this.executeServerEvent("CANCEL", true);
   };
   this.GXValidFnc = [];
   this.GXCtrlIds=[2,7,12,17,22,27,32,37,42,47,52,57,62,67,72,75];
   this.GXLastCtrlId =75;
   this.GXValidFnc[2]={fld:"TBL2",grid:0};
   this.GXValidFnc[5]={fld:"TEXTBLOCKUSU_COD", format:0,grid:0};
   this.GXValidFnc[7]={lvl:0,type:"char",len:16,dec:0,sign:false,ro:1,grid:0,gxgrid:null,fnc:this.Valid_Usu_cod,isvalid:null,fld:"USU_COD",gxz:"Z6USU_COD",gxold:"O6USU_COD",gxvar:"A6USU_COD",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",v2v:function(Value){gx.O.A6USU_COD=Value},v2z:function(Value){gx.O.Z6USU_COD=Value},v2c:function(){gx.fn.setControlValue("USU_COD",gx.O.A6USU_COD,0)},c2v:function(){gx.O.A6USU_COD=this.val()},val:function(){return gx.fn.getControlValue("USU_COD")},nac:function(){return  false }};
   this.GXValidFnc[10]={fld:"TEXTBLOCKUSU_DES", format:0,grid:0};
   this.GXValidFnc[12]={lvl:0,type:"char",len:50,dec:0,sign:false,ro:1,grid:0,gxgrid:null,fnc:null,isvalid:null,fld:"USU_DES",gxz:"Z7USU_DES",gxold:"O7USU_DES",gxvar:"A7USU_DES",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",v2v:function(Value){gx.O.A7USU_DES=Value},v2z:function(Value){gx.O.Z7USU_DES=Value},v2c:function(){gx.fn.setControlValue("USU_DES",gx.O.A7USU_DES,0)},c2v:function(){gx.O.A7USU_DES=this.val()},val:function(){return gx.fn.getControlValue("USU_DES")},nac:function(){return  false }};
   this.GXValidFnc[15]={fld:"TEXTBLOCKUSU_FEC", format:0,grid:0};
   this.GXValidFnc[17]={lvl:0,type:"date",len:10,dec:0,sign:false,ro:1,grid:0,gxgrid:null,fnc:null,isvalid:null,fld:"USU_FEC",gxz:"Z156USU_FEC",gxold:"O156USU_FEC",gxvar:"A156USU_FEC",dp:{f:0,st:false,wn:false,mf:false,pic:"99/99/9999",dec:0},ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",v2v:function(Value){gx.O.A156USU_FEC=gx.fn.toDatetimeValue(Value)},v2z:function(Value){gx.O.Z156USU_FEC=gx.fn.toDatetimeValue(Value)},v2c:function(){gx.fn.setControlValue("USU_FEC",gx.O.A156USU_FEC,0)},c2v:function(){gx.O.A156USU_FEC=this.val()},val:function(){return gx.fn.getControlValue("USU_FEC")},nac:function(){return  false }};
   this.GXValidFnc[20]={fld:"TEXTBLOCKUSU_CDA", format:0,grid:0};
   this.GXValidFnc[22]={lvl:0,type:"char",len:8,dec:0,sign:false,ro:1,grid:0,gxgrid:null,fnc:null,isvalid:null,fld:"USU_CDA",gxz:"Z250USU_CDA",gxold:"O250USU_CDA",gxvar:"A250USU_CDA",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",v2v:function(Value){gx.O.A250USU_CDA=Value},v2z:function(Value){gx.O.Z250USU_CDA=Value},v2c:function(){gx.fn.setControlValue("USU_CDA",gx.O.A250USU_CDA,0)},c2v:function(){gx.O.A250USU_CDA=this.val()},val:function(){return gx.fn.getControlValue("USU_CDA")},nac:function(){return  false }};
   this.GXValidFnc[25]={fld:"TEXTBLOCKUSU_EMP", format:0,grid:0};
   this.GXValidFnc[27]={lvl:0,type:"char",len:3,dec:0,sign:false,ro:1,grid:0,gxgrid:null,fnc:null,isvalid:null,fld:"USU_EMP",gxz:"Z251USU_EMP",gxold:"O251USU_EMP",gxvar:"A251USU_EMP",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",v2v:function(Value){gx.O.A251USU_EMP=Value},v2z:function(Value){gx.O.Z251USU_EMP=Value},v2c:function(){gx.fn.setControlValue("USU_EMP",gx.O.A251USU_EMP,0)},c2v:function(){gx.O.A251USU_EMP=this.val()},val:function(){return gx.fn.getControlValue("USU_EMP")},nac:function(){return  false }};
   this.GXValidFnc[30]={fld:"TEXTBLOCKUSU_LEG", format:0,grid:0};
   this.GXValidFnc[32]={lvl:0,type:"int",len:5,dec:0,sign:false,pic:"ZZZZ9",ro:1,grid:0,gxgrid:null,fnc:null,isvalid:null,rgrid:[],fld:"USU_LEG",gxz:"Z252USU_LEG",gxold:"O252USU_LEG",gxvar:"A252USU_LEG",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",v2v:function(Value){gx.O.A252USU_LEG=gx.num.intval(Value)},v2z:function(Value){gx.O.Z252USU_LEG=gx.num.intval(Value)},v2c:function(){gx.fn.setControlValue("USU_LEG",gx.O.A252USU_LEG,0)},c2v:function(){gx.O.A252USU_LEG=this.val()},val:function(){return gx.fn.getIntegerValue("USU_LEG",'.')},nac:function(){return  false }};
   this.GXValidFnc[35]={fld:"TEXTBLOCKUSU_INT", format:0,grid:0};
   this.GXValidFnc[37]={lvl:0,type:"char",len:10,dec:0,sign:false,ro:1,grid:0,gxgrid:null,fnc:null,isvalid:null,fld:"USU_INT",gxz:"Z180USU_INT",gxold:"O180USU_INT",gxvar:"A180USU_INT",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",v2v:function(Value){gx.O.A180USU_INT=Value},v2z:function(Value){gx.O.Z180USU_INT=Value},v2c:function(){gx.fn.setControlValue("USU_INT",gx.O.A180USU_INT,0)},c2v:function(){gx.O.A180USU_INT=this.val()},val:function(){return gx.fn.getControlValue("USU_INT")},nac:function(){return  false }};
   this.GXValidFnc[40]={fld:"TEXTBLOCKUSU_CLAK", format:0,grid:0};
   this.GXValidFnc[42]={lvl:0,type:"char",len:32,dec:0,sign:false,ro:1,grid:0,gxgrid:null,fnc:null,isvalid:null,fld:"USU_CLAK",gxz:"Z253USU_CLAK",gxold:"O253USU_CLAK",gxvar:"A253USU_CLAK",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",v2v:function(Value){gx.O.A253USU_CLAK=Value},v2z:function(Value){gx.O.Z253USU_CLAK=Value},v2c:function(){gx.fn.setControlValue("USU_CLAK",gx.O.A253USU_CLAK,0)},c2v:function(){gx.O.A253USU_CLAK=this.val()},val:function(){return gx.fn.getControlValue("USU_CLAK")},nac:function(){return  false }};
   this.GXValidFnc[45]={fld:"TEXTBLOCKUSU_MAIW", format:0,grid:0};
   this.GXValidFnc[47]={lvl:0,type:"svchar",len:256,dec:0,sign:false,ro:1,grid:0,gxgrid:null,fnc:null,isvalid:null,fld:"USU_MAIW",gxz:"Z249USU_MAIW",gxold:"O249USU_MAIW",gxvar:"A249USU_MAIW",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",v2v:function(Value){gx.O.A249USU_MAIW=Value},v2z:function(Value){gx.O.Z249USU_MAIW=Value},v2c:function(){gx.fn.setControlValue("USU_MAIW",gx.O.A249USU_MAIW,0)},c2v:function(){gx.O.A249USU_MAIW=this.val()},val:function(){return gx.fn.getControlValue("USU_MAIW")},nac:function(){return  false }};
   this.GXValidFnc[50]={fld:"TEXTBLOCKUSU_TIPW", format:0,grid:0};
   this.GXValidFnc[52]={lvl:0,type:"char",len:1,dec:0,sign:false,ro:1,grid:0,gxgrid:null,fnc:null,isvalid:null,fld:"USU_TIPW",gxz:"Z254USU_TIPW",gxold:"O254USU_TIPW",gxvar:"A254USU_TIPW",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",v2v:function(Value){gx.O.A254USU_TIPW=Value},v2z:function(Value){gx.O.Z254USU_TIPW=Value},v2c:function(){gx.fn.setControlValue("USU_TIPW",gx.O.A254USU_TIPW,0)},c2v:function(){gx.O.A254USU_TIPW=this.val()},val:function(){return gx.fn.getControlValue("USU_TIPW")},nac:function(){return  false }};
   this.GXValidFnc[55]={fld:"TEXTBLOCKUSU_NROW", format:0,grid:0};
   this.GXValidFnc[57]={lvl:0,type:"int",len:11,dec:0,sign:false,pic:"ZZZZZZZZZZ9",ro:1,grid:0,gxgrid:null,fnc:null,isvalid:null,rgrid:[],fld:"USU_NROW",gxz:"Z255USU_NROW",gxold:"O255USU_NROW",gxvar:"A255USU_NROW",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",v2v:function(Value){gx.O.A255USU_NROW=gx.num.intval(Value)},v2z:function(Value){gx.O.Z255USU_NROW=gx.num.intval(Value)},v2c:function(){gx.fn.setControlValue("USU_NROW",gx.O.A255USU_NROW,0)},c2v:function(){gx.O.A255USU_NROW=this.val()},val:function(){return gx.fn.getIntegerValue("USU_NROW",'.')},nac:function(){return  false }};
   this.GXValidFnc[60]={fld:"TEXTBLOCKUSU_STS", format:0,grid:0};
   this.GXValidFnc[62]={lvl:0,type:"int",len:2,dec:0,sign:true,pic:"Z9",ro:1,grid:0,gxgrid:null,fnc:null,isvalid:null,rgrid:[],fld:"USU_STS",gxz:"Z256USU_STS",gxold:"O256USU_STS",gxvar:"A256USU_STS",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",v2v:function(Value){gx.O.A256USU_STS=gx.num.intval(Value)},v2z:function(Value){gx.O.Z256USU_STS=gx.num.intval(Value)},v2c:function(){gx.fn.setControlValue("USU_STS",gx.O.A256USU_STS,0)},c2v:function(){gx.O.A256USU_STS=this.val()},val:function(){return gx.fn.getIntegerValue("USU_STS",'.')},nac:function(){return  false }};
   this.GXValidFnc[65]={fld:"TEXTBLOCKUSU_ACTIV", format:0,grid:0};
   this.GXValidFnc[67]={lvl:0,type:"dtime",len:8,dec:5,sign:false,ro:1,grid:0,gxgrid:null,fnc:null,isvalid:null,fld:"USU_ACTIV",gxz:"Z257USU_ACTIV",gxold:"O257USU_ACTIV",gxvar:"A257USU_ACTIV",dp:{f:0,st:true,wn:false,mf:false,pic:"99/99/99 99:99",dec:5},ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",v2v:function(Value){gx.O.A257USU_ACTIV=gx.fn.toDatetimeValue(Value)},v2z:function(Value){gx.O.Z257USU_ACTIV=gx.fn.toDatetimeValue(Value)},v2c:function(){gx.fn.setControlValue("USU_ACTIV",gx.O.A257USU_ACTIV,0)},c2v:function(){gx.O.A257USU_ACTIV=this.val()},val:function(){return gx.fn.getControlValue("USU_ACTIV")},nac:function(){return  false }};
   this.GXValidFnc[70]={fld:"TEXTBLOCKUSU_ERR", format:0,grid:0};
   this.GXValidFnc[72]={lvl:0,type:"int",len:4,dec:0,sign:false,pic:"ZZZ9",ro:1,grid:0,gxgrid:null,fnc:null,isvalid:null,rgrid:[],fld:"USU_ERR",gxz:"Z258USU_ERR",gxold:"O258USU_ERR",gxvar:"A258USU_ERR",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",v2v:function(Value){gx.O.A258USU_ERR=gx.num.intval(Value)},v2z:function(Value){gx.O.Z258USU_ERR=gx.num.intval(Value)},v2c:function(){gx.fn.setControlValue("USU_ERR",gx.O.A258USU_ERR,0)},c2v:function(){gx.O.A258USU_ERR=this.val()},val:function(){return gx.fn.getIntegerValue("USU_ERR",'.')},nac:function(){return  false }};
   this.GXValidFnc[75]={lvl:0,type:"char",len:20,dec:0,sign:false,isPwd:true,ro:1,grid:0,gxgrid:null,fnc:null,isvalid:null,fld:"USU_CLA",gxz:"Z155USU_CLA",gxold:"O155USU_CLA",gxvar:"A155USU_CLA",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",v2v:function(Value){gx.O.A155USU_CLA=Value},v2z:function(Value){gx.O.Z155USU_CLA=Value},v2c:function(){gx.fn.setControlValue("USU_CLA",gx.O.A155USU_CLA,0)},c2v:function(){gx.O.A155USU_CLA=this.val()},val:function(){return gx.fn.getControlValue("USU_CLA")},nac:function(){return  false }};
   this.A6USU_COD = "" ;
   this.Z6USU_COD = "" ;
   this.O6USU_COD = "" ;
   this.A7USU_DES = "" ;
   this.Z7USU_DES = "" ;
   this.O7USU_DES = "" ;
   this.A156USU_FEC = gx.date.nullDate() ;
   this.Z156USU_FEC = gx.date.nullDate() ;
   this.O156USU_FEC = gx.date.nullDate() ;
   this.A250USU_CDA = "" ;
   this.Z250USU_CDA = "" ;
   this.O250USU_CDA = "" ;
   this.A251USU_EMP = "" ;
   this.Z251USU_EMP = "" ;
   this.O251USU_EMP = "" ;
   this.A252USU_LEG = 0 ;
   this.Z252USU_LEG = 0 ;
   this.O252USU_LEG = 0 ;
   this.A180USU_INT = "" ;
   this.Z180USU_INT = "" ;
   this.O180USU_INT = "" ;
   this.A253USU_CLAK = "" ;
   this.Z253USU_CLAK = "" ;
   this.O253USU_CLAK = "" ;
   this.A249USU_MAIW = "" ;
   this.Z249USU_MAIW = "" ;
   this.O249USU_MAIW = "" ;
   this.A254USU_TIPW = "" ;
   this.Z254USU_TIPW = "" ;
   this.O254USU_TIPW = "" ;
   this.A255USU_NROW = 0 ;
   this.Z255USU_NROW = 0 ;
   this.O255USU_NROW = 0 ;
   this.A256USU_STS = 0 ;
   this.Z256USU_STS = 0 ;
   this.O256USU_STS = 0 ;
   this.A257USU_ACTIV = gx.date.nullDate() ;
   this.Z257USU_ACTIV = gx.date.nullDate() ;
   this.O257USU_ACTIV = gx.date.nullDate() ;
   this.A258USU_ERR = 0 ;
   this.Z258USU_ERR = 0 ;
   this.O258USU_ERR = 0 ;
   this.A155USU_CLA = "" ;
   this.Z155USU_CLA = "" ;
   this.O155USU_CLA = "" ;
   this.ServerEvents = ["e130g2_client" ,"e140g2_client" ,"e150g2_client" ,"e160g2_client"];
   this.SetStandaloneVars( );
}
