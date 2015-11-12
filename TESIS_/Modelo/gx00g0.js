/*
               File: Gx00G0
        Description: Selection List SEG003
             Author: GeneXus C# Generator version 10_1_5-42940
       Generated on: 1/6/2014 11:8:24.94
       Program type: Callable routine
          Main DBMS: sqlserver
*/
gx.evt.autoSkip = false;
function gx00g0() {
   this.ServerClass =  "Gx00G0" ;
   this.PackageName =  "GeneXus.Programs" ;
   this.setObjectType("web");
   this.hasEnterEvent = true;
   this.autoRefresh = true;
   this.SetStandaloneVars=function()
   {
      this.AV9pUSU_COD=gx.fn.getControlValue("vPUSU_COD") ;
      this.AV10pSIS_COD=gx.fn.getIntegerValue("vPSIS_COD",'.') ;
   };
   this.e132s2_client=function()
   {
      this.executeServerEvent("ENTER", true, arguments[0]);
   };
   this.e142s2_client=function()
   {
      this.executeServerEvent("CANCEL", true, arguments[0]);
   };
   this.GXValidFnc = [];
   this.GXCtrlIds=[2,8,9,14,19,22,23,27,28,29,32];
   this.GXLastCtrlId =32;
   this.Grid1Container = new gx.grid.grid(this, 2,"WbpLvl2",26,"Grid1","Grid1","Grid1Container",this.CmpContext,this.IsMasterPage,"gx00g0",[],false,1,false,true,10,true,false,false,"",0,"px","Nueva fila",true,false,false,null,null,false,"");
   this.Grid1Container.addBitmap("&Linkselection","vLINKSELECTION",27,0,"px",17,"px",null,"","");
   this.Grid1Container.addSingleLineEdit(6,28,"USU_COD","CODIGO","","USU_COD","char",0,"px",16,16,"left",null,[],6,"USU_COD",true,0,false,false);
   this.Grid1Container.addSingleLineEdit(116,29,"SIS_COD","CODIGO","Seleccionar","SIS_COD","int",0,"px",3,3,"right",null,[],116,"SIS_COD",true,0,false,false);
   this.setGrid(this.Grid1Container);
   this.GXValidFnc[2]={fld:"TABLE1",grid:0};
   this.GXValidFnc[8]={fld:"GROUP1",grid:0};
   this.GXValidFnc[9]={fld:"TABLE2",grid:0};
   this.GXValidFnc[12]={fld:"TEXTBLOCKUSU_COD", format:0,grid:0};
   this.GXValidFnc[14]={lvl:0,type:"char",len:16,dec:0,sign:false,ro:0,grid:0,gxgrid:null,fnc:null,isvalid:null,fld:"vCUSU_COD",gxz:"ZV6cUSU_COD",gxold:"OV6cUSU_COD",gxvar:"AV6cUSU_COD",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",v2v:function(Value){gx.O.AV6cUSU_COD=Value},v2z:function(Value){gx.O.ZV6cUSU_COD=Value},v2c:function(){gx.fn.setControlValue("vCUSU_COD",gx.O.AV6cUSU_COD,0)},c2v:function(){gx.O.AV6cUSU_COD=this.val()},val:function(){return gx.fn.getControlValue("vCUSU_COD")},nac:function(){return  false }};
   this.GXValidFnc[17]={fld:"TEXTBLOCKSIS_COD", format:0,grid:0};
   this.GXValidFnc[19]={lvl:0,type:"int",len:3,dec:0,sign:false,pic:"ZZ9",ro:0,grid:0,gxgrid:null,fnc:null,isvalid:null,rgrid:[this.Grid1Container],fld:"vCSIS_COD",gxz:"ZV7cSIS_COD",gxold:"OV7cSIS_COD",gxvar:"AV7cSIS_COD",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",v2v:function(Value){gx.O.AV7cSIS_COD=gx.num.intval(Value)},v2z:function(Value){gx.O.ZV7cSIS_COD=gx.num.intval(Value)},v2c:function(){gx.fn.setControlValue("vCSIS_COD",gx.O.AV7cSIS_COD,0)},c2v:function(){gx.O.AV7cSIS_COD=this.val()},val:function(){return gx.fn.getIntegerValue("vCSIS_COD",'.')},nac:function(){return  false }};
   this.GXValidFnc[22]={fld:"GROUP2",grid:0};
   this.GXValidFnc[23]={fld:"TABLE3",grid:0};
   this.GXValidFnc[27]={lvl:2,type:"bits",len:4,dec:0,sign:false,ro:1,grid:26,gxgrid:this.Grid1Container,fnc:null,isvalid:null,fld:"vLINKSELECTION",gxz:"ZV5LinkSelection",gxold:"OV5LinkSelection",gxvar:"AV5LinkSelection",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",v2v:function(Value){gx.O.AV5LinkSelection=Value},v2z:function(Value){gx.O.ZV5LinkSelection=Value},v2c:function(){},c2v:function(){gx.O.AV5LinkSelection=this.val()},val:function(){return gx.fn.getGridControlValue("vLINKSELECTION",gx.fn.currentGridRowImpl(26))},nac:function(){return  false }};
   this.GXValidFnc[28]={lvl:2,type:"char",len:16,dec:0,sign:false,ro:1,grid:26,gxgrid:this.Grid1Container,fnc:null,isvalid:null,fld:"USU_COD",gxz:"Z6USU_COD",gxold:"O6USU_COD",gxvar:"A6USU_COD",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",v2v:function(Value){gx.O.A6USU_COD=Value},v2z:function(Value){gx.O.Z6USU_COD=Value},v2c:function(){gx.fn.setGridControlValue("USU_COD",gx.fn.currentGridRowImpl(26),gx.O.A6USU_COD,0)},c2v:function(){gx.O.A6USU_COD=this.val()},val:function(){return gx.fn.getGridControlValue("USU_COD",gx.fn.currentGridRowImpl(26))},nac:function(){return  false }};
   this.GXValidFnc[29]={lvl:2,type:"int",len:3,dec:0,sign:false,pic:"ZZ9",ro:1,grid:26,gxgrid:this.Grid1Container,fnc:null,isvalid:null,rgrid:[],fld:"SIS_COD",gxz:"Z116SIS_COD",gxold:"O116SIS_COD",gxvar:"A116SIS_COD",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",v2v:function(Value){gx.O.A116SIS_COD=gx.num.intval(Value)},v2z:function(Value){gx.O.Z116SIS_COD=gx.num.intval(Value)},v2c:function(){gx.fn.setGridControlValue("SIS_COD",gx.fn.currentGridRowImpl(26),gx.O.A116SIS_COD,0)},c2v:function(){gx.O.A116SIS_COD=this.val()},val:function(){return gx.fn.getGridIntegerValue("SIS_COD",gx.fn.currentGridRowImpl(26),'.')},nac:function(){return  false }};
   this.GXValidFnc[32]={fld:"TABLE4",grid:0};
   this.AV6cUSU_COD = "" ;
   this.ZV6cUSU_COD = "" ;
   this.OV6cUSU_COD = "" ;
   this.AV7cSIS_COD = 0 ;
   this.ZV7cSIS_COD = 0 ;
   this.OV7cSIS_COD = 0 ;
   this.ZV5LinkSelection = "" ;
   this.OV5LinkSelection = "" ;
   this.Z6USU_COD = "" ;
   this.O6USU_COD = "" ;
   this.Z116SIS_COD = 0 ;
   this.O116SIS_COD = 0 ;
   this.AV9pUSU_COD = "" ;
   this.AV10pSIS_COD = 0 ;
   this.AV5LinkSelection = "" ;
   this.A6USU_COD = "" ;
   this.A116SIS_COD = 0 ;
   this.ServerEvents = ["e132s2_client" ,"e142s2_client"];
   this.VarControlMap["AV9pUSU_COD"] = {id:"vPUSU_COD",grid:0,type:"char"};
   this.VarControlMap["AV10pSIS_COD"] = {id:"vPSIS_COD",grid:0,type:"int"};
   this.Grid1Container.addRefreshingVar(this.GXValidFnc[14]);
   this.Grid1Container.addRefreshingVar(this.GXValidFnc[19]);
   this.SetStandaloneVars( );
}
gx00g0.prototype = new gx.GxObject;
gx.setParentObj(new gx00g0());
