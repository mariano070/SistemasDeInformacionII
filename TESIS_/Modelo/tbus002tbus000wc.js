/*
               File: TBUS002TBUS000WC
        Description: TBUS002 TBUS000 WC
             Author: GeneXus C# Generator version 10_1_5-42940
       Generated on: 1/6/2014 11:8:7.93
       Program type: Callable routine
          Main DBMS: sqlserver
*/
gx.evt.autoSkip = false;
function tbus002tbus000wc(CmpContext) {
   this.ServerClass =  "TBUS002TBUS000WC" ;
   this.PackageName =  "GeneXus.Programs" ;
   this.setObjectType("web");
   this.setCmpContext(CmpContext);
   this.ReadonlyForm = true;
   this.hasEnterEvent = false;
   this.autoRefresh = true;
   this.SetStandaloneVars=function()
   {
   };
   this.Valid_Bus_vua=function()
   {
      try {
         if(  gx.fn.currentGridRowImpl(12) ===0) return true;
         var gxballoon = gx.util.balloon.getNew("BUS_VUA", gx.fn.currentGridRowImpl(12));
         this.AnyError  = 0;

      }
      catch(e){}
      try {
         if (gxballoon == null) return true; return gxballoon.show();
      }
      catch(e){}
      return true ;
   }
   this.Valid_Bus_vut=function()
   {
      try {
         if(  gx.fn.currentGridRowImpl(12) ===0) return true;
         var gxballoon = gx.util.balloon.getNew("BUS_VUT", gx.fn.currentGridRowImpl(12));
         this.AnyError  = 0;

      }
      catch(e){}
      try {
         if (gxballoon == null) return true; return gxballoon.show();
      }
      catch(e){}
      return true ;
   }
   this.Valid_Bus_voa=function()
   {
      try {
         if(  gx.fn.currentGridRowImpl(12) ===0) return true;
         var gxballoon = gx.util.balloon.getNew("BUS_VOA", gx.fn.currentGridRowImpl(12));
         this.AnyError  = 0;

      }
      catch(e){}
      try {
         if (gxballoon == null) return true; return gxballoon.show();
      }
      catch(e){}
      return true ;
   }
   this.Valid_Bus_aaa=function()
   {
      try {
         if(  gx.fn.currentGridRowImpl(12) ===0) return true;
         var gxballoon = gx.util.balloon.getNew("BUS_AAA", gx.fn.currentGridRowImpl(12));
         this.AnyError  = 0;

      }
      catch(e){}
      try {
         if (gxballoon == null) return true; return gxballoon.show();
      }
      catch(e){}
      return true ;
   }
   this.Valid_Bus_aea=function()
   {
      try {
         if(  gx.fn.currentGridRowImpl(12) ===0) return true;
         var gxballoon = gx.util.balloon.getNew("BUS_AEA", gx.fn.currentGridRowImpl(12));
         this.AnyError  = 0;

      }
      catch(e){}
      try {
         if (gxballoon == null) return true; return gxballoon.show();
      }
      catch(e){}
      return true ;
   }
   this.Valid_Bus_voh=function()
   {
      try {
         if(  gx.fn.currentGridRowImpl(12) ===0) return true;
         var gxballoon = gx.util.balloon.getNew("BUS_VOH", gx.fn.currentGridRowImpl(12));
         this.AnyError  = 0;

      }
      catch(e){}
      try {
         if (gxballoon == null) return true; return gxballoon.show();
      }
      catch(e){}
      return true ;
   }
   this.Valid_Bus_aah=function()
   {
      try {
         if(  gx.fn.currentGridRowImpl(12) ===0) return true;
         var gxballoon = gx.util.balloon.getNew("BUS_AAH", gx.fn.currentGridRowImpl(12));
         this.AnyError  = 0;

      }
      catch(e){}
      try {
         if (gxballoon == null) return true; return gxballoon.show();
      }
      catch(e){}
      return true ;
   }
   this.Valid_Bus_aeh=function()
   {
      try {
         if(  gx.fn.currentGridRowImpl(12) ===0) return true;
         var gxballoon = gx.util.balloon.getNew("BUS_AEH", gx.fn.currentGridRowImpl(12));
         this.AnyError  = 0;

      }
      catch(e){}
      try {
         if (gxballoon == null) return true; return gxballoon.show();
      }
      catch(e){}
      return true ;
   }
   this.e11482_client=function()
   {
      this.executeServerEvent("'DOINSERT'", true, arguments[0]);
   };
   this.e14482_client=function()
   {
      this.executeServerEvent("ENTER", true, arguments[0]);
   };
   this.e15482_client=function()
   {
      this.executeServerEvent("CANCEL", true, arguments[0]);
   };
   this.GXValidFnc = [];
   this.GXCtrlIds=[2,5,9,13,14,15,16,17,18,19,20,21,22,23,24,25,26,27,28,29,30,31,32,33,34,35,36,37,38,39,40,41,42,43,44,45,46,47,48,49,52];
   this.GXLastCtrlId =52;
   this.GridContainer = new gx.grid.grid(this, 2,"WbpLvl2",12,"Grid","Grid","GridContainer",this.CmpContext,this.IsMasterPage,"tbus002tbus000wc",[],false,1,false,true,0,true,false,false,"",0,"px","Nueva fila",true,false,false,null,null,false,"");
   this.GridContainer.addBitmap("&Update","vUPDATE",13,0,"px",17,"px",null,"","");
   this.GridContainer.addBitmap("&Delete","vDELETE",14,0,"px",17,"px",null,"","");
   this.GridContainer.addSingleLineEdit(8,15,"BUS_EMP","CODIGO DE EMPRESA","","BUS_EMP","char",0,"px",1,1,"left",null,[],8,"BUS_EMP",true,0,false,false);
   this.GridContainer.addSingleLineEdit(3,16,"BUS_COD","NUMERO DE CODIGO DEL BIEN","","BUS_COD","int",0,"px",4,4,"right",null,[],3,"BUS_COD",true,0,false,false);
   this.GridContainer.addSingleLineEdit(4,17,"BUS_PAR","NUMERO DE PARTIDA DEL BIEN","","BUS_PAR","int",0,"px",2,2,"right",null,[],4,"BUS_PAR",true,0,false,false);
   this.GridContainer.addSingleLineEdit(54,18,"BUS_DES","DESCRIPCION DEL BIEN","","BUS_DES","char",0,"px",50,50,"left",null,[],54,"BUS_DES",true,0,false,false);
   this.GridContainer.addSingleLineEdit(170,19,"BUS_FAL","FECHA DE ALTA DEL BIEN","","BUS_FAL","date",0,"px",10,10,"right",null,[],170,"BUS_FAL",true,0,false,false);
   this.GridContainer.addSingleLineEdit(55,20,"BUS_FAD","FECHA DE ADQUISICION DEL BIEN","","BUS_FAD","date",0,"px",10,10,"right",null,[],55,"BUS_FAD",true,0,false,false);
   this.GridContainer.addSingleLineEdit(329,21,"BUS_VUA","VIDA UTIL ASIGNADA AL BIEN","","BUS_VUA","int",0,"px",4,4,"right",null,[],329,"BUS_VUA",true,0,false,false);
   this.GridContainer.addSingleLineEdit(330,22,"BUS_VAO","VALOR DE ORIGEN DEL BIEN","","BUS_VAO","decimal",0,"px",18,18,"right",null,[],330,"BUS_VAO",true,7,false,false);
   this.GridContainer.addSingleLineEdit(331,23,"BUS_COM","COMPROBANTE DE COMPRA","","BUS_COM","char",0,"px",2,2,"left",null,[],331,"BUS_COM",true,0,false,false);
   this.GridContainer.addSingleLineEdit(350,24,"BUS_CBD","DE COMPRA","","BUS_CBD","char",0,"px",20,20,"left",null,[],350,"BUS_CBD",true,0,false,false);
   this.GridContainer.addSingleLineEdit(333,25,"BUS_NCO","NUMERO DEL COMP. DE COMPRA","","BUS_NCO","char",0,"px",12,12,"left",null,[],333,"BUS_NCO",true,0,false,false);
   this.GridContainer.addSingleLineEdit(171,26,"BUS_ARE","SECTOR DE LA EMPRESA","","BUS_ARE","int",0,"px",4,4,"right",null,[],171,"BUS_ARE",true,0,false,false);
   this.GridContainer.addSingleLineEdit(175,27,"BUS_ARD","ARD","","BUS_ARD","char",0,"px",30,30,"left",null,[],175,"BUS_ARD",true,0,false,false);
   this.GridContainer.addSingleLineEdit(172,28,"BUS_SEC","AREA A QUE PERTENECE EL BIEN","","BUS_SEC","int",0,"px",2,2,"right",null,[],172,"BUS_SEC",true,0,false,false);
   this.GridContainer.addSingleLineEdit(176,29,"BUS_SED","SED","","BUS_SED","char",0,"px",30,30,"left",null,[],176,"BUS_SED",true,0,false,false);
   this.GridContainer.addSingleLineEdit(56,30,"BUS_TIP","CODIGO DE TIPO DE BIEN","","BUS_TIP","int",0,"px",3,3,"right",null,[],56,"BUS_TIP",true,0,false,false);
   this.GridContainer.addSingleLineEdit(59,31,"BUS_TID","TID","","BUS_TID","char",0,"px",20,20,"left",null,[],59,"BUS_TID",true,0,false,false);
   this.GridContainer.addSingleLineEdit(174,32,"BUS_FBA","FECHA DE BAJA DEL BIEN","","BUS_FBA","date",0,"px",10,10,"right",null,[],174,"BUS_FBA",true,0,false,false);
   this.GridContainer.addSingleLineEdit(334,33,"BUS_MBA","MOTIVO DE BAJA DEL BIEN","","BUS_MBA","char",0,"px",30,30,"left",null,[],334,"BUS_MBA",true,0,false,false);
   this.GridContainer.addSingleLineEdit(340,34,"BUS_FPR","FECHA DE PROCESO AJUSTE","","BUS_FPR","date",0,"px",10,10,"right",null,[],340,"BUS_FPR",false,0,false,false);
   this.GridContainer.addSingleLineEdit(335,35,"BUS_VUT","VIDA UTIL TRANSCURRIDA","","BUS_VUT","int",0,"px",4,4,"right",null,[],335,"BUS_VUT",false,0,false,false);
   this.GridContainer.addSingleLineEdit(336,36,"BUS_COE","ULTIMO COEFICIENTE DE CALCULO","","BUS_COE","decimal",0,"px",18,18,"right",null,[],336,"BUS_COE",false,7,false,false);
   this.GridContainer.addSingleLineEdit(341,37,"BUS_VOC","VALOR ORIGEN AJUSTADO (C)","","BUS_VOC","decimal",0,"px",18,18,"right",null,[],341,"BUS_VOC",false,7,false,false);
   this.GridContainer.addSingleLineEdit(337,38,"BUS_VOA","VALOR DE ORIGEN AJUSTADO","","BUS_VOA","decimal",0,"px",18,18,"right",null,[],337,"BUS_VOA",false,7,false,false);
   this.GridContainer.addSingleLineEdit(338,39,"BUS_AAA","AMORTIZ. ACUMULADAS AJUSTADAS","","BUS_AAA","decimal",0,"px",10,10,"right",null,[],338,"BUS_AAA",false,2,false,false);
   this.GridContainer.addSingleLineEdit(339,40,"BUS_AEA","AMORTIZ. DEL EJERCICIO AJUST.","","BUS_AEA","decimal",0,"px",10,10,"right",null,[],339,"BUS_AEA",false,2,false,false);
   this.GridContainer.addSingleLineEdit(342,41,"BUS_VAH","VALOR HISTORICO BASE","","BUS_VAH","decimal",0,"px",18,18,"right",null,[],342,"BUS_VAH",true,7,false,false);
   this.GridContainer.addSingleLineEdit(343,42,"BUS_VHF","FECHA VALOR HISTORICO BASE","","BUS_VHF","date",0,"px",10,10,"right",null,[],343,"BUS_VHF",true,0,false,false);
   this.GridContainer.addSingleLineEdit(344,43,"BUS_VOH","VALOR DE ORIGEN HISTORICO","","BUS_VOH","decimal",0,"px",18,18,"right",null,[],344,"BUS_VOH",false,7,false,false);
   this.GridContainer.addSingleLineEdit(345,44,"BUS_AAH","AMORTIZ. ACUMULADAS VAL HISTOR","","BUS_AAH","decimal",0,"px",10,10,"right",null,[],345,"BUS_AAH",false,2,false,false);
   this.GridContainer.addSingleLineEdit(346,45,"BUS_AEH","AMORTIZ. DEL EJERCICIO HISTORI","","BUS_AEH","decimal",0,"px",10,10,"right",null,[],346,"BUS_AEH",false,2,false,false);
   this.GridContainer.addSingleLineEdit(347,46,"BUS_VRA","VALOR RESIDUAL AJ (FORMULA)","","BUS_VRA","decimal",0,"px",18,18,"right",null,[],347,"BUS_VRA",false,7,false,false);
   this.GridContainer.addSingleLineEdit(348,47,"BUS_VRH","VALOR RESIDUAL HIST(FORMULA)","","BUS_VRH","decimal",0,"px",18,18,"right",null,[],348,"BUS_VRH",false,7,false,false);
   this.GridContainer.addSingleLineEdit(349,48,"BUS_VUR","VIDA UTIL RESIDUAL (FORMULA)","","BUS_VUR","int",0,"px",4,4,"right",null,[],349,"BUS_VUR",false,0,false,false);
   this.GridContainer.addSingleLineEdit(103,49,"BUS_IDT","DE USO","","BUS_IDT","int",0,"px",8,8,"right",null,[],103,"BUS_IDT",true,0,false,false);
   this.setGrid(this.GridContainer);
   this.GXValidFnc[2]={fld:"TABLE",grid:0};
   this.GXValidFnc[5]={fld:"TABLEGRIDCONTAINER",grid:0};
   this.GXValidFnc[9]={fld:"INSERT",grid:0};
   this.GXValidFnc[13]={lvl:2,type:"bits",len:4,dec:0,sign:false,ro:1,grid:12,gxgrid:this.GridContainer,fnc:null,isvalid:null,fld:"vUPDATE",gxz:"ZV12Update",gxold:"OV12Update",gxvar:"AV12Update",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",v2v:function(Value){gx.O.AV12Update=Value},v2z:function(Value){gx.O.ZV12Update=Value},v2c:function(){},c2v:function(){gx.O.AV12Update=this.val()},val:function(){return gx.fn.getGridControlValue("vUPDATE",gx.fn.currentGridRowImpl(12))},nac:function(){return  false }};
   this.GXValidFnc[14]={lvl:2,type:"bits",len:4,dec:0,sign:false,ro:1,grid:12,gxgrid:this.GridContainer,fnc:null,isvalid:null,fld:"vDELETE",gxz:"ZV13Delete",gxold:"OV13Delete",gxvar:"AV13Delete",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",v2v:function(Value){gx.O.AV13Delete=Value},v2z:function(Value){gx.O.ZV13Delete=Value},v2c:function(){},c2v:function(){gx.O.AV13Delete=this.val()},val:function(){return gx.fn.getGridControlValue("vDELETE",gx.fn.currentGridRowImpl(12))},nac:function(){return  false }};
   this.GXValidFnc[15]={lvl:2,type:"char",len:1,dec:0,sign:false,ro:1,grid:12,gxgrid:this.GridContainer,fnc:null,isvalid:null,fld:"BUS_EMP",gxz:"Z8BUS_EMP",gxold:"O8BUS_EMP",gxvar:"A8BUS_EMP",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",v2v:function(Value){gx.O.A8BUS_EMP=Value},v2z:function(Value){gx.O.Z8BUS_EMP=Value},v2c:function(){gx.fn.setGridControlValue("BUS_EMP",gx.fn.currentGridRowImpl(12),gx.O.A8BUS_EMP,0)},c2v:function(){gx.O.A8BUS_EMP=this.val()},val:function(){return gx.fn.getGridControlValue("BUS_EMP",gx.fn.currentGridRowImpl(12))},nac:function(){return  false }};
   this.GXValidFnc[16]={lvl:2,type:"int",len:4,dec:0,sign:false,pic:"ZZZ9",ro:1,grid:12,gxgrid:this.GridContainer,fnc:null,isvalid:null,rgrid:[],fld:"BUS_COD",gxz:"Z3BUS_COD",gxold:"O3BUS_COD",gxvar:"A3BUS_COD",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",v2v:function(Value){gx.O.A3BUS_COD=gx.num.intval(Value)},v2z:function(Value){gx.O.Z3BUS_COD=gx.num.intval(Value)},v2c:function(){gx.fn.setGridControlValue("BUS_COD",gx.fn.currentGridRowImpl(12),gx.O.A3BUS_COD,0)},c2v:function(){gx.O.A3BUS_COD=this.val()},val:function(){return gx.fn.getGridIntegerValue("BUS_COD",gx.fn.currentGridRowImpl(12),'.')},nac:function(){return  false }};
   this.GXValidFnc[17]={lvl:2,type:"int",len:2,dec:0,sign:false,pic:"Z9",ro:1,grid:12,gxgrid:this.GridContainer,fnc:null,isvalid:null,rgrid:[],fld:"BUS_PAR",gxz:"Z4BUS_PAR",gxold:"O4BUS_PAR",gxvar:"A4BUS_PAR",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",v2v:function(Value){gx.O.A4BUS_PAR=gx.num.intval(Value)},v2z:function(Value){gx.O.Z4BUS_PAR=gx.num.intval(Value)},v2c:function(){gx.fn.setGridControlValue("BUS_PAR",gx.fn.currentGridRowImpl(12),gx.O.A4BUS_PAR,0)},c2v:function(){gx.O.A4BUS_PAR=this.val()},val:function(){return gx.fn.getGridIntegerValue("BUS_PAR",gx.fn.currentGridRowImpl(12),'.')},nac:function(){return  false }};
   this.GXValidFnc[18]={lvl:2,type:"char",len:50,dec:0,sign:false,ro:1,grid:12,gxgrid:this.GridContainer,fnc:null,isvalid:null,fld:"BUS_DES",gxz:"Z54BUS_DES",gxold:"O54BUS_DES",gxvar:"A54BUS_DES",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",v2v:function(Value){gx.O.A54BUS_DES=Value},v2z:function(Value){gx.O.Z54BUS_DES=Value},v2c:function(){gx.fn.setGridControlValue("BUS_DES",gx.fn.currentGridRowImpl(12),gx.O.A54BUS_DES,0)},c2v:function(){gx.O.A54BUS_DES=this.val()},val:function(){return gx.fn.getGridControlValue("BUS_DES",gx.fn.currentGridRowImpl(12))},nac:function(){return  false }};
   this.GXValidFnc[19]={lvl:2,type:"date",len:10,dec:0,sign:false,ro:1,grid:12,gxgrid:this.GridContainer,fnc:null,isvalid:null,fld:"BUS_FAL",gxz:"Z170BUS_FAL",gxold:"O170BUS_FAL",gxvar:"A170BUS_FAL",dp:{f:0,st:false,wn:false,mf:false,pic:"99/99/9999",dec:0},ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",v2v:function(Value){gx.O.A170BUS_FAL=gx.fn.toDatetimeValue(Value)},v2z:function(Value){gx.O.Z170BUS_FAL=gx.fn.toDatetimeValue(Value)},v2c:function(){gx.fn.setGridControlValue("BUS_FAL",gx.fn.currentGridRowImpl(12),gx.O.A170BUS_FAL,0)},c2v:function(){gx.O.A170BUS_FAL=this.val()},val:function(){return gx.fn.getGridControlValue("BUS_FAL",gx.fn.currentGridRowImpl(12))},nac:function(){return  false }};
   this.GXValidFnc[20]={lvl:2,type:"date",len:10,dec:0,sign:false,ro:1,grid:12,gxgrid:this.GridContainer,fnc:null,isvalid:null,fld:"BUS_FAD",gxz:"Z55BUS_FAD",gxold:"O55BUS_FAD",gxvar:"A55BUS_FAD",dp:{f:0,st:false,wn:false,mf:false,pic:"99/99/9999",dec:0},ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",v2v:function(Value){gx.O.A55BUS_FAD=gx.fn.toDatetimeValue(Value)},v2z:function(Value){gx.O.Z55BUS_FAD=gx.fn.toDatetimeValue(Value)},v2c:function(){gx.fn.setGridControlValue("BUS_FAD",gx.fn.currentGridRowImpl(12),gx.O.A55BUS_FAD,0)},c2v:function(){gx.O.A55BUS_FAD=this.val()},val:function(){return gx.fn.getGridControlValue("BUS_FAD",gx.fn.currentGridRowImpl(12))},nac:function(){return  false }};
   this.GXValidFnc[21]={lvl:2,type:"int",len:4,dec:0,sign:false,pic:"ZZZ9",ro:1,grid:12,gxgrid:this.GridContainer,fnc:this.Valid_Bus_vua,isvalid:null,rgrid:[],fld:"BUS_VUA",gxz:"Z329BUS_VUA",gxold:"O329BUS_VUA",gxvar:"A329BUS_VUA",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",v2v:function(Value){gx.O.A329BUS_VUA=gx.num.intval(Value)},v2z:function(Value){gx.O.Z329BUS_VUA=gx.num.intval(Value)},v2c:function(){gx.fn.setGridControlValue("BUS_VUA",gx.fn.currentGridRowImpl(12),gx.O.A329BUS_VUA,0)},c2v:function(){gx.O.A329BUS_VUA=this.val()},val:function(){return gx.fn.getGridIntegerValue("BUS_VUA",gx.fn.currentGridRowImpl(12),'.')},nac:function(){return  false }};
   this.GXValidFnc[22]={lvl:2,type:"decimal",len:18,dec:7,sign:false,pic:"ZZZZZZZZZ9.9999999",ro:1,grid:12,gxgrid:this.GridContainer,fnc:null,isvalid:null,rgrid:[],fld:"BUS_VAO",gxz:"Z330BUS_VAO",gxold:"O330BUS_VAO",gxvar:"A330BUS_VAO",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",v2v:function(Value){gx.O.A330BUS_VAO=gx.fn.toDecimalValue(Value,',','.')},v2z:function(Value){gx.O.Z330BUS_VAO=gx.fn.toDecimalValue(Value,'.',',')},v2c:function(){gx.fn.setGridDecimalValue("BUS_VAO",gx.fn.currentGridRowImpl(12),gx.O.A330BUS_VAO,7,',')},c2v:function(){gx.O.A330BUS_VAO=this.val()},val:function(){return gx.fn.getGridDecimalValue("BUS_VAO",gx.fn.currentGridRowImpl(12),'.',',')},nac:function(){return  false }};
   this.GXValidFnc[23]={lvl:2,type:"char",len:2,dec:0,sign:false,ro:1,grid:12,gxgrid:this.GridContainer,fnc:null,isvalid:null,fld:"BUS_COM",gxz:"Z331BUS_COM",gxold:"O331BUS_COM",gxvar:"A331BUS_COM",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",v2v:function(Value){gx.O.A331BUS_COM=Value},v2z:function(Value){gx.O.Z331BUS_COM=Value},v2c:function(){gx.fn.setGridControlValue("BUS_COM",gx.fn.currentGridRowImpl(12),gx.O.A331BUS_COM,0)},c2v:function(){gx.O.A331BUS_COM=this.val()},val:function(){return gx.fn.getGridControlValue("BUS_COM",gx.fn.currentGridRowImpl(12))},nac:function(){return  false }};
   this.GXValidFnc[24]={lvl:2,type:"char",len:20,dec:0,sign:false,ro:1,grid:12,gxgrid:this.GridContainer,fnc:null,isvalid:null,fld:"BUS_CBD",gxz:"Z350BUS_CBD",gxold:"O350BUS_CBD",gxvar:"A350BUS_CBD",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",v2v:function(Value){gx.O.A350BUS_CBD=Value},v2z:function(Value){gx.O.Z350BUS_CBD=Value},v2c:function(){gx.fn.setGridControlValue("BUS_CBD",gx.fn.currentGridRowImpl(12),gx.O.A350BUS_CBD,0)},c2v:function(){gx.O.A350BUS_CBD=this.val()},val:function(){return gx.fn.getGridControlValue("BUS_CBD",gx.fn.currentGridRowImpl(12))},nac:function(){return  false }};
   this.GXValidFnc[25]={lvl:2,type:"char",len:12,dec:0,sign:false,ro:1,grid:12,gxgrid:this.GridContainer,fnc:null,isvalid:null,fld:"BUS_NCO",gxz:"Z333BUS_NCO",gxold:"O333BUS_NCO",gxvar:"A333BUS_NCO",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",v2v:function(Value){gx.O.A333BUS_NCO=Value},v2z:function(Value){gx.O.Z333BUS_NCO=Value},v2c:function(){gx.fn.setGridControlValue("BUS_NCO",gx.fn.currentGridRowImpl(12),gx.O.A333BUS_NCO,0)},c2v:function(){gx.O.A333BUS_NCO=this.val()},val:function(){return gx.fn.getGridControlValue("BUS_NCO",gx.fn.currentGridRowImpl(12))},nac:function(){return  false }};
   this.GXValidFnc[26]={lvl:2,type:"int",len:4,dec:0,sign:false,pic:"ZZZ9",ro:1,grid:12,gxgrid:this.GridContainer,fnc:null,isvalid:null,rgrid:[],fld:"BUS_ARE",gxz:"Z171BUS_ARE",gxold:"O171BUS_ARE",gxvar:"A171BUS_ARE",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",v2v:function(Value){gx.O.A171BUS_ARE=gx.num.intval(Value)},v2z:function(Value){gx.O.Z171BUS_ARE=gx.num.intval(Value)},v2c:function(){gx.fn.setGridControlValue("BUS_ARE",gx.fn.currentGridRowImpl(12),gx.O.A171BUS_ARE,0)},c2v:function(){gx.O.A171BUS_ARE=this.val()},val:function(){return gx.fn.getGridIntegerValue("BUS_ARE",gx.fn.currentGridRowImpl(12),'.')},nac:function(){return  false }};
   this.GXValidFnc[27]={lvl:2,type:"char",len:30,dec:0,sign:false,ro:1,grid:12,gxgrid:this.GridContainer,fnc:null,isvalid:null,fld:"BUS_ARD",gxz:"Z175BUS_ARD",gxold:"O175BUS_ARD",gxvar:"A175BUS_ARD",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",v2v:function(Value){gx.O.A175BUS_ARD=Value},v2z:function(Value){gx.O.Z175BUS_ARD=Value},v2c:function(){gx.fn.setGridControlValue("BUS_ARD",gx.fn.currentGridRowImpl(12),gx.O.A175BUS_ARD,0)},c2v:function(){gx.O.A175BUS_ARD=this.val()},val:function(){return gx.fn.getGridControlValue("BUS_ARD",gx.fn.currentGridRowImpl(12))},nac:function(){return  false }};
   this.GXValidFnc[28]={lvl:2,type:"int",len:2,dec:0,sign:false,pic:"Z9",ro:1,grid:12,gxgrid:this.GridContainer,fnc:null,isvalid:null,rgrid:[],fld:"BUS_SEC",gxz:"Z172BUS_SEC",gxold:"O172BUS_SEC",gxvar:"A172BUS_SEC",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",v2v:function(Value){gx.O.A172BUS_SEC=gx.num.intval(Value)},v2z:function(Value){gx.O.Z172BUS_SEC=gx.num.intval(Value)},v2c:function(){gx.fn.setGridControlValue("BUS_SEC",gx.fn.currentGridRowImpl(12),gx.O.A172BUS_SEC,0)},c2v:function(){gx.O.A172BUS_SEC=this.val()},val:function(){return gx.fn.getGridIntegerValue("BUS_SEC",gx.fn.currentGridRowImpl(12),'.')},nac:function(){return  false }};
   this.GXValidFnc[29]={lvl:2,type:"char",len:30,dec:0,sign:false,ro:1,grid:12,gxgrid:this.GridContainer,fnc:null,isvalid:null,fld:"BUS_SED",gxz:"Z176BUS_SED",gxold:"O176BUS_SED",gxvar:"A176BUS_SED",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",v2v:function(Value){gx.O.A176BUS_SED=Value},v2z:function(Value){gx.O.Z176BUS_SED=Value},v2c:function(){gx.fn.setGridControlValue("BUS_SED",gx.fn.currentGridRowImpl(12),gx.O.A176BUS_SED,0)},c2v:function(){gx.O.A176BUS_SED=this.val()},val:function(){return gx.fn.getGridControlValue("BUS_SED",gx.fn.currentGridRowImpl(12))},nac:function(){return  false }};
   this.GXValidFnc[30]={lvl:2,type:"int",len:3,dec:0,sign:false,pic:"ZZ9",ro:1,grid:12,gxgrid:this.GridContainer,fnc:null,isvalid:null,rgrid:[],fld:"BUS_TIP",gxz:"Z56BUS_TIP",gxold:"O56BUS_TIP",gxvar:"A56BUS_TIP",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",v2v:function(Value){gx.O.A56BUS_TIP=gx.num.intval(Value)},v2z:function(Value){gx.O.Z56BUS_TIP=gx.num.intval(Value)},v2c:function(){gx.fn.setGridControlValue("BUS_TIP",gx.fn.currentGridRowImpl(12),gx.O.A56BUS_TIP,0)},c2v:function(){gx.O.A56BUS_TIP=this.val()},val:function(){return gx.fn.getGridIntegerValue("BUS_TIP",gx.fn.currentGridRowImpl(12),'.')},nac:function(){return  false }};
   this.GXValidFnc[31]={lvl:2,type:"char",len:20,dec:0,sign:false,ro:1,grid:12,gxgrid:this.GridContainer,fnc:null,isvalid:null,fld:"BUS_TID",gxz:"Z59BUS_TID",gxold:"O59BUS_TID",gxvar:"A59BUS_TID",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",v2v:function(Value){gx.O.A59BUS_TID=Value},v2z:function(Value){gx.O.Z59BUS_TID=Value},v2c:function(){gx.fn.setGridControlValue("BUS_TID",gx.fn.currentGridRowImpl(12),gx.O.A59BUS_TID,0)},c2v:function(){gx.O.A59BUS_TID=this.val()},val:function(){return gx.fn.getGridControlValue("BUS_TID",gx.fn.currentGridRowImpl(12))},nac:function(){return  false }};
   this.GXValidFnc[32]={lvl:2,type:"date",len:10,dec:0,sign:false,ro:1,grid:12,gxgrid:this.GridContainer,fnc:null,isvalid:null,fld:"BUS_FBA",gxz:"Z174BUS_FBA",gxold:"O174BUS_FBA",gxvar:"A174BUS_FBA",dp:{f:0,st:false,wn:false,mf:false,pic:"99/99/9999",dec:0},ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",v2v:function(Value){gx.O.A174BUS_FBA=gx.fn.toDatetimeValue(Value)},v2z:function(Value){gx.O.Z174BUS_FBA=gx.fn.toDatetimeValue(Value)},v2c:function(){gx.fn.setGridControlValue("BUS_FBA",gx.fn.currentGridRowImpl(12),gx.O.A174BUS_FBA,0)},c2v:function(){gx.O.A174BUS_FBA=this.val()},val:function(){return gx.fn.getGridControlValue("BUS_FBA",gx.fn.currentGridRowImpl(12))},nac:function(){return  false }};
   this.GXValidFnc[33]={lvl:2,type:"char",len:30,dec:0,sign:false,ro:1,grid:12,gxgrid:this.GridContainer,fnc:null,isvalid:null,fld:"BUS_MBA",gxz:"Z334BUS_MBA",gxold:"O334BUS_MBA",gxvar:"A334BUS_MBA",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",v2v:function(Value){gx.O.A334BUS_MBA=Value},v2z:function(Value){gx.O.Z334BUS_MBA=Value},v2c:function(){gx.fn.setGridControlValue("BUS_MBA",gx.fn.currentGridRowImpl(12),gx.O.A334BUS_MBA,0)},c2v:function(){gx.O.A334BUS_MBA=this.val()},val:function(){return gx.fn.getGridControlValue("BUS_MBA",gx.fn.currentGridRowImpl(12))},nac:function(){return  false }};
   this.GXValidFnc[34]={lvl:2,type:"date",len:10,dec:0,sign:false,ro:1,grid:12,gxgrid:this.GridContainer,fnc:null,isvalid:null,fld:"BUS_FPR",gxz:"Z340BUS_FPR",gxold:"O340BUS_FPR",gxvar:"A340BUS_FPR",dp:{f:0,st:false,wn:false,mf:false,pic:"99/99/9999",dec:0},ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",v2v:function(Value){gx.O.A340BUS_FPR=gx.fn.toDatetimeValue(Value)},v2z:function(Value){gx.O.Z340BUS_FPR=gx.fn.toDatetimeValue(Value)},v2c:function(){gx.fn.setGridControlValue("BUS_FPR",gx.fn.currentGridRowImpl(12),gx.O.A340BUS_FPR,0)},c2v:function(){gx.O.A340BUS_FPR=this.val()},val:function(){return gx.fn.getGridControlValue("BUS_FPR",gx.fn.currentGridRowImpl(12))},nac:function(){return  false }};
   this.GXValidFnc[35]={lvl:2,type:"int",len:4,dec:0,sign:false,pic:"ZZZ9",ro:1,grid:12,gxgrid:this.GridContainer,fnc:this.Valid_Bus_vut,isvalid:null,rgrid:[],fld:"BUS_VUT",gxz:"Z335BUS_VUT",gxold:"O335BUS_VUT",gxvar:"A335BUS_VUT",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",v2v:function(Value){gx.O.A335BUS_VUT=gx.num.intval(Value)},v2z:function(Value){gx.O.Z335BUS_VUT=gx.num.intval(Value)},v2c:function(){gx.fn.setGridControlValue("BUS_VUT",gx.fn.currentGridRowImpl(12),gx.O.A335BUS_VUT,0)},c2v:function(){gx.O.A335BUS_VUT=this.val()},val:function(){return gx.fn.getGridIntegerValue("BUS_VUT",gx.fn.currentGridRowImpl(12),'.')},nac:function(){return  false }};
   this.GXValidFnc[36]={lvl:2,type:"decimal",len:18,dec:7,sign:false,pic:"ZZZZZZZZZ9.9999999",ro:1,grid:12,gxgrid:this.GridContainer,fnc:null,isvalid:null,rgrid:[],fld:"BUS_COE",gxz:"Z336BUS_COE",gxold:"O336BUS_COE",gxvar:"A336BUS_COE",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",v2v:function(Value){gx.O.A336BUS_COE=gx.fn.toDecimalValue(Value,',','.')},v2z:function(Value){gx.O.Z336BUS_COE=gx.fn.toDecimalValue(Value,'.',',')},v2c:function(){gx.fn.setGridDecimalValue("BUS_COE",gx.fn.currentGridRowImpl(12),gx.O.A336BUS_COE,7,',')},c2v:function(){gx.O.A336BUS_COE=this.val()},val:function(){return gx.fn.getGridDecimalValue("BUS_COE",gx.fn.currentGridRowImpl(12),'.',',')},nac:function(){return  false }};
   this.GXValidFnc[37]={lvl:2,type:"decimal",len:18,dec:7,sign:false,pic:"ZZZZZZZZZ9.9999999",ro:1,grid:12,gxgrid:this.GridContainer,fnc:null,isvalid:null,rgrid:[],fld:"BUS_VOC",gxz:"Z341BUS_VOC",gxold:"O341BUS_VOC",gxvar:"A341BUS_VOC",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",v2v:function(Value){gx.O.A341BUS_VOC=gx.fn.toDecimalValue(Value,',','.')},v2z:function(Value){gx.O.Z341BUS_VOC=gx.fn.toDecimalValue(Value,'.',',')},v2c:function(){gx.fn.setGridDecimalValue("BUS_VOC",gx.fn.currentGridRowImpl(12),gx.O.A341BUS_VOC,7,',')},c2v:function(){gx.O.A341BUS_VOC=this.val()},val:function(){return gx.fn.getGridDecimalValue("BUS_VOC",gx.fn.currentGridRowImpl(12),'.',',')},nac:function(){return  false }};
   this.GXValidFnc[38]={lvl:2,type:"decimal",len:18,dec:7,sign:false,pic:"ZZZZZZZZZ9.9999999",ro:1,grid:12,gxgrid:this.GridContainer,fnc:this.Valid_Bus_voa,isvalid:null,rgrid:[],fld:"BUS_VOA",gxz:"Z337BUS_VOA",gxold:"O337BUS_VOA",gxvar:"A337BUS_VOA",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",v2v:function(Value){gx.O.A337BUS_VOA=gx.fn.toDecimalValue(Value,',','.')},v2z:function(Value){gx.O.Z337BUS_VOA=gx.fn.toDecimalValue(Value,'.',',')},v2c:function(){gx.fn.setGridDecimalValue("BUS_VOA",gx.fn.currentGridRowImpl(12),gx.O.A337BUS_VOA,7,',')},c2v:function(){gx.O.A337BUS_VOA=this.val()},val:function(){return gx.fn.getGridDecimalValue("BUS_VOA",gx.fn.currentGridRowImpl(12),'.',',')},nac:function(){return  false }};
   this.GXValidFnc[39]={lvl:2,type:"decimal",len:10,dec:2,sign:false,pic:"ZZZZZZ9.99",ro:1,grid:12,gxgrid:this.GridContainer,fnc:this.Valid_Bus_aaa,isvalid:null,rgrid:[],fld:"BUS_AAA",gxz:"Z338BUS_AAA",gxold:"O338BUS_AAA",gxvar:"A338BUS_AAA",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",v2v:function(Value){gx.O.A338BUS_AAA=gx.fn.toDecimalValue(Value,',','.')},v2z:function(Value){gx.O.Z338BUS_AAA=gx.fn.toDecimalValue(Value,'.',',')},v2c:function(){gx.fn.setGridDecimalValue("BUS_AAA",gx.fn.currentGridRowImpl(12),gx.O.A338BUS_AAA,2,',')},c2v:function(){gx.O.A338BUS_AAA=this.val()},val:function(){return gx.fn.getGridDecimalValue("BUS_AAA",gx.fn.currentGridRowImpl(12),'.',',')},nac:function(){return  false }};
   this.GXValidFnc[40]={lvl:2,type:"decimal",len:10,dec:2,sign:false,pic:"ZZZZZZ9.99",ro:1,grid:12,gxgrid:this.GridContainer,fnc:this.Valid_Bus_aea,isvalid:null,rgrid:[],fld:"BUS_AEA",gxz:"Z339BUS_AEA",gxold:"O339BUS_AEA",gxvar:"A339BUS_AEA",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",v2v:function(Value){gx.O.A339BUS_AEA=gx.fn.toDecimalValue(Value,',','.')},v2z:function(Value){gx.O.Z339BUS_AEA=gx.fn.toDecimalValue(Value,'.',',')},v2c:function(){gx.fn.setGridDecimalValue("BUS_AEA",gx.fn.currentGridRowImpl(12),gx.O.A339BUS_AEA,2,',')},c2v:function(){gx.O.A339BUS_AEA=this.val()},val:function(){return gx.fn.getGridDecimalValue("BUS_AEA",gx.fn.currentGridRowImpl(12),'.',',')},nac:function(){return  false }};
   this.GXValidFnc[41]={lvl:2,type:"decimal",len:18,dec:7,sign:false,pic:"ZZZZZZZZZ9.9999999",ro:1,grid:12,gxgrid:this.GridContainer,fnc:null,isvalid:null,rgrid:[],fld:"BUS_VAH",gxz:"Z342BUS_VAH",gxold:"O342BUS_VAH",gxvar:"A342BUS_VAH",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",v2v:function(Value){gx.O.A342BUS_VAH=gx.fn.toDecimalValue(Value,',','.')},v2z:function(Value){gx.O.Z342BUS_VAH=gx.fn.toDecimalValue(Value,'.',',')},v2c:function(){gx.fn.setGridDecimalValue("BUS_VAH",gx.fn.currentGridRowImpl(12),gx.O.A342BUS_VAH,7,',')},c2v:function(){gx.O.A342BUS_VAH=this.val()},val:function(){return gx.fn.getGridDecimalValue("BUS_VAH",gx.fn.currentGridRowImpl(12),'.',',')},nac:function(){return  false }};
   this.GXValidFnc[42]={lvl:2,type:"date",len:10,dec:0,sign:false,ro:1,grid:12,gxgrid:this.GridContainer,fnc:null,isvalid:null,fld:"BUS_VHF",gxz:"Z343BUS_VHF",gxold:"O343BUS_VHF",gxvar:"A343BUS_VHF",dp:{f:0,st:false,wn:false,mf:false,pic:"99/99/9999",dec:0},ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",v2v:function(Value){gx.O.A343BUS_VHF=gx.fn.toDatetimeValue(Value)},v2z:function(Value){gx.O.Z343BUS_VHF=gx.fn.toDatetimeValue(Value)},v2c:function(){gx.fn.setGridControlValue("BUS_VHF",gx.fn.currentGridRowImpl(12),gx.O.A343BUS_VHF,0)},c2v:function(){gx.O.A343BUS_VHF=this.val()},val:function(){return gx.fn.getGridControlValue("BUS_VHF",gx.fn.currentGridRowImpl(12))},nac:function(){return  false }};
   this.GXValidFnc[43]={lvl:2,type:"decimal",len:18,dec:7,sign:false,pic:"ZZZZZZZZZ9.9999999",ro:1,grid:12,gxgrid:this.GridContainer,fnc:this.Valid_Bus_voh,isvalid:null,rgrid:[],fld:"BUS_VOH",gxz:"Z344BUS_VOH",gxold:"O344BUS_VOH",gxvar:"A344BUS_VOH",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",v2v:function(Value){gx.O.A344BUS_VOH=gx.fn.toDecimalValue(Value,',','.')},v2z:function(Value){gx.O.Z344BUS_VOH=gx.fn.toDecimalValue(Value,'.',',')},v2c:function(){gx.fn.setGridDecimalValue("BUS_VOH",gx.fn.currentGridRowImpl(12),gx.O.A344BUS_VOH,7,',')},c2v:function(){gx.O.A344BUS_VOH=this.val()},val:function(){return gx.fn.getGridDecimalValue("BUS_VOH",gx.fn.currentGridRowImpl(12),'.',',')},nac:function(){return  false }};
   this.GXValidFnc[44]={lvl:2,type:"decimal",len:10,dec:2,sign:false,pic:"ZZZZZZ9.99",ro:1,grid:12,gxgrid:this.GridContainer,fnc:this.Valid_Bus_aah,isvalid:null,rgrid:[],fld:"BUS_AAH",gxz:"Z345BUS_AAH",gxold:"O345BUS_AAH",gxvar:"A345BUS_AAH",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",v2v:function(Value){gx.O.A345BUS_AAH=gx.fn.toDecimalValue(Value,',','.')},v2z:function(Value){gx.O.Z345BUS_AAH=gx.fn.toDecimalValue(Value,'.',',')},v2c:function(){gx.fn.setGridDecimalValue("BUS_AAH",gx.fn.currentGridRowImpl(12),gx.O.A345BUS_AAH,2,',')},c2v:function(){gx.O.A345BUS_AAH=this.val()},val:function(){return gx.fn.getGridDecimalValue("BUS_AAH",gx.fn.currentGridRowImpl(12),'.',',')},nac:function(){return  false }};
   this.GXValidFnc[45]={lvl:2,type:"decimal",len:10,dec:2,sign:false,pic:"ZZZZZZ9.99",ro:1,grid:12,gxgrid:this.GridContainer,fnc:this.Valid_Bus_aeh,isvalid:null,rgrid:[],fld:"BUS_AEH",gxz:"Z346BUS_AEH",gxold:"O346BUS_AEH",gxvar:"A346BUS_AEH",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",v2v:function(Value){gx.O.A346BUS_AEH=gx.fn.toDecimalValue(Value,',','.')},v2z:function(Value){gx.O.Z346BUS_AEH=gx.fn.toDecimalValue(Value,'.',',')},v2c:function(){gx.fn.setGridDecimalValue("BUS_AEH",gx.fn.currentGridRowImpl(12),gx.O.A346BUS_AEH,2,',')},c2v:function(){gx.O.A346BUS_AEH=this.val()},val:function(){return gx.fn.getGridDecimalValue("BUS_AEH",gx.fn.currentGridRowImpl(12),'.',',')},nac:function(){return  false }};
   this.GXValidFnc[46]={lvl:2,type:"decimal",len:18,dec:7,sign:false,pic:"ZZZZZZZZZ9.9999999",ro:1,grid:12,gxgrid:this.GridContainer,fnc:null,isvalid:null,rgrid:[],fld:"BUS_VRA",gxz:"Z347BUS_VRA",gxold:"O347BUS_VRA",gxvar:"A347BUS_VRA",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",v2v:function(Value){gx.O.A347BUS_VRA=gx.fn.toDecimalValue(Value,',','.')},v2z:function(Value){gx.O.Z347BUS_VRA=gx.fn.toDecimalValue(Value,'.',',')},v2c:function(){gx.fn.setGridDecimalValue("BUS_VRA",gx.fn.currentGridRowImpl(12),gx.O.A347BUS_VRA,7,',')},c2v:function(){gx.O.A347BUS_VRA=this.val()},val:function(){return gx.fn.getGridDecimalValue("BUS_VRA",gx.fn.currentGridRowImpl(12),'.',',')},nac:function(){return  false }};
   this.GXValidFnc[47]={lvl:2,type:"decimal",len:18,dec:7,sign:false,pic:"ZZZZZZZZZ9.9999999",ro:1,grid:12,gxgrid:this.GridContainer,fnc:null,isvalid:null,rgrid:[],fld:"BUS_VRH",gxz:"Z348BUS_VRH",gxold:"O348BUS_VRH",gxvar:"A348BUS_VRH",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",v2v:function(Value){gx.O.A348BUS_VRH=gx.fn.toDecimalValue(Value,',','.')},v2z:function(Value){gx.O.Z348BUS_VRH=gx.fn.toDecimalValue(Value,'.',',')},v2c:function(){gx.fn.setGridDecimalValue("BUS_VRH",gx.fn.currentGridRowImpl(12),gx.O.A348BUS_VRH,7,',')},c2v:function(){gx.O.A348BUS_VRH=this.val()},val:function(){return gx.fn.getGridDecimalValue("BUS_VRH",gx.fn.currentGridRowImpl(12),'.',',')},nac:function(){return  false }};
   this.GXValidFnc[48]={lvl:2,type:"int",len:4,dec:0,sign:false,pic:"ZZZ9",ro:1,grid:12,gxgrid:this.GridContainer,fnc:null,isvalid:null,rgrid:[],fld:"BUS_VUR",gxz:"Z349BUS_VUR",gxold:"O349BUS_VUR",gxvar:"A349BUS_VUR",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",v2v:function(Value){gx.O.A349BUS_VUR=gx.num.intval(Value)},v2z:function(Value){gx.O.Z349BUS_VUR=gx.num.intval(Value)},v2c:function(){gx.fn.setGridControlValue("BUS_VUR",gx.fn.currentGridRowImpl(12),gx.O.A349BUS_VUR,0)},c2v:function(){gx.O.A349BUS_VUR=this.val()},val:function(){return gx.fn.getGridIntegerValue("BUS_VUR",gx.fn.currentGridRowImpl(12),'.')},nac:function(){return  false }};
   this.GXValidFnc[49]={lvl:2,type:"int",len:8,dec:0,sign:false,pic:"ZZZZZZZ9",ro:1,grid:12,gxgrid:this.GridContainer,fnc:null,isvalid:null,rgrid:[],fld:"BUS_IDT",gxz:"Z103BUS_IDT",gxold:"O103BUS_IDT",gxvar:"A103BUS_IDT",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",v2v:function(Value){gx.O.A103BUS_IDT=gx.num.intval(Value)},v2z:function(Value){gx.O.Z103BUS_IDT=gx.num.intval(Value)},v2c:function(){gx.fn.setGridControlValue("BUS_IDT",gx.fn.currentGridRowImpl(12),gx.O.A103BUS_IDT,0)},c2v:function(){gx.O.A103BUS_IDT=this.val()},val:function(){return gx.fn.getGridIntegerValue("BUS_IDT",gx.fn.currentGridRowImpl(12),'.')},nac:function(){return  false }};
   this.GXValidFnc[52]={lvl:0,type:"int",len:4,dec:0,sign:false,pic:"ZZZ9",ro:1,grid:0,gxgrid:null,fnc:null,isvalid:null,rgrid:[],fld:"BUS_RUB",gxz:"Z1BUS_RUB",gxold:"O1BUS_RUB",gxvar:"A1BUS_RUB",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",v2v:function(Value){gx.O.A1BUS_RUB=gx.num.intval(Value)},v2z:function(Value){gx.O.Z1BUS_RUB=gx.num.intval(Value)},v2c:function(){gx.fn.setControlValue("BUS_RUB",gx.O.A1BUS_RUB,0)},c2v:function(){gx.O.A1BUS_RUB=this.val()},val:function(){return gx.fn.getIntegerValue("BUS_RUB",'.')},nac:function(){return  false }};
   this.ZV12Update = "" ;
   this.OV12Update = "" ;
   this.ZV13Delete = "" ;
   this.OV13Delete = "" ;
   this.Z8BUS_EMP = "" ;
   this.O8BUS_EMP = "" ;
   this.Z3BUS_COD = 0 ;
   this.O3BUS_COD = 0 ;
   this.Z4BUS_PAR = 0 ;
   this.O4BUS_PAR = 0 ;
   this.Z54BUS_DES = "" ;
   this.O54BUS_DES = "" ;
   this.Z170BUS_FAL = gx.date.nullDate() ;
   this.O170BUS_FAL = gx.date.nullDate() ;
   this.Z55BUS_FAD = gx.date.nullDate() ;
   this.O55BUS_FAD = gx.date.nullDate() ;
   this.Z329BUS_VUA = 0 ;
   this.O329BUS_VUA = 0 ;
   this.Z330BUS_VAO = 0 ;
   this.O330BUS_VAO = 0 ;
   this.Z331BUS_COM = "" ;
   this.O331BUS_COM = "" ;
   this.Z350BUS_CBD = "" ;
   this.O350BUS_CBD = "" ;
   this.Z333BUS_NCO = "" ;
   this.O333BUS_NCO = "" ;
   this.Z171BUS_ARE = 0 ;
   this.O171BUS_ARE = 0 ;
   this.Z175BUS_ARD = "" ;
   this.O175BUS_ARD = "" ;
   this.Z172BUS_SEC = 0 ;
   this.O172BUS_SEC = 0 ;
   this.Z176BUS_SED = "" ;
   this.O176BUS_SED = "" ;
   this.Z56BUS_TIP = 0 ;
   this.O56BUS_TIP = 0 ;
   this.Z59BUS_TID = "" ;
   this.O59BUS_TID = "" ;
   this.Z174BUS_FBA = gx.date.nullDate() ;
   this.O174BUS_FBA = gx.date.nullDate() ;
   this.Z334BUS_MBA = "" ;
   this.O334BUS_MBA = "" ;
   this.Z340BUS_FPR = gx.date.nullDate() ;
   this.O340BUS_FPR = gx.date.nullDate() ;
   this.Z335BUS_VUT = 0 ;
   this.O335BUS_VUT = 0 ;
   this.Z336BUS_COE = 0 ;
   this.O336BUS_COE = 0 ;
   this.Z341BUS_VOC = 0 ;
   this.O341BUS_VOC = 0 ;
   this.Z337BUS_VOA = 0 ;
   this.O337BUS_VOA = 0 ;
   this.Z338BUS_AAA = 0 ;
   this.O338BUS_AAA = 0 ;
   this.Z339BUS_AEA = 0 ;
   this.O339BUS_AEA = 0 ;
   this.Z342BUS_VAH = 0 ;
   this.O342BUS_VAH = 0 ;
   this.Z343BUS_VHF = gx.date.nullDate() ;
   this.O343BUS_VHF = gx.date.nullDate() ;
   this.Z344BUS_VOH = 0 ;
   this.O344BUS_VOH = 0 ;
   this.Z345BUS_AAH = 0 ;
   this.O345BUS_AAH = 0 ;
   this.Z346BUS_AEH = 0 ;
   this.O346BUS_AEH = 0 ;
   this.Z347BUS_VRA = 0 ;
   this.O347BUS_VRA = 0 ;
   this.Z348BUS_VRH = 0 ;
   this.O348BUS_VRH = 0 ;
   this.Z349BUS_VUR = 0 ;
   this.O349BUS_VUR = 0 ;
   this.Z103BUS_IDT = 0 ;
   this.O103BUS_IDT = 0 ;
   this.A1BUS_RUB = 0 ;
   this.Z1BUS_RUB = 0 ;
   this.O1BUS_RUB = 0 ;
   this.AV7BUS_RUB = 0 ;
   this.AV12Update = "" ;
   this.AV13Delete = "" ;
   this.A8BUS_EMP = "" ;
   this.A3BUS_COD = 0 ;
   this.A4BUS_PAR = 0 ;
   this.A54BUS_DES = "" ;
   this.A170BUS_FAL = gx.date.nullDate() ;
   this.A55BUS_FAD = gx.date.nullDate() ;
   this.A329BUS_VUA = 0 ;
   this.A330BUS_VAO = 0 ;
   this.A331BUS_COM = "" ;
   this.A350BUS_CBD = "" ;
   this.A333BUS_NCO = "" ;
   this.A171BUS_ARE = 0 ;
   this.A175BUS_ARD = "" ;
   this.A172BUS_SEC = 0 ;
   this.A176BUS_SED = "" ;
   this.A56BUS_TIP = 0 ;
   this.A59BUS_TID = "" ;
   this.A174BUS_FBA = gx.date.nullDate() ;
   this.A334BUS_MBA = "" ;
   this.A340BUS_FPR = gx.date.nullDate() ;
   this.A335BUS_VUT = 0 ;
   this.A336BUS_COE = 0 ;
   this.A341BUS_VOC = 0 ;
   this.A337BUS_VOA = 0 ;
   this.A338BUS_AAA = 0 ;
   this.A339BUS_AEA = 0 ;
   this.A342BUS_VAH = 0 ;
   this.A343BUS_VHF = gx.date.nullDate() ;
   this.A344BUS_VOH = 0 ;
   this.A345BUS_AAH = 0 ;
   this.A346BUS_AEH = 0 ;
   this.A347BUS_VRA = 0 ;
   this.A348BUS_VRH = 0 ;
   this.A349BUS_VUR = 0 ;
   this.A103BUS_IDT = 0 ;
   this.ServerEvents = ["e11482_client" ,"e14482_client" ,"e15482_client"];
   this.VarControlMap["AV7BUS_RUB"] = {id:"vBUS_RUB",grid:0,type:"int"};
   this.GridContainer.addRefreshingVar({rfrVar:"AV7BUS_RUB"});
   this.GridContainer.addRefreshingVar({rfrVar:"AV13Delete", rfrProp:"Tooltiptext"});
   this.GridContainer.addRefreshingVar({rfrVar:"AV13Delete", rfrProp:"Value"});
   this.GridContainer.addRefreshingVar({rfrVar:"AV12Update", rfrProp:"Tooltiptext"});
   this.GridContainer.addRefreshingVar({rfrVar:"AV12Update", rfrProp:"Value"});
   this.GridContainer.addRefreshingVar(this.GXValidFnc[52]);
   this.SetStandaloneVars( );
}