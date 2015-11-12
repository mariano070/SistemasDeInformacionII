/*
               File: TBUS000
        Description: ACT. DE BIENES DE USO
             Author: GeneXus C# Generator version 10_1_5-42940
       Generated on: 1/6/2014 11:7:57.12
       Program type: Callable routine
          Main DBMS: sqlserver
*/
gx.evt.autoSkip = false;
function tbus000() {
   this.ServerClass =  "TBUS000" ;
   this.PackageName =  "GeneXus.Programs" ;
   this.setObjectType("trn");
   this.hasEnterEvent = true;
   this.SetStandaloneVars=function()
   {
      this.AV8BUS_EMP=gx.fn.getControlValue("vBUS_EMP") ;
      this.Gx_BScreen=gx.fn.getIntegerValue("vGXBSCREEN",'.') ;
      this.AV11BUS_RUB=gx.fn.getIntegerValue("vBUS_RUB",'.') ;
      this.AV7BUS_COD=gx.fn.getIntegerValue("vBUS_COD",'.') ;
      this.AV10BUS_PAR=gx.fn.getIntegerValue("vBUS_PAR",'.') ;
      this.AV18Insert_BUS_COM=gx.fn.getControlValue("vINSERT_BUS_COM") ;
      this.AV17Insert_BUS_ARE=gx.fn.getIntegerValue("vINSERT_BUS_ARE",'.') ;
      this.AV19Insert_BUS_SEC=gx.fn.getIntegerValue("vINSERT_BUS_SEC",'.') ;
      this.AV20Insert_BUS_TIP=gx.fn.getIntegerValue("vINSERT_BUS_TIP",'.') ;
      this.AV16error=gx.fn.getIntegerValue("vERROR",'.') ;
      this.Gx_mode=gx.fn.getControlValue("vMODE") ;
      this.AV31error_t=gx.fn.getIntegerValue("vERROR_T",'.') ;
      this.AV30mensaje=gx.fn.getControlValue("vMENSAJE") ;
      this.AV32error_2=gx.fn.getIntegerValue("vERROR_2",'.') ;
      this.A61BUS_RUD=gx.fn.getControlValue("BUS_RUD") ;
      this.A178BUS_AMO=gx.fn.getControlValue("BUS_AMO") ;
      this.AV34Pgmname=gx.fn.getControlValue("vPGMNAME") ;
   };
   this.Valid_Bus_emp=function()
   {
      /*
         call server method valid_BUS_EMP
      */
      gx.ajax.validSrvEvt("dyncall","Valid_Bus_emp",["gx.O.Gx_mode", "gx.O.A8BUS_EMP", "gx.O.A1BUS_RUB", "gx.O.A54BUS_DES", 'gx.date.urlDate(gx.O.A170BUS_FAL,"DMY4")', 'gx.date.urlDate(gx.O.A55BUS_FAD,"DMY4")', "gx.O.A333BUS_NCO", "gx.O.A331BUS_COM"],["A1BUS_RUB", "A54BUS_DES", "A170BUS_FAL", "A55BUS_FAD", "A333BUS_NCO", "A331BUS_COM"]);
      return true;
   }
   this.Valid_Bus_rub=function()
   {
      /*
         call server method valid_BUS_RUB
      */
      gx.ajax.validSrvEvt("dyncall","Valid_Bus_rub",["gx.O.A1BUS_RUB", "gx.O.A61BUS_RUD", "gx.O.A178BUS_AMO"],["A61BUS_RUD", "A178BUS_AMO"]);
      return true;
   }
   this.Valid_Bus_cod=function()
   {
      try {
         var gxballoon = gx.util.balloon.getNew("BUS_COD");
         this.AnyError  = 0;
         if ( (0==this.A3BUS_COD) )
         {
            try {
               gxballoon.setError("El bien debe tener un código.");
               this.AnyError = 1 ;
            }
            catch(e){}
         }

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
      /*
         call server method valid_BUS_PAR
      */
      gx.ajax.validSrvEvt("dyncall","Valid_Bus_par",["gx.O.Gx_mode", "gx.O.A3BUS_COD", "gx.O.A1BUS_RUB", "gx.O.A8BUS_EMP", "gx.O.A4BUS_PAR", "gx.O.AV16error"],["AV16error"]);
      return true;
   }
   this.Valid_Bus_des=function()
   {
      try {
         var gxballoon = gx.util.balloon.getNew("BUS_DES");
         this.AnyError  = 0;
         if ( (""==this.A54BUS_DES) )
         {
            try {
               gxballoon.setError("El bien debe llevar una descripción.");
               this.AnyError = 1 ;
            }
            catch(e){}
         }

      }
      catch(e){}
      try {
         if (gxballoon == null) return true; return gxballoon.show();
      }
      catch(e){}
      return true ;
   }
   this.Valid_Bus_fal=function()
   {
      try {
         var gxballoon = gx.util.balloon.getNew("BUS_FAL");
         this.AnyError  = 0;
         if ( ! ( (new gx.date.gxdate("").compare(this.A170BUS_FAL)==0) || new gx.date.gxdate( this.A170BUS_FAL ).compare( gx.date.ymdtod( 1753, 01, 01) ) >= 0 ) )
         {
            try {
               gxballoon.setError("Campo FECHA DE ALTA DEL BIEN fuera de rango");
               this.AnyError = 1 ;
            }
            catch(e){}
         }
         if ( (new gx.date.gxdate("").compare(this.A170BUS_FAL)==0) )
         {
            try {
               gxballoon.setError("El bien debe llevar una fecha de alta.");
               this.AnyError = 1 ;
            }
            catch(e){}
         }

      }
      catch(e){}
      try {
         if (gxballoon == null) return true; return gxballoon.show();
      }
      catch(e){}
      return true ;
   }
   this.Valid_Bus_fad=function()
   {
      try {
         var gxballoon = gx.util.balloon.getNew("BUS_FAD");
         this.AnyError  = 0;
         if ( ! ( (new gx.date.gxdate("").compare(this.A55BUS_FAD)==0) || new gx.date.gxdate( this.A55BUS_FAD ).compare( gx.date.ymdtod( 1753, 01, 01) ) >= 0 ) )
         {
            try {
               gxballoon.setError("Campo FECHA DE ADQUISICION DEL BIEN fuera de rango");
               this.AnyError = 1 ;
            }
            catch(e){}
         }
         if ( (new gx.date.gxdate("").compare(this.A55BUS_FAD)==0) )
         {
            try {
               gxballoon.setError("El bien debe llevar una fecha de adquisición.");
               this.AnyError = 1 ;
            }
            catch(e){}
         }

      }
      catch(e){}
      try {
         if (gxballoon == null) return true; return gxballoon.show();
      }
      catch(e){}
      return true ;
   }
   this.Valid_Bus_vua=function()
   {
      try {
         var gxballoon = gx.util.balloon.getNew("BUS_VUA");
         this.AnyError  = 0;

      }
      catch(e){}
      try {
         if (gxballoon == null) return true; return gxballoon.show();
      }
      catch(e){}
      return true ;
   }
   this.Valid_Bus_vao=function()
   {
      try {
         var gxballoon = gx.util.balloon.getNew("BUS_VAO");
         this.AnyError  = 0;
         if ( (0.0==this.A330BUS_VAO) )
         {
            try {
               gxballoon.setError("El bien debe tener un valor de origen.");
               this.AnyError = 1 ;
            }
            catch(e){}
         }

      }
      catch(e){}
      try {
         if (gxballoon == null) return true; return gxballoon.show();
      }
      catch(e){}
      return true ;
   }
   this.Valid_Bus_com=function()
   {
      try {
         var gxballoon = gx.util.balloon.getNew("BUS_COM");
         this.AnyError  = 0;

      }
      catch(e){}
      try {
         if (gxballoon == null) return true; return gxballoon.show();
      }
      catch(e){}
      return true ;
   }
   this.Valid_Bus_nco=function()
   {
      try {
         var gxballoon = gx.util.balloon.getNew("BUS_NCO");
         this.AnyError  = 0;

      }
      catch(e){}
      try {
         if (gxballoon == null) return true; return gxballoon.show();
      }
      catch(e){}
      return true ;
   }
   this.Valid_Bus_fba=function()
   {
      /*
         call server method valid_BUS_FBA
      */
      gx.ajax.validSrvEvt("dyncall","Valid_Bus_fba",["gx.O.A103BUS_IDT", 'gx.date.urlDate(gx.O.A174BUS_FBA,"DMY4")', "gx.O.AV32error_2"],["AV32error_2"]);
      return true;
   }
   this.Valid_Bus_idt=function()
   {
      /*
         call server method valid_BUS_IDT
      */
      gx.ajax.validSrvEvt("dyncall","Valid_Bus_idt",["gx.O.A4BUS_PAR", "gx.O.A3BUS_COD", "gx.O.A1BUS_RUB", "gx.O.A8BUS_EMP", "gx.O.A103BUS_IDT", "gx.O.AV31error_t", "gx.O.AV30mensaje"],["AV31error_t", "AV30mensaje"]);
      return true;
   }
   this.Valid_Bus_vut=function()
   {
      try {
         var gxballoon = gx.util.balloon.getNew("BUS_VUT");
         this.AnyError  = 0;
         try {
            this.A349BUS_VUR = this.A329BUS_VUA - this.A335BUS_VUT ;
         }
         catch(e){}

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
         var gxballoon = gx.util.balloon.getNew("BUS_VOA");
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
         var gxballoon = gx.util.balloon.getNew("BUS_AAA");
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
         var gxballoon = gx.util.balloon.getNew("BUS_AEA");
         this.AnyError  = 0;
         try {
            this.A347BUS_VRA = gx.num.subtract( gx.num.subtract( this.A337BUS_VOA , this.A338BUS_AAA ) , this.A339BUS_AEA ) ;
         }
         catch(e){}

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
         var gxballoon = gx.util.balloon.getNew("BUS_VOH");
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
         var gxballoon = gx.util.balloon.getNew("BUS_AAH");
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
         var gxballoon = gx.util.balloon.getNew("BUS_AEH");
         this.AnyError  = 0;
         try {
            this.A348BUS_VRH = gx.num.subtract( gx.num.subtract( this.A344BUS_VOH , this.A345BUS_AAH ) , this.A346BUS_AEH ) ;
         }
         catch(e){}

      }
      catch(e){}
      try {
         if (gxballoon == null) return true; return gxballoon.show();
      }
      catch(e){}
      return true ;
   }
   this.e120o2_client=function()
   {
      this.executeServerEvent("AFTER TRN", true);
   };
   this.e130o24_client=function()
   {
      this.executeServerEvent("ENTER", true);
   };
   this.e140o24_client=function()
   {
      this.executeServerEvent("CANCEL", true);
   };
   this.GXValidFnc = [];
   this.GXCtrlIds=[2,5,8,9,10,11,12,13,14,15,16,17,18,19,20,21,22,23,26,27,33,38,43,48,49,54,62,67,72,77,85,86,91,99,100,105,106,111,112,120,125,130,136,139,144,149,154,159,164,169,174,179,184,189,194,199,204,209,214,223,224];
   this.GXLastCtrlId =224;
   this.GXValidFnc[2]={fld:"TABLEMAIN",grid:0};
   this.GXValidFnc[5]={fld:"TABLETOOLBAR",grid:0};
   this.GXValidFnc[8]={fld:"BTN_FIRST",grid:0};
   this.GXValidFnc[9]={fld:"BTN_FIRST_SEPARATOR",grid:0};
   this.GXValidFnc[10]={fld:"BTN_PREVIOUS",grid:0};
   this.GXValidFnc[11]={fld:"BTN_PREVIOUS_SEPARATOR",grid:0};
   this.GXValidFnc[12]={fld:"BTN_NEXT",grid:0};
   this.GXValidFnc[13]={fld:"BTN_NEXT_SEPARATOR",grid:0};
   this.GXValidFnc[14]={fld:"BTN_LAST",grid:0};
   this.GXValidFnc[15]={fld:"BTN_LAST_SEPARATOR",grid:0};
   this.GXValidFnc[16]={fld:"BTN_SELECT",grid:0};
   this.GXValidFnc[17]={fld:"BTN_SELECT_SEPARATOR",grid:0};
   this.GXValidFnc[18]={fld:"BTN_ENTER2",grid:0};
   this.GXValidFnc[19]={fld:"BTN_ENTER2_SEPARATOR",grid:0};
   this.GXValidFnc[20]={fld:"BTN_CANCEL2",grid:0};
   this.GXValidFnc[21]={fld:"BTN_CANCEL2_SEPARATOR",grid:0};
   this.GXValidFnc[22]={fld:"BTN_DELETE2",grid:0};
   this.GXValidFnc[23]={fld:"BTN_DELETE2_SEPARATOR",grid:0};
   this.GXValidFnc[26]={fld:"GROUPDATA",grid:0};
   this.GXValidFnc[27]={fld:"TABLE1",grid:0};
   this.GXValidFnc[33]={fld:"TABLE2",grid:0};
   this.GXValidFnc[36]={fld:"TEXTBLOCKBUS_EMP", format:0,grid:0};
   this.GXValidFnc[38]={lvl:0,type:"char",len:1,dec:0,sign:false,ro:0,grid:0,gxgrid:null,fnc:this.Valid_Bus_emp,isvalid:null,fld:"BUS_EMP",gxz:"Z8BUS_EMP",gxold:"O8BUS_EMP",gxvar:"A8BUS_EMP",ucs:[],op:[85,91,67,62,54,43],ip:[85,91,67,62,54,43,38],nacdep:[],ctrltype:"edit",v2v:function(Value){gx.O.A8BUS_EMP=Value},v2z:function(Value){gx.O.Z8BUS_EMP=Value},v2c:function(){gx.fn.setControlValue("BUS_EMP",gx.O.A8BUS_EMP,0)},c2v:function(){gx.O.A8BUS_EMP=this.val()},val:function(){return gx.fn.getControlValue("BUS_EMP")},nac:function(){return  ! (""==this.AV8BUS_EMP) }};
   this.GXValidFnc[41]={fld:"TEXTBLOCKBUS_RUB", format:0,grid:0};
   this.GXValidFnc[43]={lvl:0,type:"int",len:4,dec:0,sign:false,pic:"ZZZ9",ro:0,grid:0,gxgrid:null,fnc:this.Valid_Bus_rub,isvalid:null,rgrid:[],fld:"BUS_RUB",gxz:"Z1BUS_RUB",gxold:"O1BUS_RUB",gxvar:"A1BUS_RUB",ucs:[],op:[],ip:[43],nacdep:[],ctrltype:"edit",v2v:function(Value){gx.O.A1BUS_RUB=gx.num.intval(Value)},v2z:function(Value){gx.O.Z1BUS_RUB=gx.num.intval(Value)},v2c:function(){gx.fn.setControlValue("BUS_RUB",gx.O.A1BUS_RUB,0)},c2v:function(){gx.O.A1BUS_RUB=this.val()},val:function(){return gx.fn.getIntegerValue("BUS_RUB",'.')},nac:function(){return  ! (0==this.AV11BUS_RUB) }};
   this.GXValidFnc[46]={fld:"TEXTBLOCKBUS_COD", format:0,grid:0};
   this.GXValidFnc[48]={lvl:0,type:"int",len:4,dec:0,sign:false,pic:"ZZZ9",ro:0,grid:0,gxgrid:null,fnc:this.Valid_Bus_cod,isvalid:null,rgrid:[],fld:"BUS_COD",gxz:"Z3BUS_COD",gxold:"O3BUS_COD",gxvar:"A3BUS_COD",ucs:[],op:[48],ip:[48],nacdep:[],ctrltype:"edit",v2v:function(Value){gx.O.A3BUS_COD=gx.num.intval(Value)},v2z:function(Value){gx.O.Z3BUS_COD=gx.num.intval(Value)},v2c:function(){gx.fn.setControlValue("BUS_COD",gx.O.A3BUS_COD,0)},c2v:function(){gx.O.A3BUS_COD=this.val()},val:function(){return gx.fn.getIntegerValue("BUS_COD",'.')},nac:function(){return  ! (0==this.AV7BUS_COD) }};
   this.GXValidFnc[49]={lvl:0,type:"int",len:2,dec:0,sign:false,pic:"Z9",ro:0,grid:0,gxgrid:null,fnc:this.Valid_Bus_par,isvalid:null,rgrid:[],fld:"BUS_PAR",gxz:"Z4BUS_PAR",gxold:"O4BUS_PAR",gxvar:"A4BUS_PAR",ucs:[],op:[49],ip:[49],nacdep:[],ctrltype:"edit",v2v:function(Value){gx.O.A4BUS_PAR=gx.num.intval(Value)},v2z:function(Value){gx.O.Z4BUS_PAR=gx.num.intval(Value)},v2c:function(){gx.fn.setControlValue("BUS_PAR",gx.O.A4BUS_PAR,0)},c2v:function(){gx.O.A4BUS_PAR=this.val()},val:function(){return gx.fn.getIntegerValue("BUS_PAR",'.')},nac:function(){return  ! (0==this.AV10BUS_PAR) }};
   this.GXValidFnc[52]={fld:"TEXTBLOCKBUS_DES", format:0,grid:0};
   this.GXValidFnc[54]={lvl:0,type:"char",len:50,dec:0,sign:false,ro:0,grid:0,gxgrid:null,fnc:this.Valid_Bus_des,isvalid:null,fld:"BUS_DES",gxz:"Z54BUS_DES",gxold:"O54BUS_DES",gxvar:"A54BUS_DES",ucs:[],op:[54],ip:[54],nacdep:[],ctrltype:"edit",v2v:function(Value){gx.O.A54BUS_DES=Value},v2z:function(Value){gx.O.Z54BUS_DES=Value},v2c:function(){gx.fn.setControlValue("BUS_DES",gx.O.A54BUS_DES,0)},c2v:function(){gx.O.A54BUS_DES=this.val()},val:function(){return gx.fn.getControlValue("BUS_DES")},nac:function(){return  false }};
   this.GXValidFnc[60]={fld:"TEXTBLOCKBUS_FAL", format:0,grid:0};
   this.GXValidFnc[62]={lvl:0,type:"date",len:10,dec:0,sign:false,ro:0,grid:0,gxgrid:null,fnc:this.Valid_Bus_fal,isvalid:null,fld:"BUS_FAL",gxz:"Z170BUS_FAL",gxold:"O170BUS_FAL",gxvar:"A170BUS_FAL",dp:{f:0,st:false,wn:false,mf:false,pic:"99/99/9999",dec:0},ucs:[],op:[62],ip:[62],nacdep:[],ctrltype:"edit",v2v:function(Value){gx.O.A170BUS_FAL=gx.fn.toDatetimeValue(Value)},v2z:function(Value){gx.O.Z170BUS_FAL=gx.fn.toDatetimeValue(Value)},v2c:function(){gx.fn.setControlValue("BUS_FAL",gx.O.A170BUS_FAL,0)},c2v:function(){gx.O.A170BUS_FAL=this.val()},val:function(){return gx.fn.getControlValue("BUS_FAL")},nac:function(){return  false }};
   this.GXValidFnc[65]={fld:"TEXTBLOCKBUS_FAD", format:0,grid:0};
   this.GXValidFnc[67]={lvl:0,type:"date",len:10,dec:0,sign:false,ro:0,grid:0,gxgrid:null,fnc:this.Valid_Bus_fad,isvalid:null,fld:"BUS_FAD",gxz:"Z55BUS_FAD",gxold:"O55BUS_FAD",gxvar:"A55BUS_FAD",dp:{f:0,st:false,wn:false,mf:false,pic:"99/99/9999",dec:0},ucs:[],op:[67],ip:[67],nacdep:[],ctrltype:"edit",v2v:function(Value){gx.O.A55BUS_FAD=gx.fn.toDatetimeValue(Value)},v2z:function(Value){gx.O.Z55BUS_FAD=gx.fn.toDatetimeValue(Value)},v2c:function(){gx.fn.setControlValue("BUS_FAD",gx.O.A55BUS_FAD,0)},c2v:function(){gx.O.A55BUS_FAD=this.val()},val:function(){return gx.fn.getControlValue("BUS_FAD")},nac:function(){return  false }};
   this.GXValidFnc[70]={fld:"TEXTBLOCKBUS_VUA", format:0,grid:0};
   this.GXValidFnc[72]={lvl:0,type:"int",len:4,dec:0,sign:false,pic:"ZZZ9",ro:0,grid:0,gxgrid:null,fnc:this.Valid_Bus_vua,isvalid:null,rgrid:[],fld:"BUS_VUA",gxz:"Z329BUS_VUA",gxold:"O329BUS_VUA",gxvar:"A329BUS_VUA",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",v2v:function(Value){gx.O.A329BUS_VUA=gx.num.intval(Value)},v2z:function(Value){gx.O.Z329BUS_VUA=gx.num.intval(Value)},v2c:function(){gx.fn.setControlValue("BUS_VUA",gx.O.A329BUS_VUA,0)},c2v:function(){gx.O.A329BUS_VUA=this.val()},val:function(){return gx.fn.getIntegerValue("BUS_VUA",'.')},nac:function(){return  false }};
   this.GXValidFnc[75]={fld:"TEXTBLOCKBUS_VAO", format:0,grid:0};
   this.GXValidFnc[77]={lvl:0,type:"decimal",len:18,dec:7,sign:false,pic:"ZZZZZZZZZ9.9999999",ro:0,grid:0,gxgrid:null,fnc:this.Valid_Bus_vao,isvalid:null,rgrid:[],fld:"BUS_VAO",gxz:"Z330BUS_VAO",gxold:"O330BUS_VAO",gxvar:"A330BUS_VAO",ucs:[],op:[77],ip:[77],nacdep:[],ctrltype:"edit",v2v:function(Value){gx.O.A330BUS_VAO=gx.fn.toDecimalValue(Value,',','.')},v2z:function(Value){gx.O.Z330BUS_VAO=gx.fn.toDecimalValue(Value,'.',',')},v2c:function(){gx.fn.setDecimalValue("BUS_VAO",gx.O.A330BUS_VAO,7,',')},c2v:function(){gx.O.A330BUS_VAO=this.val()},val:function(){return gx.fn.getDecimalValue("BUS_VAO",'.',',')},nac:function(){return  false }};
   this.GXValidFnc[83]={fld:"TEXTBLOCKBUS_COM", format:0,grid:0};
   this.GXValidFnc[85]={lvl:0,type:"char",len:2,dec:0,sign:false,ro:0,grid:0,gxgrid:null,fnc:this.Valid_Bus_com,isvalid:null,fld:"BUS_COM",gxz:"Z331BUS_COM",gxold:"O331BUS_COM",gxvar:"A331BUS_COM",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",v2v:function(Value){gx.O.A331BUS_COM=Value},v2z:function(Value){gx.O.Z331BUS_COM=Value},v2c:function(){gx.fn.setControlValue("BUS_COM",gx.O.A331BUS_COM,0)},c2v:function(){gx.O.A331BUS_COM=this.val()},val:function(){return gx.fn.getControlValue("BUS_COM")},nac:function(){return  this.Gx_mode == "INS" && ! (""==this.AV18Insert_BUS_COM) }};
   this.GXValidFnc[86]={lvl:0,type:"char",len:20,dec:0,sign:false,ro:0,grid:0,gxgrid:null,fnc:null,isvalid:null,fld:"BUS_CBD",gxz:"Z350BUS_CBD",gxold:"O350BUS_CBD",gxvar:"A350BUS_CBD",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",v2v:function(Value){gx.O.A350BUS_CBD=Value},v2z:function(Value){gx.O.Z350BUS_CBD=Value},v2c:function(){gx.fn.setControlValue("BUS_CBD",gx.O.A350BUS_CBD,0)},c2v:function(){gx.O.A350BUS_CBD=this.val()},val:function(){return gx.fn.getControlValue("BUS_CBD")},nac:function(){return  false }};
   this.GXValidFnc[89]={fld:"TEXTBLOCKBUS_NCO", format:0,grid:0};
   this.GXValidFnc[91]={lvl:0,type:"char",len:12,dec:0,sign:false,ro:0,grid:0,gxgrid:null,fnc:this.Valid_Bus_nco,isvalid:null,fld:"BUS_NCO",gxz:"Z333BUS_NCO",gxold:"O333BUS_NCO",gxvar:"A333BUS_NCO",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",v2v:function(Value){gx.O.A333BUS_NCO=Value},v2z:function(Value){gx.O.Z333BUS_NCO=Value},v2c:function(){gx.fn.setControlValue("BUS_NCO",gx.O.A333BUS_NCO,0)},c2v:function(){gx.O.A333BUS_NCO=this.val()},val:function(){return gx.fn.getControlValue("BUS_NCO")},nac:function(){return  false }};
   this.GXValidFnc[97]={fld:"TEXTBLOCKBUS_SEC", format:0,grid:0};
   this.GXValidFnc[99]={lvl:0,type:"int",len:2,dec:0,sign:false,pic:"Z9",ro:0,grid:0,gxgrid:null,fnc:null,isvalid:null,rgrid:[],fld:"BUS_SEC",gxz:"Z172BUS_SEC",gxold:"O172BUS_SEC",gxvar:"A172BUS_SEC",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",v2v:function(Value){gx.O.A172BUS_SEC=gx.num.intval(Value)},v2z:function(Value){gx.O.Z172BUS_SEC=gx.num.intval(Value)},v2c:function(){gx.fn.setControlValue("BUS_SEC",gx.O.A172BUS_SEC,0)},c2v:function(){gx.O.A172BUS_SEC=this.val()},val:function(){return gx.fn.getIntegerValue("BUS_SEC",'.')},nac:function(){return  this.Gx_mode == "INS" && ! (0==this.AV19Insert_BUS_SEC) }};
   this.GXValidFnc[100]={lvl:0,type:"char",len:30,dec:0,sign:false,ro:0,grid:0,gxgrid:null,fnc:null,isvalid:null,fld:"BUS_SED",gxz:"Z176BUS_SED",gxold:"O176BUS_SED",gxvar:"A176BUS_SED",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",v2v:function(Value){gx.O.A176BUS_SED=Value},v2z:function(Value){gx.O.Z176BUS_SED=Value},v2c:function(){gx.fn.setControlValue("BUS_SED",gx.O.A176BUS_SED,0)},c2v:function(){gx.O.A176BUS_SED=this.val()},val:function(){return gx.fn.getControlValue("BUS_SED")},nac:function(){return  false }};
   this.GXValidFnc[103]={fld:"TEXTBLOCKBUS_ARE", format:0,grid:0};
   this.GXValidFnc[105]={lvl:0,type:"int",len:4,dec:0,sign:false,pic:"ZZZ9",ro:0,grid:0,gxgrid:null,fnc:null,isvalid:null,rgrid:[],fld:"BUS_ARE",gxz:"Z171BUS_ARE",gxold:"O171BUS_ARE",gxvar:"A171BUS_ARE",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",v2v:function(Value){gx.O.A171BUS_ARE=gx.num.intval(Value)},v2z:function(Value){gx.O.Z171BUS_ARE=gx.num.intval(Value)},v2c:function(){gx.fn.setControlValue("BUS_ARE",gx.O.A171BUS_ARE,0)},c2v:function(){gx.O.A171BUS_ARE=this.val()},val:function(){return gx.fn.getIntegerValue("BUS_ARE",'.')},nac:function(){return  this.Gx_mode == "INS" && ! (0==this.AV17Insert_BUS_ARE) }};
   this.GXValidFnc[106]={lvl:0,type:"char",len:30,dec:0,sign:false,ro:0,grid:0,gxgrid:null,fnc:null,isvalid:null,fld:"BUS_ARD",gxz:"Z175BUS_ARD",gxold:"O175BUS_ARD",gxvar:"A175BUS_ARD",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",v2v:function(Value){gx.O.A175BUS_ARD=Value},v2z:function(Value){gx.O.Z175BUS_ARD=Value},v2c:function(){gx.fn.setControlValue("BUS_ARD",gx.O.A175BUS_ARD,0)},c2v:function(){gx.O.A175BUS_ARD=this.val()},val:function(){return gx.fn.getControlValue("BUS_ARD")},nac:function(){return  false }};
   this.GXValidFnc[109]={fld:"TEXTBLOCKBUS_TIP", format:0,grid:0};
   this.GXValidFnc[111]={lvl:0,type:"int",len:3,dec:0,sign:false,pic:"ZZ9",ro:0,grid:0,gxgrid:null,fnc:null,isvalid:null,rgrid:[],fld:"BUS_TIP",gxz:"Z56BUS_TIP",gxold:"O56BUS_TIP",gxvar:"A56BUS_TIP",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",v2v:function(Value){gx.O.A56BUS_TIP=gx.num.intval(Value)},v2z:function(Value){gx.O.Z56BUS_TIP=gx.num.intval(Value)},v2c:function(){gx.fn.setControlValue("BUS_TIP",gx.O.A56BUS_TIP,0)},c2v:function(){gx.O.A56BUS_TIP=this.val()},val:function(){return gx.fn.getIntegerValue("BUS_TIP",'.')},nac:function(){return  this.Gx_mode == "INS" && ! (0==this.AV20Insert_BUS_TIP) }};
   this.GXValidFnc[112]={lvl:0,type:"char",len:20,dec:0,sign:false,ro:0,grid:0,gxgrid:null,fnc:null,isvalid:null,fld:"BUS_TID",gxz:"Z59BUS_TID",gxold:"O59BUS_TID",gxvar:"A59BUS_TID",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",v2v:function(Value){gx.O.A59BUS_TID=Value},v2z:function(Value){gx.O.Z59BUS_TID=Value},v2c:function(){gx.fn.setControlValue("BUS_TID",gx.O.A59BUS_TID,0)},c2v:function(){gx.O.A59BUS_TID=this.val()},val:function(){return gx.fn.getControlValue("BUS_TID")},nac:function(){return  false }};
   this.GXValidFnc[118]={fld:"TEXTBLOCKBUS_FBA", format:0,grid:0};
   this.GXValidFnc[120]={lvl:0,type:"date",len:10,dec:0,sign:false,ro:0,grid:0,gxgrid:null,fnc:this.Valid_Bus_fba,isvalid:null,fld:"BUS_FBA",gxz:"Z174BUS_FBA",gxold:"O174BUS_FBA",gxvar:"A174BUS_FBA",dp:{f:0,st:false,wn:false,mf:false,pic:"99/99/9999",dec:0},ucs:[],op:[130,120],ip:[130,120],nacdep:[],ctrltype:"edit",v2v:function(Value){gx.O.A174BUS_FBA=gx.fn.toDatetimeValue(Value)},v2z:function(Value){gx.O.Z174BUS_FBA=gx.fn.toDatetimeValue(Value)},v2c:function(){gx.fn.setControlValue("BUS_FBA",gx.O.A174BUS_FBA,0)},c2v:function(){gx.O.A174BUS_FBA=this.val()},val:function(){return gx.fn.getControlValue("BUS_FBA")},nac:function(){return  false }};
   this.GXValidFnc[123]={fld:"TEXTBLOCKBUS_MBA", format:0,grid:0};
   this.GXValidFnc[125]={lvl:0,type:"char",len:30,dec:0,sign:false,ro:0,grid:0,gxgrid:null,fnc:null,isvalid:null,fld:"BUS_MBA",gxz:"Z334BUS_MBA",gxold:"O334BUS_MBA",gxvar:"A334BUS_MBA",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",v2v:function(Value){gx.O.A334BUS_MBA=Value},v2z:function(Value){gx.O.Z334BUS_MBA=Value},v2c:function(){gx.fn.setControlValue("BUS_MBA",gx.O.A334BUS_MBA,0)},c2v:function(){gx.O.A334BUS_MBA=this.val()},val:function(){return gx.fn.getControlValue("BUS_MBA")},nac:function(){return  false }};
   this.GXValidFnc[128]={fld:"TEXTBLOCK2", format:0,grid:0};
   this.GXValidFnc[130]={lvl:0,type:"int",len:8,dec:0,sign:false,pic:"ZZZZZZZ9",ro:0,grid:0,gxgrid:null,fnc:this.Valid_Bus_idt,isvalid:null,rgrid:[],fld:"BUS_IDT",gxz:"Z103BUS_IDT",gxold:"O103BUS_IDT",gxvar:"A103BUS_IDT",ucs:[],op:[130],ip:[130],nacdep:[],ctrltype:"edit",v2v:function(Value){gx.O.A103BUS_IDT=gx.num.intval(Value)},v2z:function(Value){gx.O.Z103BUS_IDT=gx.num.intval(Value)},v2c:function(){gx.fn.setControlValue("BUS_IDT",gx.O.A103BUS_IDT,0)},c2v:function(){gx.O.A103BUS_IDT=this.val()},val:function(){return gx.fn.getIntegerValue("BUS_IDT",'.')},nac:function(){return  false }};
   this.GXValidFnc[133]={fld:"TEXTBLOCK1", format:0,grid:0};
   this.GXValidFnc[136]={fld:"TABLEPROCESOS",grid:0};
   this.GXValidFnc[139]={fld:"TABLE3",grid:0};
   this.GXValidFnc[142]={fld:"TEXTBLOCKBUS_FPR", format:0,grid:0};
   this.GXValidFnc[144]={lvl:0,type:"date",len:10,dec:0,sign:false,ro:1,grid:0,gxgrid:null,fnc:null,isvalid:null,fld:"BUS_FPR",gxz:"Z340BUS_FPR",gxold:"O340BUS_FPR",gxvar:"A340BUS_FPR",dp:{f:0,st:false,wn:false,mf:false,pic:"99/99/9999",dec:0},ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",v2v:function(Value){gx.O.A340BUS_FPR=gx.fn.toDatetimeValue(Value)},v2z:function(Value){gx.O.Z340BUS_FPR=gx.fn.toDatetimeValue(Value)},v2c:function(){gx.fn.setControlValue("BUS_FPR",gx.O.A340BUS_FPR,0)},c2v:function(){gx.O.A340BUS_FPR=this.val()},val:function(){return gx.fn.getControlValue("BUS_FPR")},nac:function(){return  false }};
   this.GXValidFnc[147]={fld:"TEXTBLOCKBUS_VUT", format:0,grid:0};
   this.GXValidFnc[149]={lvl:0,type:"int",len:4,dec:0,sign:false,pic:"ZZZ9",ro:1,grid:0,gxgrid:null,fnc:this.Valid_Bus_vut,isvalid:null,rgrid:[],fld:"BUS_VUT",gxz:"Z335BUS_VUT",gxold:"O335BUS_VUT",gxvar:"A335BUS_VUT",ucs:[],op:[214],ip:[214,149,72],nacdep:[],ctrltype:"edit",v2v:function(Value){gx.O.A335BUS_VUT=gx.num.intval(Value)},v2z:function(Value){gx.O.Z335BUS_VUT=gx.num.intval(Value)},v2c:function(){gx.fn.setControlValue("BUS_VUT",gx.O.A335BUS_VUT,0)},c2v:function(){gx.O.A335BUS_VUT=this.val()},val:function(){return gx.fn.getIntegerValue("BUS_VUT",'.')},nac:function(){return  false }};
   this.GXValidFnc[152]={fld:"TEXTBLOCKBUS_COE", format:0,grid:0};
   this.GXValidFnc[154]={lvl:0,type:"decimal",len:18,dec:7,sign:false,pic:"ZZZZZZZZZ9.9999999",ro:1,grid:0,gxgrid:null,fnc:null,isvalid:null,rgrid:[],fld:"BUS_COE",gxz:"Z336BUS_COE",gxold:"O336BUS_COE",gxvar:"A336BUS_COE",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",v2v:function(Value){gx.O.A336BUS_COE=gx.fn.toDecimalValue(Value,',','.')},v2z:function(Value){gx.O.Z336BUS_COE=gx.fn.toDecimalValue(Value,'.',',')},v2c:function(){gx.fn.setDecimalValue("BUS_COE",gx.O.A336BUS_COE,7,',')},c2v:function(){gx.O.A336BUS_COE=this.val()},val:function(){return gx.fn.getDecimalValue("BUS_COE",'.',',')},nac:function(){return  false }};
   this.GXValidFnc[157]={fld:"TEXTBLOCKBUS_VOC", format:0,grid:0};
   this.GXValidFnc[159]={lvl:0,type:"decimal",len:18,dec:7,sign:false,pic:"ZZZZZZZZZ9.9999999",ro:1,grid:0,gxgrid:null,fnc:null,isvalid:null,rgrid:[],fld:"BUS_VOC",gxz:"Z341BUS_VOC",gxold:"O341BUS_VOC",gxvar:"A341BUS_VOC",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",v2v:function(Value){gx.O.A341BUS_VOC=gx.fn.toDecimalValue(Value,',','.')},v2z:function(Value){gx.O.Z341BUS_VOC=gx.fn.toDecimalValue(Value,'.',',')},v2c:function(){gx.fn.setDecimalValue("BUS_VOC",gx.O.A341BUS_VOC,7,',')},c2v:function(){gx.O.A341BUS_VOC=this.val()},val:function(){return gx.fn.getDecimalValue("BUS_VOC",'.',',')},nac:function(){return  false }};
   this.GXValidFnc[162]={fld:"TEXTBLOCKBUS_VOA", format:0,grid:0};
   this.GXValidFnc[164]={lvl:0,type:"decimal",len:18,dec:7,sign:false,pic:"ZZZZZZZZZ9.9999999",ro:1,grid:0,gxgrid:null,fnc:this.Valid_Bus_voa,isvalid:null,rgrid:[],fld:"BUS_VOA",gxz:"Z337BUS_VOA",gxold:"O337BUS_VOA",gxvar:"A337BUS_VOA",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",v2v:function(Value){gx.O.A337BUS_VOA=gx.fn.toDecimalValue(Value,',','.')},v2z:function(Value){gx.O.Z337BUS_VOA=gx.fn.toDecimalValue(Value,'.',',')},v2c:function(){gx.fn.setDecimalValue("BUS_VOA",gx.O.A337BUS_VOA,7,',')},c2v:function(){gx.O.A337BUS_VOA=this.val()},val:function(){return gx.fn.getDecimalValue("BUS_VOA",'.',',')},nac:function(){return  false }};
   this.GXValidFnc[167]={fld:"TEXTBLOCKBUS_AAA", format:0,grid:0};
   this.GXValidFnc[169]={lvl:0,type:"decimal",len:10,dec:2,sign:false,pic:"ZZZZZZ9.99",ro:1,grid:0,gxgrid:null,fnc:this.Valid_Bus_aaa,isvalid:null,rgrid:[],fld:"BUS_AAA",gxz:"Z338BUS_AAA",gxold:"O338BUS_AAA",gxvar:"A338BUS_AAA",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",v2v:function(Value){gx.O.A338BUS_AAA=gx.fn.toDecimalValue(Value,',','.')},v2z:function(Value){gx.O.Z338BUS_AAA=gx.fn.toDecimalValue(Value,'.',',')},v2c:function(){gx.fn.setDecimalValue("BUS_AAA",gx.O.A338BUS_AAA,2,',')},c2v:function(){gx.O.A338BUS_AAA=this.val()},val:function(){return gx.fn.getDecimalValue("BUS_AAA",'.',',')},nac:function(){return  false }};
   this.GXValidFnc[172]={fld:"TEXTBLOCKBUS_AEA", format:0,grid:0};
   this.GXValidFnc[174]={lvl:0,type:"decimal",len:10,dec:2,sign:false,pic:"ZZZZZZ9.99",ro:1,grid:0,gxgrid:null,fnc:this.Valid_Bus_aea,isvalid:null,rgrid:[],fld:"BUS_AEA",gxz:"Z339BUS_AEA",gxold:"O339BUS_AEA",gxvar:"A339BUS_AEA",ucs:[],op:[204],ip:[204,174,169,164],nacdep:[],ctrltype:"edit",v2v:function(Value){gx.O.A339BUS_AEA=gx.fn.toDecimalValue(Value,',','.')},v2z:function(Value){gx.O.Z339BUS_AEA=gx.fn.toDecimalValue(Value,'.',',')},v2c:function(){gx.fn.setDecimalValue("BUS_AEA",gx.O.A339BUS_AEA,2,',')},c2v:function(){gx.O.A339BUS_AEA=this.val()},val:function(){return gx.fn.getDecimalValue("BUS_AEA",'.',',')},nac:function(){return  false }};
   this.GXValidFnc[177]={fld:"TEXTBLOCKBUS_AEA2", format:0,grid:0};
   this.GXValidFnc[179]={lvl:0,type:"decimal",len:18,dec:7,sign:false,pic:"ZZZZZZZZZ9.9999999",ro:1,grid:0,gxgrid:null,fnc:null,isvalid:null,rgrid:[],fld:"BUS_VAH",gxz:"Z342BUS_VAH",gxold:"O342BUS_VAH",gxvar:"A342BUS_VAH",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",v2v:function(Value){gx.O.A342BUS_VAH=gx.fn.toDecimalValue(Value,',','.')},v2z:function(Value){gx.O.Z342BUS_VAH=gx.fn.toDecimalValue(Value,'.',',')},v2c:function(){gx.fn.setDecimalValue("BUS_VAH",gx.O.A342BUS_VAH,7,',')},c2v:function(){gx.O.A342BUS_VAH=this.val()},val:function(){return gx.fn.getDecimalValue("BUS_VAH",'.',',')},nac:function(){return  false }};
   this.GXValidFnc[182]={fld:"TEXTBLOCKBUS_AEA3", format:0,grid:0};
   this.GXValidFnc[184]={lvl:0,type:"date",len:10,dec:0,sign:false,ro:1,grid:0,gxgrid:null,fnc:null,isvalid:null,fld:"BUS_VHF",gxz:"Z343BUS_VHF",gxold:"O343BUS_VHF",gxvar:"A343BUS_VHF",dp:{f:0,st:false,wn:false,mf:false,pic:"99/99/9999",dec:0},ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",v2v:function(Value){gx.O.A343BUS_VHF=gx.fn.toDatetimeValue(Value)},v2z:function(Value){gx.O.Z343BUS_VHF=gx.fn.toDatetimeValue(Value)},v2c:function(){gx.fn.setControlValue("BUS_VHF",gx.O.A343BUS_VHF,0)},c2v:function(){gx.O.A343BUS_VHF=this.val()},val:function(){return gx.fn.getControlValue("BUS_VHF")},nac:function(){return  false }};
   this.GXValidFnc[187]={fld:"TEXTBLOCKBUS_VOH", format:0,grid:0};
   this.GXValidFnc[189]={lvl:0,type:"decimal",len:18,dec:7,sign:false,pic:"ZZZZZZZZZ9.9999999",ro:1,grid:0,gxgrid:null,fnc:this.Valid_Bus_voh,isvalid:null,rgrid:[],fld:"BUS_VOH",gxz:"Z344BUS_VOH",gxold:"O344BUS_VOH",gxvar:"A344BUS_VOH",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",v2v:function(Value){gx.O.A344BUS_VOH=gx.fn.toDecimalValue(Value,',','.')},v2z:function(Value){gx.O.Z344BUS_VOH=gx.fn.toDecimalValue(Value,'.',',')},v2c:function(){gx.fn.setDecimalValue("BUS_VOH",gx.O.A344BUS_VOH,7,',')},c2v:function(){gx.O.A344BUS_VOH=this.val()},val:function(){return gx.fn.getDecimalValue("BUS_VOH",'.',',')},nac:function(){return  false }};
   this.GXValidFnc[192]={fld:"TEXTBLOCKBUS_AAH", format:0,grid:0};
   this.GXValidFnc[194]={lvl:0,type:"decimal",len:10,dec:2,sign:false,pic:"ZZZZZZ9.99",ro:1,grid:0,gxgrid:null,fnc:this.Valid_Bus_aah,isvalid:null,rgrid:[],fld:"BUS_AAH",gxz:"Z345BUS_AAH",gxold:"O345BUS_AAH",gxvar:"A345BUS_AAH",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",v2v:function(Value){gx.O.A345BUS_AAH=gx.fn.toDecimalValue(Value,',','.')},v2z:function(Value){gx.O.Z345BUS_AAH=gx.fn.toDecimalValue(Value,'.',',')},v2c:function(){gx.fn.setDecimalValue("BUS_AAH",gx.O.A345BUS_AAH,2,',')},c2v:function(){gx.O.A345BUS_AAH=this.val()},val:function(){return gx.fn.getDecimalValue("BUS_AAH",'.',',')},nac:function(){return  false }};
   this.GXValidFnc[197]={fld:"TEXTBLOCKBUS_AEH", format:0,grid:0};
   this.GXValidFnc[199]={lvl:0,type:"decimal",len:10,dec:2,sign:false,pic:"ZZZZZZ9.99",ro:1,grid:0,gxgrid:null,fnc:this.Valid_Bus_aeh,isvalid:null,rgrid:[],fld:"BUS_AEH",gxz:"Z346BUS_AEH",gxold:"O346BUS_AEH",gxvar:"A346BUS_AEH",ucs:[],op:[209],ip:[209,199,194,189],nacdep:[],ctrltype:"edit",v2v:function(Value){gx.O.A346BUS_AEH=gx.fn.toDecimalValue(Value,',','.')},v2z:function(Value){gx.O.Z346BUS_AEH=gx.fn.toDecimalValue(Value,'.',',')},v2c:function(){gx.fn.setDecimalValue("BUS_AEH",gx.O.A346BUS_AEH,2,',')},c2v:function(){gx.O.A346BUS_AEH=this.val()},val:function(){return gx.fn.getDecimalValue("BUS_AEH",'.',',')},nac:function(){return  false }};
   this.GXValidFnc[202]={fld:"TEXTBLOCKBUS_VRA", format:0,grid:0};
   this.GXValidFnc[204]={lvl:0,type:"decimal",len:18,dec:7,sign:false,pic:"ZZZZZZZZZ9.9999999",ro:1,grid:0,gxgrid:null,fnc:null,isvalid:null,rgrid:[],fld:"BUS_VRA",gxz:"Z347BUS_VRA",gxold:"O347BUS_VRA",gxvar:"A347BUS_VRA",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",v2v:function(Value){gx.O.A347BUS_VRA=gx.fn.toDecimalValue(Value,',','.')},v2z:function(Value){gx.O.Z347BUS_VRA=gx.fn.toDecimalValue(Value,'.',',')},v2c:function(){gx.fn.setDecimalValue("BUS_VRA",gx.O.A347BUS_VRA,7,',')},c2v:function(){gx.O.A347BUS_VRA=this.val()},val:function(){return gx.fn.getDecimalValue("BUS_VRA",'.',',')},nac:function(){return  false }};
   this.GXValidFnc[207]={fld:"TEXTBLOCKBUS_VRH", format:0,grid:0};
   this.GXValidFnc[209]={lvl:0,type:"decimal",len:18,dec:7,sign:false,pic:"ZZZZZZZZZ9.9999999",ro:1,grid:0,gxgrid:null,fnc:null,isvalid:null,rgrid:[],fld:"BUS_VRH",gxz:"Z348BUS_VRH",gxold:"O348BUS_VRH",gxvar:"A348BUS_VRH",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",v2v:function(Value){gx.O.A348BUS_VRH=gx.fn.toDecimalValue(Value,',','.')},v2z:function(Value){gx.O.Z348BUS_VRH=gx.fn.toDecimalValue(Value,'.',',')},v2c:function(){gx.fn.setDecimalValue("BUS_VRH",gx.O.A348BUS_VRH,7,',')},c2v:function(){gx.O.A348BUS_VRH=this.val()},val:function(){return gx.fn.getDecimalValue("BUS_VRH",'.',',')},nac:function(){return  false }};
   this.GXValidFnc[212]={fld:"TEXTBLOCKBUS_VUR", format:0,grid:0};
   this.GXValidFnc[214]={lvl:0,type:"int",len:4,dec:0,sign:false,pic:"ZZZ9",ro:1,grid:0,gxgrid:null,fnc:null,isvalid:null,rgrid:[],fld:"BUS_VUR",gxz:"Z349BUS_VUR",gxold:"O349BUS_VUR",gxvar:"A349BUS_VUR",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",v2v:function(Value){gx.O.A349BUS_VUR=gx.num.intval(Value)},v2z:function(Value){gx.O.Z349BUS_VUR=gx.num.intval(Value)},v2c:function(){gx.fn.setControlValue("BUS_VUR",gx.O.A349BUS_VUR,0)},c2v:function(){gx.O.A349BUS_VUR=this.val()},val:function(){return gx.fn.getIntegerValue("BUS_VUR",'.')},nac:function(){return  false }};
   this.GXValidFnc[223]={fld:"PROMPT_1",grid:24};
   this.GXValidFnc[224]={fld:"PROMPT_103",grid:24};
   this.A8BUS_EMP = "" ;
   this.Z8BUS_EMP = "" ;
   this.O8BUS_EMP = "" ;
   this.A1BUS_RUB = 0 ;
   this.Z1BUS_RUB = 0 ;
   this.O1BUS_RUB = 0 ;
   this.A3BUS_COD = 0 ;
   this.Z3BUS_COD = 0 ;
   this.O3BUS_COD = 0 ;
   this.A4BUS_PAR = 0 ;
   this.Z4BUS_PAR = 0 ;
   this.O4BUS_PAR = 0 ;
   this.A54BUS_DES = "" ;
   this.Z54BUS_DES = "" ;
   this.O54BUS_DES = "" ;
   this.A170BUS_FAL = gx.date.nullDate() ;
   this.Z170BUS_FAL = gx.date.nullDate() ;
   this.O170BUS_FAL = gx.date.nullDate() ;
   this.A55BUS_FAD = gx.date.nullDate() ;
   this.Z55BUS_FAD = gx.date.nullDate() ;
   this.O55BUS_FAD = gx.date.nullDate() ;
   this.A329BUS_VUA = 0 ;
   this.Z329BUS_VUA = 0 ;
   this.O329BUS_VUA = 0 ;
   this.A330BUS_VAO = 0 ;
   this.Z330BUS_VAO = 0 ;
   this.O330BUS_VAO = 0 ;
   this.A331BUS_COM = "" ;
   this.Z331BUS_COM = "" ;
   this.O331BUS_COM = "" ;
   this.A350BUS_CBD = "" ;
   this.Z350BUS_CBD = "" ;
   this.O350BUS_CBD = "" ;
   this.A333BUS_NCO = "" ;
   this.Z333BUS_NCO = "" ;
   this.O333BUS_NCO = "" ;
   this.A172BUS_SEC = 0 ;
   this.Z172BUS_SEC = 0 ;
   this.O172BUS_SEC = 0 ;
   this.A176BUS_SED = "" ;
   this.Z176BUS_SED = "" ;
   this.O176BUS_SED = "" ;
   this.A171BUS_ARE = 0 ;
   this.Z171BUS_ARE = 0 ;
   this.O171BUS_ARE = 0 ;
   this.A175BUS_ARD = "" ;
   this.Z175BUS_ARD = "" ;
   this.O175BUS_ARD = "" ;
   this.A56BUS_TIP = 0 ;
   this.Z56BUS_TIP = 0 ;
   this.O56BUS_TIP = 0 ;
   this.A59BUS_TID = "" ;
   this.Z59BUS_TID = "" ;
   this.O59BUS_TID = "" ;
   this.A174BUS_FBA = gx.date.nullDate() ;
   this.Z174BUS_FBA = gx.date.nullDate() ;
   this.O174BUS_FBA = gx.date.nullDate() ;
   this.A334BUS_MBA = "" ;
   this.Z334BUS_MBA = "" ;
   this.O334BUS_MBA = "" ;
   this.A103BUS_IDT = 0 ;
   this.Z103BUS_IDT = 0 ;
   this.O103BUS_IDT = 0 ;
   this.A340BUS_FPR = gx.date.nullDate() ;
   this.Z340BUS_FPR = gx.date.nullDate() ;
   this.O340BUS_FPR = gx.date.nullDate() ;
   this.A335BUS_VUT = 0 ;
   this.Z335BUS_VUT = 0 ;
   this.O335BUS_VUT = 0 ;
   this.A336BUS_COE = 0 ;
   this.Z336BUS_COE = 0 ;
   this.O336BUS_COE = 0 ;
   this.A341BUS_VOC = 0 ;
   this.Z341BUS_VOC = 0 ;
   this.O341BUS_VOC = 0 ;
   this.A337BUS_VOA = 0 ;
   this.Z337BUS_VOA = 0 ;
   this.O337BUS_VOA = 0 ;
   this.A338BUS_AAA = 0 ;
   this.Z338BUS_AAA = 0 ;
   this.O338BUS_AAA = 0 ;
   this.A339BUS_AEA = 0 ;
   this.Z339BUS_AEA = 0 ;
   this.O339BUS_AEA = 0 ;
   this.A342BUS_VAH = 0 ;
   this.Z342BUS_VAH = 0 ;
   this.O342BUS_VAH = 0 ;
   this.A343BUS_VHF = gx.date.nullDate() ;
   this.Z343BUS_VHF = gx.date.nullDate() ;
   this.O343BUS_VHF = gx.date.nullDate() ;
   this.A344BUS_VOH = 0 ;
   this.Z344BUS_VOH = 0 ;
   this.O344BUS_VOH = 0 ;
   this.A345BUS_AAH = 0 ;
   this.Z345BUS_AAH = 0 ;
   this.O345BUS_AAH = 0 ;
   this.A346BUS_AEH = 0 ;
   this.Z346BUS_AEH = 0 ;
   this.O346BUS_AEH = 0 ;
   this.A347BUS_VRA = 0 ;
   this.Z347BUS_VRA = 0 ;
   this.O347BUS_VRA = 0 ;
   this.A348BUS_VRH = 0 ;
   this.Z348BUS_VRH = 0 ;
   this.O348BUS_VRH = 0 ;
   this.A349BUS_VUR = 0 ;
   this.Z349BUS_VUR = 0 ;
   this.O349BUS_VUR = 0 ;
   this.AV15Context = {} ;
   this.AV27USUARIO = "" ;
   this.AV34Pgmname = "" ;
   this.AV21IsAuthorized = false ;
   this.AV25TrnContext = {} ;
   this.AV18Insert_BUS_COM = "" ;
   this.AV17Insert_BUS_ARE = 0 ;
   this.AV19Insert_BUS_SEC = 0 ;
   this.AV20Insert_BUS_TIP = 0 ;
   this.AV35GXV1 = 0 ;
   this.AV9BUS_IDT = 0 ;
   this.AV8BUS_EMP = "" ;
   this.AV11BUS_RUB = 0 ;
   this.AV7BUS_COD = 0 ;
   this.AV10BUS_PAR = 0 ;
   this.AV16error = 0 ;
   this.AV31error_t = 0 ;
   this.AV30mensaje = "" ;
   this.AV32error_2 = 0 ;
   this.Gx_BScreen = 0 ;
   this.A61BUS_RUD = "" ;
   this.A178BUS_AMO = "" ;
   this.Gx_mode = "" ;
   this.ServerEvents = ["e120o2_client" ,"e130o24_client" ,"e140o24_client"];
   this.setPrompt("PROMPT_1", [43]);
   this.setPrompt("PROMPT_103", [130]);
   this.EnterCtrl = ["BTN_ENTER"];
   this.VarControlMap["AV8BUS_EMP"] = {id:"vBUS_EMP",grid:0,type:"char"};
   this.VarControlMap["Gx_BScreen"] = {id:"vGXBSCREEN",grid:0,type:"int"};
   this.VarControlMap["AV11BUS_RUB"] = {id:"vBUS_RUB",grid:0,type:"int"};
   this.VarControlMap["AV7BUS_COD"] = {id:"vBUS_COD",grid:0,type:"int"};
   this.VarControlMap["AV10BUS_PAR"] = {id:"vBUS_PAR",grid:0,type:"int"};
   this.VarControlMap["AV18Insert_BUS_COM"] = {id:"vINSERT_BUS_COM",grid:0,type:"char"};
   this.VarControlMap["AV17Insert_BUS_ARE"] = {id:"vINSERT_BUS_ARE",grid:0,type:"int"};
   this.VarControlMap["AV19Insert_BUS_SEC"] = {id:"vINSERT_BUS_SEC",grid:0,type:"int"};
   this.VarControlMap["AV20Insert_BUS_TIP"] = {id:"vINSERT_BUS_TIP",grid:0,type:"int"};
   this.VarControlMap["AV16error"] = {id:"vERROR",grid:0,type:"int"};
   this.VarControlMap["Gx_mode"] = {id:"vMODE",grid:0,type:"char"};
   this.VarControlMap["AV31error_t"] = {id:"vERROR_T",grid:0,type:"int"};
   this.VarControlMap["AV30mensaje"] = {id:"vMENSAJE",grid:0,type:"char"};
   this.VarControlMap["AV32error_2"] = {id:"vERROR_2",grid:0,type:"int"};
   this.VarControlMap["A61BUS_RUD"] = {id:"BUS_RUD",grid:0,type:"char"};
   this.VarControlMap["A178BUS_AMO"] = {id:"BUS_AMO",grid:0,type:"char"};
   this.VarControlMap["AV34Pgmname"] = {id:"vPGMNAME",grid:0,type:"char"};
   this.SetStandaloneVars( );
}
tbus000.prototype = new gx.GxObject;
gx.setParentObj(new tbus000());
