/*
               File: TBUS002TTBUS000_bWC
        Description: TBUS002 TTBUS000_b WC
             Author: GeneXus C# Generator version 10_1_5-42940
       Generated on: 1/6/2014 11:6:32.94
       Program type: Callable routine
          Main DBMS: sqlserver
*/
gx.evt.autoSkip = false;
function tbus002ttbus000_bwc(CmpContext) {
   this.ServerClass =  "TBUS002TTBUS000_bWC" ;
   this.PackageName =  "GeneXus.Programs" ;
   this.setObjectType("web");
   this.setCmpContext(CmpContext);
   this.ReadonlyForm = true;
   this.hasEnterEvent = false;
   this.autoRefresh = true;
   this.SetStandaloneVars=function()
   {
   };
   this.e114a2_client=function()
   {
      this.executeServerEvent("'DOINSERT'", true, arguments[0]);
   };
   this.e144a2_client=function()
   {
      this.executeServerEvent("ENTER", true, arguments[0]);
   };
   this.e154a2_client=function()
   {
      this.executeServerEvent("CANCEL", true, arguments[0]);
   };
   this.GXValidFnc = [];
   this.GXCtrlIds=[2,5,9,13,14,15,16,17,18,19,22];
   this.GXLastCtrlId =22;
   this.GridContainer = new gx.grid.grid(this, 2,"WbpLvl2",12,"Grid","Grid","GridContainer",this.CmpContext,this.IsMasterPage,"tbus002ttbus000_bwc",[],false,1,false,true,0,true,false,false,"",0,"px","Nueva fila",true,false,false,null,null,false,"");
   this.GridContainer.addBitmap("&Update","vUPDATE",13,0,"px",17,"px",null,"","");
   this.GridContainer.addBitmap("&Delete","vDELETE",14,0,"px",17,"px",null,"","");
   this.GridContainer.addSingleLineEdit(11,15,"TTBUS_ID","Id del bien de uso:","","TTBUS_Id","int",0,"px",8,8,"right",null,[],11,"TTBUS_Id",true,0,false,false);
   this.GridContainer.addSingleLineEdit(16,16,"TTBUS_FECHABAJA","Fecha de Baja:","","TTBUS_FechaBaja","date",0,"px",10,10,"right",null,[],16,"TTBUS_FechaBaja",true,0,false,false);
   this.GridContainer.addSingleLineEdit(43,17,"TTBUS_MOTIVOBAJA","de Baja","","TTBUS_MotivoBaja","svchar",0,"px",50,50,"left",null,[],43,"TTBUS_MotivoBaja",true,0,false,false);
   this.GridContainer.addSingleLineEdit(195,18,"TTBUS_USUARIOBAJA","la Baja","","TTBUS_UsuarioBaja","char",0,"px",15,15,"left",null,[],195,"TTBUS_UsuarioBaja",true,0,false,false);
   this.GridContainer.addSingleLineEdit(196,19,"TTBUS_MAQUINABAJA","la baja","","TTBUS_MaquinaBaja","char",0,"px",20,20,"left",null,[],196,"TTBUS_MaquinaBaja",true,0,false,false);
   this.setGrid(this.GridContainer);
   this.GXValidFnc[2]={fld:"TABLE",grid:0};
   this.GXValidFnc[5]={fld:"TABLEGRIDCONTAINER",grid:0};
   this.GXValidFnc[9]={fld:"INSERT",grid:0};
   this.GXValidFnc[13]={lvl:2,type:"bits",len:4,dec:0,sign:false,ro:1,grid:12,gxgrid:this.GridContainer,fnc:null,isvalid:null,fld:"vUPDATE",gxz:"ZV12Update",gxold:"OV12Update",gxvar:"AV12Update",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",v2v:function(Value){gx.O.AV12Update=Value},v2z:function(Value){gx.O.ZV12Update=Value},v2c:function(){},c2v:function(){gx.O.AV12Update=this.val()},val:function(){return gx.fn.getGridControlValue("vUPDATE",gx.fn.currentGridRowImpl(12))},nac:function(){return  false }};
   this.GXValidFnc[14]={lvl:2,type:"bits",len:4,dec:0,sign:false,ro:1,grid:12,gxgrid:this.GridContainer,fnc:null,isvalid:null,fld:"vDELETE",gxz:"ZV13Delete",gxold:"OV13Delete",gxvar:"AV13Delete",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",v2v:function(Value){gx.O.AV13Delete=Value},v2z:function(Value){gx.O.ZV13Delete=Value},v2c:function(){},c2v:function(){gx.O.AV13Delete=this.val()},val:function(){return gx.fn.getGridControlValue("vDELETE",gx.fn.currentGridRowImpl(12))},nac:function(){return  false }};
   this.GXValidFnc[15]={lvl:2,type:"int",len:8,dec:0,sign:false,pic:"ZZZZZZZ9",ro:1,grid:12,gxgrid:this.GridContainer,fnc:null,isvalid:null,rgrid:[],fld:"TTBUS_ID",gxz:"Z11TTBUS_Id",gxold:"O11TTBUS_Id",gxvar:"A11TTBUS_Id",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",v2v:function(Value){gx.O.A11TTBUS_Id=gx.num.intval(Value)},v2z:function(Value){gx.O.Z11TTBUS_Id=gx.num.intval(Value)},v2c:function(){gx.fn.setGridControlValue("TTBUS_ID",gx.fn.currentGridRowImpl(12),gx.O.A11TTBUS_Id,0)},c2v:function(){gx.O.A11TTBUS_Id=this.val()},val:function(){return gx.fn.getGridIntegerValue("TTBUS_ID",gx.fn.currentGridRowImpl(12),'.')},nac:function(){return  false }};
   this.GXValidFnc[16]={lvl:2,type:"date",len:10,dec:0,sign:false,ro:1,grid:12,gxgrid:this.GridContainer,fnc:null,isvalid:null,fld:"TTBUS_FECHABAJA",gxz:"Z16TTBUS_FechaBaja",gxold:"O16TTBUS_FechaBaja",gxvar:"A16TTBUS_FechaBaja",dp:{f:0,st:false,wn:false,mf:false,pic:"99/99/9999",dec:0},ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",v2v:function(Value){gx.O.A16TTBUS_FechaBaja=gx.fn.toDatetimeValue(Value)},v2z:function(Value){gx.O.Z16TTBUS_FechaBaja=gx.fn.toDatetimeValue(Value)},v2c:function(){gx.fn.setGridControlValue("TTBUS_FECHABAJA",gx.fn.currentGridRowImpl(12),gx.O.A16TTBUS_FechaBaja,0)},c2v:function(){gx.O.A16TTBUS_FechaBaja=this.val()},val:function(){return gx.fn.getGridControlValue("TTBUS_FECHABAJA",gx.fn.currentGridRowImpl(12))},nac:function(){return  false }};
   this.GXValidFnc[17]={lvl:2,type:"svchar",len:50,dec:0,sign:false,ro:1,grid:12,gxgrid:this.GridContainer,fnc:null,isvalid:null,fld:"TTBUS_MOTIVOBAJA",gxz:"Z43TTBUS_MotivoBaja",gxold:"O43TTBUS_MotivoBaja",gxvar:"A43TTBUS_MotivoBaja",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",v2v:function(Value){gx.O.A43TTBUS_MotivoBaja=Value},v2z:function(Value){gx.O.Z43TTBUS_MotivoBaja=Value},v2c:function(){gx.fn.setGridControlValue("TTBUS_MOTIVOBAJA",gx.fn.currentGridRowImpl(12),gx.O.A43TTBUS_MotivoBaja,0)},c2v:function(){gx.O.A43TTBUS_MotivoBaja=this.val()},val:function(){return gx.fn.getGridControlValue("TTBUS_MOTIVOBAJA",gx.fn.currentGridRowImpl(12))},nac:function(){return  false }};
   this.GXValidFnc[18]={lvl:2,type:"char",len:15,dec:0,sign:false,ro:1,grid:12,gxgrid:this.GridContainer,fnc:null,isvalid:null,fld:"TTBUS_USUARIOBAJA",gxz:"Z195TTBUS_UsuarioBaja",gxold:"O195TTBUS_UsuarioBaja",gxvar:"A195TTBUS_UsuarioBaja",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",v2v:function(Value){gx.O.A195TTBUS_UsuarioBaja=Value},v2z:function(Value){gx.O.Z195TTBUS_UsuarioBaja=Value},v2c:function(){gx.fn.setGridControlValue("TTBUS_USUARIOBAJA",gx.fn.currentGridRowImpl(12),gx.O.A195TTBUS_UsuarioBaja,0)},c2v:function(){gx.O.A195TTBUS_UsuarioBaja=this.val()},val:function(){return gx.fn.getGridControlValue("TTBUS_USUARIOBAJA",gx.fn.currentGridRowImpl(12))},nac:function(){return  false }};
   this.GXValidFnc[19]={lvl:2,type:"char",len:20,dec:0,sign:false,ro:1,grid:12,gxgrid:this.GridContainer,fnc:null,isvalid:null,fld:"TTBUS_MAQUINABAJA",gxz:"Z196TTBUS_MaquinaBaja",gxold:"O196TTBUS_MaquinaBaja",gxvar:"A196TTBUS_MaquinaBaja",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",v2v:function(Value){gx.O.A196TTBUS_MaquinaBaja=Value},v2z:function(Value){gx.O.Z196TTBUS_MaquinaBaja=Value},v2c:function(){gx.fn.setGridControlValue("TTBUS_MAQUINABAJA",gx.fn.currentGridRowImpl(12),gx.O.A196TTBUS_MaquinaBaja,0)},c2v:function(){gx.O.A196TTBUS_MaquinaBaja=this.val()},val:function(){return gx.fn.getGridControlValue("TTBUS_MAQUINABAJA",gx.fn.currentGridRowImpl(12))},nac:function(){return  false }};
   this.GXValidFnc[22]={lvl:0,type:"int",len:4,dec:0,sign:false,pic:"ZZZ9",ro:1,grid:0,gxgrid:null,fnc:null,isvalid:null,rgrid:[],fld:"TTBUS_RUBROBIEN",gxz:"Z17TTBUS_RubroBien",gxold:"O17TTBUS_RubroBien",gxvar:"A17TTBUS_RubroBien",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",v2v:function(Value){gx.O.A17TTBUS_RubroBien=gx.num.intval(Value)},v2z:function(Value){gx.O.Z17TTBUS_RubroBien=gx.num.intval(Value)},v2c:function(){gx.fn.setControlValue("TTBUS_RUBROBIEN",gx.O.A17TTBUS_RubroBien,0)},c2v:function(){gx.O.A17TTBUS_RubroBien=this.val()},val:function(){return gx.fn.getIntegerValue("TTBUS_RUBROBIEN",'.')},nac:function(){return  false }};
   this.ZV12Update = "" ;
   this.OV12Update = "" ;
   this.ZV13Delete = "" ;
   this.OV13Delete = "" ;
   this.Z11TTBUS_Id = 0 ;
   this.O11TTBUS_Id = 0 ;
   this.Z16TTBUS_FechaBaja = gx.date.nullDate() ;
   this.O16TTBUS_FechaBaja = gx.date.nullDate() ;
   this.Z43TTBUS_MotivoBaja = "" ;
   this.O43TTBUS_MotivoBaja = "" ;
   this.Z195TTBUS_UsuarioBaja = "" ;
   this.O195TTBUS_UsuarioBaja = "" ;
   this.Z196TTBUS_MaquinaBaja = "" ;
   this.O196TTBUS_MaquinaBaja = "" ;
   this.A17TTBUS_RubroBien = 0 ;
   this.Z17TTBUS_RubroBien = 0 ;
   this.O17TTBUS_RubroBien = 0 ;
   this.AV7TTBUS_RubroBien = 0 ;
   this.AV12Update = "" ;
   this.AV13Delete = "" ;
   this.A11TTBUS_Id = 0 ;
   this.A16TTBUS_FechaBaja = gx.date.nullDate() ;
   this.A43TTBUS_MotivoBaja = "" ;
   this.A195TTBUS_UsuarioBaja = "" ;
   this.A196TTBUS_MaquinaBaja = "" ;
   this.ServerEvents = ["e114a2_client" ,"e144a2_client" ,"e154a2_client"];
   this.VarControlMap["AV7TTBUS_RubroBien"] = {id:"vTTBUS_RUBROBIEN",grid:0,type:"int"};
   this.GridContainer.addRefreshingVar({rfrVar:"AV7TTBUS_RubroBien"});
   this.GridContainer.addRefreshingVar({rfrVar:"AV13Delete", rfrProp:"Tooltiptext"});
   this.GridContainer.addRefreshingVar({rfrVar:"AV13Delete", rfrProp:"Value"});
   this.GridContainer.addRefreshingVar({rfrVar:"AV12Update", rfrProp:"Tooltiptext"});
   this.GridContainer.addRefreshingVar({rfrVar:"AV12Update", rfrProp:"Value"});
   this.SetStandaloneVars( );
}
