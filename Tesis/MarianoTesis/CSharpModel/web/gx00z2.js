/*
               File: Gx00Z2
        Description: Selection List PROGRAMAS ACCEDIDOS POR SESION
             Author: GeneXus C# Generator version 10_1_5-42940
       Generated on: 1/6/2014 11:8:14.41
       Program type: Callable routine
          Main DBMS: sqlserver
*/
gx.evt.autoSkip = false;
function gx00z2() {
   this.ServerClass =  "Gx00Z2" ;
   this.PackageName =  "GeneXus.Programs" ;
   this.setObjectType("web");
   this.hasEnterEvent = true;
   this.autoRefresh = true;
   this.SetStandaloneVars=function()
   {
      this.AV10pUSU_COD=gx.fn.getControlValue("vPUSU_COD") ;
      this.AV11pSIS_COD=gx.fn.getIntegerValue("vPSIS_COD",'.') ;
      this.AV12pPRG_COD=gx.fn.getIntegerValue("vPPRG_COD",'.') ;
      this.AV13pPRS_NRO=gx.fn.getIntegerValue("vPPRS_NRO",'.') ;
      this.AV14pPRS_ORD=gx.fn.getIntegerValue("vPPRS_ORD",'.') ;
   };
   this.e134e2_client=function()
   {
      this.executeServerEvent("ENTER", true, arguments[0]);
   };
   this.e144e2_client=function()
   {
      this.executeServerEvent("CANCEL", true, arguments[0]);
   };
   this.GXValidFnc = [];
   this.GXCtrlIds=[2,8,9,14,19,24,29,32,33,37,38,39,40,41,42,43,46];
   this.GXLastCtrlId =46;
   this.Grid1Container = new gx.grid.grid(this, 2,"WbpLvl2",36,"Grid1","Grid1","Grid1Container",this.CmpContext,this.IsMasterPage,"gx00z2",[],false,1,false,true,10,true,false,false,"",0,"px","Nueva fila",true,false,false,null,null,false,"");
   this.Grid1Container.addBitmap("&Linkselection","vLINKSELECTION",37,0,"px",17,"px",null,"","");
   this.Grid1Container.addSingleLineEdit(126,38,"PRG_COD","CODIGO","","PRG_COD","int",0,"px",4,4,"right",null,[],126,"PRG_COD",true,0,false,false);
   this.Grid1Container.addSingleLineEdit(118,39,"PRS_NRO","NRO DE SESION ASIGNADA","","PRS_NRO","int",0,"px",8,8,"right",null,[],118,"PRS_NRO",true,0,false,false);
   this.Grid1Container.addSingleLineEdit(407,40,"PRS_ORD","ORDEN DE LLAMADOS","","PRS_ORD","int",0,"px",3,3,"right",null,[],407,"PRS_ORD",true,0,false,false);
   this.Grid1Container.addSingleLineEdit(408,41,"PRS_DES","DESCRIPCION PROGRAMA","Seleccionar","PRS_DES","char",0,"px",30,30,"left",null,[],408,"PRS_DES",true,0,false,false);
   this.Grid1Container.addSingleLineEdit(6,42,"USU_COD","CODIGO","","USU_COD","char",0,"px",16,16,"left",null,[],6,"USU_COD",false,0,false,false);
   this.Grid1Container.addSingleLineEdit(116,43,"SIS_COD","CODIGO","","SIS_COD","int",0,"px",3,3,"right",null,[],116,"SIS_COD",false,0,false,false);
   this.setGrid(this.Grid1Container);
   this.GXValidFnc[2]={fld:"TABLE1",grid:0};
   this.GXValidFnc[8]={fld:"GROUP1",grid:0};
   this.GXValidFnc[9]={fld:"TABLE2",grid:0};
   this.GXValidFnc[12]={fld:"TEXTBLOCKPRG_COD", format:0,grid:0};
   this.GXValidFnc[14]={lvl:0,type:"int",len:4,dec:0,sign:false,pic:"ZZZ9",ro:0,grid:0,gxgrid:null,fnc:null,isvalid:null,rgrid:[this.Grid1Container],fld:"vCPRG_COD",gxz:"ZV6cPRG_COD",gxold:"OV6cPRG_COD",gxvar:"AV6cPRG_COD",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",v2v:function(Value){gx.O.AV6cPRG_COD=gx.num.intval(Value)},v2z:function(Value){gx.O.ZV6cPRG_COD=gx.num.intval(Value)},v2c:function(){gx.fn.setControlValue("vCPRG_COD",gx.O.AV6cPRG_COD,0)},c2v:function(){gx.O.AV6cPRG_COD=this.val()},val:function(){return gx.fn.getIntegerValue("vCPRG_COD",'.')},nac:function(){return  false }};
   this.GXValidFnc[17]={fld:"TEXTBLOCKPRS_NRO", format:0,grid:0};
   this.GXValidFnc[19]={lvl:0,type:"int",len:8,dec:0,sign:false,pic:"ZZZZZZZ9",ro:0,grid:0,gxgrid:null,fnc:null,isvalid:null,rgrid:[this.Grid1Container],fld:"vCPRS_NRO",gxz:"ZV7cPRS_NRO",gxold:"OV7cPRS_NRO",gxvar:"AV7cPRS_NRO",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",v2v:function(Value){gx.O.AV7cPRS_NRO=gx.num.intval(Value)},v2z:function(Value){gx.O.ZV7cPRS_NRO=gx.num.intval(Value)},v2c:function(){gx.fn.setControlValue("vCPRS_NRO",gx.O.AV7cPRS_NRO,0)},c2v:function(){gx.O.AV7cPRS_NRO=this.val()},val:function(){return gx.fn.getIntegerValue("vCPRS_NRO",'.')},nac:function(){return  false }};
   this.GXValidFnc[22]={fld:"TEXTBLOCKPRS_ORD", format:0,grid:0};
   this.GXValidFnc[24]={lvl:0,type:"int",len:3,dec:0,sign:false,pic:"ZZ9",ro:0,grid:0,gxgrid:null,fnc:null,isvalid:null,rgrid:[this.Grid1Container],fld:"vCPRS_ORD",gxz:"ZV8cPRS_ORD",gxold:"OV8cPRS_ORD",gxvar:"AV8cPRS_ORD",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",v2v:function(Value){gx.O.AV8cPRS_ORD=gx.num.intval(Value)},v2z:function(Value){gx.O.ZV8cPRS_ORD=gx.num.intval(Value)},v2c:function(){gx.fn.setControlValue("vCPRS_ORD",gx.O.AV8cPRS_ORD,0)},c2v:function(){gx.O.AV8cPRS_ORD=this.val()},val:function(){return gx.fn.getIntegerValue("vCPRS_ORD",'.')},nac:function(){return  false }};
   this.GXValidFnc[27]={fld:"TEXTBLOCKPRS_DES", format:0,grid:0};
   this.GXValidFnc[29]={lvl:0,type:"char",len:30,dec:0,sign:false,ro:0,grid:0,gxgrid:null,fnc:null,isvalid:null,fld:"vCPRS_DES",gxz:"ZV9cPRS_DES",gxold:"OV9cPRS_DES",gxvar:"AV9cPRS_DES",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",v2v:function(Value){gx.O.AV9cPRS_DES=Value},v2z:function(Value){gx.O.ZV9cPRS_DES=Value},v2c:function(){gx.fn.setControlValue("vCPRS_DES",gx.O.AV9cPRS_DES,0)},c2v:function(){gx.O.AV9cPRS_DES=this.val()},val:function(){return gx.fn.getControlValue("vCPRS_DES")},nac:function(){return  false }};
   this.GXValidFnc[32]={fld:"GROUP2",grid:0};
   this.GXValidFnc[33]={fld:"TABLE3",grid:0};
   this.GXValidFnc[37]={lvl:2,type:"bits",len:4,dec:0,sign:false,ro:1,grid:36,gxgrid:this.Grid1Container,fnc:null,isvalid:null,fld:"vLINKSELECTION",gxz:"ZV5LinkSelection",gxold:"OV5LinkSelection",gxvar:"AV5LinkSelection",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",v2v:function(Value){gx.O.AV5LinkSelection=Value},v2z:function(Value){gx.O.ZV5LinkSelection=Value},v2c:function(){},c2v:function(){gx.O.AV5LinkSelection=this.val()},val:function(){return gx.fn.getGridControlValue("vLINKSELECTION",gx.fn.currentGridRowImpl(36))},nac:function(){return  false }};
   this.GXValidFnc[38]={lvl:2,type:"int",len:4,dec:0,sign:false,pic:"ZZZ9",ro:1,grid:36,gxgrid:this.Grid1Container,fnc:null,isvalid:null,rgrid:[],fld:"PRG_COD",gxz:"Z126PRG_COD",gxold:"O126PRG_COD",gxvar:"A126PRG_COD",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",v2v:function(Value){gx.O.A126PRG_COD=gx.num.intval(Value)},v2z:function(Value){gx.O.Z126PRG_COD=gx.num.intval(Value)},v2c:function(){gx.fn.setGridControlValue("PRG_COD",gx.fn.currentGridRowImpl(36),gx.O.A126PRG_COD,0)},c2v:function(){gx.O.A126PRG_COD=this.val()},val:function(){return gx.fn.getGridIntegerValue("PRG_COD",gx.fn.currentGridRowImpl(36),'.')},nac:function(){return  false }};
   this.GXValidFnc[39]={lvl:2,type:"int",len:8,dec:0,sign:false,pic:"ZZZZZZZ9",ro:1,grid:36,gxgrid:this.Grid1Container,fnc:null,isvalid:null,rgrid:[],fld:"PRS_NRO",gxz:"Z118PRS_NRO",gxold:"O118PRS_NRO",gxvar:"A118PRS_NRO",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",v2v:function(Value){gx.O.A118PRS_NRO=gx.num.intval(Value)},v2z:function(Value){gx.O.Z118PRS_NRO=gx.num.intval(Value)},v2c:function(){gx.fn.setGridControlValue("PRS_NRO",gx.fn.currentGridRowImpl(36),gx.O.A118PRS_NRO,0)},c2v:function(){gx.O.A118PRS_NRO=this.val()},val:function(){return gx.fn.getGridIntegerValue("PRS_NRO",gx.fn.currentGridRowImpl(36),'.')},nac:function(){return  false }};
   this.GXValidFnc[40]={lvl:2,type:"int",len:3,dec:0,sign:false,pic:"ZZ9",ro:1,grid:36,gxgrid:this.Grid1Container,fnc:null,isvalid:null,rgrid:[],fld:"PRS_ORD",gxz:"Z407PRS_ORD",gxold:"O407PRS_ORD",gxvar:"A407PRS_ORD",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",v2v:function(Value){gx.O.A407PRS_ORD=gx.num.intval(Value)},v2z:function(Value){gx.O.Z407PRS_ORD=gx.num.intval(Value)},v2c:function(){gx.fn.setGridControlValue("PRS_ORD",gx.fn.currentGridRowImpl(36),gx.O.A407PRS_ORD,0)},c2v:function(){gx.O.A407PRS_ORD=this.val()},val:function(){return gx.fn.getGridIntegerValue("PRS_ORD",gx.fn.currentGridRowImpl(36),'.')},nac:function(){return  false }};
   this.GXValidFnc[41]={lvl:2,type:"char",len:30,dec:0,sign:false,ro:1,grid:36,gxgrid:this.Grid1Container,fnc:null,isvalid:null,fld:"PRS_DES",gxz:"Z408PRS_DES",gxold:"O408PRS_DES",gxvar:"A408PRS_DES",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",v2v:function(Value){gx.O.A408PRS_DES=Value},v2z:function(Value){gx.O.Z408PRS_DES=Value},v2c:function(){gx.fn.setGridControlValue("PRS_DES",gx.fn.currentGridRowImpl(36),gx.O.A408PRS_DES,0)},c2v:function(){gx.O.A408PRS_DES=this.val()},val:function(){return gx.fn.getGridControlValue("PRS_DES",gx.fn.currentGridRowImpl(36))},nac:function(){return  false }};
   this.GXValidFnc[42]={lvl:2,type:"char",len:16,dec:0,sign:false,ro:1,grid:36,gxgrid:this.Grid1Container,fnc:null,isvalid:null,fld:"USU_COD",gxz:"Z6USU_COD",gxold:"O6USU_COD",gxvar:"A6USU_COD",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",v2v:function(Value){gx.O.A6USU_COD=Value},v2z:function(Value){gx.O.Z6USU_COD=Value},v2c:function(){gx.fn.setGridControlValue("USU_COD",gx.fn.currentGridRowImpl(36),gx.O.A6USU_COD,0)},c2v:function(){gx.O.A6USU_COD=this.val()},val:function(){return gx.fn.getGridControlValue("USU_COD",gx.fn.currentGridRowImpl(36))},nac:function(){return  false }};
   this.GXValidFnc[43]={lvl:2,type:"int",len:3,dec:0,sign:false,pic:"ZZ9",ro:1,grid:36,gxgrid:this.Grid1Container,fnc:null,isvalid:null,rgrid:[],fld:"SIS_COD",gxz:"Z116SIS_COD",gxold:"O116SIS_COD",gxvar:"A116SIS_COD",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",v2v:function(Value){gx.O.A116SIS_COD=gx.num.intval(Value)},v2z:function(Value){gx.O.Z116SIS_COD=gx.num.intval(Value)},v2c:function(){gx.fn.setGridControlValue("SIS_COD",gx.fn.currentGridRowImpl(36),gx.O.A116SIS_COD,0)},c2v:function(){gx.O.A116SIS_COD=this.val()},val:function(){return gx.fn.getGridIntegerValue("SIS_COD",gx.fn.currentGridRowImpl(36),'.')},nac:function(){return  false }};
   this.GXValidFnc[46]={fld:"TABLE4",grid:0};
   this.AV6cPRG_COD = 0 ;
   this.ZV6cPRG_COD = 0 ;
   this.OV6cPRG_COD = 0 ;
   this.AV7cPRS_NRO = 0 ;
   this.ZV7cPRS_NRO = 0 ;
   this.OV7cPRS_NRO = 0 ;
   this.AV8cPRS_ORD = 0 ;
   this.ZV8cPRS_ORD = 0 ;
   this.OV8cPRS_ORD = 0 ;
   this.AV9cPRS_DES = "" ;
   this.ZV9cPRS_DES = "" ;
   this.OV9cPRS_DES = "" ;
   this.ZV5LinkSelection = "" ;
   this.OV5LinkSelection = "" ;
   this.Z126PRG_COD = 0 ;
   this.O126PRG_COD = 0 ;
   this.Z118PRS_NRO = 0 ;
   this.O118PRS_NRO = 0 ;
   this.Z407PRS_ORD = 0 ;
   this.O407PRS_ORD = 0 ;
   this.Z408PRS_DES = "" ;
   this.O408PRS_DES = "" ;
   this.Z6USU_COD = "" ;
   this.O6USU_COD = "" ;
   this.Z116SIS_COD = 0 ;
   this.O116SIS_COD = 0 ;
   this.AV10pUSU_COD = "" ;
   this.AV11pSIS_COD = 0 ;
   this.AV12pPRG_COD = 0 ;
   this.AV13pPRS_NRO = 0 ;
   this.AV14pPRS_ORD = 0 ;
   this.AV5LinkSelection = "" ;
   this.A126PRG_COD = 0 ;
   this.A118PRS_NRO = 0 ;
   this.A407PRS_ORD = 0 ;
   this.A408PRS_DES = "" ;
   this.A6USU_COD = "" ;
   this.A116SIS_COD = 0 ;
   this.ServerEvents = ["e134e2_client" ,"e144e2_client"];
   this.VarControlMap["AV10pUSU_COD"] = {id:"vPUSU_COD",grid:0,type:"char"};
   this.VarControlMap["AV11pSIS_COD"] = {id:"vPSIS_COD",grid:0,type:"int"};
   this.VarControlMap["AV12pPRG_COD"] = {id:"vPPRG_COD",grid:0,type:"int"};
   this.VarControlMap["AV13pPRS_NRO"] = {id:"vPPRS_NRO",grid:0,type:"int"};
   this.VarControlMap["AV14pPRS_ORD"] = {id:"vPPRS_ORD",grid:0,type:"int"};
   this.VarControlMap["AV10pUSU_COD"] = {id:"vPUSU_COD",grid:0,type:"char"};
   this.VarControlMap["AV11pSIS_COD"] = {id:"vPSIS_COD",grid:0,type:"int"};
   this.Grid1Container.addRefreshingVar(this.GXValidFnc[14]);
   this.Grid1Container.addRefreshingVar(this.GXValidFnc[19]);
   this.Grid1Container.addRefreshingVar(this.GXValidFnc[24]);
   this.Grid1Container.addRefreshingVar(this.GXValidFnc[29]);
   this.Grid1Container.addRefreshingVar({rfrVar:"AV10pUSU_COD"});
   this.Grid1Container.addRefreshingVar({rfrVar:"AV11pSIS_COD"});
   this.SetStandaloneVars( );
}
gx00z2.prototype = new gx.GxObject;
gx.setParentObj(new gx00z2());
