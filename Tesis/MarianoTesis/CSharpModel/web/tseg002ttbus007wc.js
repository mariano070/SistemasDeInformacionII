/*
               File: TSEG002TTBUS007WC
        Description: TSEG002 TTBUS007 WC
             Author: GeneXus C# Generator version 10_1_5-42940
       Generated on: 1/6/2014 11:8:32.64
       Program type: Callable routine
          Main DBMS: sqlserver
*/
gx.evt.autoSkip = false;
function tseg002ttbus007wc(CmpContext) {
   this.ServerClass =  "TSEG002TTBUS007WC" ;
   this.PackageName =  "GeneXus.Programs" ;
   this.setObjectType("web");
   this.setCmpContext(CmpContext);
   this.ReadonlyForm = true;
   this.hasEnterEvent = false;
   this.autoRefresh = true;
   this.SetStandaloneVars=function()
   {
   };
   this.Valid_Ttbus7_pos=function()
   {
      try {
         if(  gx.fn.currentGridRowImpl(12) ===0) return true;
         var gxballoon = gx.util.balloon.getNew("TTBUS7_POS", gx.fn.currentGridRowImpl(12));
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
   this.e110k2_client=function()
   {
      this.executeServerEvent("'DOINSERT'", true, arguments[0]);
   };
   this.e140k2_client=function()
   {
      this.executeServerEvent("ENTER", true, arguments[0]);
   };
   this.e150k2_client=function()
   {
      this.executeServerEvent("CANCEL", true, arguments[0]);
   };
   this.GXValidFnc = [];
   this.GXCtrlIds=[2,5,9,13,14,15,16,17,20];
   this.GXLastCtrlId =20;
   this.GridContainer = new gx.grid.grid(this, 2,"WbpLvl2",12,"Grid","Grid","GridContainer",this.CmpContext,this.IsMasterPage,"tseg002ttbus007wc",[],false,1,false,true,0,true,false,false,"",0,"px","Nueva fila",true,false,false,null,null,false,"");
   this.GridContainer.addBitmap("&Update","vUPDATE",13,0,"px",17,"px",null,"","");
   this.GridContainer.addBitmap("&Delete","vDELETE",14,0,"px",17,"px",null,"","");
   this.GridContainer.addSingleLineEdit(33,15,"TTBUS7_POS","Id. de Posición","","TTBUS7_Pos","int",0,"px",3,3,"right",null,[],33,"TTBUS7_Pos",true,0,false,false);
   this.GridContainer.addSingleLineEdit(34,16,"TTBUS7_DES","Descripción posición","","TTBUS7_Des","char",0,"px",50,50,"left",null,[],34,"TTBUS7_Des",true,0,false,false);
   this.GridContainer.addComboBox(198,17,"TTBUS7_RSR","Sistema Relacionado","TTBUS7_RSR","int",null,0,true,false,0,"px");
   this.setGrid(this.GridContainer);
   this.GXValidFnc[2]={fld:"TABLE",grid:0};
   this.GXValidFnc[5]={fld:"TABLEGRIDCONTAINER",grid:0};
   this.GXValidFnc[9]={fld:"INSERT",grid:0};
   this.GXValidFnc[13]={lvl:2,type:"bits",len:4,dec:0,sign:false,ro:1,grid:12,gxgrid:this.GridContainer,fnc:null,isvalid:null,fld:"vUPDATE",gxz:"ZV12Update",gxold:"OV12Update",gxvar:"AV12Update",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",v2v:function(Value){gx.O.AV12Update=Value},v2z:function(Value){gx.O.ZV12Update=Value},v2c:function(){},c2v:function(){gx.O.AV12Update=this.val()},val:function(){return gx.fn.getGridControlValue("vUPDATE",gx.fn.currentGridRowImpl(12))},nac:function(){return  false }};
   this.GXValidFnc[14]={lvl:2,type:"bits",len:4,dec:0,sign:false,ro:1,grid:12,gxgrid:this.GridContainer,fnc:null,isvalid:null,fld:"vDELETE",gxz:"ZV13Delete",gxold:"OV13Delete",gxvar:"AV13Delete",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",v2v:function(Value){gx.O.AV13Delete=Value},v2z:function(Value){gx.O.ZV13Delete=Value},v2c:function(){},c2v:function(){gx.O.AV13Delete=this.val()},val:function(){return gx.fn.getGridControlValue("vDELETE",gx.fn.currentGridRowImpl(12))},nac:function(){return  false }};
   this.GXValidFnc[15]={lvl:2,type:"int",len:3,dec:0,sign:false,pic:"ZZ9",ro:1,grid:12,gxgrid:this.GridContainer,fnc:this.Valid_Ttbus7_pos,isvalid:null,rgrid:[],fld:"TTBUS7_POS",gxz:"Z33TTBUS7_Pos",gxold:"O33TTBUS7_Pos",gxvar:"A33TTBUS7_Pos",ucs:[],op:[16],ip:[16,15],nacdep:[],ctrltype:"edit",v2v:function(Value){gx.O.A33TTBUS7_Pos=gx.num.intval(Value)},v2z:function(Value){gx.O.Z33TTBUS7_Pos=gx.num.intval(Value)},v2c:function(){gx.fn.setGridControlValue("TTBUS7_POS",gx.fn.currentGridRowImpl(12),gx.O.A33TTBUS7_Pos,0)},c2v:function(){gx.O.A33TTBUS7_Pos=this.val()},val:function(){return gx.fn.getGridIntegerValue("TTBUS7_POS",gx.fn.currentGridRowImpl(12),'.')},nac:function(){return  false }};
   this.GXValidFnc[16]={lvl:2,type:"char",len:50,dec:0,sign:false,ro:1,grid:12,gxgrid:this.GridContainer,fnc:null,isvalid:null,fld:"TTBUS7_DES",gxz:"Z34TTBUS7_Des",gxold:"O34TTBUS7_Des",gxvar:"A34TTBUS7_Des",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",v2v:function(Value){gx.O.A34TTBUS7_Des=Value},v2z:function(Value){gx.O.Z34TTBUS7_Des=Value},v2c:function(){gx.fn.setGridControlValue("TTBUS7_DES",gx.fn.currentGridRowImpl(12),gx.O.A34TTBUS7_Des,0)},c2v:function(){gx.O.A34TTBUS7_Des=this.val()},val:function(){return gx.fn.getGridControlValue("TTBUS7_DES",gx.fn.currentGridRowImpl(12))},nac:function(){return  false }};
   this.GXValidFnc[17]={lvl:2,type:"int",len:1,dec:0,sign:false,pic:"9",ro:1,grid:12,gxgrid:this.GridContainer,fnc:null,isvalid:null,rgrid:[],fld:"TTBUS7_RSR",gxz:"Z198TTBUS7_RSR",gxold:"O198TTBUS7_RSR",gxvar:"A198TTBUS7_RSR",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"combo",v2v:function(Value){gx.O.A198TTBUS7_RSR=gx.num.intval(Value)},v2z:function(Value){gx.O.Z198TTBUS7_RSR=gx.num.intval(Value)},v2c:function(){gx.fn.setGridComboBoxValue("TTBUS7_RSR",gx.fn.currentGridRowImpl(12),gx.O.A198TTBUS7_RSR)},c2v:function(){gx.O.A198TTBUS7_RSR=this.val()},val:function(){return gx.fn.getGridIntegerValue("TTBUS7_RSR",gx.fn.currentGridRowImpl(12),'.')},nac:function(){return  false }};
   this.GXValidFnc[20]={lvl:0,type:"char",len:16,dec:0,sign:false,ro:1,grid:0,gxgrid:null,fnc:null,isvalid:null,fld:"TTBUS7_CODRESP",gxz:"Z35TTBUS7_CodResp",gxold:"O35TTBUS7_CodResp",gxvar:"A35TTBUS7_CodResp",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",v2v:function(Value){gx.O.A35TTBUS7_CodResp=Value},v2z:function(Value){gx.O.Z35TTBUS7_CodResp=Value},v2c:function(){gx.fn.setControlValue("TTBUS7_CODRESP",gx.O.A35TTBUS7_CodResp,0)},c2v:function(){gx.O.A35TTBUS7_CodResp=this.val()},val:function(){return gx.fn.getControlValue("TTBUS7_CODRESP")},nac:function(){return  false }};
   this.ZV12Update = "" ;
   this.OV12Update = "" ;
   this.ZV13Delete = "" ;
   this.OV13Delete = "" ;
   this.Z33TTBUS7_Pos = 0 ;
   this.O33TTBUS7_Pos = 0 ;
   this.Z34TTBUS7_Des = "" ;
   this.O34TTBUS7_Des = "" ;
   this.Z198TTBUS7_RSR = 0 ;
   this.O198TTBUS7_RSR = 0 ;
   this.A35TTBUS7_CodResp = "" ;
   this.Z35TTBUS7_CodResp = "" ;
   this.O35TTBUS7_CodResp = "" ;
   this.AV7TTBUS7_CodResp = "" ;
   this.AV12Update = "" ;
   this.AV13Delete = "" ;
   this.A33TTBUS7_Pos = 0 ;
   this.A34TTBUS7_Des = "" ;
   this.A198TTBUS7_RSR = 0 ;
   this.ServerEvents = ["e110k2_client" ,"e140k2_client" ,"e150k2_client"];
   this.VarControlMap["AV7TTBUS7_CodResp"] = {id:"vTTBUS7_CODRESP",grid:0,type:"char"};
   this.GridContainer.addRefreshingVar({rfrVar:"AV7TTBUS7_CodResp"});
   this.GridContainer.addRefreshingVar({rfrVar:"AV13Delete", rfrProp:"Tooltiptext"});
   this.GridContainer.addRefreshingVar({rfrVar:"AV13Delete", rfrProp:"Value"});
   this.GridContainer.addRefreshingVar({rfrVar:"AV12Update", rfrProp:"Tooltiptext"});
   this.GridContainer.addRefreshingVar({rfrVar:"AV12Update", rfrProp:"Value"});
   this.SetStandaloneVars( );
}
