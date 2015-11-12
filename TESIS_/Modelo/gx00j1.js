/*
               File: Gx00J1
        Description: Selection List Empresas con Acceso WEB
             Author: GeneXus C# Generator version 10_1_5-42940
       Generated on: 1/6/2014 11:8:48.11
       Program type: Callable routine
          Main DBMS: sqlserver
*/
gx.evt.autoSkip = false;
function gx00j1() {
   this.ServerClass =  "Gx00J1" ;
   this.PackageName =  "GeneXus.Programs" ;
   this.setObjectType("web");
   this.hasEnterEvent = true;
   this.autoRefresh = true;
   this.SetStandaloneVars=function()
   {
      this.AV8pEMPW_USU=gx.fn.getControlValue("vPEMPW_USU") ;
      this.AV9pEMPW_EMP=gx.fn.getIntegerValue("vPEMPW_EMP",'.') ;
   };
   this.e132o2_client=function()
   {
      this.executeServerEvent("ENTER", true, arguments[0]);
   };
   this.e142o2_client=function()
   {
      this.executeServerEvent("CANCEL", true, arguments[0]);
   };
   this.GXValidFnc = [];
   this.GXCtrlIds=[2,8,9,14,19,22,23,27,28,29,30,33];
   this.GXLastCtrlId =33;
   this.Grid1Container = new gx.grid.grid(this, 2,"WbpLvl2",26,"Grid1","Grid1","Grid1Container",this.CmpContext,this.IsMasterPage,"gx00j1",[],false,1,false,true,10,true,false,false,"",0,"px","Nueva fila",true,false,false,null,null,false,"");
   this.Grid1Container.addBitmap("&Linkselection","vLINKSELECTION",27,0,"px",17,"px",null,"","");
   this.Grid1Container.addSingleLineEdit(279,28,"EMPW_EMP","Empresa","","EMPW_EMP","int",0,"px",8,8,"right",null,[],279,"EMPW_EMP",true,0,false,false);
   this.Grid1Container.addSingleLineEdit(281,29,"EMPW_EMD","Empresa","","EMPW_EMD","char",0,"px",50,50,"left",null,[],281,"EMPW_EMD",true,0,false,false);
   this.Grid1Container.addSingleLineEdit(278,30,"EMPW_USU","Usuario","","EMPW_USU","char",0,"px",16,16,"left",null,[],278,"EMPW_USU",false,0,false,false);
   this.setGrid(this.Grid1Container);
   this.GXValidFnc[2]={fld:"TABLE1",grid:0};
   this.GXValidFnc[8]={fld:"GROUP1",grid:0};
   this.GXValidFnc[9]={fld:"TABLE2",grid:0};
   this.GXValidFnc[12]={fld:"TEXTBLOCKEMPW_EMP", format:0,grid:0};
   this.GXValidFnc[14]={lvl:0,type:"int",len:8,dec:0,sign:true,pic:"ZZZZZZZ9",ro:0,grid:0,gxgrid:null,fnc:null,isvalid:null,rgrid:[this.Grid1Container],fld:"vCEMPW_EMP",gxz:"ZV6cEMPW_EMP",gxold:"OV6cEMPW_EMP",gxvar:"AV6cEMPW_EMP",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",v2v:function(Value){gx.O.AV6cEMPW_EMP=gx.num.intval(Value)},v2z:function(Value){gx.O.ZV6cEMPW_EMP=gx.num.intval(Value)},v2c:function(){gx.fn.setControlValue("vCEMPW_EMP",gx.O.AV6cEMPW_EMP,0)},c2v:function(){gx.O.AV6cEMPW_EMP=this.val()},val:function(){return gx.fn.getIntegerValue("vCEMPW_EMP",'.')},nac:function(){return  false }};
   this.GXValidFnc[17]={fld:"TEXTBLOCKEMPW_EMD", format:0,grid:0};
   this.GXValidFnc[19]={lvl:0,type:"char",len:50,dec:0,sign:false,ro:0,grid:0,gxgrid:null,fnc:null,isvalid:null,fld:"vCEMPW_EMD",gxz:"ZV7cEMPW_EMD",gxold:"OV7cEMPW_EMD",gxvar:"AV7cEMPW_EMD",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",v2v:function(Value){gx.O.AV7cEMPW_EMD=Value},v2z:function(Value){gx.O.ZV7cEMPW_EMD=Value},v2c:function(){gx.fn.setControlValue("vCEMPW_EMD",gx.O.AV7cEMPW_EMD,0)},c2v:function(){gx.O.AV7cEMPW_EMD=this.val()},val:function(){return gx.fn.getControlValue("vCEMPW_EMD")},nac:function(){return  false }};
   this.GXValidFnc[22]={fld:"GROUP2",grid:0};
   this.GXValidFnc[23]={fld:"TABLE3",grid:0};
   this.GXValidFnc[27]={lvl:2,type:"bits",len:4,dec:0,sign:false,ro:1,grid:26,gxgrid:this.Grid1Container,fnc:null,isvalid:null,fld:"vLINKSELECTION",gxz:"ZV5LinkSelection",gxold:"OV5LinkSelection",gxvar:"AV5LinkSelection",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",v2v:function(Value){gx.O.AV5LinkSelection=Value},v2z:function(Value){gx.O.ZV5LinkSelection=Value},v2c:function(){},c2v:function(){gx.O.AV5LinkSelection=this.val()},val:function(){return gx.fn.getGridControlValue("vLINKSELECTION",gx.fn.currentGridRowImpl(26))},nac:function(){return  false }};
   this.GXValidFnc[28]={lvl:2,type:"int",len:8,dec:0,sign:true,pic:"ZZZZZZZ9",ro:1,grid:26,gxgrid:this.Grid1Container,fnc:null,isvalid:null,rgrid:[],fld:"EMPW_EMP",gxz:"Z279EMPW_EMP",gxold:"O279EMPW_EMP",gxvar:"A279EMPW_EMP",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",v2v:function(Value){gx.O.A279EMPW_EMP=gx.num.intval(Value)},v2z:function(Value){gx.O.Z279EMPW_EMP=gx.num.intval(Value)},v2c:function(){gx.fn.setGridControlValue("EMPW_EMP",gx.fn.currentGridRowImpl(26),gx.O.A279EMPW_EMP,0)},c2v:function(){gx.O.A279EMPW_EMP=this.val()},val:function(){return gx.fn.getGridIntegerValue("EMPW_EMP",gx.fn.currentGridRowImpl(26),'.')},nac:function(){return  false }};
   this.GXValidFnc[29]={lvl:2,type:"char",len:50,dec:0,sign:false,ro:1,grid:26,gxgrid:this.Grid1Container,fnc:null,isvalid:null,fld:"EMPW_EMD",gxz:"Z281EMPW_EMD",gxold:"O281EMPW_EMD",gxvar:"A281EMPW_EMD",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",v2v:function(Value){gx.O.A281EMPW_EMD=Value},v2z:function(Value){gx.O.Z281EMPW_EMD=Value},v2c:function(){gx.fn.setGridControlValue("EMPW_EMD",gx.fn.currentGridRowImpl(26),gx.O.A281EMPW_EMD,0)},c2v:function(){gx.O.A281EMPW_EMD=this.val()},val:function(){return gx.fn.getGridControlValue("EMPW_EMD",gx.fn.currentGridRowImpl(26))},nac:function(){return  false }};
   this.GXValidFnc[30]={lvl:2,type:"char",len:16,dec:0,sign:false,ro:1,grid:26,gxgrid:this.Grid1Container,fnc:null,isvalid:null,fld:"EMPW_USU",gxz:"Z278EMPW_USU",gxold:"O278EMPW_USU",gxvar:"A278EMPW_USU",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",v2v:function(Value){gx.O.A278EMPW_USU=Value},v2z:function(Value){gx.O.Z278EMPW_USU=Value},v2c:function(){gx.fn.setGridControlValue("EMPW_USU",gx.fn.currentGridRowImpl(26),gx.O.A278EMPW_USU,0)},c2v:function(){gx.O.A278EMPW_USU=this.val()},val:function(){return gx.fn.getGridControlValue("EMPW_USU",gx.fn.currentGridRowImpl(26))},nac:function(){return  false }};
   this.GXValidFnc[33]={fld:"TABLE4",grid:0};
   this.AV6cEMPW_EMP = 0 ;
   this.ZV6cEMPW_EMP = 0 ;
   this.OV6cEMPW_EMP = 0 ;
   this.AV7cEMPW_EMD = "" ;
   this.ZV7cEMPW_EMD = "" ;
   this.OV7cEMPW_EMD = "" ;
   this.ZV5LinkSelection = "" ;
   this.OV5LinkSelection = "" ;
   this.Z279EMPW_EMP = 0 ;
   this.O279EMPW_EMP = 0 ;
   this.Z281EMPW_EMD = "" ;
   this.O281EMPW_EMD = "" ;
   this.Z278EMPW_USU = "" ;
   this.O278EMPW_USU = "" ;
   this.AV8pEMPW_USU = "" ;
   this.AV9pEMPW_EMP = 0 ;
   this.AV5LinkSelection = "" ;
   this.A279EMPW_EMP = 0 ;
   this.A281EMPW_EMD = "" ;
   this.A278EMPW_USU = "" ;
   this.ServerEvents = ["e132o2_client" ,"e142o2_client"];
   this.VarControlMap["AV8pEMPW_USU"] = {id:"vPEMPW_USU",grid:0,type:"char"};
   this.VarControlMap["AV9pEMPW_EMP"] = {id:"vPEMPW_EMP",grid:0,type:"int"};
   this.VarControlMap["AV8pEMPW_USU"] = {id:"vPEMPW_USU",grid:0,type:"char"};
   this.Grid1Container.addRefreshingVar(this.GXValidFnc[14]);
   this.Grid1Container.addRefreshingVar(this.GXValidFnc[19]);
   this.Grid1Container.addRefreshingVar({rfrVar:"AV8pEMPW_USU"});
   this.SetStandaloneVars( );
}
gx00j1.prototype = new gx.GxObject;
gx.setParentObj(new gx00j1());
