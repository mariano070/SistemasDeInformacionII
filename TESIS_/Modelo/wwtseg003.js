/*
               File: WWTSEG003
        Description: Work With ACT. USUARIO/SISTEMA
             Author: GeneXus C# Generator version 10_1_5-42940
       Generated on: 1/6/2014 11:8:27.43
       Program type: Main program
          Main DBMS: sqlserver
*/
gx.evt.autoSkip = false;
function wwtseg003() {
   this.ServerClass =  "WWTSEG003" ;
   this.PackageName =  "GeneXus.Programs" ;
   this.setObjectType("web");
   this.hasEnterEvent = false;
   this.autoRefresh = true;
   this.SetStandaloneVars=function()
   {
   };
   this.Valid_Usu_cod=function()
   {
      try {
         if(  gx.fn.currentGridRowImpl(26) ===0) return true;
         var gxballoon = gx.util.balloon.getNew("USU_COD", gx.fn.currentGridRowImpl(26));
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
   this.Valid_Sis_cod=function()
   {
      try {
         if(  gx.fn.currentGridRowImpl(26) ===0) return true;
         var gxballoon = gx.util.balloon.getNew("SIS_COD", gx.fn.currentGridRowImpl(26));
         this.AnyError  = 0;

      }
      catch(e){}
      try {
         if (gxballoon == null) return true; return gxballoon.show();
      }
      catch(e){}
      return true ;
   }
   this.e110q2_client=function()
   {
      this.executeServerEvent("'DOINSERT'", true, arguments[0]);
   };
   this.e150q2_client=function()
   {
      this.executeServerEvent("ENTER", true, arguments[0]);
   };
   this.e160q2_client=function()
   {
      this.executeServerEvent("CANCEL", true, arguments[0]);
   };
   this.GXValidFnc = [];
   this.GXCtrlIds=[2,8,13,19,23,27,28,29,30,31,32,33];
   this.GXLastCtrlId =33;
   this.GridContainer = new gx.grid.grid(this, 2,"WbpLvl2",26,"Grid","Grid","GridContainer",this.CmpContext,this.IsMasterPage,"wwtseg003",[],false,1,false,true,0,true,false,false,"",0,"px","Nueva fila",true,false,false,null,null,false,"");
   this.GridContainer.addBitmap("&Update","vUPDATE",27,0,"px",17,"px",null,"","");
   this.GridContainer.addBitmap("&Delete","vDELETE",28,0,"px",17,"px",null,"","");
   this.GridContainer.addSingleLineEdit(6,29,"USU_COD","CODIGO","","USU_COD","char",0,"px",16,16,"left",null,[],6,"USU_COD",true,0,false,false);
   this.GridContainer.addSingleLineEdit(7,30,"USU_DES","DESCRIPCION","","USU_DES","char",0,"px",50,50,"left",null,[],7,"USU_DES",true,0,false,false);
   this.GridContainer.addSingleLineEdit(155,31,"USU_CLA","CONTRASEÑA","","USU_CLA","char",0,"px",20,20,"left",null,[],155,"USU_CLA",false,0,false,true);
   this.GridContainer.addSingleLineEdit(116,32,"SIS_COD","CODIGO","","SIS_COD","int",0,"px",3,3,"right",null,[],116,"SIS_COD",true,0,false,false);
   this.GridContainer.addSingleLineEdit(259,33,"SIS_DES","DESCRIPCION","","SIS_DES","char",0,"px",15,15,"left",null,[],259,"SIS_DES",true,0,false,false);
   this.setGrid(this.GridContainer);
   this.GXValidFnc[2]={fld:"TABLE",grid:0};
   this.GXValidFnc[5]={fld:"TITLETEXT", format:0,grid:0};
   this.GXValidFnc[8]={fld:"TABLESEARCH",grid:0};
   this.GXValidFnc[11]={fld:"FILTERTEXTUSU_DES", format:0,grid:0};
   this.GXValidFnc[13]={lvl:0,type:"char",len:50,dec:0,sign:false,ro:0,grid:0,gxgrid:null,fnc:null,isvalid:null,fld:"vUSU_DES",gxz:"ZV13USU_DES",gxold:"OV13USU_DES",gxvar:"AV13USU_DES",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",v2v:function(Value){gx.O.AV13USU_DES=Value},v2z:function(Value){gx.O.ZV13USU_DES=Value},v2c:function(){gx.fn.setControlValue("vUSU_DES",gx.O.AV13USU_DES,0)},c2v:function(){gx.O.AV13USU_DES=this.val()},val:function(){return gx.fn.getControlValue("vUSU_DES")},nac:function(){return  false }};
   this.GXValidFnc[16]={fld:"TABLESEPARATOR", format:0,grid:0};
   this.GXValidFnc[19]={fld:"TABLEGRIDCONTAINER",grid:0};
   this.GXValidFnc[23]={fld:"INSERT",grid:0};
   this.GXValidFnc[27]={lvl:2,type:"bits",len:4,dec:0,sign:false,ro:1,grid:26,gxgrid:this.GridContainer,fnc:null,isvalid:null,fld:"vUPDATE",gxz:"ZV14Update",gxold:"OV14Update",gxvar:"AV14Update",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",v2v:function(Value){gx.O.AV14Update=Value},v2z:function(Value){gx.O.ZV14Update=Value},v2c:function(){},c2v:function(){gx.O.AV14Update=this.val()},val:function(){return gx.fn.getGridControlValue("vUPDATE",gx.fn.currentGridRowImpl(26))},nac:function(){return  false }};
   this.GXValidFnc[28]={lvl:2,type:"bits",len:4,dec:0,sign:false,ro:1,grid:26,gxgrid:this.GridContainer,fnc:null,isvalid:null,fld:"vDELETE",gxz:"ZV15Delete",gxold:"OV15Delete",gxvar:"AV15Delete",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",v2v:function(Value){gx.O.AV15Delete=Value},v2z:function(Value){gx.O.ZV15Delete=Value},v2c:function(){},c2v:function(){gx.O.AV15Delete=this.val()},val:function(){return gx.fn.getGridControlValue("vDELETE",gx.fn.currentGridRowImpl(26))},nac:function(){return  false }};
   this.GXValidFnc[29]={lvl:2,type:"char",len:16,dec:0,sign:false,ro:1,grid:26,gxgrid:this.GridContainer,fnc:this.Valid_Usu_cod,isvalid:null,fld:"USU_COD",gxz:"Z6USU_COD",gxold:"O6USU_COD",gxvar:"A6USU_COD",ucs:[],op:[30,31,33],ip:[30,31,33,29,32],nacdep:[],ctrltype:"edit",v2v:function(Value){gx.O.A6USU_COD=Value},v2z:function(Value){gx.O.Z6USU_COD=Value},v2c:function(){gx.fn.setGridControlValue("USU_COD",gx.fn.currentGridRowImpl(26),gx.O.A6USU_COD,0)},c2v:function(){gx.O.A6USU_COD=this.val()},val:function(){return gx.fn.getGridControlValue("USU_COD",gx.fn.currentGridRowImpl(26))},nac:function(){return  false }};
   this.GXValidFnc[30]={lvl:2,type:"char",len:50,dec:0,sign:false,ro:1,grid:26,gxgrid:this.GridContainer,fnc:null,isvalid:null,fld:"USU_DES",gxz:"Z7USU_DES",gxold:"O7USU_DES",gxvar:"A7USU_DES",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",v2v:function(Value){gx.O.A7USU_DES=Value},v2z:function(Value){gx.O.Z7USU_DES=Value},v2c:function(){gx.fn.setGridControlValue("USU_DES",gx.fn.currentGridRowImpl(26),gx.O.A7USU_DES,0)},c2v:function(){gx.O.A7USU_DES=this.val()},val:function(){return gx.fn.getGridControlValue("USU_DES",gx.fn.currentGridRowImpl(26))},nac:function(){return  false }};
   this.GXValidFnc[31]={lvl:2,type:"char",len:20,dec:0,sign:false,isPwd:true,ro:1,grid:26,gxgrid:this.GridContainer,fnc:null,isvalid:null,fld:"USU_CLA",gxz:"Z155USU_CLA",gxold:"O155USU_CLA",gxvar:"A155USU_CLA",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",v2v:function(Value){gx.O.A155USU_CLA=Value},v2z:function(Value){gx.O.Z155USU_CLA=Value},v2c:function(){gx.fn.setGridControlValue("USU_CLA",gx.fn.currentGridRowImpl(26),gx.O.A155USU_CLA,0)},c2v:function(){gx.O.A155USU_CLA=this.val()},val:function(){return gx.fn.getGridControlValue("USU_CLA",gx.fn.currentGridRowImpl(26))},nac:function(){return  false }};
   this.GXValidFnc[32]={lvl:2,type:"int",len:3,dec:0,sign:false,pic:"ZZ9",ro:1,grid:26,gxgrid:this.GridContainer,fnc:this.Valid_Sis_cod,isvalid:null,rgrid:[],fld:"SIS_COD",gxz:"Z116SIS_COD",gxold:"O116SIS_COD",gxvar:"A116SIS_COD",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",v2v:function(Value){gx.O.A116SIS_COD=gx.num.intval(Value)},v2z:function(Value){gx.O.Z116SIS_COD=gx.num.intval(Value)},v2c:function(){gx.fn.setGridControlValue("SIS_COD",gx.fn.currentGridRowImpl(26),gx.O.A116SIS_COD,0)},c2v:function(){gx.O.A116SIS_COD=this.val()},val:function(){return gx.fn.getGridIntegerValue("SIS_COD",gx.fn.currentGridRowImpl(26),'.')},nac:function(){return  false }};
   this.GXValidFnc[33]={lvl:2,type:"char",len:15,dec:0,sign:false,ro:1,grid:26,gxgrid:this.GridContainer,fnc:null,isvalid:null,fld:"SIS_DES",gxz:"Z259SIS_DES",gxold:"O259SIS_DES",gxvar:"A259SIS_DES",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",v2v:function(Value){gx.O.A259SIS_DES=Value},v2z:function(Value){gx.O.Z259SIS_DES=Value},v2c:function(){gx.fn.setGridControlValue("SIS_DES",gx.fn.currentGridRowImpl(26),gx.O.A259SIS_DES,0)},c2v:function(){gx.O.A259SIS_DES=this.val()},val:function(){return gx.fn.getGridControlValue("SIS_DES",gx.fn.currentGridRowImpl(26))},nac:function(){return  false }};
   this.AV13USU_DES = "" ;
   this.ZV13USU_DES = "" ;
   this.OV13USU_DES = "" ;
   this.ZV14Update = "" ;
   this.OV14Update = "" ;
   this.ZV15Delete = "" ;
   this.OV15Delete = "" ;
   this.Z6USU_COD = "" ;
   this.O6USU_COD = "" ;
   this.Z7USU_DES = "" ;
   this.O7USU_DES = "" ;
   this.Z155USU_CLA = "" ;
   this.O155USU_CLA = "" ;
   this.Z116SIS_COD = 0 ;
   this.O116SIS_COD = 0 ;
   this.Z259SIS_DES = "" ;
   this.O259SIS_DES = "" ;
   this.AV14Update = "" ;
   this.AV15Delete = "" ;
   this.A6USU_COD = "" ;
   this.A7USU_DES = "" ;
   this.A155USU_CLA = "" ;
   this.A116SIS_COD = 0 ;
   this.A259SIS_DES = "" ;
   this.ServerEvents = ["e110q2_client" ,"e150q2_client" ,"e160q2_client"];
   this.GridContainer.addRefreshingVar(this.GXValidFnc[13]);
   this.GridContainer.addRefreshingVar({rfrVar:"AV15Delete", rfrProp:"Tooltiptext"});
   this.GridContainer.addRefreshingVar({rfrVar:"AV15Delete", rfrProp:"Value"});
   this.GridContainer.addRefreshingVar({rfrVar:"AV14Update", rfrProp:"Tooltiptext"});
   this.GridContainer.addRefreshingVar({rfrVar:"AV14Update", rfrProp:"Value"});
   this.SetStandaloneVars( );
}
wwtseg003.prototype = new gx.GxObject;
gx.setParentObj(new wwtseg003());
