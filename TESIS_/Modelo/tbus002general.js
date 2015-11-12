/*
               File: TBUS002General
        Description: TBUS002 General
             Author: GeneXus C# Generator version 10_1_5-42940
       Generated on: 1/6/2014 11:8:11.38
       Program type: Callable routine
          Main DBMS: sqlserver
*/
gx.evt.autoSkip = false;
function tbus002general(CmpContext) {
   this.ServerClass =  "TBUS002General" ;
   this.PackageName =  "GeneXus.Programs" ;
   this.setObjectType("web");
   this.setCmpContext(CmpContext);
   this.ReadonlyForm = true;
   this.hasEnterEvent = false;
   this.autoRefresh = true;
   this.SetStandaloneVars=function()
   {
   };
   this.Valid_Rbr_cod=function()
   {
      try {
         var gxballoon = gx.util.balloon.getNew("RBR_COD");
         this.AnyError  = 0;

      }
      catch(e){}
      try {
         if (gxballoon == null) return true; return gxballoon.show();
      }
      catch(e){}
      return true ;
   }
   this.e13472_client=function()
   {
      this.executeServerEvent("'DOUPDATE'", false);
   };
   this.e14472_client=function()
   {
      this.executeServerEvent("'DODELETE'", false);
   };
   this.e15472_client=function()
   {
      this.executeServerEvent("ENTER", true);
   };
   this.e16472_client=function()
   {
      this.executeServerEvent("CANCEL", true);
   };
   this.GXValidFnc = [];
   this.GXCtrlIds=[2,7,12,17,22];
   this.GXLastCtrlId =22;
   this.GXValidFnc[2]={fld:"TBL2",grid:0};
   this.GXValidFnc[5]={fld:"TEXTBLOCKRBR_COD", format:0,grid:0};
   this.GXValidFnc[7]={lvl:0,type:"int",len:4,dec:0,sign:false,pic:"ZZZ9",ro:1,grid:0,gxgrid:null,fnc:this.Valid_Rbr_cod,isvalid:null,rgrid:[],fld:"RBR_COD",gxz:"Z2RBR_COD",gxold:"O2RBR_COD",gxvar:"A2RBR_COD",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",v2v:function(Value){gx.O.A2RBR_COD=gx.num.intval(Value)},v2z:function(Value){gx.O.Z2RBR_COD=gx.num.intval(Value)},v2c:function(){gx.fn.setControlValue("RBR_COD",gx.O.A2RBR_COD,0)},c2v:function(){gx.O.A2RBR_COD=this.val()},val:function(){return gx.fn.getIntegerValue("RBR_COD",'.')},nac:function(){return  false }};
   this.GXValidFnc[10]={fld:"TEXTBLOCKRBR_DES", format:0,grid:0};
   this.GXValidFnc[12]={lvl:0,type:"char",len:30,dec:0,sign:false,ro:1,grid:0,gxgrid:null,fnc:null,isvalid:null,fld:"RBR_DES",gxz:"Z19RBR_DES",gxold:"O19RBR_DES",gxvar:"A19RBR_DES",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",v2v:function(Value){gx.O.A19RBR_DES=Value},v2z:function(Value){gx.O.Z19RBR_DES=Value},v2c:function(){gx.fn.setControlValue("RBR_DES",gx.O.A19RBR_DES,0)},c2v:function(){gx.O.A19RBR_DES=this.val()},val:function(){return gx.fn.getControlValue("RBR_DES")},nac:function(){return  false }};
   this.GXValidFnc[15]={fld:"TEXTBLOCKRBR_AEA", format:0,grid:0};
   this.GXValidFnc[17]={lvl:0,type:"decimal",len:10,dec:2,sign:false,pic:"ZZZZZZ9.99",ro:1,grid:0,gxgrid:null,fnc:null,isvalid:null,rgrid:[],fld:"RBR_AEA",gxz:"Z197RBR_AEA",gxold:"O197RBR_AEA",gxvar:"A197RBR_AEA",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",v2v:function(Value){gx.O.A197RBR_AEA=gx.fn.toDecimalValue(Value,',','.')},v2z:function(Value){gx.O.Z197RBR_AEA=gx.fn.toDecimalValue(Value,'.',',')},v2c:function(){gx.fn.setDecimalValue("RBR_AEA",gx.O.A197RBR_AEA,2,',')},c2v:function(){gx.O.A197RBR_AEA=this.val()},val:function(){return gx.fn.getDecimalValue("RBR_AEA",'.',',')},nac:function(){return  false }};
   this.GXValidFnc[20]={fld:"TEXTBLOCKRBR_AMO", format:0,grid:0};
   this.GXValidFnc[22]={lvl:0,type:"char",len:1,dec:0,sign:false,ro:1,grid:0,gxgrid:null,fnc:null,isvalid:null,fld:"RBR_AMO",gxz:"Z179RBR_AMO",gxold:"O179RBR_AMO",gxvar:"A179RBR_AMO",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",v2v:function(Value){gx.O.A179RBR_AMO=Value},v2z:function(Value){gx.O.Z179RBR_AMO=Value},v2c:function(){gx.fn.setControlValue("RBR_AMO",gx.O.A179RBR_AMO,0)},c2v:function(){gx.O.A179RBR_AMO=this.val()},val:function(){return gx.fn.getControlValue("RBR_AMO")},nac:function(){return  false }};
   this.A2RBR_COD = 0 ;
   this.Z2RBR_COD = 0 ;
   this.O2RBR_COD = 0 ;
   this.A19RBR_DES = "" ;
   this.Z19RBR_DES = "" ;
   this.O19RBR_DES = "" ;
   this.A197RBR_AEA = 0 ;
   this.Z197RBR_AEA = 0 ;
   this.O197RBR_AEA = 0 ;
   this.A179RBR_AMO = "" ;
   this.Z179RBR_AMO = "" ;
   this.O179RBR_AMO = "" ;
   this.ServerEvents = ["e13472_client" ,"e14472_client" ,"e15472_client" ,"e16472_client"];
   this.SetStandaloneVars( );
}
