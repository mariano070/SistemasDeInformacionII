gx.evt.autoSkip=false;function htbus004c(){this.ServerClass="HTBUS004c";this.PackageName="GeneXus.Programs";this.setObjectType("web");this.hasEnterEvent=false;this.autoRefresh=true;this.SetStandaloneVars=function(){this.AV11USUARIO=gx.fn.getControlValue("vUSUARIO");this.AV8SISTEMA=gx.fn.getControlValue("vSISTEMA")};this.e131p2_client=function(){this.clearMessages();gx.popup.openUrl(gx.http.formatLink("htbus001_i.aspx",[this.AV15gTTBUS2_IdBien,this.AV8SISTEMA,this.AV11USUARIO]),["AV15gTTBUS2_IdBien","AV8SISTEMA","AV11USUARIO"]);
this.refreshOutputs([])};this.e111p2_client=function(){this.executeServerEvent("'RECIBIR BIEN'",false,arguments[0])};this.e141p2_client=function(){this.executeServerEvent("ENTER",true,arguments[0])};this.e151p2_client=function(){this.executeServerEvent("CANCEL",true,arguments[0])};this.GXValidFnc=[];this.GXCtrlIds=[2,10,15,25,26,27,28,29,30,31,32,33,34,35,36,37,38,39];this.GXLastCtrlId=39;this.Grid1Container=new gx.grid.grid(this,2,"WbpLvl2",24,"Grid1","Grid1","Grid1Container",this.CmpContext,this.IsMasterPage,"htbus004c",[],false,1,false,true,10,true,false,false,"",0,"px","Nueva fila",true,false,true,null,null,false,"");
this.Grid1Container.addCheckBox("Seleccion",25,"vSELECCION","","","seleccion","int",1,0,null,true,false,0,"px");this.Grid1Container.addBitmap("&Detalle","vDETALLE",26,0,"px",17,"px","e131p2_client","","");this.Grid1Container.addSingleLineEdit("Gttbus2_idmovimiento",27,"vGTTBUS2_IDMOVIMIENTO","Nº Mov.","","gTTBUS2_IdMovimiento","int",0,"px",12,12,"right",null,[],"Gttbus2_idmovimiento","gTTBUS2_IdMovimiento",true,0,false,false);this.Grid1Container.addSingleLineEdit("Gnumeroidentificador",28,"vGNUMEROIDENTIFICADOR","Nº Etiqueta","","gNumeroIdentificador","svchar",0,"px",80,80,"left",null,[],"Gnumeroidentificador","gNumeroIdentificador",true,0,false,false);
this.Grid1Container.addSingleLineEdit("Gttbus2_idbien",29,"vGTTBUS2_IDBIEN","Nº Bien","","gTTBUS2_IdBien","int",0,"px",8,8,"right",null,[],"Gttbus2_idbien","gTTBUS2_IdBien",true,0,false,false);this.Grid1Container.addSingleLineEdit("Ttbus_descripcion",30,"vTTBUS_DESCRIPCION","Descripción","","TTBUS_Descripcion","svchar",0,"px",50,50,"left",null,"['vTTBUS_DESCRIPCION',[],[],false,[]];","Ttbus_descripcion","TTBUS_Descripcion",true,0,false,false);this.Grid1Container.addSingleLineEdit("Gttbus2_codposdesde",31,"vGTTBUS2_CODPOSDESDE","g TTBUS2_ Cod Pos Desde","","gTTBUS2_CodPosDesde","int",0,"px",3,3,"right",null,[],"Gttbus2_codposdesde","gTTBUS2_CodPosDesde",false,0,false,false);
this.Grid1Container.addSingleLineEdit("Dttbus3_des",32,"vDTTBUS3_DES","Posición Envío","","dTTBUS3_Des","char",0,"px",50,50,"left",null,[],"Dttbus3_des","dTTBUS3_Des",true,0,false,false);this.Grid1Container.addSingleLineEdit("Gttbus2_respdesde",33,"vGTTBUS2_RESPDESDE","g TTBUS2_ Resp Desde","","gTTBUS2_RespDesde","char",0,"px",15,15,"left",null,[],"Gttbus2_respdesde","gTTBUS2_RespDesde",false,0,false,false);this.Grid1Container.addSingleLineEdit("Dusu_des",34,"vDUSU_DES","Responsable Envío","","dUSU_DES","char",0,"px",50,50,"left",null,[],"Dusu_des","dUSU_DES",true,0,false,false);
this.Grid1Container.addSingleLineEdit("Gttbus2_fechaenvio",35,"vGTTBUS2_FECHAENVIO","Fecha Envío","","gTTBUS2_FechaEnvio","dtime",0,"px",16,10,"right",null,[],"Gttbus2_fechaenvio","gTTBUS2_FechaEnvio",true,5,false,false);this.Grid1Container.addSingleLineEdit("Gttbus2_fecharecepcion",36,"vGTTBUS2_FECHARECEPCION","Fecha Recepción","","gTTBUS2_FechaRecepcion","dtime",0,"px",14,8,"right",null,[],"Gttbus2_fecharecepcion","gTTBUS2_FechaRecepcion",true,5,false,false);this.Grid1Container.addSingleLineEdit("Gttbus2_fechaenvio",35,"vGTTBUS2_FECHAENVIO","Fecha Envío","","gTTBUS2_FechaEnvio","dtime",0,"px",16,10,"right",null,[],"Gttbus2_fechaenvio","gTTBUS2_FechaEnvio",true,5,false,false);
this.Grid1Container.addSingleLineEdit("Gttbus2_motivoenvio",38,"vGTTBUS2_MOTIVOENVIO","Motivo Envío","","gTTBUS2_MotivoEnvio","svchar",0,"px",100,100,"left",null,"['vGTTBUS2_MOTIVOENVIO',[],[],false,[]];","Gttbus2_motivoenvio","gTTBUS2_MotivoEnvio",true,0,false,false);this.Grid1Container.addSingleLineEdit("Gttbus2_observaciones",39,"vGTTBUS2_OBSERVACIONES","Observaciones","","gTTBUS2_Observaciones","svchar",0,"px",400,400,"left",null,"['vGTTBUS2_OBSERVACIONES',[],[],false,[]];","Gttbus2_observaciones","gTTBUS2_Observaciones",true,0,false,false);
this.setGrid(this.Grid1Container);this.GXValidFnc[2]={fld:"TABLE1",grid:0};this.GXValidFnc[10]={fld:"TABLE2",grid:0};this.GXValidFnc[13]={fld:"TEXTBLOCK2",format:0,grid:0};this.GXValidFnc[15]={lvl:0,type:"int",len:1,dec:0,sign:false,pic:"9",ro:0,grid:0,gxgrid:null,fnc:null,isvalid:null,rgrid:[],fld:"vTTBUS2_ESTADOENVIO",gxz:"ZV12TTBUS2_EstadoEnvio",gxold:"OV12TTBUS2_EstadoEnvio",gxvar:"AV12TTBUS2_EstadoEnvio",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"combo",v2v:function(a){gx.O.AV12TTBUS2_EstadoEnvio=gx.num.intval(a)
},v2z:function(a){gx.O.ZV12TTBUS2_EstadoEnvio=gx.num.intval(a)},v2c:function(){gx.fn.setComboBoxValue("vTTBUS2_ESTADOENVIO",gx.O.AV12TTBUS2_EstadoEnvio)},c2v:function(){gx.O.AV12TTBUS2_EstadoEnvio=this.val()},val:function(){return gx.fn.getIntegerValue("vTTBUS2_ESTADOENVIO",".")},nac:function(){return false}};this.GXValidFnc[25]={lvl:2,type:"int",len:1,dec:0,sign:false,pic:"9",ro:0,grid:24,gxgrid:this.Grid1Container,fnc:null,isvalid:null,rgrid:[],fld:"vSELECCION",gxz:"ZV26seleccion",gxold:"OV26seleccion",gxvar:"AV26seleccion",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"checkbox",v2v:function(a){gx.O.AV26seleccion=gx.num.intval(a)
},v2z:function(a){gx.O.ZV26seleccion=gx.num.intval(a)},v2c:function(){gx.fn.setGridCheckBoxValue("vSELECCION",gx.fn.currentGridRowImpl(24),gx.O.AV26seleccion,"1")},c2v:function(){gx.O.AV26seleccion=this.val()},val:function(){return gx.fn.getGridCheckBoxValue("vSELECCION",gx.fn.currentGridRowImpl(24),"1","0")},nac:function(){return false}};this.GXValidFnc[26]={lvl:2,type:"bits",len:4,dec:0,sign:false,ro:1,grid:24,gxgrid:this.Grid1Container,fnc:null,isvalid:null,fld:"vDETALLE",gxz:"ZV27detalle",gxold:"OV27detalle",gxvar:"AV27detalle",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",v2v:function(a){gx.O.AV27detalle=a
},v2z:function(a){gx.O.ZV27detalle=a},v2c:function(){},c2v:function(){gx.O.AV27detalle=this.val()},val:function(){return gx.fn.getGridControlValue("vDETALLE",gx.fn.currentGridRowImpl(24))},nac:function(){return false}};this.GXValidFnc[27]={lvl:2,type:"int",len:12,dec:0,sign:false,pic:"ZZZZZZZZZZZ9",ro:0,grid:24,gxgrid:this.Grid1Container,fnc:null,isvalid:null,rgrid:[],fld:"vGTTBUS2_IDMOVIMIENTO",gxz:"ZV18gTTBUS2_IdMovimiento",gxold:"OV18gTTBUS2_IdMovimiento",gxvar:"AV18gTTBUS2_IdMovimiento",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",v2v:function(a){gx.O.AV18gTTBUS2_IdMovimiento=gx.num.intval(a)
},v2z:function(a){gx.O.ZV18gTTBUS2_IdMovimiento=gx.num.intval(a)},v2c:function(){gx.fn.setGridControlValue("vGTTBUS2_IDMOVIMIENTO",gx.fn.currentGridRowImpl(24),gx.O.AV18gTTBUS2_IdMovimiento,0)},c2v:function(){gx.O.AV18gTTBUS2_IdMovimiento=this.val()},val:function(){return gx.fn.getGridIntegerValue("vGTTBUS2_IDMOVIMIENTO",gx.fn.currentGridRowImpl(24),".")},nac:function(){return false}};this.GXValidFnc[28]={lvl:2,type:"svchar",len:80,dec:0,sign:false,ro:0,grid:24,gxgrid:this.Grid1Container,fnc:null,isvalid:null,fld:"vGNUMEROIDENTIFICADOR",gxz:"ZV28gNumeroIdentificador",gxold:"OV28gNumeroIdentificador",gxvar:"AV28gNumeroIdentificador",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",v2v:function(a){gx.O.AV28gNumeroIdentificador=a
},v2z:function(a){gx.O.ZV28gNumeroIdentificador=a},v2c:function(){gx.fn.setGridControlValue("vGNUMEROIDENTIFICADOR",gx.fn.currentGridRowImpl(24),gx.O.AV28gNumeroIdentificador,0)},c2v:function(){gx.O.AV28gNumeroIdentificador=this.val()},val:function(){return gx.fn.getGridControlValue("vGNUMEROIDENTIFICADOR",gx.fn.currentGridRowImpl(24))},nac:function(){return false}};this.GXValidFnc[29]={lvl:2,type:"int",len:8,dec:0,sign:false,pic:"ZZZZZZZ9",ro:0,grid:24,gxgrid:this.Grid1Container,fnc:null,isvalid:null,rgrid:[],fld:"vGTTBUS2_IDBIEN",gxz:"ZV15gTTBUS2_IdBien",gxold:"OV15gTTBUS2_IdBien",gxvar:"AV15gTTBUS2_IdBien",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",v2v:function(a){gx.O.AV15gTTBUS2_IdBien=gx.num.intval(a)
},v2z:function(a){gx.O.ZV15gTTBUS2_IdBien=gx.num.intval(a)},v2c:function(){gx.fn.setGridControlValue("vGTTBUS2_IDBIEN",gx.fn.currentGridRowImpl(24),gx.O.AV15gTTBUS2_IdBien,0)},c2v:function(){gx.O.AV15gTTBUS2_IdBien=this.val()},val:function(){return gx.fn.getGridIntegerValue("vGTTBUS2_IDBIEN",gx.fn.currentGridRowImpl(24),".")},nac:function(){return false}};this.GXValidFnc[30]={lvl:2,gxsgprm:["vTTBUS_DESCRIPCION",[],[],false,[]],type:"svchar",len:50,dec:0,sign:false,ro:0,grid:24,gxgrid:this.Grid1Container,fnc:null,isvalid:null,fld:"vTTBUS_DESCRIPCION",gxz:"ZV9TTBUS_Descripcion",gxold:"OV9TTBUS_Descripcion",gxvar:"AV9TTBUS_Descripcion",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",v2v:function(a){gx.O.AV9TTBUS_Descripcion=a
},v2z:function(a){gx.O.ZV9TTBUS_Descripcion=a},v2c:function(){gx.fn.setGridControlValue("vTTBUS_DESCRIPCION",gx.fn.currentGridRowImpl(24),gx.O.AV9TTBUS_Descripcion,0)},c2v:function(){gx.O.AV9TTBUS_Descripcion=this.val()},val:function(){return gx.fn.getGridControlValue("vTTBUS_DESCRIPCION",gx.fn.currentGridRowImpl(24))},nac:function(){return false}};this.GXValidFnc[31]={lvl:2,type:"int",len:3,dec:0,sign:false,pic:"ZZ9",ro:0,grid:24,gxgrid:this.Grid1Container,fnc:null,isvalid:null,rgrid:[],fld:"vGTTBUS2_CODPOSDESDE",gxz:"ZV14gTTBUS2_CodPosDesde",gxold:"OV14gTTBUS2_CodPosDesde",gxvar:"AV14gTTBUS2_CodPosDesde",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",v2v:function(a){gx.O.AV14gTTBUS2_CodPosDesde=gx.num.intval(a)
},v2z:function(a){gx.O.ZV14gTTBUS2_CodPosDesde=gx.num.intval(a)},v2c:function(){gx.fn.setGridControlValue("vGTTBUS2_CODPOSDESDE",gx.fn.currentGridRowImpl(24),gx.O.AV14gTTBUS2_CodPosDesde,0)},c2v:function(){gx.O.AV14gTTBUS2_CodPosDesde=this.val()},val:function(){return gx.fn.getGridIntegerValue("vGTTBUS2_CODPOSDESDE",gx.fn.currentGridRowImpl(24),".")},nac:function(){return false}};this.GXValidFnc[32]={lvl:2,type:"char",len:50,dec:0,sign:false,ro:0,grid:24,gxgrid:this.Grid1Container,fnc:null,isvalid:null,fld:"vDTTBUS3_DES",gxz:"ZV13dTTBUS3_Des",gxold:"OV13dTTBUS3_Des",gxvar:"AV13dTTBUS3_Des",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",v2v:function(a){gx.O.AV13dTTBUS3_Des=a
},v2z:function(a){gx.O.ZV13dTTBUS3_Des=a},v2c:function(){gx.fn.setGridControlValue("vDTTBUS3_DES",gx.fn.currentGridRowImpl(24),gx.O.AV13dTTBUS3_Des,0)},c2v:function(){gx.O.AV13dTTBUS3_Des=this.val()},val:function(){return gx.fn.getGridControlValue("vDTTBUS3_DES",gx.fn.currentGridRowImpl(24))},nac:function(){return false}};this.GXValidFnc[33]={lvl:2,type:"char",len:15,dec:0,sign:false,ro:0,grid:24,gxgrid:this.Grid1Container,fnc:null,isvalid:null,fld:"vGTTBUS2_RESPDESDE",gxz:"ZV24gTTBUS2_RespDesde",gxold:"OV24gTTBUS2_RespDesde",gxvar:"AV24gTTBUS2_RespDesde",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",v2v:function(a){gx.O.AV24gTTBUS2_RespDesde=a
},v2z:function(a){gx.O.ZV24gTTBUS2_RespDesde=a},v2c:function(){gx.fn.setGridControlValue("vGTTBUS2_RESPDESDE",gx.fn.currentGridRowImpl(24),gx.O.AV24gTTBUS2_RespDesde,0)},c2v:function(){gx.O.AV24gTTBUS2_RespDesde=this.val()},val:function(){return gx.fn.getGridControlValue("vGTTBUS2_RESPDESDE",gx.fn.currentGridRowImpl(24))},nac:function(){return false}};this.GXValidFnc[34]={lvl:2,type:"char",len:50,dec:0,sign:false,ro:0,grid:24,gxgrid:this.Grid1Container,fnc:null,isvalid:null,fld:"vDUSU_DES",gxz:"ZV7dUSU_DES",gxold:"OV7dUSU_DES",gxvar:"AV7dUSU_DES",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",v2v:function(a){gx.O.AV7dUSU_DES=a
},v2z:function(a){gx.O.ZV7dUSU_DES=a},v2c:function(){gx.fn.setGridControlValue("vDUSU_DES",gx.fn.currentGridRowImpl(24),gx.O.AV7dUSU_DES,0)},c2v:function(){gx.O.AV7dUSU_DES=this.val()},val:function(){return gx.fn.getGridControlValue("vDUSU_DES",gx.fn.currentGridRowImpl(24))},nac:function(){return false}};this.GXValidFnc[35]={lvl:2,type:"dtime",len:10,dec:5,sign:false,ro:0,grid:24,gxgrid:this.Grid1Container,fnc:null,isvalid:null,fld:"vGTTBUS2_FECHAENVIO",gxz:"ZV20gTTBUS2_FechaEnvio",gxold:"OV20gTTBUS2_FechaEnvio",gxvar:"AV20gTTBUS2_FechaEnvio",dp:{f:0,st:true,wn:false,mf:false,pic:"99/99/9999 99:99",dec:5},ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",v2v:function(a){gx.O.AV20gTTBUS2_FechaEnvio=gx.fn.toDatetimeValue(a)
},v2z:function(a){gx.O.ZV20gTTBUS2_FechaEnvio=gx.fn.toDatetimeValue(a)},v2c:function(){gx.fn.setGridControlValue("vGTTBUS2_FECHAENVIO",gx.fn.currentGridRowImpl(24),gx.O.AV20gTTBUS2_FechaEnvio,0)},c2v:function(){gx.O.AV20gTTBUS2_FechaEnvio=this.val()},val:function(){return gx.fn.getGridControlValue("vGTTBUS2_FECHAENVIO",gx.fn.currentGridRowImpl(24))},nac:function(){return false}};this.GXValidFnc[36]={lvl:2,type:"dtime",len:8,dec:5,sign:false,ro:0,grid:24,gxgrid:this.Grid1Container,fnc:null,isvalid:null,fld:"vGTTBUS2_FECHARECEPCION",gxz:"ZV25gTTBUS2_FechaRecepcion",gxold:"OV25gTTBUS2_FechaRecepcion",gxvar:"AV25gTTBUS2_FechaRecepcion",dp:{f:0,st:true,wn:false,mf:false,pic:"99/99/99 99:99",dec:5},ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",v2v:function(a){gx.O.AV25gTTBUS2_FechaRecepcion=gx.fn.toDatetimeValue(a)
},v2z:function(a){gx.O.ZV25gTTBUS2_FechaRecepcion=gx.fn.toDatetimeValue(a)},v2c:function(){gx.fn.setGridControlValue("vGTTBUS2_FECHARECEPCION",gx.fn.currentGridRowImpl(24),gx.O.AV25gTTBUS2_FechaRecepcion,0)},c2v:function(){gx.O.AV25gTTBUS2_FechaRecepcion=this.val()},val:function(){return gx.fn.getGridControlValue("vGTTBUS2_FECHARECEPCION",gx.fn.currentGridRowImpl(24))},nac:function(){return false}};this.GXValidFnc[37]={lvl:2,type:"dtime",len:10,dec:5,sign:false,ro:0,grid:24,gxgrid:this.Grid1Container,fnc:null,isvalid:null,fld:"vGTTBUS2_FECHAENVIO",gxz:"ZV20gTTBUS2_FechaEnvio",gxold:"OV20gTTBUS2_FechaEnvio",gxvar:"AV20gTTBUS2_FechaEnvio",dp:{f:0,st:true,wn:false,mf:false,pic:"99/99/9999 99:99",dec:5},ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",v2v:function(a){gx.O.AV20gTTBUS2_FechaEnvio=gx.fn.toDatetimeValue(a)
},v2z:function(a){gx.O.ZV20gTTBUS2_FechaEnvio=gx.fn.toDatetimeValue(a)},v2c:function(){gx.fn.setGridControlValue("vGTTBUS2_FECHAENVIO",gx.fn.currentGridRowImpl(24),gx.O.AV20gTTBUS2_FechaEnvio,0)},c2v:function(){gx.O.AV20gTTBUS2_FechaEnvio=this.val()},val:function(){return gx.fn.getGridControlValue("vGTTBUS2_FECHAENVIO",gx.fn.currentGridRowImpl(24))},nac:function(){return false}};this.GXValidFnc[38]={lvl:2,gxsgprm:["vGTTBUS2_MOTIVOENVIO",[],[],false,[]],type:"svchar",len:100,dec:0,sign:false,ro:0,grid:24,gxgrid:this.Grid1Container,fnc:null,isvalid:null,fld:"vGTTBUS2_MOTIVOENVIO",gxz:"ZV22gTTBUS2_MotivoEnvio",gxold:"OV22gTTBUS2_MotivoEnvio",gxvar:"AV22gTTBUS2_MotivoEnvio",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",v2v:function(a){gx.O.AV22gTTBUS2_MotivoEnvio=a
},v2z:function(a){gx.O.ZV22gTTBUS2_MotivoEnvio=a},v2c:function(){gx.fn.setGridControlValue("vGTTBUS2_MOTIVOENVIO",gx.fn.currentGridRowImpl(24),gx.O.AV22gTTBUS2_MotivoEnvio,0)},c2v:function(){gx.O.AV22gTTBUS2_MotivoEnvio=this.val()},val:function(){return gx.fn.getGridControlValue("vGTTBUS2_MOTIVOENVIO",gx.fn.currentGridRowImpl(24))},nac:function(){return false}};this.GXValidFnc[39]={lvl:2,gxsgprm:["vGTTBUS2_OBSERVACIONES",[],[],false,[]],type:"svchar",len:400,dec:0,sign:false,ro:0,grid:24,gxgrid:this.Grid1Container,fnc:null,isvalid:null,fld:"vGTTBUS2_OBSERVACIONES",gxz:"ZV23gTTBUS2_Observaciones",gxold:"OV23gTTBUS2_Observaciones",gxvar:"AV23gTTBUS2_Observaciones",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",v2v:function(a){gx.O.AV23gTTBUS2_Observaciones=a
},v2z:function(a){gx.O.ZV23gTTBUS2_Observaciones=a},v2c:function(){gx.fn.setGridControlValue("vGTTBUS2_OBSERVACIONES",gx.fn.currentGridRowImpl(24),gx.O.AV23gTTBUS2_Observaciones,0)},c2v:function(){gx.O.AV23gTTBUS2_Observaciones=this.val()},val:function(){return gx.fn.getGridControlValue("vGTTBUS2_OBSERVACIONES",gx.fn.currentGridRowImpl(24))},nac:function(){return false}};this.AV12TTBUS2_EstadoEnvio=0;this.ZV12TTBUS2_EstadoEnvio=0;this.OV12TTBUS2_EstadoEnvio=0;this.ZV26seleccion=0;this.OV26seleccion=0;
this.ZV27detalle="";this.OV27detalle="";this.ZV18gTTBUS2_IdMovimiento=0;this.OV18gTTBUS2_IdMovimiento=0;this.ZV28gNumeroIdentificador="";this.OV28gNumeroIdentificador="";this.ZV15gTTBUS2_IdBien=0;this.OV15gTTBUS2_IdBien=0;this.ZV9TTBUS_Descripcion="";this.OV9TTBUS_Descripcion="";this.ZV14gTTBUS2_CodPosDesde=0;this.OV14gTTBUS2_CodPosDesde=0;this.ZV13dTTBUS3_Des="";this.OV13dTTBUS3_Des="";this.ZV24gTTBUS2_RespDesde="";this.OV24gTTBUS2_RespDesde="";this.ZV7dUSU_DES="";this.OV7dUSU_DES="";this.ZV20gTTBUS2_FechaEnvio=gx.date.nullDate();
this.OV20gTTBUS2_FechaEnvio=gx.date.nullDate();this.ZV25gTTBUS2_FechaRecepcion=gx.date.nullDate();this.OV25gTTBUS2_FechaRecepcion=gx.date.nullDate();this.ZV22gTTBUS2_MotivoEnvio="";this.OV22gTTBUS2_MotivoEnvio="";this.ZV23gTTBUS2_Observaciones="";this.OV23gTTBUS2_Observaciones="";this.AV11USUARIO="";this.AV8SISTEMA="";this.AV26seleccion=0;this.AV27detalle="";this.AV18gTTBUS2_IdMovimiento=0;this.AV28gNumeroIdentificador="";this.AV15gTTBUS2_IdBien=0;this.AV9TTBUS_Descripcion="";this.AV14gTTBUS2_CodPosDesde=0;
this.AV13dTTBUS3_Des="";this.AV24gTTBUS2_RespDesde="";this.AV7dUSU_DES="";this.AV20gTTBUS2_FechaEnvio=gx.date.nullDate();this.AV25gTTBUS2_FechaRecepcion=gx.date.nullDate();this.AV22gTTBUS2_MotivoEnvio="";this.AV23gTTBUS2_Observaciones="";this.A53TTBUS2_IdUsuario="";this.A26TTBUS2_EstadoEnvio=0;this.A52TTBUS2_IdMovimiento=0;this.A22TTBUS2_IdBien=0;this.A48TTBUS2_CodPosDesde=0;this.A24TTBUS2_RespDesde="";this.A45TTBUS2_FechaEnvio=gx.date.nullDate();this.A25TTBUS2_RespHacia="";this.A47TTBUS2_MotivoEnvio="";
this.A87TTBUS2_Observaciones="";this.A102TTBUS2_TipoResp="";this.A6USU_COD="";this.A7USU_DES="";this.A33TTBUS7_Pos=0;this.A34TTBUS7_Des="";this.A11TTBUS_Id=0;this.A12TTBUS_Descripcion="";this.A46TTBUS2_FechaRecepcion=gx.date.nullDate();this.ServerEvents=["e111p2_client","e141p2_client","e151p2_client"];this.VarControlMap.A52TTBUS2_IdMovimiento={id:"TTBUS2_IDMOVIMIENTO",grid:0,type:"int"};this.VarControlMap.A26TTBUS2_EstadoEnvio={id:"TTBUS2_ESTADOENVIO",grid:0,type:"int"};this.VarControlMap.AV11USUARIO={id:"vUSUARIO",grid:0,type:"char"};
this.VarControlMap.AV8SISTEMA={id:"vSISTEMA",grid:0,type:"char"};this.VarControlMap.A102TTBUS2_TipoResp={id:"TTBUS2_TIPORESP",grid:0,type:"char"};this.VarControlMap.A53TTBUS2_IdUsuario={id:"TTBUS2_IDUSUARIO",grid:0,type:"char"};this.VarControlMap.A26TTBUS2_EstadoEnvio={id:"TTBUS2_ESTADOENVIO",grid:0,type:"int"};this.VarControlMap.A87TTBUS2_Observaciones={id:"TTBUS2_OBSERVACIONES",grid:0,type:"svchar"};this.VarControlMap.A47TTBUS2_MotivoEnvio={id:"TTBUS2_MOTIVOENVIO",grid:0,type:"svchar"};this.VarControlMap.A25TTBUS2_RespHacia={id:"TTBUS2_RESPHACIA",grid:0,type:"char"};
this.VarControlMap.A46TTBUS2_FechaRecepcion={id:"TTBUS2_FECHARECEPCION",grid:0,type:"dtime"};this.VarControlMap.A45TTBUS2_FechaEnvio={id:"TTBUS2_FECHAENVIO",grid:0,type:"dtime"};this.VarControlMap.A7USU_DES={id:"USU_DES",grid:0,type:"char"};this.VarControlMap.A6USU_COD={id:"USU_COD",grid:0,type:"char"};this.VarControlMap.A24TTBUS2_RespDesde={id:"TTBUS2_RESPDESDE",grid:0,type:"char"};this.VarControlMap.A34TTBUS7_Des={id:"TTBUS7_DES",grid:0,type:"char"};this.VarControlMap.A33TTBUS7_Pos={id:"TTBUS7_POS",grid:0,type:"int"};
this.VarControlMap.A48TTBUS2_CodPosDesde={id:"TTBUS2_CODPOSDESDE",grid:0,type:"int"};this.VarControlMap.A12TTBUS_Descripcion={id:"TTBUS_DESCRIPCION",grid:0,type:"svchar"};this.VarControlMap.A11TTBUS_Id={id:"TTBUS_ID",grid:0,type:"int"};this.VarControlMap.A22TTBUS2_IdBien={id:"TTBUS2_IDBIEN",grid:0,type:"int"};this.VarControlMap.A52TTBUS2_IdMovimiento={id:"TTBUS2_IDMOVIMIENTO",grid:0,type:"int"};this.Grid1Container.addRefreshingVar({rfrVar:"A102TTBUS2_TipoResp"});this.Grid1Container.addRefreshingVar({rfrVar:"A53TTBUS2_IdUsuario"});
this.Grid1Container.addRefreshingVar({rfrVar:"A26TTBUS2_EstadoEnvio"});this.Grid1Container.addRefreshingVar({rfrVar:"A87TTBUS2_Observaciones"});this.Grid1Container.addRefreshingVar({rfrVar:"A47TTBUS2_MotivoEnvio"});this.Grid1Container.addRefreshingVar({rfrVar:"A25TTBUS2_RespHacia"});this.Grid1Container.addRefreshingVar({rfrVar:"A46TTBUS2_FechaRecepcion"});this.Grid1Container.addRefreshingVar({rfrVar:"A45TTBUS2_FechaEnvio"});this.Grid1Container.addRefreshingVar({rfrVar:"A7USU_DES"});this.Grid1Container.addRefreshingVar({rfrVar:"A6USU_COD"});
this.Grid1Container.addRefreshingVar({rfrVar:"A24TTBUS2_RespDesde"});this.Grid1Container.addRefreshingVar({rfrVar:"A34TTBUS7_Des"});this.Grid1Container.addRefreshingVar({rfrVar:"A33TTBUS7_Pos"});this.Grid1Container.addRefreshingVar({rfrVar:"A48TTBUS2_CodPosDesde"});this.Grid1Container.addRefreshingVar({rfrVar:"A12TTBUS_Descripcion"});this.Grid1Container.addRefreshingVar({rfrVar:"A11TTBUS_Id"});this.Grid1Container.addRefreshingVar({rfrVar:"A22TTBUS2_IdBien"});this.Grid1Container.addRefreshingVar({rfrVar:"A52TTBUS2_IdMovimiento"});
this.SetStandaloneVars()}htbus004c.prototype=new gx.GxObject;gx.setParentObj(new htbus004c());