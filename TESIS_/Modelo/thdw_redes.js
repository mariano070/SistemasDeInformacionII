gx.evt.autoSkip=false;function thdw_redes(){this.ServerClass="THDW_REDES";this.PackageName="GeneXus.Programs";this.setObjectType("trn");this.hasEnterEvent=true;this.SetStandaloneVars=function(){this.AV7THDW_UBI_COD_=gx.fn.getIntegerValue("vTHDW_UBI_COD_",".");this.AV10Red_Id=gx.fn.getIntegerValue("vRED_ID",".");this.Gx_BScreen=gx.fn.getIntegerValue("vGXBSCREEN",".");this.Gx_mode=gx.fn.getControlValue("vMODE");this.AV8SISTEMA=gx.fn.getControlValue("vSISTEMA");this.AV9USUARIO=gx.fn.getControlValue("vUSUARIO")
};this.Valid_Thdw_ubi_cod_=function(){gx.ajax.validSrvEvt("dyncall","Valid_Thdw_ubi_cod_",["gx.O.Gx_mode","gx.O.A306THDW_UBI_COD_","gx.O.A300Red_Id"],["A300Red_Id"]);return true};this.Valid_Red_id=function(){try{var a=gx.util.balloon.getNew("RED_ID");this.AnyError=0}catch(b){}try{if(a==null){return true}return a.show()}catch(b){}return true};this.Valid_Red_descripcion=function(){try{var a=gx.util.balloon.getNew("RED_DESCRIPCION");this.AnyError=0;if(gx.text.trim(this.A301Red_Descripcion)==""&&true){try{a.setError("Debe ingresar una descripción.");
this.AnyError=1}catch(b){}}}catch(b){}try{if(a==null){return true}return a.show()}catch(b){}return true};this.Valid_Red_direcciondesdeb1=function(){try{var a=gx.util.balloon.getNew("RED_DIRECCIONDESDEB1");this.AnyError=0;if(this.A308Red_DireccionDesdeB1>255&&true){try{a.setError("Nº inválido para dirección IP. Debe ser menor o igual a 255.");this.AnyError=1}catch(b){}}}catch(b){}try{if(a==null){return true}return a.show()}catch(b){}return true};this.Valid_Red_direcciondesdeb2=function(){try{var a=gx.util.balloon.getNew("RED_DIRECCIONDESDEB2");
this.AnyError=0;if(this.A309Red_DireccionDesdeB2>255&&true){try{a.setError("Nº inválido para dirección IP. Debe ser menor o igual a 255.");this.AnyError=1}catch(b){}}}catch(b){}try{if(a==null){return true}return a.show()}catch(b){}return true};this.Valid_Red_direcciondesdeb3=function(){try{var a=gx.util.balloon.getNew("RED_DIRECCIONDESDEB3");this.AnyError=0;if(this.A310Red_DireccionDesdeB3>255&&true){try{a.setError("Nº inválido para dirección IP. Debe ser menor o igual a 255.");this.AnyError=1}catch(b){}}}catch(b){}try{if(a==null){return true
}return a.show()}catch(b){}return true};this.Valid_Red_direcciondesdeb4=function(){try{var a=gx.util.balloon.getNew("RED_DIRECCIONDESDEB4");this.AnyError=0;if(this.A315Red_DireccionDesdeB4>255&&true){try{a.setError("Nº inválido para dirección IP. Debe ser menor o igual a 255.");this.AnyError=1}catch(b){}}}catch(b){}try{if(a==null){return true}return a.show()}catch(b){}return true};this.Valid_Red_direccionhastab1=function(){try{var a=gx.util.balloon.getNew("RED_DIRECCIONHASTAB1");this.AnyError=0;if(this.A316Red_DireccionHastaB1>255&&true){try{a.setError("Nº inválido para dirección IP. Debe ser menor o igual a 255.");
this.AnyError=1}catch(b){}}}catch(b){}try{if(a==null){return true}return a.show()}catch(b){}return true};this.Valid_Red_direccionhastab2=function(){try{var a=gx.util.balloon.getNew("RED_DIRECCIONHASTAB2");this.AnyError=0;if(this.A317Red_DireccionHastaB2>255&&true){try{a.setError("Nº inválido para dirección IP. Debe ser menor o igual a 255.");this.AnyError=1}catch(b){}}}catch(b){}try{if(a==null){return true}return a.show()}catch(b){}return true};this.Valid_Red_direccionhastab3=function(){try{var a=gx.util.balloon.getNew("RED_DIRECCIONHASTAB3");
this.AnyError=0;if(this.A318Red_DireccionHastaB3>255&&true){try{a.setError("Nº inválido para dirección IP. Debe ser menor o igual a 255.");this.AnyError=1}catch(b){}}}catch(b){}try{if(a==null){return true}return a.show()}catch(b){}return true};this.Valid_Red_direccionhastab4=function(){try{var a=gx.util.balloon.getNew("RED_DIRECCIONHASTAB4");this.AnyError=0;if(this.A319Red_DireccionHastaB4>255&&true){try{a.setError("Nº inválido para dirección IP. Debe ser menor o igual a 255.");this.AnyError=1}catch(b){}}if((this.A315Red_DireccionDesdeB4>this.A319Red_DireccionHastaB4)&&true){try{a.setError("La IP Desde debe ser menor que la IP hasta.");
this.AnyError=1}catch(b){}}}catch(b){}try{if(a==null){return true}return a.show()}catch(b){}return true};this.Valid_Red_mascarab1=function(){try{var a=gx.util.balloon.getNew("RED_MASCARAB1");this.AnyError=0;if(this.A320Red_MascaraB1>255&&true){try{a.setError("Nº inválido para dirección IP. Debe ser menor o igual a 255.");this.AnyError=1}catch(b){}}}catch(b){}try{if(a==null){return true}return a.show()}catch(b){}return true};this.Valid_Red_mascarab2=function(){try{var a=gx.util.balloon.getNew("RED_MASCARAB2");
this.AnyError=0;if(this.A321Red_MascaraB2>255&&true){try{a.setError("Nº inválido para dirección IP. Debe ser menor o igual a 255.");this.AnyError=1}catch(b){}}}catch(b){}try{if(a==null){return true}return a.show()}catch(b){}return true};this.Valid_Red_mascarab3=function(){try{var a=gx.util.balloon.getNew("RED_MASCARAB3");this.AnyError=0;if(this.A322Red_MascaraB3>255&&true){try{a.setError("Nº inválido para dirección IP. Debe ser menor o igual a 255.");this.AnyError=1}catch(b){}}}catch(b){}try{if(a==null){return true
}return a.show()}catch(b){}return true};this.Valid_Red_mascarab4=function(){try{var a=gx.util.balloon.getNew("RED_MASCARAB4");this.AnyError=0;if(this.A323Red_MascaraB4>255&&true){try{a.setError("Nº inválido para dirección IP. Debe ser menor o igual a 255.");this.AnyError=1}catch(b){}}}catch(b){}try{if(a==null){return true}return a.show()}catch(b){}return true};this.Valid_Red_puertaenlaceb1=function(){try{var a=gx.util.balloon.getNew("RED_PUERTAENLACEB1");this.AnyError=0;if(this.A324Red_PuertaEnlaceB1>255&&true){try{a.setError("Nº inválido para dirección IP. Debe ser menor o igual a 255.");
this.AnyError=1}catch(b){}}}catch(b){}try{if(a==null){return true}return a.show()}catch(b){}return true};this.Valid_Red_puertaenlaceb2=function(){try{var a=gx.util.balloon.getNew("RED_PUERTAENLACEB2");this.AnyError=0;if(this.A325Red_PuertaEnlaceB2>255&&true){try{a.setError("Nº inválido para dirección IP. Debe ser menor o igual a 255.");this.AnyError=1}catch(b){}}}catch(b){}try{if(a==null){return true}return a.show()}catch(b){}return true};this.Valid_Red_puertaenlaceb3=function(){try{var a=gx.util.balloon.getNew("RED_PUERTAENLACEB3");
this.AnyError=0;if(this.A326Red_PuertaEnlaceB3>255&&true){try{a.setError("Nº inválido para dirección IP. Debe ser menor o igual a 255.");this.AnyError=1}catch(b){}}}catch(b){}try{if(a==null){return true}return a.show()}catch(b){}return true};this.Valid_Red_puertaenlaceb4=function(){try{var a=gx.util.balloon.getNew("RED_PUERTAENLACEB4");this.AnyError=0;if(this.A327Red_PuertaEnlaceB4>255&&true){try{a.setError("Nº inválido para dirección IP. Debe ser menor o igual a 255.");this.AnyError=1}catch(b){}}}catch(b){}try{if(a==null){return true
}return a.show()}catch(b){}return true};this.e11152_client=function(){this.executeServerEvent("AFTER TRN",true)};this.e121539_client=function(){this.executeServerEvent("ENTER",true)};this.e131539_client=function(){this.executeServerEvent("CANCEL",true)};this.GXValidFnc=[];this.GXCtrlIds=[2,5,8,9,15,20,25,30,35,36,37,38,43,44,45,46,51,52,53,54,59,60,61,62];this.GXLastCtrlId=62;this.GXValidFnc[2]={fld:"TABLEMAIN",grid:0};this.GXValidFnc[5]={fld:"TABLETOOLBAR",grid:0};this.GXValidFnc[8]={fld:"GROUPDATA",grid:0};
this.GXValidFnc[9]={fld:"TABLE1",grid:0};this.GXValidFnc[15]={fld:"TABLE2",grid:0};this.GXValidFnc[18]={fld:"TEXTBLOCKTHDW_UBI_COD_",format:0,grid:0};this.GXValidFnc[20]={lvl:0,type:"int",len:10,dec:0,sign:false,pic:"ZZZZZZZZZ9",ro:1,grid:0,gxgrid:null,fnc:this.Valid_Thdw_ubi_cod_,isvalid:null,rgrid:[],fld:"THDW_UBI_COD_",gxz:"Z306THDW_UBI_COD_",gxold:"O306THDW_UBI_COD_",gxvar:"A306THDW_UBI_COD_",ucs:[],op:[25],ip:[25,20],nacdep:[],ctrltype:"edit",v2v:function(a){gx.O.A306THDW_UBI_COD_=gx.num.intval(a)
},v2z:function(a){gx.O.Z306THDW_UBI_COD_=gx.num.intval(a)},v2c:function(){gx.fn.setControlValue("THDW_UBI_COD_",gx.O.A306THDW_UBI_COD_,0)},c2v:function(){gx.O.A306THDW_UBI_COD_=this.val()},val:function(){return gx.fn.getIntegerValue("THDW_UBI_COD_",".")},nac:function(){return false}};this.GXValidFnc[23]={fld:"TEXTBLOCKRED_ID",format:0,grid:0};this.GXValidFnc[25]={lvl:0,type:"int",len:10,dec:0,sign:false,pic:"ZZZZZZZZZ9",ro:1,grid:0,gxgrid:null,fnc:this.Valid_Red_id,isvalid:null,rgrid:[],fld:"RED_ID",gxz:"Z300Red_Id",gxold:"O300Red_Id",gxvar:"A300Red_Id",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",v2v:function(a){gx.O.A300Red_Id=gx.num.intval(a)
},v2z:function(a){gx.O.Z300Red_Id=gx.num.intval(a)},v2c:function(){gx.fn.setControlValue("RED_ID",gx.O.A300Red_Id,0)},c2v:function(){gx.O.A300Red_Id=this.val()},val:function(){return gx.fn.getIntegerValue("RED_ID",".")},nac:function(){return false}};this.GXValidFnc[28]={fld:"TEXTBLOCKRED_DESCRIPCION",format:0,grid:0};this.GXValidFnc[30]={lvl:0,type:"char",len:30,dec:0,sign:false,ro:0,grid:0,gxgrid:null,fnc:this.Valid_Red_descripcion,isvalid:null,fld:"RED_DESCRIPCION",gxz:"Z301Red_Descripcion",gxold:"O301Red_Descripcion",gxvar:"A301Red_Descripcion",ucs:[],op:[30],ip:[30],nacdep:[],ctrltype:"edit",v2v:function(a){gx.O.A301Red_Descripcion=a
},v2z:function(a){gx.O.Z301Red_Descripcion=a},v2c:function(){gx.fn.setControlValue("RED_DESCRIPCION",gx.O.A301Red_Descripcion,0)},c2v:function(){gx.O.A301Red_Descripcion=this.val()},val:function(){return gx.fn.getControlValue("RED_DESCRIPCION")},nac:function(){return false}};this.GXValidFnc[33]={fld:"TEXTBLOCKRED_DIRECCIONDESDEB1",format:0,grid:0};this.GXValidFnc[35]={lvl:0,type:"int",len:3,dec:0,sign:false,pic:"ZZ9",ro:0,grid:0,gxgrid:null,fnc:this.Valid_Red_direcciondesdeb1,isvalid:null,rgrid:[],fld:"RED_DIRECCIONDESDEB1",gxz:"Z308Red_DireccionDesdeB1",gxold:"O308Red_DireccionDesdeB1",gxvar:"A308Red_DireccionDesdeB1",ucs:[],op:[35],ip:[35],nacdep:[],ctrltype:"edit",v2v:function(a){gx.O.A308Red_DireccionDesdeB1=gx.num.intval(a)
},v2z:function(a){gx.O.Z308Red_DireccionDesdeB1=gx.num.intval(a)},v2c:function(){gx.fn.setControlValue("RED_DIRECCIONDESDEB1",gx.O.A308Red_DireccionDesdeB1,0)},c2v:function(){gx.O.A308Red_DireccionDesdeB1=this.val()},val:function(){return gx.fn.getIntegerValue("RED_DIRECCIONDESDEB1",".")},nac:function(){return false}};this.GXValidFnc[36]={lvl:0,type:"int",len:3,dec:0,sign:false,pic:"ZZ9",ro:0,grid:0,gxgrid:null,fnc:this.Valid_Red_direcciondesdeb2,isvalid:null,rgrid:[],fld:"RED_DIRECCIONDESDEB2",gxz:"Z309Red_DireccionDesdeB2",gxold:"O309Red_DireccionDesdeB2",gxvar:"A309Red_DireccionDesdeB2",ucs:[],op:[36],ip:[36],nacdep:[],ctrltype:"edit",v2v:function(a){gx.O.A309Red_DireccionDesdeB2=gx.num.intval(a)
},v2z:function(a){gx.O.Z309Red_DireccionDesdeB2=gx.num.intval(a)},v2c:function(){gx.fn.setControlValue("RED_DIRECCIONDESDEB2",gx.O.A309Red_DireccionDesdeB2,0)},c2v:function(){gx.O.A309Red_DireccionDesdeB2=this.val()},val:function(){return gx.fn.getIntegerValue("RED_DIRECCIONDESDEB2",".")},nac:function(){return false}};this.GXValidFnc[37]={lvl:0,type:"int",len:3,dec:0,sign:false,pic:"ZZ9",ro:0,grid:0,gxgrid:null,fnc:this.Valid_Red_direcciondesdeb3,isvalid:null,rgrid:[],fld:"RED_DIRECCIONDESDEB3",gxz:"Z310Red_DireccionDesdeB3",gxold:"O310Red_DireccionDesdeB3",gxvar:"A310Red_DireccionDesdeB3",ucs:[],op:[37],ip:[37],nacdep:[],ctrltype:"edit",v2v:function(a){gx.O.A310Red_DireccionDesdeB3=gx.num.intval(a)
},v2z:function(a){gx.O.Z310Red_DireccionDesdeB3=gx.num.intval(a)},v2c:function(){gx.fn.setControlValue("RED_DIRECCIONDESDEB3",gx.O.A310Red_DireccionDesdeB3,0)},c2v:function(){gx.O.A310Red_DireccionDesdeB3=this.val()},val:function(){return gx.fn.getIntegerValue("RED_DIRECCIONDESDEB3",".")},nac:function(){return false}};this.GXValidFnc[38]={lvl:0,type:"int",len:3,dec:0,sign:false,pic:"ZZ9",ro:0,grid:0,gxgrid:null,fnc:this.Valid_Red_direcciondesdeb4,isvalid:null,rgrid:[],fld:"RED_DIRECCIONDESDEB4",gxz:"Z315Red_DireccionDesdeB4",gxold:"O315Red_DireccionDesdeB4",gxvar:"A315Red_DireccionDesdeB4",ucs:[],op:[38],ip:[38],nacdep:[],ctrltype:"edit",v2v:function(a){gx.O.A315Red_DireccionDesdeB4=gx.num.intval(a)
},v2z:function(a){gx.O.Z315Red_DireccionDesdeB4=gx.num.intval(a)},v2c:function(){gx.fn.setControlValue("RED_DIRECCIONDESDEB4",gx.O.A315Red_DireccionDesdeB4,0)},c2v:function(){gx.O.A315Red_DireccionDesdeB4=this.val()},val:function(){return gx.fn.getIntegerValue("RED_DIRECCIONDESDEB4",".")},nac:function(){return false}};this.GXValidFnc[41]={fld:"TEXTBLOCKRED_DIRECCIONHASTAB1",format:0,grid:0};this.GXValidFnc[43]={lvl:0,type:"int",len:3,dec:0,sign:false,pic:"ZZ9",ro:0,grid:0,gxgrid:null,fnc:this.Valid_Red_direccionhastab1,isvalid:null,rgrid:[],fld:"RED_DIRECCIONHASTAB1",gxz:"Z316Red_DireccionHastaB1",gxold:"O316Red_DireccionHastaB1",gxvar:"A316Red_DireccionHastaB1",ucs:[],op:[43],ip:[43],nacdep:[],ctrltype:"edit",v2v:function(a){gx.O.A316Red_DireccionHastaB1=gx.num.intval(a)
},v2z:function(a){gx.O.Z316Red_DireccionHastaB1=gx.num.intval(a)},v2c:function(){gx.fn.setControlValue("RED_DIRECCIONHASTAB1",gx.O.A316Red_DireccionHastaB1,0)},c2v:function(){gx.O.A316Red_DireccionHastaB1=this.val()},val:function(){return gx.fn.getIntegerValue("RED_DIRECCIONHASTAB1",".")},nac:function(){return false}};this.GXValidFnc[44]={lvl:0,type:"int",len:3,dec:0,sign:false,pic:"ZZ9",ro:0,grid:0,gxgrid:null,fnc:this.Valid_Red_direccionhastab2,isvalid:null,rgrid:[],fld:"RED_DIRECCIONHASTAB2",gxz:"Z317Red_DireccionHastaB2",gxold:"O317Red_DireccionHastaB2",gxvar:"A317Red_DireccionHastaB2",ucs:[],op:[44],ip:[44],nacdep:[],ctrltype:"edit",v2v:function(a){gx.O.A317Red_DireccionHastaB2=gx.num.intval(a)
},v2z:function(a){gx.O.Z317Red_DireccionHastaB2=gx.num.intval(a)},v2c:function(){gx.fn.setControlValue("RED_DIRECCIONHASTAB2",gx.O.A317Red_DireccionHastaB2,0)},c2v:function(){gx.O.A317Red_DireccionHastaB2=this.val()},val:function(){return gx.fn.getIntegerValue("RED_DIRECCIONHASTAB2",".")},nac:function(){return false}};this.GXValidFnc[45]={lvl:0,type:"int",len:3,dec:0,sign:false,pic:"ZZ9",ro:0,grid:0,gxgrid:null,fnc:this.Valid_Red_direccionhastab3,isvalid:null,rgrid:[],fld:"RED_DIRECCIONHASTAB3",gxz:"Z318Red_DireccionHastaB3",gxold:"O318Red_DireccionHastaB3",gxvar:"A318Red_DireccionHastaB3",ucs:[],op:[45],ip:[45],nacdep:[],ctrltype:"edit",v2v:function(a){gx.O.A318Red_DireccionHastaB3=gx.num.intval(a)
},v2z:function(a){gx.O.Z318Red_DireccionHastaB3=gx.num.intval(a)},v2c:function(){gx.fn.setControlValue("RED_DIRECCIONHASTAB3",gx.O.A318Red_DireccionHastaB3,0)},c2v:function(){gx.O.A318Red_DireccionHastaB3=this.val()},val:function(){return gx.fn.getIntegerValue("RED_DIRECCIONHASTAB3",".")},nac:function(){return false}};this.GXValidFnc[46]={lvl:0,type:"int",len:3,dec:0,sign:false,pic:"ZZ9",ro:0,grid:0,gxgrid:null,fnc:this.Valid_Red_direccionhastab4,isvalid:null,rgrid:[],fld:"RED_DIRECCIONHASTAB4",gxz:"Z319Red_DireccionHastaB4",gxold:"O319Red_DireccionHastaB4",gxvar:"A319Red_DireccionHastaB4",ucs:[],op:[38,46],ip:[38,46],nacdep:[],ctrltype:"edit",v2v:function(a){gx.O.A319Red_DireccionHastaB4=gx.num.intval(a)
},v2z:function(a){gx.O.Z319Red_DireccionHastaB4=gx.num.intval(a)},v2c:function(){gx.fn.setControlValue("RED_DIRECCIONHASTAB4",gx.O.A319Red_DireccionHastaB4,0)},c2v:function(){gx.O.A319Red_DireccionHastaB4=this.val()},val:function(){return gx.fn.getIntegerValue("RED_DIRECCIONHASTAB4",".")},nac:function(){return false}};this.GXValidFnc[49]={fld:"TEXTBLOCKRED_MASCARAB1",format:0,grid:0};this.GXValidFnc[51]={lvl:0,type:"int",len:3,dec:0,sign:false,pic:"ZZ9",ro:0,grid:0,gxgrid:null,fnc:this.Valid_Red_mascarab1,isvalid:null,rgrid:[],fld:"RED_MASCARAB1",gxz:"Z320Red_MascaraB1",gxold:"O320Red_MascaraB1",gxvar:"A320Red_MascaraB1",ucs:[],op:[51],ip:[51],nacdep:[],ctrltype:"edit",v2v:function(a){gx.O.A320Red_MascaraB1=gx.num.intval(a)
},v2z:function(a){gx.O.Z320Red_MascaraB1=gx.num.intval(a)},v2c:function(){gx.fn.setControlValue("RED_MASCARAB1",gx.O.A320Red_MascaraB1,0)},c2v:function(){gx.O.A320Red_MascaraB1=this.val()},val:function(){return gx.fn.getIntegerValue("RED_MASCARAB1",".")},nac:function(){return false}};this.GXValidFnc[52]={lvl:0,type:"int",len:3,dec:0,sign:false,pic:"ZZ9",ro:0,grid:0,gxgrid:null,fnc:this.Valid_Red_mascarab2,isvalid:null,rgrid:[],fld:"RED_MASCARAB2",gxz:"Z321Red_MascaraB2",gxold:"O321Red_MascaraB2",gxvar:"A321Red_MascaraB2",ucs:[],op:[52],ip:[52],nacdep:[],ctrltype:"edit",v2v:function(a){gx.O.A321Red_MascaraB2=gx.num.intval(a)
},v2z:function(a){gx.O.Z321Red_MascaraB2=gx.num.intval(a)},v2c:function(){gx.fn.setControlValue("RED_MASCARAB2",gx.O.A321Red_MascaraB2,0)},c2v:function(){gx.O.A321Red_MascaraB2=this.val()},val:function(){return gx.fn.getIntegerValue("RED_MASCARAB2",".")},nac:function(){return false}};this.GXValidFnc[53]={lvl:0,type:"int",len:3,dec:0,sign:false,pic:"ZZ9",ro:0,grid:0,gxgrid:null,fnc:this.Valid_Red_mascarab3,isvalid:null,rgrid:[],fld:"RED_MASCARAB3",gxz:"Z322Red_MascaraB3",gxold:"O322Red_MascaraB3",gxvar:"A322Red_MascaraB3",ucs:[],op:[53],ip:[53],nacdep:[],ctrltype:"edit",v2v:function(a){gx.O.A322Red_MascaraB3=gx.num.intval(a)
},v2z:function(a){gx.O.Z322Red_MascaraB3=gx.num.intval(a)},v2c:function(){gx.fn.setControlValue("RED_MASCARAB3",gx.O.A322Red_MascaraB3,0)},c2v:function(){gx.O.A322Red_MascaraB3=this.val()},val:function(){return gx.fn.getIntegerValue("RED_MASCARAB3",".")},nac:function(){return false}};this.GXValidFnc[54]={lvl:0,type:"int",len:3,dec:0,sign:false,pic:"ZZ9",ro:0,grid:0,gxgrid:null,fnc:this.Valid_Red_mascarab4,isvalid:null,rgrid:[],fld:"RED_MASCARAB4",gxz:"Z323Red_MascaraB4",gxold:"O323Red_MascaraB4",gxvar:"A323Red_MascaraB4",ucs:[],op:[54],ip:[54],nacdep:[],ctrltype:"edit",v2v:function(a){gx.O.A323Red_MascaraB4=gx.num.intval(a)
},v2z:function(a){gx.O.Z323Red_MascaraB4=gx.num.intval(a)},v2c:function(){gx.fn.setControlValue("RED_MASCARAB4",gx.O.A323Red_MascaraB4,0)},c2v:function(){gx.O.A323Red_MascaraB4=this.val()},val:function(){return gx.fn.getIntegerValue("RED_MASCARAB4",".")},nac:function(){return false}};this.GXValidFnc[57]={fld:"TEXTBLOCKRED_PUERTAENLACEB1",format:0,grid:0};this.GXValidFnc[59]={lvl:0,type:"int",len:3,dec:0,sign:false,pic:"ZZ9",ro:0,grid:0,gxgrid:null,fnc:this.Valid_Red_puertaenlaceb1,isvalid:null,rgrid:[],fld:"RED_PUERTAENLACEB1",gxz:"Z324Red_PuertaEnlaceB1",gxold:"O324Red_PuertaEnlaceB1",gxvar:"A324Red_PuertaEnlaceB1",ucs:[],op:[59],ip:[59],nacdep:[],ctrltype:"edit",v2v:function(a){gx.O.A324Red_PuertaEnlaceB1=gx.num.intval(a)
},v2z:function(a){gx.O.Z324Red_PuertaEnlaceB1=gx.num.intval(a)},v2c:function(){gx.fn.setControlValue("RED_PUERTAENLACEB1",gx.O.A324Red_PuertaEnlaceB1,0)},c2v:function(){gx.O.A324Red_PuertaEnlaceB1=this.val()},val:function(){return gx.fn.getIntegerValue("RED_PUERTAENLACEB1",".")},nac:function(){return false}};this.GXValidFnc[60]={lvl:0,type:"int",len:3,dec:0,sign:false,pic:"ZZ9",ro:0,grid:0,gxgrid:null,fnc:this.Valid_Red_puertaenlaceb2,isvalid:null,rgrid:[],fld:"RED_PUERTAENLACEB2",gxz:"Z325Red_PuertaEnlaceB2",gxold:"O325Red_PuertaEnlaceB2",gxvar:"A325Red_PuertaEnlaceB2",ucs:[],op:[60],ip:[60],nacdep:[],ctrltype:"edit",v2v:function(a){gx.O.A325Red_PuertaEnlaceB2=gx.num.intval(a)
},v2z:function(a){gx.O.Z325Red_PuertaEnlaceB2=gx.num.intval(a)},v2c:function(){gx.fn.setControlValue("RED_PUERTAENLACEB2",gx.O.A325Red_PuertaEnlaceB2,0)},c2v:function(){gx.O.A325Red_PuertaEnlaceB2=this.val()},val:function(){return gx.fn.getIntegerValue("RED_PUERTAENLACEB2",".")},nac:function(){return false}};this.GXValidFnc[61]={lvl:0,type:"int",len:3,dec:0,sign:false,pic:"ZZ9",ro:0,grid:0,gxgrid:null,fnc:this.Valid_Red_puertaenlaceb3,isvalid:null,rgrid:[],fld:"RED_PUERTAENLACEB3",gxz:"Z326Red_PuertaEnlaceB3",gxold:"O326Red_PuertaEnlaceB3",gxvar:"A326Red_PuertaEnlaceB3",ucs:[],op:[61],ip:[61],nacdep:[],ctrltype:"edit",v2v:function(a){gx.O.A326Red_PuertaEnlaceB3=gx.num.intval(a)
},v2z:function(a){gx.O.Z326Red_PuertaEnlaceB3=gx.num.intval(a)},v2c:function(){gx.fn.setControlValue("RED_PUERTAENLACEB3",gx.O.A326Red_PuertaEnlaceB3,0)},c2v:function(){gx.O.A326Red_PuertaEnlaceB3=this.val()},val:function(){return gx.fn.getIntegerValue("RED_PUERTAENLACEB3",".")},nac:function(){return false}};this.GXValidFnc[62]={lvl:0,type:"int",len:3,dec:0,sign:false,pic:"ZZ9",ro:0,grid:0,gxgrid:null,fnc:this.Valid_Red_puertaenlaceb4,isvalid:null,rgrid:[],fld:"RED_PUERTAENLACEB4",gxz:"Z327Red_PuertaEnlaceB4",gxold:"O327Red_PuertaEnlaceB4",gxvar:"A327Red_PuertaEnlaceB4",ucs:[],op:[62],ip:[62],nacdep:[],ctrltype:"edit",v2v:function(a){gx.O.A327Red_PuertaEnlaceB4=gx.num.intval(a)
},v2z:function(a){gx.O.Z327Red_PuertaEnlaceB4=gx.num.intval(a)},v2c:function(){gx.fn.setControlValue("RED_PUERTAENLACEB4",gx.O.A327Red_PuertaEnlaceB4,0)},c2v:function(){gx.O.A327Red_PuertaEnlaceB4=this.val()},val:function(){return gx.fn.getIntegerValue("RED_PUERTAENLACEB4",".")},nac:function(){return false}};this.A306THDW_UBI_COD_=0;this.Z306THDW_UBI_COD_=0;this.O306THDW_UBI_COD_=0;this.A300Red_Id=0;this.Z300Red_Id=0;this.O300Red_Id=0;this.A301Red_Descripcion="";this.Z301Red_Descripcion="";this.O301Red_Descripcion="";
this.A308Red_DireccionDesdeB1=0;this.Z308Red_DireccionDesdeB1=0;this.O308Red_DireccionDesdeB1=0;this.A309Red_DireccionDesdeB2=0;this.Z309Red_DireccionDesdeB2=0;this.O309Red_DireccionDesdeB2=0;this.A310Red_DireccionDesdeB3=0;this.Z310Red_DireccionDesdeB3=0;this.O310Red_DireccionDesdeB3=0;this.A315Red_DireccionDesdeB4=0;this.Z315Red_DireccionDesdeB4=0;this.O315Red_DireccionDesdeB4=0;this.A316Red_DireccionHastaB1=0;this.Z316Red_DireccionHastaB1=0;this.O316Red_DireccionHastaB1=0;this.A317Red_DireccionHastaB2=0;
this.Z317Red_DireccionHastaB2=0;this.O317Red_DireccionHastaB2=0;this.A318Red_DireccionHastaB3=0;this.Z318Red_DireccionHastaB3=0;this.O318Red_DireccionHastaB3=0;this.A319Red_DireccionHastaB4=0;this.Z319Red_DireccionHastaB4=0;this.O319Red_DireccionHastaB4=0;this.A320Red_MascaraB1=0;this.Z320Red_MascaraB1=0;this.O320Red_MascaraB1=0;this.A321Red_MascaraB2=0;this.Z321Red_MascaraB2=0;this.O321Red_MascaraB2=0;this.A322Red_MascaraB3=0;this.Z322Red_MascaraB3=0;this.O322Red_MascaraB3=0;this.A323Red_MascaraB4=0;
this.Z323Red_MascaraB4=0;this.O323Red_MascaraB4=0;this.A324Red_PuertaEnlaceB1=0;this.Z324Red_PuertaEnlaceB1=0;this.O324Red_PuertaEnlaceB1=0;this.A325Red_PuertaEnlaceB2=0;this.Z325Red_PuertaEnlaceB2=0;this.O325Red_PuertaEnlaceB2=0;this.A326Red_PuertaEnlaceB3=0;this.Z326Red_PuertaEnlaceB3=0;this.O326Red_PuertaEnlaceB3=0;this.A327Red_PuertaEnlaceB4=0;this.Z327Red_PuertaEnlaceB4=0;this.O327Red_PuertaEnlaceB4=0;this.AV7THDW_UBI_COD_=0;this.AV10Red_Id=0;this.AV8SISTEMA="";this.AV9USUARIO="";this.Gx_BScreen=0;
this.Gx_mode="";this.ServerEvents=["e11152_client","e121539_client","e131539_client"];this.EnterCtrl=["BTN_ENTER"];this.VarControlMap.AV7THDW_UBI_COD_={id:"vTHDW_UBI_COD_",grid:0,type:"int"};this.VarControlMap.AV10Red_Id={id:"vRED_ID",grid:0,type:"int"};this.VarControlMap.Gx_BScreen={id:"vGXBSCREEN",grid:0,type:"int"};this.VarControlMap.Gx_mode={id:"vMODE",grid:0,type:"char"};this.VarControlMap.AV8SISTEMA={id:"vSISTEMA",grid:0,type:"char"};this.VarControlMap.AV9USUARIO={id:"vUSUARIO",grid:0,type:"char"};
this.SetStandaloneVars()}thdw_redes.prototype=new gx.GxObject;gx.setParentObj(new thdw_redes());