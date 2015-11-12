/*
               File: TBUS002TTBUS000WC
        Description: TBUS002 TTBUS000 WC
             Author: GeneXus C# Generator version 10_1_5-42940
       Generated on: 1/6/2014 11:8:5.32
       Program type: Callable routine
          Main DBMS: sqlserver
*/
gx.evt.autoSkip = false;
function tbus002ttbus000wc(CmpContext) {
   this.ServerClass =  "TBUS002TTBUS000WC" ;
   this.PackageName =  "GeneXus.Programs" ;
   this.setObjectType("web");
   this.setCmpContext(CmpContext);
   this.ReadonlyForm = true;
   this.hasEnterEvent = false;
   this.autoRefresh = true;
   this.SetStandaloneVars=function()
   {
   };
   this.Valid_Bus_emp=function()
   {
      try {
         if(  gx.fn.currentGridRowImpl(12) ===0) return true;
         var gxballoon = gx.util.balloon.getNew("BUS_EMP", gx.fn.currentGridRowImpl(12));
         this.AnyError  = 0;

      }
      catch(e){}
      try {
         if (gxballoon == null) return true; return gxballoon.show();
      }
      catch(e){}
      return true ;
   }
   this.Valid_Bus_rub=function()
   {
      try {
         if(  gx.fn.currentGridRowImpl(12) ===0) return true;
         var gxballoon = gx.util.balloon.getNew("BUS_RUB", gx.fn.currentGridRowImpl(12));
         this.AnyError  = 0;

      }
      catch(e){}
      try {
         if (gxballoon == null) return true; return gxballoon.show();
      }
      catch(e){}
      return true ;
   }
   this.Valid_Bus_cod=function()
   {
      try {
         if(  gx.fn.currentGridRowImpl(12) ===0) return true;
         var gxballoon = gx.util.balloon.getNew("BUS_COD", gx.fn.currentGridRowImpl(12));
         this.AnyError  = 0;

      }
      catch(e){}
      try {
         if (gxballoon == null) return true; return gxballoon.show();
      }
      catch(e){}
      return true ;
   }
   this.Valid_Bus_par=function()
   {
      try {
         if(  gx.fn.currentGridRowImpl(12) ===0) return true;
         var gxballoon = gx.util.balloon.getNew("BUS_PAR", gx.fn.currentGridRowImpl(12));
         this.AnyError  = 0;

      }
      catch(e){}
      try {
         if (gxballoon == null) return true; return gxballoon.show();
      }
      catch(e){}
      return true ;
   }
   this.Valid_Hardware_id=function()
   {
      try {
         if(  gx.fn.currentGridRowImpl(12) ===0) return true;
         var gxballoon = gx.util.balloon.getNew("HARDWARE_ID", gx.fn.currentGridRowImpl(12));
         this.AnyError  = 0;

      }
      catch(e){}
      try {
         if (gxballoon == null) return true; return gxballoon.show();
      }
      catch(e){}
      return true ;
   }
   this.Valid_Ttbus_rubrobien=function()
   {
      try {
         var gxballoon = gx.util.balloon.getNew("TTBUS_RUBROBIEN");
         this.AnyError  = 0;

      }
      catch(e){}
      try {
         if (gxballoon == null) return true; return gxballoon.show();
      }
      catch(e){}
      return true ;
   }
   this.e11492_client=function()
   {
      this.executeServerEvent("'DOINSERT'", true, arguments[0]);
   };
   this.e14492_client=function()
   {
      this.executeServerEvent("ENTER", true, arguments[0]);
   };
   this.e15492_client=function()
   {
      this.executeServerEvent("CANCEL", true, arguments[0]);
   };
   this.GXValidFnc = [];
   this.GXCtrlIds=[2,5,9,13,14,15,16,17,18,19,20,21,22,23,24,25,26,27,28,29,30,31,32,33,34,35,36,37,38,39,40,41,42,45];
   this.GXLastCtrlId =45;
   this.GridContainer = new gx.grid.grid(this, 2,"WbpLvl2",12,"Grid","Grid","GridContainer",this.CmpContext,this.IsMasterPage,"tbus002ttbus000wc",[],false,1,false,true,0,true,false,false,"",0,"px","Nueva fila",true,false,false,null,null,false,"");
   this.GridContainer.addBitmap("&Update","vUPDATE",13,0,"px",17,"px",null,"","");
   this.GridContainer.addBitmap("&Delete","vDELETE",14,0,"px",17,"px",null,"","");
   this.GridContainer.addSingleLineEdit(11,15,"TTBUS_ID","Id del bien de uso:","","TTBUS_Id","int",0,"px",8,8,"right",null,[],11,"TTBUS_Id",true,0,false,false);
   this.GridContainer.addSingleLineEdit(12,16,"TTBUS_DESCRIPCION","Descripción:","","TTBUS_Descripcion","svchar",0,"px",50,50,"left",null,"["+"'"+"TTBUS_DESCRIPCION"+"',["+"],["+""+"]"+",false"+",["+""+"]"+"];",12,"TTBUS_Descripcion",true,0,false,false);
   this.GridContainer.addSingleLineEdit(8,17,"BUS_EMP","CODIGO DE EMPRESA","","BUS_EMP","char",0,"px",1,1,"left",null,[],8,"BUS_EMP",true,0,false,false);
   this.GridContainer.addSingleLineEdit(1,18,"BUS_RUB","RUBRO DEL BIEN","","BUS_RUB","int",0,"px",4,4,"right",null,[],1,"BUS_RUB",true,0,false,false);
   this.GridContainer.addSingleLineEdit(61,19,"BUS_RUD","DESCRIPCIPCION RUBRO","","BUS_RUD","char",0,"px",30,30,"left",null,[],61,"BUS_RUD",true,0,false,false);
   this.GridContainer.addSingleLineEdit(3,20,"BUS_COD","NUMERO DE CODIGO DEL BIEN","","BUS_COD","int",0,"px",4,4,"right",null,[],3,"BUS_COD",true,0,false,false);
   this.GridContainer.addSingleLineEdit(4,21,"BUS_PAR","NUMERO DE PARTIDA DEL BIEN","","BUS_PAR","int",0,"px",2,2,"right",null,[],4,"BUS_PAR",true,0,false,false);
   this.GridContainer.addSingleLineEdit(54,22,"BUS_DES","DESCRIPCION DEL BIEN","","BUS_DES","char",0,"px",50,50,"left",null,[],54,"BUS_DES",true,0,false,false);
   this.GridContainer.addSingleLineEdit(55,23,"BUS_FAD","FECHA DE ADQUISICION DEL BIEN","","BUS_FAD","date",0,"px",10,10,"right",null,[],55,"BUS_FAD",true,0,false,false);
   this.GridContainer.addSingleLineEdit(56,24,"BUS_TIP","CODIGO DE TIPO DE BIEN","","BUS_TIP","int",0,"px",3,3,"right",null,[],56,"BUS_TIP",true,0,false,false);
   this.GridContainer.addSingleLineEdit(59,25,"BUS_TID","BUS_ TID","","BUS_TID","char",0,"px",20,20,"left",null,[],59,"BUS_TID",true,0,false,false);
   this.GridContainer.addSingleLineEdit(10,26,"HARDWARE_ID","ID","","HARDWARE_ID","int",0,"px",4,4,"right",null,[],10,"HARDWARE_ID",true,0,false,false);
   this.GridContainer.addSingleLineEdit(58,27,"HARDWARE_DESCRIPCION","HARDWARE","","HARDWARE_DESCRIPCION","svchar",0,"px",40,40,"left",null,[],58,"HARDWARE_DESCRIPCION",true,0,false,false);
   this.GridContainer.addSingleLineEdit(9,28,"HARDWARE_NRO_SERIE","NRO. SERIE","","HARDWARE_NRO_SERIE","svchar",0,"px",20,20,"left",null,[],9,"HARDWARE_NRO_SERIE",true,0,false,false);
   this.GridContainer.addSingleLineEdit(13,29,"TTBUS_FECHACARGA","Fecha de Carga:","","TTBUS_FechaCarga","date",0,"px",10,10,"right",null,[],13,"TTBUS_FechaCarga",true,0,false,false);
   this.GridContainer.addComboBox(23,30,"TTBUS_ESTADO","de uso","TTBUS_Estado","int",null,0,true,false,0,"px");
   this.GridContainer.addSingleLineEdit(27,31,"TTBUS_CODPROVEEDOR","Proveedor","","TTBUS_CodProveedor","int",0,"px",8,8,"right",null,[],27,"TTBUS_CodProveedor",true,0,false,false);
   this.GridContainer.addSingleLineEdit(30,32,"TTBUS_DESPROVEEDOR","Proveedor","","TTBUS_DesProveedor","char",0,"px",30,30,"left",null,[],30,"TTBUS_DesProveedor",true,0,false,false);
   this.GridContainer.addSingleLineEdit(73,33,"TTBUS_CUCPROVEEDOR","Cursograma Proveedor","","TTBUS_CucProveedor","int",0,"px",8,8,"right",null,[],73,"TTBUS_CucProveedor",true,0,false,false);
   this.GridContainer.addCheckBox(29,34,"TTBUS_ALQUILADO","SI/ NO)","","TTBUS_Alquilado","int",1,0,null,true,false,0,"px");
   this.GridContainer.addSingleLineEdit(37,35,"TTBUS_CODPOSICION","Actual Bien","","TTBUS_CodPosicion","int",0,"px",3,3,"right",null,[],37,"TTBUS_CodPosicion",true,0,false,false);
   this.GridContainer.addSingleLineEdit(38,36,"TTBUS_DESPOSICION","Actual Bien","","TTBUS_DesPosicion","char",0,"px",50,50,"left",null,[],38,"TTBUS_DesPosicion",true,0,false,false);
   this.GridContainer.addSingleLineEdit(18,37,"TTBUS_RUBRODESC","del bien","","TTBUS_RubroDesc","char",0,"px",30,30,"left",null,[],18,"TTBUS_RubroDesc",true,0,false,false);
   this.GridContainer.addSingleLineEdit(74,38,"TTBUS_CONTDOCU","de documentación","","TTBUS_ContDocu","int",0,"px",8,8,"right",null,[],74,"TTBUS_ContDocu",true,0,false,false);
   this.GridContainer.addSingleLineEdit(75,39,"TTBUS_USUARIOALTA","de uso","","TTBUS_UsuarioAlta","char",0,"px",15,15,"left",null,[],75,"TTBUS_UsuarioAlta",true,0,false,false);
   this.GridContainer.addSingleLineEdit(76,40,"TTBUS_MAQUINAALTA","el bien","","TTBUS_MaquinaAlta","char",0,"px",20,20,"left",null,[],76,"TTBUS_MaquinaAlta",true,0,false,false);
   this.GridContainer.addSingleLineEdit(41,41,"TTBUS_EMPRESA","de Empresa","","TTBUS_Empresa","int",0,"px",1,1,"right",null,[],41,"TTBUS_Empresa",true,0,false,false);
   this.GridContainer.addSingleLineEdit(42,42,"TTBUS_NROSERIE","de Serie","","TTBUS_NroSerie","svchar",0,"px",20,20,"left",null,[],42,"TTBUS_NroSerie",true,0,false,false);
   this.setGrid(this.GridContainer);
   this.GXValidFnc[2]={fld:"TABLE",grid:0};
   this.GXValidFnc[5]={fld:"TABLEGRIDCONTAINER",grid:0};
   this.GXValidFnc[9]={fld:"INSERT",grid:0};
   this.GXValidFnc[13]={lvl:2,type:"bits",len:4,dec:0,sign:false,ro:1,grid:12,gxgrid:this.GridContainer,fnc:null,isvalid:null,fld:"vUPDATE",gxz:"ZV12Update",gxold:"OV12Update",gxvar:"AV12Update",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",v2v:function(Value){gx.O.AV12Update=Value},v2z:function(Value){gx.O.ZV12Update=Value},v2c:function(){},c2v:function(){gx.O.AV12Update=this.val()},val:function(){return gx.fn.getGridControlValue("vUPDATE",gx.fn.currentGridRowImpl(12))},nac:function(){return  false }};
   this.GXValidFnc[14]={lvl:2,type:"bits",len:4,dec:0,sign:false,ro:1,grid:12,gxgrid:this.GridContainer,fnc:null,isvalid:null,fld:"vDELETE",gxz:"ZV13Delete",gxold:"OV13Delete",gxvar:"AV13Delete",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",v2v:function(Value){gx.O.AV13Delete=Value},v2z:function(Value){gx.O.ZV13Delete=Value},v2c:function(){},c2v:function(){gx.O.AV13Delete=this.val()},val:function(){return gx.fn.getGridControlValue("vDELETE",gx.fn.currentGridRowImpl(12))},nac:function(){return  false }};
   this.GXValidFnc[15]={lvl:2,type:"int",len:8,dec:0,sign:false,pic:"ZZZZZZZ9",ro:1,grid:12,gxgrid:this.GridContainer,fnc:null,isvalid:null,rgrid:[],fld:"TTBUS_ID",gxz:"Z11TTBUS_Id",gxold:"O11TTBUS_Id",gxvar:"A11TTBUS_Id",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",v2v:function(Value){gx.O.A11TTBUS_Id=gx.num.intval(Value)},v2z:function(Value){gx.O.Z11TTBUS_Id=gx.num.intval(Value)},v2c:function(){gx.fn.setGridControlValue("TTBUS_ID",gx.fn.currentGridRowImpl(12),gx.O.A11TTBUS_Id,0)},c2v:function(){gx.O.A11TTBUS_Id=this.val()},val:function(){return gx.fn.getGridIntegerValue("TTBUS_ID",gx.fn.currentGridRowImpl(12),'.')},nac:function(){return  false }};
   this.GXValidFnc[16]={lvl:2,gxsgprm:['TTBUS_DESCRIPCION',[],[],false,[]],type:"svchar",len:50,dec:0,sign:false,ro:1,grid:12,gxgrid:this.GridContainer,fnc:null,isvalid:null,fld:"TTBUS_DESCRIPCION",gxz:"Z12TTBUS_Descripcion",gxold:"O12TTBUS_Descripcion",gxvar:"A12TTBUS_Descripcion",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",v2v:function(Value){gx.O.A12TTBUS_Descripcion=Value},v2z:function(Value){gx.O.Z12TTBUS_Descripcion=Value},v2c:function(){gx.fn.setGridControlValue("TTBUS_DESCRIPCION",gx.fn.currentGridRowImpl(12),gx.O.A12TTBUS_Descripcion,0)},c2v:function(){gx.O.A12TTBUS_Descripcion=this.val()},val:function(){return gx.fn.getGridControlValue("TTBUS_DESCRIPCION",gx.fn.currentGridRowImpl(12))},nac:function(){return  false }};
   this.GXValidFnc[17]={lvl:2,type:"char",len:1,dec:0,sign:false,ro:1,grid:12,gxgrid:this.GridContainer,fnc:this.Valid_Bus_emp,isvalid:null,fld:"BUS_EMP",gxz:"Z8BUS_EMP",gxold:"O8BUS_EMP",gxvar:"A8BUS_EMP",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",v2v:function(Value){gx.O.A8BUS_EMP=Value},v2z:function(Value){gx.O.Z8BUS_EMP=Value},v2c:function(){gx.fn.setGridControlValue("BUS_EMP",gx.fn.currentGridRowImpl(12),gx.O.A8BUS_EMP,0)},c2v:function(){gx.O.A8BUS_EMP=this.val()},val:function(){return gx.fn.getGridControlValue("BUS_EMP",gx.fn.currentGridRowImpl(12))},nac:function(){return  false }};
   this.GXValidFnc[18]={lvl:2,type:"int",len:4,dec:0,sign:false,pic:"ZZZ9",ro:1,grid:12,gxgrid:this.GridContainer,fnc:this.Valid_Bus_rub,isvalid:null,rgrid:[],fld:"BUS_RUB",gxz:"Z1BUS_RUB",gxold:"O1BUS_RUB",gxvar:"A1BUS_RUB",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",v2v:function(Value){gx.O.A1BUS_RUB=gx.num.intval(Value)},v2z:function(Value){gx.O.Z1BUS_RUB=gx.num.intval(Value)},v2c:function(){gx.fn.setGridControlValue("BUS_RUB",gx.fn.currentGridRowImpl(12),gx.O.A1BUS_RUB,0)},c2v:function(){gx.O.A1BUS_RUB=this.val()},val:function(){return gx.fn.getGridIntegerValue("BUS_RUB",gx.fn.currentGridRowImpl(12),'.')},nac:function(){return  false }};
   this.GXValidFnc[19]={lvl:2,type:"char",len:30,dec:0,sign:false,ro:1,grid:12,gxgrid:this.GridContainer,fnc:null,isvalid:null,fld:"BUS_RUD",gxz:"Z61BUS_RUD",gxold:"O61BUS_RUD",gxvar:"A61BUS_RUD",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",v2v:function(Value){gx.O.A61BUS_RUD=Value},v2z:function(Value){gx.O.Z61BUS_RUD=Value},v2c:function(){gx.fn.setGridControlValue("BUS_RUD",gx.fn.currentGridRowImpl(12),gx.O.A61BUS_RUD,0)},c2v:function(){gx.O.A61BUS_RUD=this.val()},val:function(){return gx.fn.getGridControlValue("BUS_RUD",gx.fn.currentGridRowImpl(12))},nac:function(){return  false }};
   this.GXValidFnc[20]={lvl:2,type:"int",len:4,dec:0,sign:false,pic:"ZZZ9",ro:1,grid:12,gxgrid:this.GridContainer,fnc:this.Valid_Bus_cod,isvalid:null,rgrid:[],fld:"BUS_COD",gxz:"Z3BUS_COD",gxold:"O3BUS_COD",gxvar:"A3BUS_COD",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",v2v:function(Value){gx.O.A3BUS_COD=gx.num.intval(Value)},v2z:function(Value){gx.O.Z3BUS_COD=gx.num.intval(Value)},v2c:function(){gx.fn.setGridControlValue("BUS_COD",gx.fn.currentGridRowImpl(12),gx.O.A3BUS_COD,0)},c2v:function(){gx.O.A3BUS_COD=this.val()},val:function(){return gx.fn.getGridIntegerValue("BUS_COD",gx.fn.currentGridRowImpl(12),'.')},nac:function(){return  false }};
   this.GXValidFnc[21]={lvl:2,type:"int",len:2,dec:0,sign:false,pic:"Z9",ro:1,grid:12,gxgrid:this.GridContainer,fnc:this.Valid_Bus_par,isvalid:null,rgrid:[],fld:"BUS_PAR",gxz:"Z4BUS_PAR",gxold:"O4BUS_PAR",gxvar:"A4BUS_PAR",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",v2v:function(Value){gx.O.A4BUS_PAR=gx.num.intval(Value)},v2z:function(Value){gx.O.Z4BUS_PAR=gx.num.intval(Value)},v2c:function(){gx.fn.setGridControlValue("BUS_PAR",gx.fn.currentGridRowImpl(12),gx.O.A4BUS_PAR,0)},c2v:function(){gx.O.A4BUS_PAR=this.val()},val:function(){return gx.fn.getGridIntegerValue("BUS_PAR",gx.fn.currentGridRowImpl(12),'.')},nac:function(){return  false }};
   this.GXValidFnc[22]={lvl:2,type:"char",len:50,dec:0,sign:false,ro:1,grid:12,gxgrid:this.GridContainer,fnc:null,isvalid:null,fld:"BUS_DES",gxz:"Z54BUS_DES",gxold:"O54BUS_DES",gxvar:"A54BUS_DES",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",v2v:function(Value){gx.O.A54BUS_DES=Value},v2z:function(Value){gx.O.Z54BUS_DES=Value},v2c:function(){gx.fn.setGridControlValue("BUS_DES",gx.fn.currentGridRowImpl(12),gx.O.A54BUS_DES,0)},c2v:function(){gx.O.A54BUS_DES=this.val()},val:function(){return gx.fn.getGridControlValue("BUS_DES",gx.fn.currentGridRowImpl(12))},nac:function(){return  false }};
   this.GXValidFnc[23]={lvl:2,type:"date",len:10,dec:0,sign:false,ro:1,grid:12,gxgrid:this.GridContainer,fnc:null,isvalid:null,fld:"BUS_FAD",gxz:"Z55BUS_FAD",gxold:"O55BUS_FAD",gxvar:"A55BUS_FAD",dp:{f:0,st:false,wn:false,mf:false,pic:"99/99/9999",dec:0},ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",v2v:function(Value){gx.O.A55BUS_FAD=gx.fn.toDatetimeValue(Value)},v2z:function(Value){gx.O.Z55BUS_FAD=gx.fn.toDatetimeValue(Value)},v2c:function(){gx.fn.setGridControlValue("BUS_FAD",gx.fn.currentGridRowImpl(12),gx.O.A55BUS_FAD,0)},c2v:function(){gx.O.A55BUS_FAD=this.val()},val:function(){return gx.fn.getGridControlValue("BUS_FAD",gx.fn.currentGridRowImpl(12))},nac:function(){return  false }};
   this.GXValidFnc[24]={lvl:2,type:"int",len:3,dec:0,sign:false,pic:"ZZ9",ro:1,grid:12,gxgrid:this.GridContainer,fnc:null,isvalid:null,rgrid:[],fld:"BUS_TIP",gxz:"Z56BUS_TIP",gxold:"O56BUS_TIP",gxvar:"A56BUS_TIP",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",v2v:function(Value){gx.O.A56BUS_TIP=gx.num.intval(Value)},v2z:function(Value){gx.O.Z56BUS_TIP=gx.num.intval(Value)},v2c:function(){gx.fn.setGridControlValue("BUS_TIP",gx.fn.currentGridRowImpl(12),gx.O.A56BUS_TIP,0)},c2v:function(){gx.O.A56BUS_TIP=this.val()},val:function(){return gx.fn.getGridIntegerValue("BUS_TIP",gx.fn.currentGridRowImpl(12),'.')},nac:function(){return  false }};
   this.GXValidFnc[25]={lvl:2,type:"char",len:20,dec:0,sign:false,ro:1,grid:12,gxgrid:this.GridContainer,fnc:null,isvalid:null,fld:"BUS_TID",gxz:"Z59BUS_TID",gxold:"O59BUS_TID",gxvar:"A59BUS_TID",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",v2v:function(Value){gx.O.A59BUS_TID=Value},v2z:function(Value){gx.O.Z59BUS_TID=Value},v2c:function(){gx.fn.setGridControlValue("BUS_TID",gx.fn.currentGridRowImpl(12),gx.O.A59BUS_TID,0)},c2v:function(){gx.O.A59BUS_TID=this.val()},val:function(){return gx.fn.getGridControlValue("BUS_TID",gx.fn.currentGridRowImpl(12))},nac:function(){return  false }};
   this.GXValidFnc[26]={lvl:2,type:"int",len:4,dec:0,sign:false,pic:"ZZZ9",ro:1,grid:12,gxgrid:this.GridContainer,fnc:this.Valid_Hardware_id,isvalid:null,rgrid:[],fld:"HARDWARE_ID",gxz:"Z10HARDWARE_ID",gxold:"O10HARDWARE_ID",gxvar:"A10HARDWARE_ID",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",v2v:function(Value){gx.O.A10HARDWARE_ID=gx.num.intval(Value)},v2z:function(Value){gx.O.Z10HARDWARE_ID=gx.num.intval(Value)},v2c:function(){gx.fn.setGridControlValue("HARDWARE_ID",gx.fn.currentGridRowImpl(12),gx.O.A10HARDWARE_ID,0)},c2v:function(){gx.O.A10HARDWARE_ID=this.val()},val:function(){return gx.fn.getGridIntegerValue("HARDWARE_ID",gx.fn.currentGridRowImpl(12),'.')},nac:function(){return  false }};
   this.GXValidFnc[27]={lvl:2,type:"svchar",len:40,dec:0,sign:false,ro:1,grid:12,gxgrid:this.GridContainer,fnc:null,isvalid:null,fld:"HARDWARE_DESCRIPCION",gxz:"Z58HARDWARE_DESCRIPCION",gxold:"O58HARDWARE_DESCRIPCION",gxvar:"A58HARDWARE_DESCRIPCION",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",v2v:function(Value){gx.O.A58HARDWARE_DESCRIPCION=Value},v2z:function(Value){gx.O.Z58HARDWARE_DESCRIPCION=Value},v2c:function(){gx.fn.setGridControlValue("HARDWARE_DESCRIPCION",gx.fn.currentGridRowImpl(12),gx.O.A58HARDWARE_DESCRIPCION,0)},c2v:function(){gx.O.A58HARDWARE_DESCRIPCION=this.val()},val:function(){return gx.fn.getGridControlValue("HARDWARE_DESCRIPCION",gx.fn.currentGridRowImpl(12))},nac:function(){return  false }};
   this.GXValidFnc[28]={lvl:2,type:"svchar",len:20,dec:0,sign:false,ro:1,grid:12,gxgrid:this.GridContainer,fnc:null,isvalid:null,fld:"HARDWARE_NRO_SERIE",gxz:"Z9HARDWARE_NRO_SERIE",gxold:"O9HARDWARE_NRO_SERIE",gxvar:"A9HARDWARE_NRO_SERIE",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",v2v:function(Value){gx.O.A9HARDWARE_NRO_SERIE=Value},v2z:function(Value){gx.O.Z9HARDWARE_NRO_SERIE=Value},v2c:function(){gx.fn.setGridControlValue("HARDWARE_NRO_SERIE",gx.fn.currentGridRowImpl(12),gx.O.A9HARDWARE_NRO_SERIE,0)},c2v:function(){gx.O.A9HARDWARE_NRO_SERIE=this.val()},val:function(){return gx.fn.getGridControlValue("HARDWARE_NRO_SERIE",gx.fn.currentGridRowImpl(12))},nac:function(){return  false }};
   this.GXValidFnc[29]={lvl:2,type:"date",len:10,dec:0,sign:false,ro:1,grid:12,gxgrid:this.GridContainer,fnc:null,isvalid:null,fld:"TTBUS_FECHACARGA",gxz:"Z13TTBUS_FechaCarga",gxold:"O13TTBUS_FechaCarga",gxvar:"A13TTBUS_FechaCarga",dp:{f:0,st:false,wn:false,mf:false,pic:"99/99/9999",dec:0},ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",v2v:function(Value){gx.O.A13TTBUS_FechaCarga=gx.fn.toDatetimeValue(Value)},v2z:function(Value){gx.O.Z13TTBUS_FechaCarga=gx.fn.toDatetimeValue(Value)},v2c:function(){gx.fn.setGridControlValue("TTBUS_FECHACARGA",gx.fn.currentGridRowImpl(12),gx.O.A13TTBUS_FechaCarga,0)},c2v:function(){gx.O.A13TTBUS_FechaCarga=this.val()},val:function(){return gx.fn.getGridControlValue("TTBUS_FECHACARGA",gx.fn.currentGridRowImpl(12))},nac:function(){return  false }};
   this.GXValidFnc[30]={lvl:2,type:"int",len:1,dec:0,sign:false,pic:"9",ro:1,grid:12,gxgrid:this.GridContainer,fnc:null,isvalid:null,rgrid:[],fld:"TTBUS_ESTADO",gxz:"Z23TTBUS_Estado",gxold:"O23TTBUS_Estado",gxvar:"A23TTBUS_Estado",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"combo",v2v:function(Value){gx.O.A23TTBUS_Estado=gx.num.intval(Value)},v2z:function(Value){gx.O.Z23TTBUS_Estado=gx.num.intval(Value)},v2c:function(){gx.fn.setGridComboBoxValue("TTBUS_ESTADO",gx.fn.currentGridRowImpl(12),gx.O.A23TTBUS_Estado)},c2v:function(){gx.O.A23TTBUS_Estado=this.val()},val:function(){return gx.fn.getGridIntegerValue("TTBUS_ESTADO",gx.fn.currentGridRowImpl(12),'.')},nac:function(){return  false }};
   this.GXValidFnc[31]={lvl:2,type:"int",len:8,dec:0,sign:false,pic:"ZZZZZ9",ro:1,grid:12,gxgrid:this.GridContainer,fnc:null,isvalid:null,rgrid:[],fld:"TTBUS_CODPROVEEDOR",gxz:"Z27TTBUS_CodProveedor",gxold:"O27TTBUS_CodProveedor",gxvar:"A27TTBUS_CodProveedor",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",v2v:function(Value){gx.O.A27TTBUS_CodProveedor=gx.num.intval(Value)},v2z:function(Value){gx.O.Z27TTBUS_CodProveedor=gx.num.intval(Value)},v2c:function(){gx.fn.setGridControlValue("TTBUS_CODPROVEEDOR",gx.fn.currentGridRowImpl(12),gx.O.A27TTBUS_CodProveedor,0)},c2v:function(){gx.O.A27TTBUS_CodProveedor=this.val()},val:function(){return gx.fn.getGridIntegerValue("TTBUS_CODPROVEEDOR",gx.fn.currentGridRowImpl(12),'.')},nac:function(){return  false }};
   this.GXValidFnc[32]={lvl:2,type:"char",len:30,dec:0,sign:false,ro:1,grid:12,gxgrid:this.GridContainer,fnc:null,isvalid:null,fld:"TTBUS_DESPROVEEDOR",gxz:"Z30TTBUS_DesProveedor",gxold:"O30TTBUS_DesProveedor",gxvar:"A30TTBUS_DesProveedor",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",v2v:function(Value){gx.O.A30TTBUS_DesProveedor=Value},v2z:function(Value){gx.O.Z30TTBUS_DesProveedor=Value},v2c:function(){gx.fn.setGridControlValue("TTBUS_DESPROVEEDOR",gx.fn.currentGridRowImpl(12),gx.O.A30TTBUS_DesProveedor,0)},c2v:function(){gx.O.A30TTBUS_DesProveedor=this.val()},val:function(){return gx.fn.getGridControlValue("TTBUS_DESPROVEEDOR",gx.fn.currentGridRowImpl(12))},nac:function(){return  false }};
   this.GXValidFnc[33]={lvl:2,type:"int",len:8,dec:0,sign:false,pic:"ZZZZZZZ9",ro:1,grid:12,gxgrid:this.GridContainer,fnc:null,isvalid:null,rgrid:[],fld:"TTBUS_CUCPROVEEDOR",gxz:"Z73TTBUS_CucProveedor",gxold:"O73TTBUS_CucProveedor",gxvar:"A73TTBUS_CucProveedor",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",v2v:function(Value){gx.O.A73TTBUS_CucProveedor=gx.num.intval(Value)},v2z:function(Value){gx.O.Z73TTBUS_CucProveedor=gx.num.intval(Value)},v2c:function(){gx.fn.setGridControlValue("TTBUS_CUCPROVEEDOR",gx.fn.currentGridRowImpl(12),gx.O.A73TTBUS_CucProveedor,0)},c2v:function(){gx.O.A73TTBUS_CucProveedor=this.val()},val:function(){return gx.fn.getGridIntegerValue("TTBUS_CUCPROVEEDOR",gx.fn.currentGridRowImpl(12),'.')},nac:function(){return  false }};
   this.GXValidFnc[34]={lvl:2,type:"int",len:1,dec:0,sign:false,pic:"9",ro:1,grid:12,gxgrid:this.GridContainer,fnc:null,isvalid:null,rgrid:[],fld:"TTBUS_ALQUILADO",gxz:"Z29TTBUS_Alquilado",gxold:"O29TTBUS_Alquilado",gxvar:"A29TTBUS_Alquilado",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"checkbox",v2v:function(Value){gx.O.A29TTBUS_Alquilado=gx.num.intval(Value)},v2z:function(Value){gx.O.Z29TTBUS_Alquilado=gx.num.intval(Value)},v2c:function(){gx.fn.setGridCheckBoxValue("TTBUS_ALQUILADO",gx.fn.currentGridRowImpl(12),gx.O.A29TTBUS_Alquilado,"1")},c2v:function(){gx.O.A29TTBUS_Alquilado=this.val()},val:function(){return gx.fn.getGridCheckBoxValue("TTBUS_ALQUILADO",gx.fn.currentGridRowImpl(12),"1","0")},nac:function(){return  false }};
   this.GXValidFnc[35]={lvl:2,type:"int",len:3,dec:0,sign:false,pic:"ZZ9",ro:1,grid:12,gxgrid:this.GridContainer,fnc:null,isvalid:null,rgrid:[],fld:"TTBUS_CODPOSICION",gxz:"Z37TTBUS_CodPosicion",gxold:"O37TTBUS_CodPosicion",gxvar:"A37TTBUS_CodPosicion",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",v2v:function(Value){gx.O.A37TTBUS_CodPosicion=gx.num.intval(Value)},v2z:function(Value){gx.O.Z37TTBUS_CodPosicion=gx.num.intval(Value)},v2c:function(){gx.fn.setGridControlValue("TTBUS_CODPOSICION",gx.fn.currentGridRowImpl(12),gx.O.A37TTBUS_CodPosicion,0)},c2v:function(){gx.O.A37TTBUS_CodPosicion=this.val()},val:function(){return gx.fn.getGridIntegerValue("TTBUS_CODPOSICION",gx.fn.currentGridRowImpl(12),'.')},nac:function(){return  false }};
   this.GXValidFnc[36]={lvl:2,type:"char",len:50,dec:0,sign:false,ro:1,grid:12,gxgrid:this.GridContainer,fnc:null,isvalid:null,fld:"TTBUS_DESPOSICION",gxz:"Z38TTBUS_DesPosicion",gxold:"O38TTBUS_DesPosicion",gxvar:"A38TTBUS_DesPosicion",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",v2v:function(Value){gx.O.A38TTBUS_DesPosicion=Value},v2z:function(Value){gx.O.Z38TTBUS_DesPosicion=Value},v2c:function(){gx.fn.setGridControlValue("TTBUS_DESPOSICION",gx.fn.currentGridRowImpl(12),gx.O.A38TTBUS_DesPosicion,0)},c2v:function(){gx.O.A38TTBUS_DesPosicion=this.val()},val:function(){return gx.fn.getGridControlValue("TTBUS_DESPOSICION",gx.fn.currentGridRowImpl(12))},nac:function(){return  false }};
   this.GXValidFnc[37]={lvl:2,type:"char",len:30,dec:0,sign:false,ro:1,grid:12,gxgrid:this.GridContainer,fnc:null,isvalid:null,fld:"TTBUS_RUBRODESC",gxz:"Z18TTBUS_RubroDesc",gxold:"O18TTBUS_RubroDesc",gxvar:"A18TTBUS_RubroDesc",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",v2v:function(Value){gx.O.A18TTBUS_RubroDesc=Value},v2z:function(Value){gx.O.Z18TTBUS_RubroDesc=Value},v2c:function(){gx.fn.setGridControlValue("TTBUS_RUBRODESC",gx.fn.currentGridRowImpl(12),gx.O.A18TTBUS_RubroDesc,0)},c2v:function(){gx.O.A18TTBUS_RubroDesc=this.val()},val:function(){return gx.fn.getGridControlValue("TTBUS_RUBRODESC",gx.fn.currentGridRowImpl(12))},nac:function(){return  false }};
   this.GXValidFnc[38]={lvl:2,type:"int",len:8,dec:0,sign:false,pic:"ZZZZZZZ9",ro:1,grid:12,gxgrid:this.GridContainer,fnc:null,isvalid:null,rgrid:[],fld:"TTBUS_CONTDOCU",gxz:"Z74TTBUS_ContDocu",gxold:"O74TTBUS_ContDocu",gxvar:"A74TTBUS_ContDocu",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",v2v:function(Value){gx.O.A74TTBUS_ContDocu=gx.num.intval(Value)},v2z:function(Value){gx.O.Z74TTBUS_ContDocu=gx.num.intval(Value)},v2c:function(){gx.fn.setGridControlValue("TTBUS_CONTDOCU",gx.fn.currentGridRowImpl(12),gx.O.A74TTBUS_ContDocu,0)},c2v:function(){gx.O.A74TTBUS_ContDocu=this.val()},val:function(){return gx.fn.getGridIntegerValue("TTBUS_CONTDOCU",gx.fn.currentGridRowImpl(12),'.')},nac:function(){return  false }};
   this.GXValidFnc[39]={lvl:2,type:"char",len:15,dec:0,sign:false,ro:1,grid:12,gxgrid:this.GridContainer,fnc:null,isvalid:null,fld:"TTBUS_USUARIOALTA",gxz:"Z75TTBUS_UsuarioAlta",gxold:"O75TTBUS_UsuarioAlta",gxvar:"A75TTBUS_UsuarioAlta",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",v2v:function(Value){gx.O.A75TTBUS_UsuarioAlta=Value},v2z:function(Value){gx.O.Z75TTBUS_UsuarioAlta=Value},v2c:function(){gx.fn.setGridControlValue("TTBUS_USUARIOALTA",gx.fn.currentGridRowImpl(12),gx.O.A75TTBUS_UsuarioAlta,0)},c2v:function(){gx.O.A75TTBUS_UsuarioAlta=this.val()},val:function(){return gx.fn.getGridControlValue("TTBUS_USUARIOALTA",gx.fn.currentGridRowImpl(12))},nac:function(){return  false }};
   this.GXValidFnc[40]={lvl:2,type:"char",len:20,dec:0,sign:false,ro:1,grid:12,gxgrid:this.GridContainer,fnc:null,isvalid:null,fld:"TTBUS_MAQUINAALTA",gxz:"Z76TTBUS_MaquinaAlta",gxold:"O76TTBUS_MaquinaAlta",gxvar:"A76TTBUS_MaquinaAlta",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",v2v:function(Value){gx.O.A76TTBUS_MaquinaAlta=Value},v2z:function(Value){gx.O.Z76TTBUS_MaquinaAlta=Value},v2c:function(){gx.fn.setGridControlValue("TTBUS_MAQUINAALTA",gx.fn.currentGridRowImpl(12),gx.O.A76TTBUS_MaquinaAlta,0)},c2v:function(){gx.O.A76TTBUS_MaquinaAlta=this.val()},val:function(){return gx.fn.getGridControlValue("TTBUS_MAQUINAALTA",gx.fn.currentGridRowImpl(12))},nac:function(){return  false }};
   this.GXValidFnc[41]={lvl:2,type:"int",len:1,dec:0,sign:false,pic:"9",ro:1,grid:12,gxgrid:this.GridContainer,fnc:null,isvalid:null,rgrid:[],fld:"TTBUS_EMPRESA",gxz:"Z41TTBUS_Empresa",gxold:"O41TTBUS_Empresa",gxvar:"A41TTBUS_Empresa",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",v2v:function(Value){gx.O.A41TTBUS_Empresa=gx.num.intval(Value)},v2z:function(Value){gx.O.Z41TTBUS_Empresa=gx.num.intval(Value)},v2c:function(){gx.fn.setGridControlValue("TTBUS_EMPRESA",gx.fn.currentGridRowImpl(12),gx.O.A41TTBUS_Empresa,0)},c2v:function(){gx.O.A41TTBUS_Empresa=this.val()},val:function(){return gx.fn.getGridIntegerValue("TTBUS_EMPRESA",gx.fn.currentGridRowImpl(12),'.')},nac:function(){return  false }};
   this.GXValidFnc[42]={lvl:2,type:"svchar",len:20,dec:0,sign:false,ro:1,grid:12,gxgrid:this.GridContainer,fnc:null,isvalid:null,fld:"TTBUS_NROSERIE",gxz:"Z42TTBUS_NroSerie",gxold:"O42TTBUS_NroSerie",gxvar:"A42TTBUS_NroSerie",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",v2v:function(Value){gx.O.A42TTBUS_NroSerie=Value},v2z:function(Value){gx.O.Z42TTBUS_NroSerie=Value},v2c:function(){gx.fn.setGridControlValue("TTBUS_NROSERIE",gx.fn.currentGridRowImpl(12),gx.O.A42TTBUS_NroSerie,0)},c2v:function(){gx.O.A42TTBUS_NroSerie=this.val()},val:function(){return gx.fn.getGridControlValue("TTBUS_NROSERIE",gx.fn.currentGridRowImpl(12))},nac:function(){return  false }};
   this.GXValidFnc[45]={lvl:0,type:"int",len:4,dec:0,sign:false,pic:"ZZZ9",ro:1,grid:0,gxgrid:null,fnc:this.Valid_Ttbus_rubrobien,isvalid:null,rgrid:[],fld:"TTBUS_RUBROBIEN",gxz:"Z17TTBUS_RubroBien",gxold:"O17TTBUS_RubroBien",gxvar:"A17TTBUS_RubroBien",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",v2v:function(Value){gx.O.A17TTBUS_RubroBien=gx.num.intval(Value)},v2z:function(Value){gx.O.Z17TTBUS_RubroBien=gx.num.intval(Value)},v2c:function(){gx.fn.setControlValue("TTBUS_RUBROBIEN",gx.O.A17TTBUS_RubroBien,0)},c2v:function(){gx.O.A17TTBUS_RubroBien=this.val()},val:function(){return gx.fn.getIntegerValue("TTBUS_RUBROBIEN",'.')},nac:function(){return  false }};
   this.ZV12Update = "" ;
   this.OV12Update = "" ;
   this.ZV13Delete = "" ;
   this.OV13Delete = "" ;
   this.Z11TTBUS_Id = 0 ;
   this.O11TTBUS_Id = 0 ;
   this.Z12TTBUS_Descripcion = "" ;
   this.O12TTBUS_Descripcion = "" ;
   this.Z8BUS_EMP = "" ;
   this.O8BUS_EMP = "" ;
   this.Z1BUS_RUB = 0 ;
   this.O1BUS_RUB = 0 ;
   this.Z61BUS_RUD = "" ;
   this.O61BUS_RUD = "" ;
   this.Z3BUS_COD = 0 ;
   this.O3BUS_COD = 0 ;
   this.Z4BUS_PAR = 0 ;
   this.O4BUS_PAR = 0 ;
   this.Z54BUS_DES = "" ;
   this.O54BUS_DES = "" ;
   this.Z55BUS_FAD = gx.date.nullDate() ;
   this.O55BUS_FAD = gx.date.nullDate() ;
   this.Z56BUS_TIP = 0 ;
   this.O56BUS_TIP = 0 ;
   this.Z59BUS_TID = "" ;
   this.O59BUS_TID = "" ;
   this.Z10HARDWARE_ID = 0 ;
   this.O10HARDWARE_ID = 0 ;
   this.Z58HARDWARE_DESCRIPCION = "" ;
   this.O58HARDWARE_DESCRIPCION = "" ;
   this.Z9HARDWARE_NRO_SERIE = "" ;
   this.O9HARDWARE_NRO_SERIE = "" ;
   this.Z13TTBUS_FechaCarga = gx.date.nullDate() ;
   this.O13TTBUS_FechaCarga = gx.date.nullDate() ;
   this.Z23TTBUS_Estado = 0 ;
   this.O23TTBUS_Estado = 0 ;
   this.Z27TTBUS_CodProveedor = 0 ;
   this.O27TTBUS_CodProveedor = 0 ;
   this.Z30TTBUS_DesProveedor = "" ;
   this.O30TTBUS_DesProveedor = "" ;
   this.Z73TTBUS_CucProveedor = 0 ;
   this.O73TTBUS_CucProveedor = 0 ;
   this.Z29TTBUS_Alquilado = 0 ;
   this.O29TTBUS_Alquilado = 0 ;
   this.Z37TTBUS_CodPosicion = 0 ;
   this.O37TTBUS_CodPosicion = 0 ;
   this.Z38TTBUS_DesPosicion = "" ;
   this.O38TTBUS_DesPosicion = "" ;
   this.Z18TTBUS_RubroDesc = "" ;
   this.O18TTBUS_RubroDesc = "" ;
   this.Z74TTBUS_ContDocu = 0 ;
   this.O74TTBUS_ContDocu = 0 ;
   this.Z75TTBUS_UsuarioAlta = "" ;
   this.O75TTBUS_UsuarioAlta = "" ;
   this.Z76TTBUS_MaquinaAlta = "" ;
   this.O76TTBUS_MaquinaAlta = "" ;
   this.Z41TTBUS_Empresa = 0 ;
   this.O41TTBUS_Empresa = 0 ;
   this.Z42TTBUS_NroSerie = "" ;
   this.O42TTBUS_NroSerie = "" ;
   this.A17TTBUS_RubroBien = 0 ;
   this.Z17TTBUS_RubroBien = 0 ;
   this.O17TTBUS_RubroBien = 0 ;
   this.AV7TTBUS_RubroBien = 0 ;
   this.AV12Update = "" ;
   this.AV13Delete = "" ;
   this.A11TTBUS_Id = 0 ;
   this.A12TTBUS_Descripcion = "" ;
   this.A8BUS_EMP = "" ;
   this.A1BUS_RUB = 0 ;
   this.A61BUS_RUD = "" ;
   this.A3BUS_COD = 0 ;
   this.A4BUS_PAR = 0 ;
   this.A54BUS_DES = "" ;
   this.A55BUS_FAD = gx.date.nullDate() ;
   this.A56BUS_TIP = 0 ;
   this.A59BUS_TID = "" ;
   this.A10HARDWARE_ID = 0 ;
   this.A58HARDWARE_DESCRIPCION = "" ;
   this.A9HARDWARE_NRO_SERIE = "" ;
   this.A13TTBUS_FechaCarga = gx.date.nullDate() ;
   this.A23TTBUS_Estado = 0 ;
   this.A27TTBUS_CodProveedor = 0 ;
   this.A30TTBUS_DesProveedor = "" ;
   this.A73TTBUS_CucProveedor = 0 ;
   this.A29TTBUS_Alquilado = 0 ;
   this.A37TTBUS_CodPosicion = 0 ;
   this.A38TTBUS_DesPosicion = "" ;
   this.A18TTBUS_RubroDesc = "" ;
   this.A74TTBUS_ContDocu = 0 ;
   this.A75TTBUS_UsuarioAlta = "" ;
   this.A76TTBUS_MaquinaAlta = "" ;
   this.A41TTBUS_Empresa = 0 ;
   this.A42TTBUS_NroSerie = "" ;
   this.ServerEvents = ["e11492_client" ,"e14492_client" ,"e15492_client"];
   this.VarControlMap["AV7TTBUS_RubroBien"] = {id:"vTTBUS_RUBROBIEN",grid:0,type:"int"};
   this.GridContainer.addRefreshingVar({rfrVar:"AV7TTBUS_RubroBien"});
   this.GridContainer.addRefreshingVar({rfrVar:"AV13Delete", rfrProp:"Tooltiptext"});
   this.GridContainer.addRefreshingVar({rfrVar:"AV13Delete", rfrProp:"Value"});
   this.GridContainer.addRefreshingVar({rfrVar:"AV12Update", rfrProp:"Tooltiptext"});
   this.GridContainer.addRefreshingVar({rfrVar:"AV12Update", rfrProp:"Value"});
   this.SetStandaloneVars( );
}
