gx.evt.autoSkip=false;function hhardware_prompt(){this.ServerClass="HHARDWARE_prompt";this.PackageName="GeneXus.Programs";this.setObjectType("web");this.hasEnterEvent=true;this.SetStandaloneVars=function(){this.AV37pHARDWARE_ID=gx.fn.getIntegerValue("vPHARDWARE_ID",".")};this.e110a2_client=function(){this.executeServerEvent("ENTER",true,arguments[0])};this.e130a2_client=function(){this.executeServerEvent("CANCEL",true,arguments[0])};this.GXValidFnc=[];this.GXCtrlIds=[3,9,14,19,24,35,36,37,38,39,40,41,42,43,44];
this.GXLastCtrlId=44;this.Grid1Container=new gx.grid.grid(this,2,"WbpLvl2",34,"Grid1","Grid1","Grid1Container",this.CmpContext,this.IsMasterPage,"hhardware_prompt",[],false,1,true,true,10,true,false,false,"",0,"px","Nueva fila",true,false,false,null,null,false,"");this.Grid1Container.addSingleLineEdit(10,35,"HARDWARE_ID","ID","","HARDWARE_ID","int",0,"px",4,4,"right","e110a2_client",[],10,"HARDWARE_ID",true,0,false,false);this.Grid1Container.addSingleLineEdit(58,36,"HARDWARE_DESCRIPCION","HARDWARE","","HARDWARE_DESCRIPCION","svchar",0,"px",40,40,"left","e110a2_client",[],58,"HARDWARE_DESCRIPCION",true,0,false,false);
this.Grid1Container.addSingleLineEdit(182,37,"FECHA_ALTA","FECHA ALTA","","fecha_alta","dtime",0,"px",19,10,"right",null,[],182,"fecha_alta",true,8,false,false);this.Grid1Container.addSingleLineEdit(181,38,"TIPOS_DE_HARDWARE_ID","ID","","TIPOS_DE_HARDWARE_ID","int",0,"px",4,4,"right",null,[],181,"TIPOS_DE_HARDWARE_ID",false,0,false,false);this.Grid1Container.addSingleLineEdit(187,39,"NOMBRE_DEL_TIPO_DE_HD","TIPO DE HW","","NOMBRE_DEL_TIPO_DE_HD","char",180,"px",20,20,"left",null,[],187,"NOMBRE_DEL_TIPO_DE_HD",true,0,false,false);
this.Grid1Container.addSingleLineEdit(189,40,"MARCAS_ID","ID","","MARCAS_ID","int",0,"px",4,4,"right",null,[],189,"MARCAS_ID",false,0,false,false);this.Grid1Container.addSingleLineEdit(190,41,"MARCAS_DESCRIPCION","MARCA","","MARCAS_DESCRIPCION","char",0,"px",20,20,"left",null,[],190,"MARCAS_DESCRIPCION",true,0,false,false);this.Grid1Container.addSingleLineEdit(183,42,"MODELO_DE_COMPONENTES_ID","ID","","MODELO_DE_COMPONENTES_ID","int",0,"px",4,4,"right",null,[],183,"MODELO_DE_COMPONENTES_ID",false,0,false,false);
this.Grid1Container.addSingleLineEdit(188,43,"MODELO_DE_COMPONENTES_NOMBRE","MODELO","","MODELO_DE_COMPONENTES_NOMBRE","char",180,"px",20,20,"left",null,[],188,"MODELO_DE_COMPONENTES_NOMBRE",true,0,false,false);this.Grid1Container.addSingleLineEdit(9,44,"HARDWARE_NRO_SERIE","NRO. SERIE","","HARDWARE_NRO_SERIE","svchar",0,"px",20,20,"left",null,[],9,"HARDWARE_NRO_SERIE",true,0,false,false);this.setGrid(this.Grid1Container);this.GXValidFnc[3]={fld:"TABLE1",grid:0};this.GXValidFnc[9]={fld:"TABLE2",grid:0};
this.GXValidFnc[12]={fld:"TEXTBLOCK12",format:0,grid:0};this.GXValidFnc[14]={lvl:0,type:"int",len:4,dec:0,sign:false,pic:"ZZZ9",ro:0,grid:0,gxgrid:null,fnc:null,isvalid:null,rgrid:[this.Grid1Container],fld:"vHARDWARE_ID",gxz:"ZV15HARDWARE_ID",gxold:"OV15HARDWARE_ID",gxvar:"AV15HARDWARE_ID",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",v2v:function(a){gx.O.AV15HARDWARE_ID=gx.num.intval(a)},v2z:function(a){gx.O.ZV15HARDWARE_ID=gx.num.intval(a)},v2c:function(){gx.fn.setControlValue("vHARDWARE_ID",gx.O.AV15HARDWARE_ID,0)
},c2v:function(){gx.O.AV15HARDWARE_ID=this.val()},val:function(){return gx.fn.getIntegerValue("vHARDWARE_ID",".")},nac:function(){return false}};this.GXValidFnc[17]={fld:"TEXTBLOCK9",format:0,grid:0};this.GXValidFnc[19]={lvl:0,type:"svchar",len:40,dec:0,sign:false,ro:0,grid:0,gxgrid:null,fnc:null,isvalid:null,fld:"vHARDWARE_DESCRIPCION",gxz:"ZV14HARDWARE_DESCRIPCION",gxold:"OV14HARDWARE_DESCRIPCION",gxvar:"AV14HARDWARE_DESCRIPCION",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",v2v:function(a){gx.O.AV14HARDWARE_DESCRIPCION=a
},v2z:function(a){gx.O.ZV14HARDWARE_DESCRIPCION=a},v2c:function(){gx.fn.setControlValue("vHARDWARE_DESCRIPCION",gx.O.AV14HARDWARE_DESCRIPCION,0)},c2v:function(){gx.O.AV14HARDWARE_DESCRIPCION=this.val()},val:function(){return gx.fn.getControlValue("vHARDWARE_DESCRIPCION")},nac:function(){return false}};this.GXValidFnc[22]={fld:"TEXTBLOCK6",format:0,grid:0};this.GXValidFnc[24]={lvl:0,type:"char",len:20,dec:0,sign:false,ro:0,grid:0,gxgrid:null,fnc:null,isvalid:null,fld:"vNOMBRE_DEL_TIPO_DE_HD",gxz:"ZV27NOMBRE_DEL_TIPO_DE_HD",gxold:"OV27NOMBRE_DEL_TIPO_DE_HD",gxvar:"AV27NOMBRE_DEL_TIPO_DE_HD",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"dyncombo",v2v:function(a){gx.O.AV27NOMBRE_DEL_TIPO_DE_HD=a
},v2z:function(a){gx.O.ZV27NOMBRE_DEL_TIPO_DE_HD=a},v2c:function(){gx.fn.setComboBoxValue("vNOMBRE_DEL_TIPO_DE_HD",gx.O.AV27NOMBRE_DEL_TIPO_DE_HD)},c2v:function(){gx.O.AV27NOMBRE_DEL_TIPO_DE_HD=this.val()},val:function(){return gx.fn.getControlValue("vNOMBRE_DEL_TIPO_DE_HD")},nac:function(){return false}};this.GXValidFnc[35]={lvl:2,type:"int",len:4,dec:0,sign:false,pic:"ZZZ9",ro:1,grid:34,gxgrid:this.Grid1Container,fnc:null,isvalid:null,rgrid:[],fld:"HARDWARE_ID",gxz:"Z10HARDWARE_ID",gxold:"O10HARDWARE_ID",gxvar:"A10HARDWARE_ID",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",v2v:function(a){gx.O.A10HARDWARE_ID=gx.num.intval(a)
},v2z:function(a){gx.O.Z10HARDWARE_ID=gx.num.intval(a)},v2c:function(){gx.fn.setGridControlValue("HARDWARE_ID",gx.fn.currentGridRowImpl(34),gx.O.A10HARDWARE_ID,0)},c2v:function(){gx.O.A10HARDWARE_ID=this.val()},val:function(){return gx.fn.getGridIntegerValue("HARDWARE_ID",gx.fn.currentGridRowImpl(34),".")},nac:function(){return false}};this.GXValidFnc[36]={lvl:2,type:"svchar",len:40,dec:0,sign:false,ro:1,grid:34,gxgrid:this.Grid1Container,fnc:null,isvalid:null,fld:"HARDWARE_DESCRIPCION",gxz:"Z58HARDWARE_DESCRIPCION",gxold:"O58HARDWARE_DESCRIPCION",gxvar:"A58HARDWARE_DESCRIPCION",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",v2v:function(a){gx.O.A58HARDWARE_DESCRIPCION=a
},v2z:function(a){gx.O.Z58HARDWARE_DESCRIPCION=a},v2c:function(){gx.fn.setGridControlValue("HARDWARE_DESCRIPCION",gx.fn.currentGridRowImpl(34),gx.O.A58HARDWARE_DESCRIPCION,0)},c2v:function(){gx.O.A58HARDWARE_DESCRIPCION=this.val()},val:function(){return gx.fn.getGridControlValue("HARDWARE_DESCRIPCION",gx.fn.currentGridRowImpl(34))},nac:function(){return false}};this.GXValidFnc[37]={lvl:2,type:"dtime",len:10,dec:8,sign:false,ro:1,grid:34,gxgrid:this.Grid1Container,fnc:null,isvalid:null,fld:"FECHA_ALTA",gxz:"Z182fecha_alta",gxold:"O182fecha_alta",gxvar:"A182fecha_alta",dp:{f:0,st:true,wn:false,mf:false,pic:"99/99/9999 99:99:99",dec:8},ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",v2v:function(a){gx.O.A182fecha_alta=gx.fn.toDatetimeValue(a)
},v2z:function(a){gx.O.Z182fecha_alta=gx.fn.toDatetimeValue(a)},v2c:function(){gx.fn.setGridControlValue("FECHA_ALTA",gx.fn.currentGridRowImpl(34),gx.O.A182fecha_alta,0)},c2v:function(){gx.O.A182fecha_alta=this.val()},val:function(){return gx.fn.getGridControlValue("FECHA_ALTA",gx.fn.currentGridRowImpl(34))},nac:function(){return false}};this.GXValidFnc[38]={lvl:2,type:"int",len:4,dec:0,sign:false,pic:"ZZZ9",ro:1,grid:34,gxgrid:this.Grid1Container,fnc:null,isvalid:null,rgrid:[],fld:"TIPOS_DE_HARDWARE_ID",gxz:"Z181TIPOS_DE_HARDWARE_ID",gxold:"O181TIPOS_DE_HARDWARE_ID",gxvar:"A181TIPOS_DE_HARDWARE_ID",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",v2v:function(a){gx.O.A181TIPOS_DE_HARDWARE_ID=gx.num.intval(a)
},v2z:function(a){gx.O.Z181TIPOS_DE_HARDWARE_ID=gx.num.intval(a)},v2c:function(){gx.fn.setGridControlValue("TIPOS_DE_HARDWARE_ID",gx.fn.currentGridRowImpl(34),gx.O.A181TIPOS_DE_HARDWARE_ID,0)},c2v:function(){gx.O.A181TIPOS_DE_HARDWARE_ID=this.val()},val:function(){return gx.fn.getGridIntegerValue("TIPOS_DE_HARDWARE_ID",gx.fn.currentGridRowImpl(34),".")},nac:function(){return false}};this.GXValidFnc[39]={lvl:2,type:"char",len:20,dec:0,sign:false,ro:1,grid:34,gxgrid:this.Grid1Container,fnc:null,isvalid:null,fld:"NOMBRE_DEL_TIPO_DE_HD",gxz:"Z187NOMBRE_DEL_TIPO_DE_HD",gxold:"O187NOMBRE_DEL_TIPO_DE_HD",gxvar:"A187NOMBRE_DEL_TIPO_DE_HD",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",v2v:function(a){gx.O.A187NOMBRE_DEL_TIPO_DE_HD=a
},v2z:function(a){gx.O.Z187NOMBRE_DEL_TIPO_DE_HD=a},v2c:function(){gx.fn.setGridControlValue("NOMBRE_DEL_TIPO_DE_HD",gx.fn.currentGridRowImpl(34),gx.O.A187NOMBRE_DEL_TIPO_DE_HD,0)},c2v:function(){gx.O.A187NOMBRE_DEL_TIPO_DE_HD=this.val()},val:function(){return gx.fn.getGridControlValue("NOMBRE_DEL_TIPO_DE_HD",gx.fn.currentGridRowImpl(34))},nac:function(){return false}};this.GXValidFnc[40]={lvl:2,type:"int",len:4,dec:0,sign:false,pic:"ZZZ9",ro:1,grid:34,gxgrid:this.Grid1Container,fnc:null,isvalid:null,rgrid:[],fld:"MARCAS_ID",gxz:"Z189MARCAS_ID",gxold:"O189MARCAS_ID",gxvar:"A189MARCAS_ID",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",v2v:function(a){gx.O.A189MARCAS_ID=gx.num.intval(a)
},v2z:function(a){gx.O.Z189MARCAS_ID=gx.num.intval(a)},v2c:function(){gx.fn.setGridControlValue("MARCAS_ID",gx.fn.currentGridRowImpl(34),gx.O.A189MARCAS_ID,0)},c2v:function(){gx.O.A189MARCAS_ID=this.val()},val:function(){return gx.fn.getGridIntegerValue("MARCAS_ID",gx.fn.currentGridRowImpl(34),".")},nac:function(){return false}};this.GXValidFnc[41]={lvl:2,type:"char",len:20,dec:0,sign:false,ro:1,grid:34,gxgrid:this.Grid1Container,fnc:null,isvalid:null,fld:"MARCAS_DESCRIPCION",gxz:"Z190MARCAS_DESCRIPCION",gxold:"O190MARCAS_DESCRIPCION",gxvar:"A190MARCAS_DESCRIPCION",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",v2v:function(a){gx.O.A190MARCAS_DESCRIPCION=a
},v2z:function(a){gx.O.Z190MARCAS_DESCRIPCION=a},v2c:function(){gx.fn.setGridControlValue("MARCAS_DESCRIPCION",gx.fn.currentGridRowImpl(34),gx.O.A190MARCAS_DESCRIPCION,0)},c2v:function(){gx.O.A190MARCAS_DESCRIPCION=this.val()},val:function(){return gx.fn.getGridControlValue("MARCAS_DESCRIPCION",gx.fn.currentGridRowImpl(34))},nac:function(){return false}};this.GXValidFnc[42]={lvl:2,type:"int",len:4,dec:0,sign:false,pic:"ZZZ9",ro:1,grid:34,gxgrid:this.Grid1Container,fnc:null,isvalid:null,rgrid:[],fld:"MODELO_DE_COMPONENTES_ID",gxz:"Z183MODELO_DE_COMPONENTES_ID",gxold:"O183MODELO_DE_COMPONENTES_ID",gxvar:"A183MODELO_DE_COMPONENTES_ID",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",v2v:function(a){gx.O.A183MODELO_DE_COMPONENTES_ID=gx.num.intval(a)
},v2z:function(a){gx.O.Z183MODELO_DE_COMPONENTES_ID=gx.num.intval(a)},v2c:function(){gx.fn.setGridControlValue("MODELO_DE_COMPONENTES_ID",gx.fn.currentGridRowImpl(34),gx.O.A183MODELO_DE_COMPONENTES_ID,0)},c2v:function(){gx.O.A183MODELO_DE_COMPONENTES_ID=this.val()},val:function(){return gx.fn.getGridIntegerValue("MODELO_DE_COMPONENTES_ID",gx.fn.currentGridRowImpl(34),".")},nac:function(){return false}};this.GXValidFnc[43]={lvl:2,type:"char",len:20,dec:0,sign:false,ro:1,grid:34,gxgrid:this.Grid1Container,fnc:null,isvalid:null,fld:"MODELO_DE_COMPONENTES_NOMBRE",gxz:"Z188MODELO_DE_COMPONENTES_NOMBRE",gxold:"O188MODELO_DE_COMPONENTES_NOMBRE",gxvar:"A188MODELO_DE_COMPONENTES_NOMBRE",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",v2v:function(a){gx.O.A188MODELO_DE_COMPONENTES_NOMBRE=a
},v2z:function(a){gx.O.Z188MODELO_DE_COMPONENTES_NOMBRE=a},v2c:function(){gx.fn.setGridControlValue("MODELO_DE_COMPONENTES_NOMBRE",gx.fn.currentGridRowImpl(34),gx.O.A188MODELO_DE_COMPONENTES_NOMBRE,0)},c2v:function(){gx.O.A188MODELO_DE_COMPONENTES_NOMBRE=this.val()},val:function(){return gx.fn.getGridControlValue("MODELO_DE_COMPONENTES_NOMBRE",gx.fn.currentGridRowImpl(34))},nac:function(){return false}};this.GXValidFnc[44]={lvl:2,type:"svchar",len:20,dec:0,sign:false,ro:1,grid:34,gxgrid:this.Grid1Container,fnc:null,isvalid:null,fld:"HARDWARE_NRO_SERIE",gxz:"Z9HARDWARE_NRO_SERIE",gxold:"O9HARDWARE_NRO_SERIE",gxvar:"A9HARDWARE_NRO_SERIE",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",v2v:function(a){gx.O.A9HARDWARE_NRO_SERIE=a
},v2z:function(a){gx.O.Z9HARDWARE_NRO_SERIE=a},v2c:function(){gx.fn.setGridControlValue("HARDWARE_NRO_SERIE",gx.fn.currentGridRowImpl(34),gx.O.A9HARDWARE_NRO_SERIE,0)},c2v:function(){gx.O.A9HARDWARE_NRO_SERIE=this.val()},val:function(){return gx.fn.getGridControlValue("HARDWARE_NRO_SERIE",gx.fn.currentGridRowImpl(34))},nac:function(){return false}};this.AV15HARDWARE_ID=0;this.ZV15HARDWARE_ID=0;this.OV15HARDWARE_ID=0;this.AV14HARDWARE_DESCRIPCION="";this.ZV14HARDWARE_DESCRIPCION="";this.OV14HARDWARE_DESCRIPCION="";
this.AV27NOMBRE_DEL_TIPO_DE_HD="";this.ZV27NOMBRE_DEL_TIPO_DE_HD="";this.OV27NOMBRE_DEL_TIPO_DE_HD="";this.Z10HARDWARE_ID=0;this.O10HARDWARE_ID=0;this.Z58HARDWARE_DESCRIPCION="";this.O58HARDWARE_DESCRIPCION="";this.Z182fecha_alta=gx.date.nullDate();this.O182fecha_alta=gx.date.nullDate();this.Z181TIPOS_DE_HARDWARE_ID=0;this.O181TIPOS_DE_HARDWARE_ID=0;this.Z187NOMBRE_DEL_TIPO_DE_HD="";this.O187NOMBRE_DEL_TIPO_DE_HD="";this.Z189MARCAS_ID=0;this.O189MARCAS_ID=0;this.Z190MARCAS_DESCRIPCION="";this.O190MARCAS_DESCRIPCION="";
this.Z183MODELO_DE_COMPONENTES_ID=0;this.O183MODELO_DE_COMPONENTES_ID=0;this.Z188MODELO_DE_COMPONENTES_NOMBRE="";this.O188MODELO_DE_COMPONENTES_NOMBRE="";this.Z9HARDWARE_NRO_SERIE="";this.O9HARDWARE_NRO_SERIE="";this.AV37pHARDWARE_ID=0;this.A104HDW_IDT=0;this.A10HARDWARE_ID=0;this.A58HARDWARE_DESCRIPCION="";this.A182fecha_alta=gx.date.nullDate();this.A181TIPOS_DE_HARDWARE_ID=0;this.A187NOMBRE_DEL_TIPO_DE_HD="";this.A189MARCAS_ID=0;this.A190MARCAS_DESCRIPCION="";this.A183MODELO_DE_COMPONENTES_ID=0;
this.A188MODELO_DE_COMPONENTES_NOMBRE="";this.A9HARDWARE_NRO_SERIE="";this.ServerEvents=["e110a2_client","e130a2_client"];this.VarControlMap.AV37pHARDWARE_ID={id:"vPHARDWARE_ID",grid:0,type:"int"};this.Grid1Container.addRefreshingVar(this.GXValidFnc[14]);this.Grid1Container.addRefreshingVar(this.GXValidFnc[19]);this.Grid1Container.addRefreshingVar(this.GXValidFnc[24]);this.SetStandaloneVars()}hhardware_prompt.prototype=new gx.GxObject;gx.setParentObj(new hhardware_prompt());