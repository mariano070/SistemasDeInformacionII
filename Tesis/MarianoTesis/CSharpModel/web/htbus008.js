gx.evt.autoSkip=false;function htbus008(){this.ServerClass="HTBUS008";this.PackageName="GeneXus.Programs";this.setObjectType("web");this.hasEnterEvent=false;this.autoRefresh=true;this.SetStandaloneVars=function(){this.AV10SISTEMA=gx.fn.getControlValue("vSISTEMA");this.AV11USUARIO=gx.fn.getControlValue("vUSUARIO")};this.Valid_Ttbus8_codusuario=function(){try{if(gx.fn.currentGridRowImpl(23)===0){return true}var a=gx.util.balloon.getNew("TTBUS8_CODUSUARIO",gx.fn.currentGridRowImpl(23));this.AnyError=0;
this.StandaloneModal();this.StandaloneNotModal()}catch(b){}try{if(a==null){return true}return a.show()}catch(b){}return true};this.e121j2_client=function(){this.executeServerEvent("'ALTA'",true,arguments[0])};this.e161j2_client=function(){this.executeServerEvent("'BAJA'",true,arguments[0])};this.e171j2_client=function(){this.executeServerEvent("'EDICION'",true,arguments[0])};this.e181j2_client=function(){this.executeServerEvent("'VISUALIZACION'",true,arguments[0])};this.e131j2_client=function(){this.executeServerEvent("'ATRáS'",false,arguments[0])
};this.e111j2_client=function(){this.executeServerEvent("'BUSCAR'",false,arguments[0])};this.e191j2_client=function(){this.executeServerEvent("ENTER",true,arguments[0])};this.e201j2_client=function(){this.executeServerEvent("CANCEL",true,arguments[0])};this.GXValidFnc=[];this.GXCtrlIds=[2,8,13,20,24,25,26,27,28];this.GXLastCtrlId=28;this.Grid1Container=new gx.grid.grid(this,2,"WbpLvl2",23,"Grid1","Grid1","Grid1Container",this.CmpContext,this.IsMasterPage,"htbus008",[],false,1,false,true,10,true,false,false,"",0,"px","Nueva fila",true,false,false,null,null,false,"");
this.Grid1Container.addBitmap("&Baja","vBAJA",24,0,"px",17,"px","e161j2_client","","");this.Grid1Container.addBitmap("&Edicion","vEDICION",25,0,"px",17,"px","e171j2_client","","");this.Grid1Container.addBitmap("&Visualizacion","vVISUALIZACION",26,0,"px",17,"px","e181j2_client","","");this.Grid1Container.addSingleLineEdit(40,27,"TTBUS8_CODUSUARIO","Cód. Usuario","","TTBUS8_CodUsuario","char",0,"px",16,16,"left",null,[],40,"TTBUS8_CodUsuario",true,0,false,false);this.Grid1Container.addSingleLineEdit(200,28,"TTBUS8_DESUSUARIO","Desc. Usuario","","TTBUS8_DesUsuario","char",0,"px",50,50,"left",null,[],200,"TTBUS8_DesUsuario",true,0,false,false);
this.setGrid(this.Grid1Container);this.GXValidFnc[2]={fld:"TABLE3",grid:0};this.GXValidFnc[8]={fld:"TABLE2",grid:0};this.GXValidFnc[11]={fld:"TEXTBLOCK2",format:0,grid:0};this.GXValidFnc[13]={lvl:0,type:"char",len:50,dec:0,sign:false,ro:0,grid:0,gxgrid:null,fnc:null,isvalid:null,fld:"vFTTBUS8_DESUSUARIO",gxz:"ZV9fTTBUS8_DesUsuario",gxold:"OV9fTTBUS8_DesUsuario",gxvar:"AV9fTTBUS8_DesUsuario",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",v2v:function(a){gx.O.AV9fTTBUS8_DesUsuario=a},v2z:function(a){gx.O.ZV9fTTBUS8_DesUsuario=a
},v2c:function(){gx.fn.setControlValue("vFTTBUS8_DESUSUARIO",gx.O.AV9fTTBUS8_DesUsuario,0)},c2v:function(){gx.O.AV9fTTBUS8_DesUsuario=this.val()},val:function(){return gx.fn.getControlValue("vFTTBUS8_DESUSUARIO")},nac:function(){return false}};this.GXValidFnc[20]={fld:"IMAGE1",grid:0};this.GXValidFnc[24]={lvl:2,type:"bits",len:4,dec:0,sign:false,ro:1,grid:23,gxgrid:this.Grid1Container,fnc:null,isvalid:null,fld:"vBAJA",gxz:"ZV5baja",gxold:"OV5baja",gxvar:"AV5baja",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",v2v:function(a){gx.O.AV5baja=a
},v2z:function(a){gx.O.ZV5baja=a},v2c:function(){},c2v:function(){gx.O.AV5baja=this.val()},val:function(){return gx.fn.getGridControlValue("vBAJA",gx.fn.currentGridRowImpl(23))},nac:function(){return false}};this.GXValidFnc[25]={lvl:2,type:"bits",len:4,dec:0,sign:false,ro:1,grid:23,gxgrid:this.Grid1Container,fnc:null,isvalid:null,fld:"vEDICION",gxz:"ZV6edicion",gxold:"OV6edicion",gxvar:"AV6edicion",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",v2v:function(a){gx.O.AV6edicion=a},v2z:function(a){gx.O.ZV6edicion=a
},v2c:function(){},c2v:function(){gx.O.AV6edicion=this.val()},val:function(){return gx.fn.getGridControlValue("vEDICION",gx.fn.currentGridRowImpl(23))},nac:function(){return false}};this.GXValidFnc[26]={lvl:2,type:"bits",len:4,dec:0,sign:false,ro:1,grid:23,gxgrid:this.Grid1Container,fnc:null,isvalid:null,fld:"vVISUALIZACION",gxz:"ZV7visualizacion",gxold:"OV7visualizacion",gxvar:"AV7visualizacion",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",v2v:function(a){gx.O.AV7visualizacion=a},v2z:function(a){gx.O.ZV7visualizacion=a
},v2c:function(){},c2v:function(){gx.O.AV7visualizacion=this.val()},val:function(){return gx.fn.getGridControlValue("vVISUALIZACION",gx.fn.currentGridRowImpl(23))},nac:function(){return false}};this.GXValidFnc[27]={lvl:2,type:"char",len:16,dec:0,sign:false,ro:1,grid:23,gxgrid:this.Grid1Container,fnc:this.Valid_Ttbus8_codusuario,isvalid:null,fld:"TTBUS8_CODUSUARIO",gxz:"Z40TTBUS8_CodUsuario",gxold:"O40TTBUS8_CodUsuario",gxvar:"A40TTBUS8_CodUsuario",ucs:[],op:[28],ip:[28,27],nacdep:[],ctrltype:"edit",v2v:function(a){gx.O.A40TTBUS8_CodUsuario=a
},v2z:function(a){gx.O.Z40TTBUS8_CodUsuario=a},v2c:function(){gx.fn.setGridControlValue("TTBUS8_CODUSUARIO",gx.fn.currentGridRowImpl(23),gx.O.A40TTBUS8_CodUsuario,0)},c2v:function(){gx.O.A40TTBUS8_CodUsuario=this.val()},val:function(){return gx.fn.getGridControlValue("TTBUS8_CODUSUARIO",gx.fn.currentGridRowImpl(23))},nac:function(){return false}};this.GXValidFnc[28]={lvl:2,type:"char",len:50,dec:0,sign:false,ro:1,grid:23,gxgrid:this.Grid1Container,fnc:null,isvalid:null,fld:"TTBUS8_DESUSUARIO",gxz:"Z200TTBUS8_DesUsuario",gxold:"O200TTBUS8_DesUsuario",gxvar:"A200TTBUS8_DesUsuario",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",v2v:function(a){gx.O.A200TTBUS8_DesUsuario=a
},v2z:function(a){gx.O.Z200TTBUS8_DesUsuario=a},v2c:function(){gx.fn.setGridControlValue("TTBUS8_DESUSUARIO",gx.fn.currentGridRowImpl(23),gx.O.A200TTBUS8_DesUsuario,0)},c2v:function(){gx.O.A200TTBUS8_DesUsuario=this.val()},val:function(){return gx.fn.getGridControlValue("TTBUS8_DESUSUARIO",gx.fn.currentGridRowImpl(23))},nac:function(){return false}};this.AV9fTTBUS8_DesUsuario="";this.ZV9fTTBUS8_DesUsuario="";this.OV9fTTBUS8_DesUsuario="";this.ZV5baja="";this.OV5baja="";this.ZV6edicion="";this.OV6edicion="";
this.ZV7visualizacion="";this.OV7visualizacion="";this.Z40TTBUS8_CodUsuario="";this.O40TTBUS8_CodUsuario="";this.Z200TTBUS8_DesUsuario="";this.O200TTBUS8_DesUsuario="";this.AV10SISTEMA="";this.AV11USUARIO="";this.AV5baja="";this.AV6edicion="";this.AV7visualizacion="";this.A40TTBUS8_CodUsuario="";this.A200TTBUS8_DesUsuario="";this.ServerEvents=["e121j2_client","e161j2_client","e171j2_client","e181j2_client","e131j2_client","e111j2_client","e191j2_client","e201j2_client"];this.VarControlMap.AV10SISTEMA={id:"vSISTEMA",grid:0,type:"char"};
this.VarControlMap.AV11USUARIO={id:"vUSUARIO",grid:0,type:"char"};this.Grid1Container.addRefreshingVar(this.GXValidFnc[13]);this.SetStandaloneVars()}htbus008.prototype=new gx.GxObject;gx.setParentObj(new htbus008());