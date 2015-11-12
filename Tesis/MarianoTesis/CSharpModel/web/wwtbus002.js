/*
               File: WWTBUS002
        Description: Work With ACTUALIZ. DE RUBROS
             Author: GeneXus C# Generator version 10_1_5-42940
       Generated on: 1/6/2014 11:8:10.92
       Program type: Callable routine
          Main DBMS: sqlserver
*/
gx.evt.autoSkip = false;
function wwtbus002() {
   this.ServerClass =  "WWTBUS002" ;
   this.PackageName =  "GeneXus.Programs" ;
   this.setObjectType("web");
   this.hasEnterEvent = false;
   this.autoRefresh = true;
   this.SetStandaloneVars=function()
   {
   };
   this.e113a2_client=function()
   {
      this.executeServerEvent("'DOINSERT'", true, arguments[0]);
   };
   this.e153a2_client=function()
   {
      this.executeServerEvent("ENTER", true, arguments[0]);
   };
   this.e163a2_client=function()
   {
      this.executeServerEvent("CANCEL", true, arguments[0]);
   };
   this.GXValidFnc = [];
   this.GXCtrlIds=[2,8,13,19,23,27,28,29,30,31,32];
   this.GXLastCtrlId =32;
   this.GridContainer = new gx.grid.grid(this, 2,"WbpLvl2",26,"Grid","Grid","GridContainer",this.CmpContext,this.IsMasterPage,"wwtbus002",[],false,1,false,true,0,true,false,false,"",0,"px","Nueva fila",true,false,false,null,null,false,"");
   this.GridContainer.addBitmap("&Update","vUPDATE",27,0,"px",17,"px",null,"","");
   this.GridContainer.addBitmap("&Delete","vDELETE",28,0,"px",17,"px",null,"","");
   this.GridContainer.addSingleLineEdit(2,29,"RBR_COD","CODIGO DE RUBRO","","RBR_COD","int",0,"px",4,4,"right",null,[],2,"RBR_COD",true,0,false,false);
   this.GridContainer.addSingleLineEdit(19,30,"RBR_DES","DESCRIPCION DEL RUBRO","","RBR_DES","char",0,"px",30,30,"left",null,[],19,"RBR_DES",true,0,false,false);
   this.GridContainer.addSingleLineEdit(197,31,"RBR_AEA","AMORT. EJERC. AJUST. MES ANT.","","RBR_AEA","decimal",0,"px",10,10,"right",null,[],197,"RBR_AEA",true,2,false,false);
   this.GridContainer.addSingleLineEdit(179,32,"RBR_AMO","RUBRO AMORTIZABLE (S/N)","","RBR_AMO","char",0,"px",1,1,"left",null,[],179,"RBR_AMO",true,0,false,false);
   this.setGrid(this.GridContainer);
   this.GXValidFnc[2]={fld:"TABLE",grid:0};
   this.GXValidFnc[5]={fld:"TITLETEXT", format:0,grid:0};
   this.GXValidFnc[8]={fld:"TABLESEARCH",grid:0};
   this.GXValidFnc[11]={fld:"FILTERTEXTRBR_DES", format:0,grid:0};
   this.GXValidFnc[13]={lvl:0,type:"char",len:30,dec:0,sign:false,ro:0,grid:0,gxgrid:null,fnc:null,isvalid:null,fld:"vRBR_DES",gxz:"ZV13RBR_DES",gxold:"OV13RBR_DES",gxvar:"AV13RBR_DES",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",v2v:function(Value){gx.O.AV13RBR_DES=Value},v2z:function(Value){gx.O.ZV13RBR_DES=Value},v2c:function(){gx.fn.setControlValue("vRBR_DES",gx.O.AV13RBR_DES,0)},c2v:function(){gx.O.AV13RBR_DES=this.val()},val:function(){return gx.fn.getControlValue("vRBR_DES")},nac:function(){return  false }};
   this.GXValidFnc[16]={fld:"TABLESEPARATOR", format:0,grid:0};
   this.GXValidFnc[19]={fld:"TABLEGRIDCONTAINER",grid:0};
   this.GXValidFnc[23]={fld:"INSERT",grid:0};
   this.GXValidFnc[27]={lvl:2,type:"bits",len:4,dec:0,sign:false,ro:1,grid:26,gxgrid:this.GridContainer,fnc:null,isvalid:null,fld:"vUPDATE",gxz:"ZV14Update",gxold:"OV14Update",gxvar:"AV14Update",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",v2v:function(Value){gx.O.AV14Update=Value},v2z:function(Value){gx.O.ZV14Update=Value},v2c:function(){},c2v:function(){gx.O.AV14Update=this.val()},val:function(){return gx.fn.getGridControlValue("vUPDATE",gx.fn.currentGridRowImpl(26))},nac:function(){return  false }};
   this.GXValidFnc[28]={lvl:2,type:"bits",len:4,dec:0,sign:false,ro:1,grid:26,gxgrid:this.GridContainer,fnc:null,isvalid:null,fld:"vDELETE",gxz:"ZV15Delete",gxold:"OV15Delete",gxvar:"AV15Delete",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",v2v:function(Value){gx.O.AV15Delete=Value},v2z:function(Value){gx.O.ZV15Delete=Value},v2c:function(){},c2v:function(){gx.O.AV15Delete=this.val()},val:function(){return gx.fn.getGridControlValue("vDELETE",gx.fn.currentGridRowImpl(26))},nac:function(){return  false }};
   this.GXValidFnc[29]={lvl:2,type:"int",len:4,dec:0,sign:false,pic:"ZZZ9",ro:1,grid:26,gxgrid:this.GridContainer,fnc:null,isvalid:null,rgrid:[],fld:"RBR_COD",gxz:"Z2RBR_COD",gxold:"O2RBR_COD",gxvar:"A2RBR_COD",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",v2v:function(Value){gx.O.A2RBR_COD=gx.num.intval(Value)},v2z:function(Value){gx.O.Z2RBR_COD=gx.num.intval(Value)},v2c:function(){gx.fn.setGridControlValue("RBR_COD",gx.fn.currentGridRowImpl(26),gx.O.A2RBR_COD,0)},c2v:function(){gx.O.A2RBR_COD=this.val()},val:function(){return gx.fn.getGridIntegerValue("RBR_COD",gx.fn.currentGridRowImpl(26),'.')},nac:function(){return  false }};
   this.GXValidFnc[30]={lvl:2,type:"char",len:30,dec:0,sign:false,ro:1,grid:26,gxgrid:this.GridContainer,fnc:null,isvalid:null,fld:"RBR_DES",gxz:"Z19RBR_DES",gxold:"O19RBR_DES",gxvar:"A19RBR_DES",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",v2v:function(Value){gx.O.A19RBR_DES=Value},v2z:function(Value){gx.O.Z19RBR_DES=Value},v2c:function(){gx.fn.setGridControlValue("RBR_DES",gx.fn.currentGridRowImpl(26),gx.O.A19RBR_DES,0)},c2v:function(){gx.O.A19RBR_DES=this.val()},val:function(){return gx.fn.getGridControlValue("RBR_DES",gx.fn.currentGridRowImpl(26))},nac:function(){return  false }};
   this.GXValidFnc[31]={lvl:2,type:"decimal",len:10,dec:2,sign:false,pic:"ZZZZZZ9.99",ro:1,grid:26,gxgrid:this.GridContainer,fnc:null,isvalid:null,rgrid:[],fld:"RBR_AEA",gxz:"Z197RBR_AEA",gxold:"O197RBR_AEA",gxvar:"A197RBR_AEA",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",v2v:function(Value){gx.O.A197RBR_AEA=gx.fn.toDecimalValue(Value,',','.')},v2z:function(Value){gx.O.Z197RBR_AEA=gx.fn.toDecimalValue(Value,'.',',')},v2c:function(){gx.fn.setGridDecimalValue("RBR_AEA",gx.fn.currentGridRowImpl(26),gx.O.A197RBR_AEA,2,',')},c2v:function(){gx.O.A197RBR_AEA=this.val()},val:function(){return gx.fn.getGridDecimalValue("RBR_AEA",gx.fn.currentGridRowImpl(26),'.',',')},nac:function(){return  false }};
   this.GXValidFnc[32]={lvl:2,type:"char",len:1,dec:0,sign:false,ro:1,grid:26,gxgrid:this.GridContainer,fnc:null,isvalid:null,fld:"RBR_AMO",gxz:"Z179RBR_AMO",gxold:"O179RBR_AMO",gxvar:"A179RBR_AMO",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",v2v:function(Value){gx.O.A179RBR_AMO=Value},v2z:function(Value){gx.O.Z179RBR_AMO=Value},v2c:function(){gx.fn.setGridControlValue("RBR_AMO",gx.fn.currentGridRowImpl(26),gx.O.A179RBR_AMO,0)},c2v:function(){gx.O.A179RBR_AMO=this.val()},val:function(){return gx.fn.getGridControlValue("RBR_AMO",gx.fn.currentGridRowImpl(26))},nac:function(){return  false }};
   this.AV13RBR_DES = "" ;
   this.ZV13RBR_DES = "" ;
   this.OV13RBR_DES = "" ;
   this.ZV14Update = "" ;
   this.OV14Update = "" ;
   this.ZV15Delete = "" ;
   this.OV15Delete = "" ;
   this.Z2RBR_COD = 0 ;
   this.O2RBR_COD = 0 ;
   this.Z19RBR_DES = "" ;
   this.O19RBR_DES = "" ;
   this.Z197RBR_AEA = 0 ;
   this.O197RBR_AEA = 0 ;
   this.Z179RBR_AMO = "" ;
   this.O179RBR_AMO = "" ;
   this.AV14Update = "" ;
   this.AV15Delete = "" ;
   this.A2RBR_COD = 0 ;
   this.A19RBR_DES = "" ;
   this.A197RBR_AEA = 0 ;
   this.A179RBR_AMO = "" ;
   this.ServerEvents = ["e113a2_client" ,"e153a2_client" ,"e163a2_client"];
   this.GridContainer.addRefreshingVar(this.GXValidFnc[13]);
   this.GridContainer.addRefreshingVar({rfrVar:"AV15Delete", rfrProp:"Tooltiptext"});
   this.GridContainer.addRefreshingVar({rfrVar:"AV15Delete", rfrProp:"Value"});
   this.GridContainer.addRefreshingVar({rfrVar:"AV14Update", rfrProp:"Tooltiptext"});
   this.GridContainer.addRefreshingVar({rfrVar:"AV14Update", rfrProp:"Value"});
   this.SetStandaloneVars( );
}
wwtbus002.prototype = new gx.GxObject;
gx.setParentObj(new wwtbus002());
