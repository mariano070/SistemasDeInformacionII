gx.evt.autoSkip=false;function gx0010(){this.ServerClass="Gx0010";this.PackageName="GeneXus.Programs";this.setObjectType("web");this.hasEnterEvent=true;this.autoRefresh=true;this.SetStandaloneVars=function(){this.AV14pTTBUS_Id=gx.fn.getIntegerValue("vPTTBUS_ID",".")};this.e132h2_client=function(){this.executeServerEvent("ENTER",true,arguments[0])};this.e142h2_client=function(){this.executeServerEvent("CANCEL",true,arguments[0])};this.GXValidFnc=[];this.GXCtrlIds=[2,8,9,14,19,24,29,34,39,44,47,48,52,53,54,55,56,57,60];
this.GXLastCtrlId=60;this.Grid1Container=new gx.grid.grid(this,2,"WbpLvl2",51,"Grid1","Grid1","Grid1Container",this.CmpContext,this.IsMasterPage,"gx0010",[],false,1,false,true,10,true,false,false,"",0,"px","Nueva fila",true,false,false,null,null,false,"");this.Grid1Container.addBitmap("&Linkselection","vLINKSELECTION",52,0,"px",17,"px",null,"","");this.Grid1Container.addSingleLineEdit(11,53,"TTBUS_ID","Id del bien de uso:","","TTBUS_Id","int",0,"px",8,8,"right",null,[],11,"TTBUS_Id",true,0,false,false);
this.Grid1Container.addSingleLineEdit(12,54,"TTBUS_DESCRIPCION","Descripción:","Seleccionar","TTBUS_Descripcion","svchar",0,"px",50,50,"left",null,"['TTBUS_DESCRIPCION',[],[],false,[]];",12,"TTBUS_Descripcion",true,0,false,false);this.Grid1Container.addSingleLineEdit(13,55,"TTBUS_FECHACARGA","Fecha de Carga:","","TTBUS_FechaCarga","date",0,"px",10,10,"right",null,[],13,"TTBUS_FechaCarga",true,0,false,false);this.Grid1Container.addComboBox(23,56,"TTBUS_ESTADO","de uso","TTBUS_Estado","int",null,0,true,false,0,"px");
this.Grid1Container.addSingleLineEdit(27,57,"TTBUS_CODPROVEEDOR","Proveedor","","TTBUS_CodProveedor","int",0,"px",8,8,"right",null,[],27,"TTBUS_CodProveedor",true,0,false,false);this.setGrid(this.Grid1Container);this.GXValidFnc[2]={fld:"TABLE1",grid:0};this.GXValidFnc[8]={fld:"GROUP1",grid:0};this.GXValidFnc[9]={fld:"TABLE2",grid:0};this.GXValidFnc[12]={fld:"TEXTBLOCKTTBUS_ID",format:0,grid:0};this.GXValidFnc[14]={lvl:0,type:"int",len:8,dec:0,sign:false,pic:"ZZZZZZZ9",ro:0,grid:0,gxgrid:null,fnc:null,isvalid:null,rgrid:[this.Grid1Container],fld:"vCTTBUS_ID",gxz:"ZV6cTTBUS_Id",gxold:"OV6cTTBUS_Id",gxvar:"AV6cTTBUS_Id",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",v2v:function(a){gx.O.AV6cTTBUS_Id=gx.num.intval(a)
},v2z:function(a){gx.O.ZV6cTTBUS_Id=gx.num.intval(a)},v2c:function(){gx.fn.setControlValue("vCTTBUS_ID",gx.O.AV6cTTBUS_Id,0)},c2v:function(){gx.O.AV6cTTBUS_Id=this.val()},val:function(){return gx.fn.getIntegerValue("vCTTBUS_ID",".")},nac:function(){return false}};this.GXValidFnc[17]={fld:"TEXTBLOCKTTBUS_DESCRIPCION",format:0,grid:0};this.GXValidFnc[19]={lvl:0,gxsgprm:["vCTTBUS_DESCRIPCION",[],[],false,[]],type:"svchar",len:50,dec:0,sign:false,ro:0,grid:0,gxgrid:null,fnc:null,isvalid:null,fld:"vCTTBUS_DESCRIPCION",gxz:"ZV7cTTBUS_Descripcion",gxold:"OV7cTTBUS_Descripcion",gxvar:"AV7cTTBUS_Descripcion",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",v2v:function(a){gx.O.AV7cTTBUS_Descripcion=a
},v2z:function(a){gx.O.ZV7cTTBUS_Descripcion=a},v2c:function(){gx.fn.setControlValue("vCTTBUS_DESCRIPCION",gx.O.AV7cTTBUS_Descripcion,0)},c2v:function(){gx.O.AV7cTTBUS_Descripcion=this.val()},val:function(){return gx.fn.getControlValue("vCTTBUS_DESCRIPCION")},nac:function(){return false}};this.GXValidFnc[22]={fld:"TEXTBLOCKTTBUS_FECHACARGA",format:0,grid:0};this.GXValidFnc[24]={lvl:0,type:"date",len:10,dec:0,sign:false,ro:0,grid:0,gxgrid:null,fnc:null,isvalid:null,fld:"vCTTBUS_FECHACARGA",gxz:"ZV8cTTBUS_FechaCarga",gxold:"OV8cTTBUS_FechaCarga",gxvar:"AV8cTTBUS_FechaCarga",dp:{f:0,st:false,wn:false,mf:false,pic:"99/99/9999",dec:0},ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",v2v:function(a){gx.O.AV8cTTBUS_FechaCarga=gx.fn.toDatetimeValue(a)
},v2z:function(a){gx.O.ZV8cTTBUS_FechaCarga=gx.fn.toDatetimeValue(a)},v2c:function(){gx.fn.setControlValue("vCTTBUS_FECHACARGA",gx.O.AV8cTTBUS_FechaCarga,0)},c2v:function(){gx.O.AV8cTTBUS_FechaCarga=this.val()},val:function(){return gx.fn.getControlValue("vCTTBUS_FECHACARGA")},nac:function(){return false}};this.GXValidFnc[27]={fld:"TEXTBLOCKTTBUS_ESTADO",format:0,grid:0};this.GXValidFnc[29]={lvl:0,type:"int",len:1,dec:0,sign:false,pic:"9",ro:0,grid:0,gxgrid:null,fnc:null,isvalid:null,rgrid:[this.Grid1Container],fld:"vCTTBUS_ESTADO",gxz:"ZV9cTTBUS_Estado",gxold:"OV9cTTBUS_Estado",gxvar:"AV9cTTBUS_Estado",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"combo",v2v:function(a){gx.O.AV9cTTBUS_Estado=gx.num.intval(a)
},v2z:function(a){gx.O.ZV9cTTBUS_Estado=gx.num.intval(a)},v2c:function(){gx.fn.setComboBoxValue("vCTTBUS_ESTADO",gx.O.AV9cTTBUS_Estado)},c2v:function(){gx.O.AV9cTTBUS_Estado=this.val()},val:function(){return gx.fn.getIntegerValue("vCTTBUS_ESTADO",".")},nac:function(){return false}};this.GXValidFnc[32]={fld:"TEXTBLOCKTTBUS_CODPROVEEDOR",format:0,grid:0};this.GXValidFnc[34]={lvl:0,type:"int",len:8,dec:0,sign:false,pic:"ZZZZZ9",ro:0,grid:0,gxgrid:null,fnc:null,isvalid:null,rgrid:[this.Grid1Container],fld:"vCTTBUS_CODPROVEEDOR",gxz:"ZV10cTTBUS_CodProveedor",gxold:"OV10cTTBUS_CodProveedor",gxvar:"AV10cTTBUS_CodProveedor",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",v2v:function(a){gx.O.AV10cTTBUS_CodProveedor=gx.num.intval(a)
},v2z:function(a){gx.O.ZV10cTTBUS_CodProveedor=gx.num.intval(a)},v2c:function(){gx.fn.setControlValue("vCTTBUS_CODPROVEEDOR",gx.O.AV10cTTBUS_CodProveedor,0)},c2v:function(){gx.O.AV10cTTBUS_CodProveedor=this.val()},val:function(){return gx.fn.getIntegerValue("vCTTBUS_CODPROVEEDOR",".")},nac:function(){return false}};this.GXValidFnc[37]={fld:"TEXTBLOCKTTBUS_ALQUILADO",format:0,grid:0};this.GXValidFnc[39]={lvl:0,type:"int",len:1,dec:0,sign:false,pic:"9",ro:0,grid:0,gxgrid:null,fnc:null,isvalid:null,rgrid:[this.Grid1Container],fld:"vCTTBUS_ALQUILADO",gxz:"ZV12cTTBUS_Alquilado",gxold:"OV12cTTBUS_Alquilado",gxvar:"AV12cTTBUS_Alquilado",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"checkbox",v2v:function(a){gx.O.AV12cTTBUS_Alquilado=gx.num.intval(a)
},v2z:function(a){gx.O.ZV12cTTBUS_Alquilado=gx.num.intval(a)},v2c:function(){gx.fn.setCheckBoxValue("vCTTBUS_ALQUILADO",gx.O.AV12cTTBUS_Alquilado,"1")},c2v:function(){gx.O.AV12cTTBUS_Alquilado=this.val()},val:function(){return gx.fn.getCheckBoxValue("vCTTBUS_ALQUILADO","1","0")},nac:function(){return false}};this.GXValidFnc[42]={fld:"TEXTBLOCKTTBUS_CODPOSICION",format:0,grid:0};this.GXValidFnc[44]={lvl:0,type:"int",len:3,dec:0,sign:false,pic:"ZZ9",ro:0,grid:0,gxgrid:null,fnc:null,isvalid:null,rgrid:[this.Grid1Container],fld:"vCTTBUS_CODPOSICION",gxz:"ZV13cTTBUS_CodPosicion",gxold:"OV13cTTBUS_CodPosicion",gxvar:"AV13cTTBUS_CodPosicion",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",v2v:function(a){gx.O.AV13cTTBUS_CodPosicion=gx.num.intval(a)
},v2z:function(a){gx.O.ZV13cTTBUS_CodPosicion=gx.num.intval(a)},v2c:function(){gx.fn.setControlValue("vCTTBUS_CODPOSICION",gx.O.AV13cTTBUS_CodPosicion,0)},c2v:function(){gx.O.AV13cTTBUS_CodPosicion=this.val()},val:function(){return gx.fn.getIntegerValue("vCTTBUS_CODPOSICION",".")},nac:function(){return false}};this.GXValidFnc[47]={fld:"GROUP2",grid:0};this.GXValidFnc[48]={fld:"TABLE3",grid:0};this.GXValidFnc[52]={lvl:2,type:"bits",len:4,dec:0,sign:false,ro:1,grid:51,gxgrid:this.Grid1Container,fnc:null,isvalid:null,fld:"vLINKSELECTION",gxz:"ZV5LinkSelection",gxold:"OV5LinkSelection",gxvar:"AV5LinkSelection",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",v2v:function(a){gx.O.AV5LinkSelection=a
},v2z:function(a){gx.O.ZV5LinkSelection=a},v2c:function(){},c2v:function(){gx.O.AV5LinkSelection=this.val()},val:function(){return gx.fn.getGridControlValue("vLINKSELECTION",gx.fn.currentGridRowImpl(51))},nac:function(){return false}};this.GXValidFnc[53]={lvl:2,type:"int",len:8,dec:0,sign:false,pic:"ZZZZZZZ9",ro:1,grid:51,gxgrid:this.Grid1Container,fnc:null,isvalid:null,rgrid:[],fld:"TTBUS_ID",gxz:"Z11TTBUS_Id",gxold:"O11TTBUS_Id",gxvar:"A11TTBUS_Id",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",v2v:function(a){gx.O.A11TTBUS_Id=gx.num.intval(a)
},v2z:function(a){gx.O.Z11TTBUS_Id=gx.num.intval(a)},v2c:function(){gx.fn.setGridControlValue("TTBUS_ID",gx.fn.currentGridRowImpl(51),gx.O.A11TTBUS_Id,0)},c2v:function(){gx.O.A11TTBUS_Id=this.val()},val:function(){return gx.fn.getGridIntegerValue("TTBUS_ID",gx.fn.currentGridRowImpl(51),".")},nac:function(){return false}};this.GXValidFnc[54]={lvl:2,gxsgprm:["TTBUS_DESCRIPCION",[],[],false,[]],type:"svchar",len:50,dec:0,sign:false,ro:1,grid:51,gxgrid:this.Grid1Container,fnc:null,isvalid:null,fld:"TTBUS_DESCRIPCION",gxz:"Z12TTBUS_Descripcion",gxold:"O12TTBUS_Descripcion",gxvar:"A12TTBUS_Descripcion",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",v2v:function(a){gx.O.A12TTBUS_Descripcion=a
},v2z:function(a){gx.O.Z12TTBUS_Descripcion=a},v2c:function(){gx.fn.setGridControlValue("TTBUS_DESCRIPCION",gx.fn.currentGridRowImpl(51),gx.O.A12TTBUS_Descripcion,0)},c2v:function(){gx.O.A12TTBUS_Descripcion=this.val()},val:function(){return gx.fn.getGridControlValue("TTBUS_DESCRIPCION",gx.fn.currentGridRowImpl(51))},nac:function(){return false}};this.GXValidFnc[55]={lvl:2,type:"date",len:10,dec:0,sign:false,ro:1,grid:51,gxgrid:this.Grid1Container,fnc:null,isvalid:null,fld:"TTBUS_FECHACARGA",gxz:"Z13TTBUS_FechaCarga",gxold:"O13TTBUS_FechaCarga",gxvar:"A13TTBUS_FechaCarga",dp:{f:0,st:false,wn:false,mf:false,pic:"99/99/9999",dec:0},ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",v2v:function(a){gx.O.A13TTBUS_FechaCarga=gx.fn.toDatetimeValue(a)
},v2z:function(a){gx.O.Z13TTBUS_FechaCarga=gx.fn.toDatetimeValue(a)},v2c:function(){gx.fn.setGridControlValue("TTBUS_FECHACARGA",gx.fn.currentGridRowImpl(51),gx.O.A13TTBUS_FechaCarga,0)},c2v:function(){gx.O.A13TTBUS_FechaCarga=this.val()},val:function(){return gx.fn.getGridControlValue("TTBUS_FECHACARGA",gx.fn.currentGridRowImpl(51))},nac:function(){return false}};this.GXValidFnc[56]={lvl:2,type:"int",len:1,dec:0,sign:false,pic:"9",ro:1,grid:51,gxgrid:this.Grid1Container,fnc:null,isvalid:null,rgrid:[],fld:"TTBUS_ESTADO",gxz:"Z23TTBUS_Estado",gxold:"O23TTBUS_Estado",gxvar:"A23TTBUS_Estado",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"combo",v2v:function(a){gx.O.A23TTBUS_Estado=gx.num.intval(a)
},v2z:function(a){gx.O.Z23TTBUS_Estado=gx.num.intval(a)},v2c:function(){gx.fn.setGridComboBoxValue("TTBUS_ESTADO",gx.fn.currentGridRowImpl(51),gx.O.A23TTBUS_Estado)},c2v:function(){gx.O.A23TTBUS_Estado=this.val()},val:function(){return gx.fn.getGridIntegerValue("TTBUS_ESTADO",gx.fn.currentGridRowImpl(51),".")},nac:function(){return false}};this.GXValidFnc[57]={lvl:2,type:"int",len:8,dec:0,sign:false,pic:"ZZZZZ9",ro:1,grid:51,gxgrid:this.Grid1Container,fnc:null,isvalid:null,rgrid:[],fld:"TTBUS_CODPROVEEDOR",gxz:"Z27TTBUS_CodProveedor",gxold:"O27TTBUS_CodProveedor",gxvar:"A27TTBUS_CodProveedor",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",v2v:function(a){gx.O.A27TTBUS_CodProveedor=gx.num.intval(a)
},v2z:function(a){gx.O.Z27TTBUS_CodProveedor=gx.num.intval(a)},v2c:function(){gx.fn.setGridControlValue("TTBUS_CODPROVEEDOR",gx.fn.currentGridRowImpl(51),gx.O.A27TTBUS_CodProveedor,0)},c2v:function(){gx.O.A27TTBUS_CodProveedor=this.val()},val:function(){return gx.fn.getGridIntegerValue("TTBUS_CODPROVEEDOR",gx.fn.currentGridRowImpl(51),".")},nac:function(){return false}};this.GXValidFnc[60]={fld:"TABLE4",grid:0};this.AV6cTTBUS_Id=0;this.ZV6cTTBUS_Id=0;this.OV6cTTBUS_Id=0;this.AV7cTTBUS_Descripcion="";
this.ZV7cTTBUS_Descripcion="";this.OV7cTTBUS_Descripcion="";this.AV8cTTBUS_FechaCarga=gx.date.nullDate();this.ZV8cTTBUS_FechaCarga=gx.date.nullDate();this.OV8cTTBUS_FechaCarga=gx.date.nullDate();this.AV9cTTBUS_Estado=0;this.ZV9cTTBUS_Estado=0;this.OV9cTTBUS_Estado=0;this.AV10cTTBUS_CodProveedor=0;this.ZV10cTTBUS_CodProveedor=0;this.OV10cTTBUS_CodProveedor=0;this.AV12cTTBUS_Alquilado=0;this.ZV12cTTBUS_Alquilado=0;this.OV12cTTBUS_Alquilado=0;this.AV13cTTBUS_CodPosicion=0;this.ZV13cTTBUS_CodPosicion=0;
this.OV13cTTBUS_CodPosicion=0;this.ZV5LinkSelection="";this.OV5LinkSelection="";this.Z11TTBUS_Id=0;this.O11TTBUS_Id=0;this.Z12TTBUS_Descripcion="";this.O12TTBUS_Descripcion="";this.Z13TTBUS_FechaCarga=gx.date.nullDate();this.O13TTBUS_FechaCarga=gx.date.nullDate();this.Z23TTBUS_Estado=0;this.O23TTBUS_Estado=0;this.Z27TTBUS_CodProveedor=0;this.O27TTBUS_CodProveedor=0;this.AV14pTTBUS_Id=0;this.A29TTBUS_Alquilado=0;this.A37TTBUS_CodPosicion=0;this.AV5LinkSelection="";this.A11TTBUS_Id=0;this.A12TTBUS_Descripcion="";
this.A13TTBUS_FechaCarga=gx.date.nullDate();this.A23TTBUS_Estado=0;this.A27TTBUS_CodProveedor=0;this.ServerEvents=["e132h2_client","e142h2_client"];this.VarControlMap.AV14pTTBUS_Id={id:"vPTTBUS_ID",grid:0,type:"int"};this.Grid1Container.addRefreshingVar(this.GXValidFnc[14]);this.Grid1Container.addRefreshingVar(this.GXValidFnc[19]);this.Grid1Container.addRefreshingVar(this.GXValidFnc[24]);this.Grid1Container.addRefreshingVar(this.GXValidFnc[29]);this.Grid1Container.addRefreshingVar(this.GXValidFnc[34]);
this.Grid1Container.addRefreshingVar(this.GXValidFnc[39]);this.Grid1Container.addRefreshingVar(this.GXValidFnc[44]);this.SetStandaloneVars()}gx0010.prototype=new gx.GxObject;gx.setParentObj(new gx0010());