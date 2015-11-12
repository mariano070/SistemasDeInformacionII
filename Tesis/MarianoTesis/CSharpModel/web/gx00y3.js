/*
               File: Gx00Y3
        Description: Selection List SESIONES POR USUARIO
             Author: GeneXus C# Generator version 10_1_5-42940
       Generated on: 1/6/2014 11:8:13.40
       Program type: Callable routine
          Main DBMS: sqlserver
*/
gx.evt.autoSkip = false;
function gx00y3() {
   this.ServerClass =  "Gx00Y3" ;
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
   };
   this.e134d2_client=function()
   {
      this.executeServerEvent("ENTER", true, arguments[0]);
   };
   this.e144d2_client=function()
   {
      this.executeServerEvent("CANCEL", true, arguments[0]);
   };
   this.GXValidFnc = [];
   this.GXCtrlIds=[2,8,9,14,19,24,29,32,33,37,38,39,40,41,42,43,44,45,48];
   this.GXLastCtrlId =48;
   this.Grid1Container = new gx.grid.grid(this, 2,"WbpLvl2",36,"Grid1","Grid1","Grid1Container",this.CmpContext,this.IsMasterPage,"gx00y3",[],false,1,false,true,10,true,false,false,"",0,"px","Nueva fila",true,false,false,null,null,false,"");
   this.Grid1Container.addBitmap("&Linkselection","vLINKSELECTION",37,0,"px",17,"px",null,"","");
   this.Grid1Container.addSingleLineEdit(118,38,"PRS_NRO","NRO DE SESION ASIGNADA","","PRS_NRO","int",0,"px",8,8,"right",null,[],118,"PRS_NRO",true,0,false,false);
   this.Grid1Container.addSingleLineEdit(166,39,"PRS_INI","MOMENTO DE INICIO SESION","Seleccionar","PRS_INI","dtime",0,"px",14,8,"right",null,[],166,"PRS_INI",true,5,false,false);
   this.Grid1Container.addSingleLineEdit(404,40,"PRS_UOB","ULTIMO OBJETO","","PRS_UOB","char",0,"px",20,20,"left",null,[],404,"PRS_UOB",true,0,false,false);
   this.Grid1Container.addSingleLineEdit(165,41,"PRS_CAD","MOMENTO CADUCIDAD SESION","","PRS_CAD","dtime",0,"px",14,8,"right",null,[],165,"PRS_CAD",true,5,false,false);
   this.Grid1Container.addSingleLineEdit(405,42,"PRS_UDE","DESCRIPCION ULTIMO OBJETO","","PRS_UDE","char",0,"px",30,30,"left",null,[],405,"PRS_UDE",true,0,false,false);
   this.Grid1Container.addSingleLineEdit(6,43,"USU_COD","CODIGO","","USU_COD","char",0,"px",16,16,"left",null,[],6,"USU_COD",false,0,false,false);
   this.Grid1Container.addSingleLineEdit(116,44,"SIS_COD","CODIGO","","SIS_COD","int",0,"px",3,3,"right",null,[],116,"SIS_COD",false,0,false,false);
   this.Grid1Container.addSingleLineEdit(126,45,"PRG_COD","CODIGO","","PRG_COD","int",0,"px",4,4,"right",null,[],126,"PRG_COD",false,0,false,false);
   this.setGrid(this.Grid1Container);
   this.GXValidFnc[2]={fld:"TABLE1",grid:0};
   this.GXValidFnc[8]={fld:"GROUP1",grid:0};
   this.GXValidFnc[9]={fld:"TABLE2",grid:0};
   this.GXValidFnc[12]={fld:"TEXTBLOCKPRS_NRO", format:0,grid:0};
   this.GXValidFnc[14]={lvl:0,type:"int",len:8,dec:0,sign:false,pic:"ZZZZZZZ9",ro:0,grid:0,gxgrid:null,fnc:null,isvalid:null,rgrid:[this.Grid1Container],fld:"vCPRS_NRO",gxz:"ZV6cPRS_NRO",gxold:"OV6cPRS_NRO",gxvar:"AV6cPRS_NRO",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",v2v:function(Value){gx.O.AV6cPRS_NRO=gx.num.intval(Value)},v2z:function(Value){gx.O.ZV6cPRS_NRO=gx.num.intval(Value)},v2c:function(){gx.fn.setControlValue("vCPRS_NRO",gx.O.AV6cPRS_NRO,0)},c2v:function(){gx.O.AV6cPRS_NRO=this.val()},val:function(){return gx.fn.getIntegerValue("vCPRS_NRO",'.')},nac:function(){return  false }};
   this.GXValidFnc[17]={fld:"TEXTBLOCKPRS_INI", format:0,grid:0};
   this.GXValidFnc[19]={lvl:0,type:"dtime",len:8,dec:5,sign:false,ro:0,grid:0,gxgrid:null,fnc:null,isvalid:null,fld:"vCPRS_INI",gxz:"ZV7cPRS_INI",gxold:"OV7cPRS_INI",gxvar:"AV7cPRS_INI",dp:{f:0,st:true,wn:false,mf:false,pic:"99/99/99 99:99",dec:5},ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",v2v:function(Value){gx.O.AV7cPRS_INI=gx.fn.toDatetimeValue(Value)},v2z:function(Value){gx.O.ZV7cPRS_INI=gx.fn.toDatetimeValue(Value)},v2c:function(){gx.fn.setControlValue("vCPRS_INI",gx.O.AV7cPRS_INI,0)},c2v:function(){gx.O.AV7cPRS_INI=this.val()},val:function(){return gx.fn.getControlValue("vCPRS_INI")},nac:function(){return  false }};
   this.GXValidFnc[22]={fld:"TEXTBLOCKPRS_UOB", format:0,grid:0};
   this.GXValidFnc[24]={lvl:0,type:"char",len:20,dec:0,sign:false,ro:0,grid:0,gxgrid:null,fnc:null,isvalid:null,fld:"vCPRS_UOB",gxz:"ZV8cPRS_UOB",gxold:"OV8cPRS_UOB",gxvar:"AV8cPRS_UOB",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",v2v:function(Value){gx.O.AV8cPRS_UOB=Value},v2z:function(Value){gx.O.ZV8cPRS_UOB=Value},v2c:function(){gx.fn.setControlValue("vCPRS_UOB",gx.O.AV8cPRS_UOB,0)},c2v:function(){gx.O.AV8cPRS_UOB=this.val()},val:function(){return gx.fn.getControlValue("vCPRS_UOB")},nac:function(){return  false }};
   this.GXValidFnc[27]={fld:"TEXTBLOCKPRS_CAD", format:0,grid:0};
   this.GXValidFnc[29]={lvl:0,type:"dtime",len:8,dec:5,sign:false,ro:0,grid:0,gxgrid:null,fnc:null,isvalid:null,fld:"vCPRS_CAD",gxz:"ZV9cPRS_CAD",gxold:"OV9cPRS_CAD",gxvar:"AV9cPRS_CAD",dp:{f:0,st:true,wn:false,mf:false,pic:"99/99/99 99:99",dec:5},ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",v2v:function(Value){gx.O.AV9cPRS_CAD=gx.fn.toDatetimeValue(Value)},v2z:function(Value){gx.O.ZV9cPRS_CAD=gx.fn.toDatetimeValue(Value)},v2c:function(){gx.fn.setControlValue("vCPRS_CAD",gx.O.AV9cPRS_CAD,0)},c2v:function(){gx.O.AV9cPRS_CAD=this.val()},val:function(){return gx.fn.getControlValue("vCPRS_CAD")},nac:function(){return  false }};
   this.GXValidFnc[32]={fld:"GROUP2",grid:0};
   this.GXValidFnc[33]={fld:"TABLE3",grid:0};
   this.GXValidFnc[37]={lvl:2,type:"bits",len:4,dec:0,sign:false,ro:1,grid:36,gxgrid:this.Grid1Container,fnc:null,isvalid:null,fld:"vLINKSELECTION",gxz:"ZV5LinkSelection",gxold:"OV5LinkSelection",gxvar:"AV5LinkSelection",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",v2v:function(Value){gx.O.AV5LinkSelection=Value},v2z:function(Value){gx.O.ZV5LinkSelection=Value},v2c:function(){},c2v:function(){gx.O.AV5LinkSelection=this.val()},val:function(){return gx.fn.getGridControlValue("vLINKSELECTION",gx.fn.currentGridRowImpl(36))},nac:function(){return  false }};
   this.GXValidFnc[38]={lvl:2,type:"int",len:8,dec:0,sign:false,pic:"ZZZZZZZ9",ro:1,grid:36,gxgrid:this.Grid1Container,fnc:null,isvalid:null,rgrid:[],fld:"PRS_NRO",gxz:"Z118PRS_NRO",gxold:"O118PRS_NRO",gxvar:"A118PRS_NRO",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",v2v:function(Value){gx.O.A118PRS_NRO=gx.num.intval(Value)},v2z:function(Value){gx.O.Z118PRS_NRO=gx.num.intval(Value)},v2c:function(){gx.fn.setGridControlValue("PRS_NRO",gx.fn.currentGridRowImpl(36),gx.O.A118PRS_NRO,0)},c2v:function(){gx.O.A118PRS_NRO=this.val()},val:function(){return gx.fn.getGridIntegerValue("PRS_NRO",gx.fn.currentGridRowImpl(36),'.')},nac:function(){return  false }};
   this.GXValidFnc[39]={lvl:2,type:"dtime",len:8,dec:5,sign:false,ro:1,grid:36,gxgrid:this.Grid1Container,fnc:null,isvalid:null,fld:"PRS_INI",gxz:"Z166PRS_INI",gxold:"O166PRS_INI",gxvar:"A166PRS_INI",dp:{f:0,st:true,wn:false,mf:false,pic:"99/99/99 99:99",dec:5},ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",v2v:function(Value){gx.O.A166PRS_INI=gx.fn.toDatetimeValue(Value)},v2z:function(Value){gx.O.Z166PRS_INI=gx.fn.toDatetimeValue(Value)},v2c:function(){gx.fn.setGridControlValue("PRS_INI",gx.fn.currentGridRowImpl(36),gx.O.A166PRS_INI,0)},c2v:function(){gx.O.A166PRS_INI=this.val()},val:function(){return gx.fn.getGridControlValue("PRS_INI",gx.fn.currentGridRowImpl(36))},nac:function(){return  false }};
   this.GXValidFnc[40]={lvl:2,type:"char",len:20,dec:0,sign:false,ro:1,grid:36,gxgrid:this.Grid1Container,fnc:null,isvalid:null,fld:"PRS_UOB",gxz:"Z404PRS_UOB",gxold:"O404PRS_UOB",gxvar:"A404PRS_UOB",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",v2v:function(Value){gx.O.A404PRS_UOB=Value},v2z:function(Value){gx.O.Z404PRS_UOB=Value},v2c:function(){gx.fn.setGridControlValue("PRS_UOB",gx.fn.currentGridRowImpl(36),gx.O.A404PRS_UOB,0)},c2v:function(){gx.O.A404PRS_UOB=this.val()},val:function(){return gx.fn.getGridControlValue("PRS_UOB",gx.fn.currentGridRowImpl(36))},nac:function(){return  false }};
   this.GXValidFnc[41]={lvl:2,type:"dtime",len:8,dec:5,sign:false,ro:1,grid:36,gxgrid:this.Grid1Container,fnc:null,isvalid:null,fld:"PRS_CAD",gxz:"Z165PRS_CAD",gxold:"O165PRS_CAD",gxvar:"A165PRS_CAD",dp:{f:0,st:true,wn:false,mf:false,pic:"99/99/99 99:99",dec:5},ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",v2v:function(Value){gx.O.A165PRS_CAD=gx.fn.toDatetimeValue(Value)},v2z:function(Value){gx.O.Z165PRS_CAD=gx.fn.toDatetimeValue(Value)},v2c:function(){gx.fn.setGridControlValue("PRS_CAD",gx.fn.currentGridRowImpl(36),gx.O.A165PRS_CAD,0)},c2v:function(){gx.O.A165PRS_CAD=this.val()},val:function(){return gx.fn.getGridControlValue("PRS_CAD",gx.fn.currentGridRowImpl(36))},nac:function(){return  false }};
   this.GXValidFnc[42]={lvl:2,type:"char",len:30,dec:0,sign:false,ro:1,grid:36,gxgrid:this.Grid1Container,fnc:null,isvalid:null,fld:"PRS_UDE",gxz:"Z405PRS_UDE",gxold:"O405PRS_UDE",gxvar:"A405PRS_UDE",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",v2v:function(Value){gx.O.A405PRS_UDE=Value},v2z:function(Value){gx.O.Z405PRS_UDE=Value},v2c:function(){gx.fn.setGridControlValue("PRS_UDE",gx.fn.currentGridRowImpl(36),gx.O.A405PRS_UDE,0)},c2v:function(){gx.O.A405PRS_UDE=this.val()},val:function(){return gx.fn.getGridControlValue("PRS_UDE",gx.fn.currentGridRowImpl(36))},nac:function(){return  false }};
   this.GXValidFnc[43]={lvl:2,type:"char",len:16,dec:0,sign:false,ro:1,grid:36,gxgrid:this.Grid1Container,fnc:null,isvalid:null,fld:"USU_COD",gxz:"Z6USU_COD",gxold:"O6USU_COD",gxvar:"A6USU_COD",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",v2v:function(Value){gx.O.A6USU_COD=Value},v2z:function(Value){gx.O.Z6USU_COD=Value},v2c:function(){gx.fn.setGridControlValue("USU_COD",gx.fn.currentGridRowImpl(36),gx.O.A6USU_COD,0)},c2v:function(){gx.O.A6USU_COD=this.val()},val:function(){return gx.fn.getGridControlValue("USU_COD",gx.fn.currentGridRowImpl(36))},nac:function(){return  false }};
   this.GXValidFnc[44]={lvl:2,type:"int",len:3,dec:0,sign:false,pic:"ZZ9",ro:1,grid:36,gxgrid:this.Grid1Container,fnc:null,isvalid:null,rgrid:[],fld:"SIS_COD",gxz:"Z116SIS_COD",gxold:"O116SIS_COD",gxvar:"A116SIS_COD",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",v2v:function(Value){gx.O.A116SIS_COD=gx.num.intval(Value)},v2z:function(Value){gx.O.Z116SIS_COD=gx.num.intval(Value)},v2c:function(){gx.fn.setGridControlValue("SIS_COD",gx.fn.currentGridRowImpl(36),gx.O.A116SIS_COD,0)},c2v:function(){gx.O.A116SIS_COD=this.val()},val:function(){return gx.fn.getGridIntegerValue("SIS_COD",gx.fn.currentGridRowImpl(36),'.')},nac:function(){return  false }};
   this.GXValidFnc[45]={lvl:2,type:"int",len:4,dec:0,sign:false,pic:"ZZZ9",ro:1,grid:36,gxgrid:this.Grid1Container,fnc:null,isvalid:null,rgrid:[],fld:"PRG_COD",gxz:"Z126PRG_COD",gxold:"O126PRG_COD",gxvar:"A126PRG_COD",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",v2v:function(Value){gx.O.A126PRG_COD=gx.num.intval(Value)},v2z:function(Value){gx.O.Z126PRG_COD=gx.num.intval(Value)},v2c:function(){gx.fn.setGridControlValue("PRG_COD",gx.fn.currentGridRowImpl(36),gx.O.A126PRG_COD,0)},c2v:function(){gx.O.A126PRG_COD=this.val()},val:function(){return gx.fn.getGridIntegerValue("PRG_COD",gx.fn.currentGridRowImpl(36),'.')},nac:function(){return  false }};
   this.GXValidFnc[48]={fld:"TABLE4",grid:0};
   this.AV6cPRS_NRO = 0 ;
   this.ZV6cPRS_NRO = 0 ;
   this.OV6cPRS_NRO = 0 ;
   this.AV7cPRS_INI = gx.date.nullDate() ;
   this.ZV7cPRS_INI = gx.date.nullDate() ;
   this.OV7cPRS_INI = gx.date.nullDate() ;
   this.AV8cPRS_UOB = "" ;
   this.ZV8cPRS_UOB = "" ;
   this.OV8cPRS_UOB = "" ;
   this.AV9cPRS_CAD = gx.date.nullDate() ;
   this.ZV9cPRS_CAD = gx.date.nullDate() ;
   this.OV9cPRS_CAD = gx.date.nullDate() ;
   this.ZV5LinkSelection = "" ;
   this.OV5LinkSelection = "" ;
   this.Z118PRS_NRO = 0 ;
   this.O118PRS_NRO = 0 ;
   this.Z166PRS_INI = gx.date.nullDate() ;
   this.O166PRS_INI = gx.date.nullDate() ;
   this.Z404PRS_UOB = "" ;
   this.O404PRS_UOB = "" ;
   this.Z165PRS_CAD = gx.date.nullDate() ;
   this.O165PRS_CAD = gx.date.nullDate() ;
   this.Z405PRS_UDE = "" ;
   this.O405PRS_UDE = "" ;
   this.Z6USU_COD = "" ;
   this.O6USU_COD = "" ;
   this.Z116SIS_COD = 0 ;
   this.O116SIS_COD = 0 ;
   this.Z126PRG_COD = 0 ;
   this.O126PRG_COD = 0 ;
   this.AV10pUSU_COD = "" ;
   this.AV11pSIS_COD = 0 ;
   this.AV12pPRG_COD = 0 ;
   this.AV13pPRS_NRO = 0 ;
   this.AV5LinkSelection = "" ;
   this.A118PRS_NRO = 0 ;
   this.A166PRS_INI = gx.date.nullDate() ;
   this.A404PRS_UOB = "" ;
   this.A165PRS_CAD = gx.date.nullDate() ;
   this.A405PRS_UDE = "" ;
   this.A6USU_COD = "" ;
   this.A116SIS_COD = 0 ;
   this.A126PRG_COD = 0 ;
   this.ServerEvents = ["e134d2_client" ,"e144d2_client"];
   this.VarControlMap["AV10pUSU_COD"] = {id:"vPUSU_COD",grid:0,type:"char"};
   this.VarControlMap["AV11pSIS_COD"] = {id:"vPSIS_COD",grid:0,type:"int"};
   this.VarControlMap["AV12pPRG_COD"] = {id:"vPPRG_COD",grid:0,type:"int"};
   this.VarControlMap["AV13pPRS_NRO"] = {id:"vPPRS_NRO",grid:0,type:"int"};
   this.VarControlMap["AV10pUSU_COD"] = {id:"vPUSU_COD",grid:0,type:"char"};
   this.VarControlMap["AV11pSIS_COD"] = {id:"vPSIS_COD",grid:0,type:"int"};
   this.VarControlMap["AV12pPRG_COD"] = {id:"vPPRG_COD",grid:0,type:"int"};
   this.Grid1Container.addRefreshingVar(this.GXValidFnc[14]);
   this.Grid1Container.addRefreshingVar(this.GXValidFnc[19]);
   this.Grid1Container.addRefreshingVar(this.GXValidFnc[24]);
   this.Grid1Container.addRefreshingVar(this.GXValidFnc[29]);
   this.Grid1Container.addRefreshingVar({rfrVar:"AV10pUSU_COD"});
   this.Grid1Container.addRefreshingVar({rfrVar:"AV11pSIS_COD"});
   this.Grid1Container.addRefreshingVar({rfrVar:"AV12pPRG_COD"});
   this.SetStandaloneVars( );
}
gx00y3.prototype = new gx.GxObject;
gx.setParentObj(new gx00y3());
