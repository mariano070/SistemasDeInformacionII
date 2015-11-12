/*
               File: TSEG002TSEG003WC
        Description: TSEG002 TSEG003 WC
             Author: GeneXus C# Generator version 10_1_5-42940
       Generated on: 1/6/2014 11:8:28.14
       Program type: Callable routine
          Main DBMS: sqlserver
*/
gx.evt.autoSkip = false;
function tseg002tseg003wc(CmpContext) {
   this.ServerClass =  "TSEG002TSEG003WC" ;
   this.PackageName =  "GeneXus.Programs" ;
   this.setObjectType("web");
   this.setCmpContext(CmpContext);
   this.ReadonlyForm = true;
   this.hasEnterEvent = false;
   this.autoRefresh = true;
   this.SetStandaloneVars=function()
   {
   };
   this.Valid_Sis_cod=function()
   {
      try {
         if(  gx.fn.currentGridRowImpl(12) ===0) return true;
         var gxballoon = gx.util.balloon.getNew("SIS_COD", gx.fn.currentGridRowImpl(12));
         this.AnyError  = 0;
         this.StandaloneModal( );
         this.StandaloneNotModal( );

      }
      catch(e){}
      try {
         if (gxballoon == null) return true; return gxballoon.show();
      }
      catch(e){}
      return true ;
   }
   this.e110h2_client=function()
   {
      this.executeServerEvent("'DOINSERT'", true, arguments[0]);
   };
   this.e140h2_client=function()
   {
      this.executeServerEvent("ENTER", true, arguments[0]);
   };
   this.e150h2_client=function()
   {
      this.executeServerEvent("CANCEL", true, arguments[0]);
   };
   this.GXValidFnc = [];
   this.GXCtrlIds=[2,5,9,13,14,15,16,19];
   this.GXLastCtrlId =19;
   this.GridContainer = new gx.grid.grid(this, 2,"WbpLvl2",12,"Grid","Grid","GridContainer",this.CmpContext,this.IsMasterPage,"tseg002tseg003wc",[],false,1,false,true,0,true,false,false,"",0,"px","Nueva fila",true,false,false,null,null,false,"");
   this.GridContainer.addBitmap("&Update","vUPDATE",13,0,"px",17,"px",null,"","");
   this.GridContainer.addBitmap("&Delete","vDELETE",14,0,"px",17,"px",null,"","");
   this.GridContainer.addSingleLineEdit(116,15,"SIS_COD","CODIGO","","SIS_COD","int",0,"px",3,3,"right",null,[],116,"SIS_COD",true,0,false,false);
   this.GridContainer.addSingleLineEdit(259,16,"SIS_DES","DESCRIPCION","","SIS_DES","char",0,"px",15,15,"left",null,[],259,"SIS_DES",true,0,false,false);
   this.setGrid(this.GridContainer);
   this.GXValidFnc[2]={fld:"TABLE",grid:0};
   this.GXValidFnc[5]={fld:"TABLEGRIDCONTAINER",grid:0};
   this.GXValidFnc[9]={fld:"INSERT",grid:0};
   this.GXValidFnc[13]={lvl:2,type:"bits",len:4,dec:0,sign:false,ro:1,grid:12,gxgrid:this.GridContainer,fnc:null,isvalid:null,fld:"vUPDATE",gxz:"ZV12Update",gxold:"OV12Update",gxvar:"AV12Update",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",v2v:function(Value){gx.O.AV12Update=Value},v2z:function(Value){gx.O.ZV12Update=Value},v2c:function(){},c2v:function(){gx.O.AV12Update=this.val()},val:function(){return gx.fn.getGridControlValue("vUPDATE",gx.fn.currentGridRowImpl(12))},nac:function(){return  false }};
   this.GXValidFnc[14]={lvl:2,type:"bits",len:4,dec:0,sign:false,ro:1,grid:12,gxgrid:this.GridContainer,fnc:null,isvalid:null,fld:"vDELETE",gxz:"ZV13Delete",gxold:"OV13Delete",gxvar:"AV13Delete",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",v2v:function(Value){gx.O.AV13Delete=Value},v2z:function(Value){gx.O.ZV13Delete=Value},v2c:function(){},c2v:function(){gx.O.AV13Delete=this.val()},val:function(){return gx.fn.getGridControlValue("vDELETE",gx.fn.currentGridRowImpl(12))},nac:function(){return  false }};
   this.GXValidFnc[15]={lvl:2,type:"int",len:3,dec:0,sign:false,pic:"ZZ9",ro:1,grid:12,gxgrid:this.GridContainer,fnc:this.Valid_Sis_cod,isvalid:null,rgrid:[],fld:"SIS_COD",gxz:"Z116SIS_COD",gxold:"O116SIS_COD",gxvar:"A116SIS_COD",ucs:[],op:[16],ip:[16,15],nacdep:[],ctrltype:"edit",v2v:function(Value){gx.O.A116SIS_COD=gx.num.intval(Value)},v2z:function(Value){gx.O.Z116SIS_COD=gx.num.intval(Value)},v2c:function(){gx.fn.setGridControlValue("SIS_COD",gx.fn.currentGridRowImpl(12),gx.O.A116SIS_COD,0)},c2v:function(){gx.O.A116SIS_COD=this.val()},val:function(){return gx.fn.getGridIntegerValue("SIS_COD",gx.fn.currentGridRowImpl(12),'.')},nac:function(){return  false }};
   this.GXValidFnc[16]={lvl:2,type:"char",len:15,dec:0,sign:false,ro:1,grid:12,gxgrid:this.GridContainer,fnc:null,isvalid:null,fld:"SIS_DES",gxz:"Z259SIS_DES",gxold:"O259SIS_DES",gxvar:"A259SIS_DES",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",v2v:function(Value){gx.O.A259SIS_DES=Value},v2z:function(Value){gx.O.Z259SIS_DES=Value},v2c:function(){gx.fn.setGridControlValue("SIS_DES",gx.fn.currentGridRowImpl(12),gx.O.A259SIS_DES,0)},c2v:function(){gx.O.A259SIS_DES=this.val()},val:function(){return gx.fn.getGridControlValue("SIS_DES",gx.fn.currentGridRowImpl(12))},nac:function(){return  false }};
   this.GXValidFnc[19]={lvl:0,type:"char",len:16,dec:0,sign:false,ro:1,grid:0,gxgrid:null,fnc:null,isvalid:null,fld:"USU_COD",gxz:"Z6USU_COD",gxold:"O6USU_COD",gxvar:"A6USU_COD",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",v2v:function(Value){gx.O.A6USU_COD=Value},v2z:function(Value){gx.O.Z6USU_COD=Value},v2c:function(){gx.fn.setControlValue("USU_COD",gx.O.A6USU_COD,0)},c2v:function(){gx.O.A6USU_COD=this.val()},val:function(){return gx.fn.getControlValue("USU_COD")},nac:function(){return  false }};
   this.ZV12Update = "" ;
   this.OV12Update = "" ;
   this.ZV13Delete = "" ;
   this.OV13Delete = "" ;
   this.Z116SIS_COD = 0 ;
   this.O116SIS_COD = 0 ;
   this.Z259SIS_DES = "" ;
   this.O259SIS_DES = "" ;
   this.A6USU_COD = "" ;
   this.Z6USU_COD = "" ;
   this.O6USU_COD = "" ;
   this.AV7USU_COD = "" ;
   this.AV12Update = "" ;
   this.AV13Delete = "" ;
   this.A116SIS_COD = 0 ;
   this.A259SIS_DES = "" ;
   this.ServerEvents = ["e110h2_client" ,"e140h2_client" ,"e150h2_client"];
   this.VarControlMap["AV7USU_COD"] = {id:"vUSU_COD",grid:0,type:"char"};
   this.GridContainer.addRefreshingVar({rfrVar:"AV7USU_COD"});
   this.GridContainer.addRefreshingVar({rfrVar:"AV13Delete", rfrProp:"Tooltiptext"});
   this.GridContainer.addRefreshingVar({rfrVar:"AV13Delete", rfrProp:"Value"});
   this.GridContainer.addRefreshingVar({rfrVar:"AV12Update", rfrProp:"Tooltiptext"});
   this.GridContainer.addRefreshingVar({rfrVar:"AV12Update", rfrProp:"Value"});
   this.SetStandaloneVars( );
}
