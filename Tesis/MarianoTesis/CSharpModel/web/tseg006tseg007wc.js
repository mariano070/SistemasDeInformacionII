/*
               File: TSEG006TSEG007WC
        Description: TSEG006 TSEG007 WC
             Author: GeneXus C# Generator version 10_1_5-42940
       Generated on: 1/6/2014 11:8:18.73
       Program type: Callable routine
          Main DBMS: sqlserver
*/
gx.evt.autoSkip = false;
function tseg006tseg007wc(CmpContext) {
   this.ServerClass =  "TSEG006TSEG007WC" ;
   this.PackageName =  "GeneXus.Programs" ;
   this.setObjectType("web");
   this.setCmpContext(CmpContext);
   this.ReadonlyForm = true;
   this.hasEnterEvent = false;
   this.autoRefresh = true;
   this.SetStandaloneVars=function()
   {
   };
   this.e11452_client=function()
   {
      this.executeServerEvent("'DOINSERT'", true, arguments[0]);
   };
   this.e14452_client=function()
   {
      this.executeServerEvent("ENTER", true, arguments[0]);
   };
   this.e15452_client=function()
   {
      this.executeServerEvent("CANCEL", true, arguments[0]);
   };
   this.GXValidFnc = [];
   this.GXCtrlIds=[2,5,9,13,14,15,16,17,20,21,22,23];
   this.GXLastCtrlId =23;
   this.GridContainer = new gx.grid.grid(this, 2,"WbpLvl2",12,"Grid","Grid","GridContainer",this.CmpContext,this.IsMasterPage,"tseg006tseg007wc",[],false,1,false,true,0,true,false,false,"",0,"px","Nueva fila",true,false,false,null,null,false,"");
   this.GridContainer.addBitmap("&Update","vUPDATE",13,0,"px",17,"px",null,"","");
   this.GridContainer.addBitmap("&Delete","vDELETE",14,0,"px",17,"px",null,"","");
   this.GridContainer.addSingleLineEdit(407,15,"PRS_ORD","ORDEN DE LLAMADOS","","PRS_ORD","int",0,"px",3,3,"right",null,[],407,"PRS_ORD",true,0,false,false);
   this.GridContainer.addSingleLineEdit(408,16,"PRS_DES","DESCRIPCION PROGRAMA","","PRS_DES","char",0,"px",30,30,"left",null,[],408,"PRS_DES",true,0,false,false);
   this.GridContainer.addSingleLineEdit(409,17,"PRS_LINK","LINK PROGRAMA","","PRS_LINK","vchar",0,"px",300,300,"left",null,[],409,"PRS_LINK",true,0,false,false);
   this.setGrid(this.GridContainer);
   this.GXValidFnc[2]={fld:"TABLE",grid:0};
   this.GXValidFnc[5]={fld:"TABLEGRIDCONTAINER",grid:0};
   this.GXValidFnc[9]={fld:"INSERT",grid:0};
   this.GXValidFnc[13]={lvl:2,type:"bits",len:4,dec:0,sign:false,ro:1,grid:12,gxgrid:this.GridContainer,fnc:null,isvalid:null,fld:"vUPDATE",gxz:"ZV15Update",gxold:"OV15Update",gxvar:"AV15Update",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",v2v:function(Value){gx.O.AV15Update=Value},v2z:function(Value){gx.O.ZV15Update=Value},v2c:function(){},c2v:function(){gx.O.AV15Update=this.val()},val:function(){return gx.fn.getGridControlValue("vUPDATE",gx.fn.currentGridRowImpl(12))},nac:function(){return  false }};
   this.GXValidFnc[14]={lvl:2,type:"bits",len:4,dec:0,sign:false,ro:1,grid:12,gxgrid:this.GridContainer,fnc:null,isvalid:null,fld:"vDELETE",gxz:"ZV16Delete",gxold:"OV16Delete",gxvar:"AV16Delete",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",v2v:function(Value){gx.O.AV16Delete=Value},v2z:function(Value){gx.O.ZV16Delete=Value},v2c:function(){},c2v:function(){gx.O.AV16Delete=this.val()},val:function(){return gx.fn.getGridControlValue("vDELETE",gx.fn.currentGridRowImpl(12))},nac:function(){return  false }};
   this.GXValidFnc[15]={lvl:2,type:"int",len:3,dec:0,sign:false,pic:"ZZ9",ro:1,grid:12,gxgrid:this.GridContainer,fnc:null,isvalid:null,rgrid:[],fld:"PRS_ORD",gxz:"Z407PRS_ORD",gxold:"O407PRS_ORD",gxvar:"A407PRS_ORD",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",v2v:function(Value){gx.O.A407PRS_ORD=gx.num.intval(Value)},v2z:function(Value){gx.O.Z407PRS_ORD=gx.num.intval(Value)},v2c:function(){gx.fn.setGridControlValue("PRS_ORD",gx.fn.currentGridRowImpl(12),gx.O.A407PRS_ORD,0)},c2v:function(){gx.O.A407PRS_ORD=this.val()},val:function(){return gx.fn.getGridIntegerValue("PRS_ORD",gx.fn.currentGridRowImpl(12),'.')},nac:function(){return  false }};
   this.GXValidFnc[16]={lvl:2,type:"char",len:30,dec:0,sign:false,ro:1,grid:12,gxgrid:this.GridContainer,fnc:null,isvalid:null,fld:"PRS_DES",gxz:"Z408PRS_DES",gxold:"O408PRS_DES",gxvar:"A408PRS_DES",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",v2v:function(Value){gx.O.A408PRS_DES=Value},v2z:function(Value){gx.O.Z408PRS_DES=Value},v2c:function(){gx.fn.setGridControlValue("PRS_DES",gx.fn.currentGridRowImpl(12),gx.O.A408PRS_DES,0)},c2v:function(){gx.O.A408PRS_DES=this.val()},val:function(){return gx.fn.getGridControlValue("PRS_DES",gx.fn.currentGridRowImpl(12))},nac:function(){return  false }};
   this.GXValidFnc[17]={lvl:2,type:"vchar",len:300,dec:0,sign:false,ro:1,grid:12,gxgrid:this.GridContainer,fnc:null,isvalid:null,fld:"PRS_LINK",gxz:"Z409PRS_LINK",gxold:"O409PRS_LINK",gxvar:"A409PRS_LINK",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",v2v:function(Value){gx.O.A409PRS_LINK=Value},v2z:function(Value){gx.O.Z409PRS_LINK=Value},v2c:function(){gx.fn.setGridControlValue("PRS_LINK",gx.fn.currentGridRowImpl(12),gx.O.A409PRS_LINK,0)},c2v:function(){gx.O.A409PRS_LINK=this.val()},val:function(){return gx.fn.getGridControlValue("PRS_LINK",gx.fn.currentGridRowImpl(12))},nac:function(){return  false }};
   this.GXValidFnc[20]={lvl:0,type:"char",len:16,dec:0,sign:false,ro:1,grid:0,gxgrid:null,fnc:null,isvalid:null,fld:"USU_COD",gxz:"Z6USU_COD",gxold:"O6USU_COD",gxvar:"A6USU_COD",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",v2v:function(Value){gx.O.A6USU_COD=Value},v2z:function(Value){gx.O.Z6USU_COD=Value},v2c:function(){gx.fn.setControlValue("USU_COD",gx.O.A6USU_COD,0)},c2v:function(){gx.O.A6USU_COD=this.val()},val:function(){return gx.fn.getControlValue("USU_COD")},nac:function(){return  false }};
   this.GXValidFnc[21]={lvl:0,type:"int",len:3,dec:0,sign:false,pic:"ZZ9",ro:1,grid:0,gxgrid:null,fnc:null,isvalid:null,rgrid:[],fld:"SIS_COD",gxz:"Z116SIS_COD",gxold:"O116SIS_COD",gxvar:"A116SIS_COD",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",v2v:function(Value){gx.O.A116SIS_COD=gx.num.intval(Value)},v2z:function(Value){gx.O.Z116SIS_COD=gx.num.intval(Value)},v2c:function(){gx.fn.setControlValue("SIS_COD",gx.O.A116SIS_COD,0)},c2v:function(){gx.O.A116SIS_COD=this.val()},val:function(){return gx.fn.getIntegerValue("SIS_COD",'.')},nac:function(){return  false }};
   this.GXValidFnc[22]={lvl:0,type:"int",len:4,dec:0,sign:false,pic:"ZZZ9",ro:1,grid:0,gxgrid:null,fnc:null,isvalid:null,rgrid:[],fld:"PRG_COD",gxz:"Z126PRG_COD",gxold:"O126PRG_COD",gxvar:"A126PRG_COD",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",v2v:function(Value){gx.O.A126PRG_COD=gx.num.intval(Value)},v2z:function(Value){gx.O.Z126PRG_COD=gx.num.intval(Value)},v2c:function(){gx.fn.setControlValue("PRG_COD",gx.O.A126PRG_COD,0)},c2v:function(){gx.O.A126PRG_COD=this.val()},val:function(){return gx.fn.getIntegerValue("PRG_COD",'.')},nac:function(){return  false }};
   this.GXValidFnc[23]={lvl:0,type:"int",len:8,dec:0,sign:false,pic:"ZZZZZZZ9",ro:1,grid:0,gxgrid:null,fnc:null,isvalid:null,rgrid:[],fld:"PRS_NRO",gxz:"Z118PRS_NRO",gxold:"O118PRS_NRO",gxvar:"A118PRS_NRO",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",v2v:function(Value){gx.O.A118PRS_NRO=gx.num.intval(Value)},v2z:function(Value){gx.O.Z118PRS_NRO=gx.num.intval(Value)},v2c:function(){gx.fn.setControlValue("PRS_NRO",gx.O.A118PRS_NRO,0)},c2v:function(){gx.O.A118PRS_NRO=this.val()},val:function(){return gx.fn.getIntegerValue("PRS_NRO",'.')},nac:function(){return  false }};
   this.ZV15Update = "" ;
   this.OV15Update = "" ;
   this.ZV16Delete = "" ;
   this.OV16Delete = "" ;
   this.Z407PRS_ORD = 0 ;
   this.O407PRS_ORD = 0 ;
   this.Z408PRS_DES = "" ;
   this.O408PRS_DES = "" ;
   this.Z409PRS_LINK = "" ;
   this.O409PRS_LINK = "" ;
   this.A6USU_COD = "" ;
   this.Z6USU_COD = "" ;
   this.O6USU_COD = "" ;
   this.A116SIS_COD = 0 ;
   this.Z116SIS_COD = 0 ;
   this.O116SIS_COD = 0 ;
   this.A126PRG_COD = 0 ;
   this.Z126PRG_COD = 0 ;
   this.O126PRG_COD = 0 ;
   this.A118PRS_NRO = 0 ;
   this.Z118PRS_NRO = 0 ;
   this.O118PRS_NRO = 0 ;
   this.AV7USU_COD = "" ;
   this.AV8SIS_COD = 0 ;
   this.AV9PRG_COD = 0 ;
   this.AV10PRS_NRO = 0 ;
   this.AV15Update = "" ;
   this.AV16Delete = "" ;
   this.A407PRS_ORD = 0 ;
   this.A408PRS_DES = "" ;
   this.A409PRS_LINK = "" ;
   this.ServerEvents = ["e11452_client" ,"e14452_client" ,"e15452_client"];
   this.VarControlMap["AV7USU_COD"] = {id:"vUSU_COD",grid:0,type:"char"};
   this.VarControlMap["AV8SIS_COD"] = {id:"vSIS_COD",grid:0,type:"int"};
   this.VarControlMap["AV9PRG_COD"] = {id:"vPRG_COD",grid:0,type:"int"};
   this.VarControlMap["AV10PRS_NRO"] = {id:"vPRS_NRO",grid:0,type:"int"};
   this.GridContainer.addRefreshingVar({rfrVar:"AV7USU_COD"});
   this.GridContainer.addRefreshingVar({rfrVar:"AV8SIS_COD"});
   this.GridContainer.addRefreshingVar({rfrVar:"AV9PRG_COD"});
   this.GridContainer.addRefreshingVar({rfrVar:"AV10PRS_NRO"});
   this.GridContainer.addRefreshingVar({rfrVar:"AV16Delete", rfrProp:"Tooltiptext"});
   this.GridContainer.addRefreshingVar({rfrVar:"AV16Delete", rfrProp:"Value"});
   this.GridContainer.addRefreshingVar({rfrVar:"AV15Update", rfrProp:"Tooltiptext"});
   this.GridContainer.addRefreshingVar({rfrVar:"AV15Update", rfrProp:"Value"});
   this.SetStandaloneVars( );
}
