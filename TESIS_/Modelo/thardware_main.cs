/*
               File: THARDWARE_MAIN
        Description: Asministración de Hardware
             Author: GeneXus C# Generator version 10_1_5-42940
       Generated on: 1/6/2014 11:19:28.39
       Program type: Callable routine
          Main DBMS: sqlserver
*/
using System;
using System.Collections;
using GeneXus.Utils;
using GeneXus.Resources;
using GeneXus.Application;
using GeneXus.Metadata;
using System.Data;
using System.Data.SqlClient;
using GeneXus.Data;
using com.genexus;
using GeneXus.Data.ADO;
using GeneXus.Data.NTier;
using GeneXus.Data.NTier.ADO;
using System.Runtime.Remoting;
using GeneXus.WebControls;
using GeneXus.Http;
using GeneXus.XML;
using GeneXus.Search;
using GeneXus.Encryption;
using GeneXus.Http.Client;
using System.Xml.Serialization;
using System.Data.SqlTypes;
namespace GeneXus.Programs {
   public class thardware_main : GXDataArea, System.Web.SessionState.IRequiresSessionState
   {
      protected void INITENV( )
      {
         if ( GxWebError != 0 )
         {
            return  ;
         }
      }

      protected void INITTRN( )
      {
         initialize_properties( ) ;
         entryPointCalled = false ;
         gxfirstwebparm = GetNextPar( ) ;
         gxfirstwebparm_bkp = gxfirstwebparm ;
         gxfirstwebparm = DecryptAjaxCall( gxfirstwebparm, "High") ;
         if ( StringUtil.StrCmp(gxfirstwebparm, "dyncall") == 0 )
         {
            setAjaxCallMode();
            if ( ! IsValidAjaxCall( true) )
            {
               GxWebError = 1 ;
               return  ;
            }
            dyncall( GetNextPar( )) ;
            return  ;
         }
         else if ( StringUtil.StrCmp(gxfirstwebparm, "gxJX_Action35") == 0 )
         {
            A10HARDWARE_ID = (short)(NumberUtil.Val( GetNextPar( ), ".")) ;
            n10HARDWARE_ID = false ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A10HARDWARE_ID", StringUtil.LTrim( StringUtil.Str( (decimal)(A10HARDWARE_ID), 4, 0)));
            A104HDW_IDT = (int)(NumberUtil.Val( GetNextPar( ), ".")) ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A104HDW_IDT", StringUtil.LTrim( StringUtil.Str( (decimal)(A104HDW_IDT), 8, 0)));
            setAjaxCallMode();
            if ( ! IsValidAjaxCall( true) )
            {
               GxWebError = 1 ;
               return  ;
            }
            XC_35_0N23( A10HARDWARE_ID, A104HDW_IDT) ;
            return  ;
         }
         else if ( StringUtil.StrCmp(gxfirstwebparm, "gxJX_Action37") == 0 )
         {
            A104HDW_IDT = (int)(NumberUtil.Val( GetNextPar( ), ".")) ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A104HDW_IDT", StringUtil.LTrim( StringUtil.Str( (decimal)(A104HDW_IDT), 8, 0)));
            A186fecha_baja = context.localUtil.ParseDTimeParm( GetNextPar( )) ;
            n186fecha_baja = false ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A186fecha_baja", context.localUtil.TToC( A186fecha_baja, 10, 8, 0, 3, "/", ":", " "));
            setAjaxCallMode();
            if ( ! IsValidAjaxCall( true) )
            {
               GxWebError = 1 ;
               return  ;
            }
            XC_37_0N23( A104HDW_IDT, A186fecha_baja) ;
            return  ;
         }
         else if ( StringUtil.StrCmp(gxfirstwebparm, "gxJX_Action39") == 0 )
         {
            A194THARDWARE_UBI = (long)(NumberUtil.Val( GetNextPar( ), ".")) ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A194THARDWARE_UBI", StringUtil.LTrim( StringUtil.Str( (decimal)(A194THARDWARE_UBI), 10, 0)));
            A311HARDWARE_RED = (long)(NumberUtil.Val( GetNextPar( ), ".")) ;
            n311HARDWARE_RED = false ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A311HARDWARE_RED", StringUtil.LTrim( StringUtil.Str( (decimal)(A311HARDWARE_RED), 10, 0)));
            A10HARDWARE_ID = (short)(NumberUtil.Val( GetNextPar( ), ".")) ;
            n10HARDWARE_ID = false ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A10HARDWARE_ID", StringUtil.LTrim( StringUtil.Str( (decimal)(A10HARDWARE_ID), 4, 0)));
            A299TIPO_DIR_IP = (short)(NumberUtil.Val( GetNextPar( ), ".")) ;
            n299TIPO_DIR_IP = false ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A299TIPO_DIR_IP", StringUtil.LTrim( StringUtil.Str( (decimal)(A299TIPO_DIR_IP), 2, 0)));
            A185ACTIVO = GetNextPar( ) ;
            n185ACTIVO = false ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A185ACTIVO", A185ACTIVO);
            Gx_mode = GetNextPar( ) ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
            setAjaxCallMode();
            if ( ! IsValidAjaxCall( true) )
            {
               GxWebError = 1 ;
               return  ;
            }
            XC_39_0N23( A194THARDWARE_UBI, A311HARDWARE_RED, A10HARDWARE_ID, A299TIPO_DIR_IP, A185ACTIVO, Gx_mode) ;
            return  ;
         }
         else if ( StringUtil.StrCmp(gxfirstwebparm, "gxJX_Action40") == 0 )
         {
            A194THARDWARE_UBI = (long)(NumberUtil.Val( GetNextPar( ), ".")) ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A194THARDWARE_UBI", StringUtil.LTrim( StringUtil.Str( (decimal)(A194THARDWARE_UBI), 10, 0)));
            A311HARDWARE_RED = (long)(NumberUtil.Val( GetNextPar( ), ".")) ;
            n311HARDWARE_RED = false ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A311HARDWARE_RED", StringUtil.LTrim( StringUtil.Str( (decimal)(A311HARDWARE_RED), 10, 0)));
            A10HARDWARE_ID = (short)(NumberUtil.Val( GetNextPar( ), ".")) ;
            n10HARDWARE_ID = false ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A10HARDWARE_ID", StringUtil.LTrim( StringUtil.Str( (decimal)(A10HARDWARE_ID), 4, 0)));
            A299TIPO_DIR_IP = (short)(NumberUtil.Val( GetNextPar( ), ".")) ;
            n299TIPO_DIR_IP = false ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A299TIPO_DIR_IP", StringUtil.LTrim( StringUtil.Str( (decimal)(A299TIPO_DIR_IP), 2, 0)));
            A185ACTIVO = GetNextPar( ) ;
            n185ACTIVO = false ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A185ACTIVO", A185ACTIVO);
            Gx_mode = GetNextPar( ) ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
            setAjaxCallMode();
            if ( ! IsValidAjaxCall( true) )
            {
               GxWebError = 1 ;
               return  ;
            }
            XC_40_0N23( A194THARDWARE_UBI, A311HARDWARE_RED, A10HARDWARE_ID, A299TIPO_DIR_IP, A185ACTIVO, Gx_mode) ;
            return  ;
         }
         else if ( StringUtil.StrCmp(gxfirstwebparm, "gxJX_Action41") == 0 )
         {
            A10HARDWARE_ID = (short)(NumberUtil.Val( GetNextPar( ), ".")) ;
            n10HARDWARE_ID = false ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A10HARDWARE_ID", StringUtil.LTrim( StringUtil.Str( (decimal)(A10HARDWARE_ID), 4, 0)));
            A194THARDWARE_UBI = (long)(NumberUtil.Val( GetNextPar( ), ".")) ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A194THARDWARE_UBI", StringUtil.LTrim( StringUtil.Str( (decimal)(A194THARDWARE_UBI), 10, 0)));
            A311HARDWARE_RED = (long)(NumberUtil.Val( GetNextPar( ), ".")) ;
            n311HARDWARE_RED = false ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A311HARDWARE_RED", StringUtil.LTrim( StringUtil.Str( (decimal)(A311HARDWARE_RED), 10, 0)));
            A312HARDWARE_IP = (short)(NumberUtil.Val( GetNextPar( ), ".")) ;
            n312HARDWARE_IP = false ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A312HARDWARE_IP", StringUtil.LTrim( StringUtil.Str( (decimal)(A312HARDWARE_IP), 3, 0)));
            A185ACTIVO = GetNextPar( ) ;
            n185ACTIVO = false ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A185ACTIVO", A185ACTIVO);
            A299TIPO_DIR_IP = (short)(NumberUtil.Val( GetNextPar( ), ".")) ;
            n299TIPO_DIR_IP = false ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A299TIPO_DIR_IP", StringUtil.LTrim( StringUtil.Str( (decimal)(A299TIPO_DIR_IP), 2, 0)));
            setAjaxCallMode();
            if ( ! IsValidAjaxCall( true) )
            {
               GxWebError = 1 ;
               return  ;
            }
            XC_41_0N23( A10HARDWARE_ID, A194THARDWARE_UBI, A311HARDWARE_RED, A312HARDWARE_IP, A185ACTIVO, A299TIPO_DIR_IP) ;
            return  ;
         }
         else if ( StringUtil.StrCmp(gxfirstwebparm, "gxajaxCallCrl"+"_"+"RESPONSABLE_ARMADO_PC") == 0 )
         {
            setAjaxCallMode();
            if ( ! IsValidAjaxCall( true) )
            {
               GxWebError = 1 ;
               return  ;
            }
            GXDLARESPONSABLE_ARMADO_PC0N23( ) ;
            return  ;
         }
         else if ( StringUtil.StrCmp(gxfirstwebparm, "gxajaxCallCrl"+"_"+"THARDWARE_UBI") == 0 )
         {
            setAjaxCallMode();
            if ( ! IsValidAjaxCall( true) )
            {
               GxWebError = 1 ;
               return  ;
            }
            GXDLATHARDWARE_UBI0N23( ) ;
            return  ;
         }
         else if ( StringUtil.StrCmp(gxfirstwebparm, "gxajaxCallCrl"+"_"+"HARDWARE_RED") == 0 )
         {
            A194THARDWARE_UBI = (long)(NumberUtil.Val( GetNextPar( ), ".")) ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A194THARDWARE_UBI", StringUtil.LTrim( StringUtil.Str( (decimal)(A194THARDWARE_UBI), 10, 0)));
            setAjaxCallMode();
            if ( ! IsValidAjaxCall( true) )
            {
               GxWebError = 1 ;
               return  ;
            }
            GXDLAHARDWARE_RED0N23( A194THARDWARE_UBI) ;
            return  ;
         }
         else if ( StringUtil.StrCmp(gxfirstwebparm, "gxajaxCallCrl"+"_"+"HARDWARE_UBA") == 0 )
         {
            setAjaxCallMode();
            if ( ! IsValidAjaxCall( true) )
            {
               GxWebError = 1 ;
               return  ;
            }
            GXDLAHARDWARE_UBA0N23( ) ;
            return  ;
         }
         else if ( StringUtil.StrCmp(gxfirstwebparm, "gxajaxEvt") == 0 )
         {
            setAjaxEventMode();
            if ( ! IsValidAjaxCall( true) )
            {
               GxWebError = 1 ;
               return  ;
            }
            gxfirstwebparm = GetNextPar( ) ;
         }
         else
         {
            if ( ! IsValidAjaxCall( false) )
            {
               GxWebError = 1 ;
               return  ;
            }
            gxfirstwebparm = gxfirstwebparm_bkp ;
         }
         if ( ! entryPointCalled )
         {
            AV12HARDWARE_ID = (short)(NumberUtil.Val( gxfirstwebparm, ".")) ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV12HARDWARE_ID", StringUtil.LTrim( StringUtil.Str( (decimal)(AV12HARDWARE_ID), 4, 0)));
            if ( StringUtil.StrCmp(gxfirstwebparm, "viewer") != 0 )
            {
               Gx_mode = GetNextPar( ) ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
               AV29SISTEMA = GetNextPar( ) ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV29SISTEMA", AV29SISTEMA);
               AV30USUARIO = GetNextPar( ) ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV30USUARIO", AV30USUARIO);
            }
         }
         cmbTH_DIREC.Name = "TH_DIREC" ;
         cmbTH_DIREC.WebTags = "" ;
         cmbTH_DIREC.addItem(" 1", "NINGUNO", 0);
         cmbTH_DIREC.addItem(" 2", "IP", 0);
         if ( ( cmbTH_DIREC.ItemCount > 0 ) && (0==A313TH_DIREC) )
         {
            A313TH_DIREC = (short)(NumberUtil.Val( cmbTH_DIREC.getItemValue(1), ".")) ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A313TH_DIREC", StringUtil.LTrim( StringUtil.Str( (decimal)(A313TH_DIREC), 2, 0)));
         }
         cmbACTIVO.Name = "ACTIVO" ;
         cmbACTIVO.WebTags = "" ;
         cmbACTIVO.addItem("Si", "Activo", 0);
         cmbACTIVO.addItem("No", "Inactivo", 0);
         cmbACTIVO.addItem("SO", "Soporte", 0);
         if ( ( cmbACTIVO.ItemCount > 0 ) && String.IsNullOrEmpty(StringUtil.RTrim( A185ACTIVO)) )
         {
            A185ACTIVO = "Si" ;
            n185ACTIVO = false ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A185ACTIVO", A185ACTIVO);
         }
         radPRUEBA_MICROFONO_AUDIO.Name = "PRUEBA_MICROFONO_AUDIO" ;
         radPRUEBA_MICROFONO_AUDIO.WebTags = "" ;
         radPRUEBA_MICROFONO_AUDIO.addItem("Si", "Si", 0);
         radPRUEBA_MICROFONO_AUDIO.addItem("No", "No", 0);
         dynRESPONSABLE_ARMADO_PC.Name = "RESPONSABLE_ARMADO_PC" ;
         dynRESPONSABLE_ARMADO_PC.WebTags = "" ;
         cmbTIPO_DIR_IP.Name = "TIPO_DIR_IP" ;
         cmbTIPO_DIR_IP.WebTags = "" ;
         cmbTIPO_DIR_IP.addItem(StringUtil.Str( (decimal)(0), 2, 0), "Sin Especificar", 0);
         cmbTIPO_DIR_IP.addItem(" 1", "DHCP", 0);
         cmbTIPO_DIR_IP.addItem(" 2", "IP Fija", 0);
         if ( ( cmbTIPO_DIR_IP.ItemCount > 0 ) && (0==A299TIPO_DIR_IP) )
         {
            A299TIPO_DIR_IP = (short)(NumberUtil.Val( cmbTIPO_DIR_IP.getItemValue(1), ".")) ;
            n299TIPO_DIR_IP = false ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A299TIPO_DIR_IP", StringUtil.LTrim( StringUtil.Str( (decimal)(A299TIPO_DIR_IP), 2, 0)));
         }
         dynTHARDWARE_UBI.Name = "THARDWARE_UBI" ;
         dynTHARDWARE_UBI.WebTags = "" ;
         dynHARDWARE_RED.Name = "HARDWARE_RED" ;
         dynHARDWARE_RED.WebTags = "" ;
         dynHARDWARE_UBA.Name = "HARDWARE_UBA" ;
         dynHARDWARE_UBA.WebTags = "" ;
         Form.Meta.addItem("Generator", "GeneXus C#", 0) ;
         Form.Meta.addItem("Version", "10_1_5-42940", 0) ;
         Form.Meta.addItem("Description", "Asministración de Hardware", 0) ;
         context.wjLoc = "" ;
         context.nUserReturn = 0 ;
         context.wbHandled = 0 ;
         if ( StringUtil.StrCmp(context.GetRequestMethod( ), "POST") == 0 )
         {
         }
         GX_FocusControl = edtHARDWARE_DESCRIPCION_Internalname ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
         wbErr = false ;
         context.SetTheme("Modern");
      }

      public thardware_main( )
      {
         context = new GxContext(  );
         DataStoreUtil.LoadDataStores( context);
         dsDESARROLLO = context.GetDataStore("DESARROLLO") ;
         dssoporte_notebook = context.GetDataStore("soporte_notebook") ;
         dsDefault = context.GetDataStore("Default") ;
         IsMain = true;
         context.SetTheme("Modern");
      }

      public thardware_main( IGxContext context )
      {
         this.context = context;
         IsMain = false;
         dsDESARROLLO = context.GetDataStore("DESARROLLO") ;
         dssoporte_notebook = context.GetDataStore("soporte_notebook") ;
         dsDefault = context.GetDataStore("Default") ;
      }

      public void release( )
      {
      }

      public void execute( ref short aP0_HARDWARE_ID ,
                           ref String aP1_Gx_mode ,
                           ref String aP2_SISTEMA ,
                           ref String aP3_USUARIO )
      {
         this.AV12HARDWARE_ID = aP0_HARDWARE_ID;
         this.Gx_mode = aP1_Gx_mode;
         this.AV29SISTEMA = aP2_SISTEMA;
         this.AV30USUARIO = aP3_USUARIO;
         executePrivate();
         aP0_HARDWARE_ID=this.AV12HARDWARE_ID;
         aP1_Gx_mode=this.Gx_mode;
         aP2_SISTEMA=this.AV29SISTEMA;
         aP3_USUARIO=this.AV30USUARIO;
      }

      void executePrivate( )
      {
         isStatic = false;
         webExecute();
      }

      protected override void createObjects( )
      {
         cmbTH_DIREC = new GXCombobox();
         cmbACTIVO = new GXCombobox();
         radPRUEBA_MICROFONO_AUDIO = new GXRadio();
         dynRESPONSABLE_ARMADO_PC = new GXCombobox();
         cmbTIPO_DIR_IP = new GXCombobox();
         dynTHARDWARE_UBI = new GXCombobox();
         dynHARDWARE_RED = new GXCombobox();
         dynHARDWARE_UBA = new GXCombobox();
      }

      public override void webExecute( )
      {
         if ( initialized == 0 )
         {
            createObjects();
            initialize();
         }
         INITENV( ) ;
         INITTRN( ) ;
         if ( ( GxWebError == 0 ) && ! isAjaxCallMode( ) )
         {
            MasterPageObj = (GXMasterPage) ClassLoader.GetInstance("appmasterpage", "GeneXus.Programs.appmasterpage", new Object[] {new GxContext( context.handle, context.DataStores, context.HttpContext)});
            MasterPageObj.setDataArea(this,false);
            MasterPageObj.webExecute();
            if ( context.isAjaxRequest( ) )
            {
               enableOutput();
               if ( ! context.isAjaxRequest( ) )
               {
                  context.GX_webresponse.AppendHeader("Cache-Control", "max-age=0");
               }
               if ( String.IsNullOrEmpty(StringUtil.RTrim( context.wjLoc)) )
               {
                  context.GX_webresponse.AddString((String)(context.getJSONResponse( )));
               }
               else
               {
                  context.Redirect( context.wjLoc );
                  context.DispatchAjaxCommands();
               }
            }
         }
         this.cleanup();
      }

      protected void Draw( )
      {
         if ( context.isAjaxRequest( ) )
         {
            disableOutput();
         }
         if ( ! GxWebStd.gx_redirect( context) )
         {
            disable_std_buttons( ) ;
            enableDisable( ) ;
            set_caption( ) ;
            /* Form start */
            wb_table1_2_0N23( true) ;
         }
         return  ;
      }

      protected void wb_table1_2_0N23e( bool wbgen )
      {
         if ( wbgen )
         {
         }
         /* Execute Exit event if defined. */
      }

      protected void wb_table1_2_0N23( bool wbgen )
      {
         if ( wbgen )
         {
            /* Table start */
            sStyleString = "" ;
            GxWebStd.gx_table_start( context, tblTable1_Internalname, tblTable1_Internalname, "", "Table", 0, "", "", 1, 2, sStyleString, "", 0);
            context.WriteHtmlText( "<tbody>") ;
            context.WriteHtmlText( "<tr>") ;
            context.WriteHtmlText( "<td>") ;
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 5,'',false,'',0)\"" ;
            ClassString = "BtnFirst" ;
            StyleString = "" ;
            GxWebStd.gx_button_ctrl( context, context.GetButtonType( ), bttBtn_first_Internalname, "|<", "|<", "", StyleString, ClassString, bttBtn_first_Visible, 0, "rounded", 5, bttBtn_first_Jsonclick, "EFIRST.", TempTags, "", "", "HLP_THARDWARE_MAIN.htm");
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 6,'',false,'',0)\"" ;
            ClassString = "BtnPrevious" ;
            StyleString = "" ;
            GxWebStd.gx_button_ctrl( context, context.GetButtonType( ), bttBtn_previous_Internalname, "<", "<", "", StyleString, ClassString, bttBtn_previous_Visible, 0, "rounded", 5, bttBtn_previous_Jsonclick, "EPREVIOUS.", TempTags, "", "", "HLP_THARDWARE_MAIN.htm");
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 7,'',false,'',0)\"" ;
            ClassString = "BtnNext" ;
            StyleString = "" ;
            GxWebStd.gx_button_ctrl( context, context.GetButtonType( ), bttBtn_next_Internalname, ">", ">", "", StyleString, ClassString, bttBtn_next_Visible, 0, "rounded", 5, bttBtn_next_Jsonclick, "ENEXT.", TempTags, "", "", "HLP_THARDWARE_MAIN.htm");
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 8,'',false,'',0)\"" ;
            ClassString = "BtnLast" ;
            StyleString = "" ;
            GxWebStd.gx_button_ctrl( context, context.GetButtonType( ), bttBtn_last_Internalname, ">|", ">|", "", StyleString, ClassString, bttBtn_last_Visible, 0, "rounded", 5, bttBtn_last_Jsonclick, "ELAST.", TempTags, "", "", "HLP_THARDWARE_MAIN.htm");
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 9,'',false,'',0)\"" ;
            ClassString = "BtnSelect" ;
            StyleString = "" ;
            GxWebStd.gx_button_ctrl( context, 2, bttBtn_select_Internalname, "Seleccionar", "Seleccionar", "", StyleString, ClassString, bttBtn_select_Visible, 0, "rounded", 4, bttBtn_select_Jsonclick, "ESELECT.", TempTags, "", "gx.popup.openPrompt('"+"gx00n0.aspx"+"',["+"{Ctrl:gx.dom.el('"+"HARDWARE_ID"+"'), id:'"+"HARDWARE_ID"+"'"+",isOut:true,isKey:true,isLastKey:true}"+"],"+"null"+","+"'', false"+","+"true"+","+"false"+");"+"return false;", "HLP_THARDWARE_MAIN.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "<tr>") ;
            context.WriteHtmlText( "<td>") ;
            ClassString = "ErrorViewer" ;
            StyleString = "" ;
            GxWebStd.gx_msg_list( context, "", context.GX_msglist.DisplayMode, StyleString, ClassString, "", "false");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "<tr>") ;
            context.WriteHtmlText( "<td>") ;
            wb_table2_15_0N23( true) ;
         }
         return  ;
      }

      protected void wb_table2_15_0N23e( bool wbgen )
      {
         if ( wbgen )
         {
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "<tr>") ;
            context.WriteHtmlText( "<td>") ;
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 154,'',false,'',0)\"" ;
            ClassString = "BtnEnter" ;
            StyleString = "" ;
            GxWebStd.gx_button_ctrl( context, context.GetButtonType( ), bttBtn_enter_Internalname, "Confirmar", "Confirmar", "", StyleString, ClassString, bttBtn_enter_Visible, bttBtn_enter_Enabled, "rounded", 5, bttBtn_enter_Jsonclick, "EENTER.", TempTags, "", "", "HLP_THARDWARE_MAIN.htm");
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 155,'',false,'',0)\"" ;
            ClassString = "BtnCheck" ;
            StyleString = "" ;
            GxWebStd.gx_button_ctrl( context, context.GetButtonType( ), bttBtn_check_Internalname, "Verificar", "Verificar", "", StyleString, ClassString, bttBtn_check_Visible, bttBtn_check_Enabled, "rounded", 5, bttBtn_check_Jsonclick, "ECHECK.", TempTags, "", "", "HLP_THARDWARE_MAIN.htm");
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 156,'',false,'',0)\"" ;
            ClassString = "BtnCancel" ;
            StyleString = "" ;
            GxWebStd.gx_button_ctrl( context, context.GetButtonType( ), bttBtn_cancel_Internalname, "Cancelar", "Cancelar", "", StyleString, ClassString, bttBtn_cancel_Visible, 1, "rounded", 1, bttBtn_cancel_Jsonclick, "ECANCEL.", TempTags, "", "", "HLP_THARDWARE_MAIN.htm");
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 157,'',false,'',0)\"" ;
            ClassString = "BtnDelete" ;
            StyleString = "" ;
            GxWebStd.gx_button_ctrl( context, context.GetButtonType( ), bttBtn_delete_Internalname, "Eliminar", "Eliminar", "", StyleString, ClassString, bttBtn_delete_Visible, bttBtn_delete_Enabled, "rounded", 5, bttBtn_delete_Jsonclick, "EDELETE.", TempTags, "", "", "HLP_THARDWARE_MAIN.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "</tbody>") ;
            /* End of table */
            context.WriteHtmlText( "</table>") ;
            wb_table1_2_0N23e( true) ;
         }
         else
         {
            wb_table1_2_0N23e( false) ;
         }
      }

      protected void wb_table2_15_0N23( bool wbgen )
      {
         if ( wbgen )
         {
            /* Table start */
            sStyleString = "" ;
            GxWebStd.gx_table_start( context, tblTable2_Internalname, tblTable2_Internalname, "", "Table", 0, "", "", 1, 2, sStyleString, "", 0);
            context.WriteHtmlText( "<tbody>") ;
            context.WriteHtmlText( "<tr>") ;
            context.WriteHtmlText( "<td style=\"width:178px\">") ;
            /* Text block */
            ClassString = "TextBlock" ;
            StyleString = "" ;
            GxWebStd.gx_label_ctrl( context, lblTextblock1_Internalname, 1, 1, 0, "HARDWARE", "", "", "", 0, lblTextblock1_Jsonclick, "", StyleString, ClassString, "HLP_THARDWARE_MAIN.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "<td style=\"width:336px\">") ;
            /* Single line edit */
            ClassString = "Attribute" ;
            StyleString = "background:transparent" ;
            GxWebStd.gx_single_line_edit( context, edtHARDWARE_ID_Internalname, StringUtil.LTrim( StringUtil.NToC( (decimal)(A10HARDWARE_ID), 4, 0, ",", "")), "", 4, "chr", 1, "row", 4, 1, edtHARDWARE_ID_Enabled, 0, 0, 0, "", "", StyleString, ClassString, "", context.localUtil.Format( (decimal)(A10HARDWARE_ID), "ZZZ9"), "", 0, edtHARDWARE_ID_Jsonclick, "", 0, 1, 1, true, "right", "HLP_THARDWARE_MAIN.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "<tr>") ;
            context.WriteHtmlText( "<td>") ;
            context.WriteHtmlText( "DESCRIPCION ") ;
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "<td>") ;
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 24,'',false,'',0)\"" ;
            ClassString = "Attribute" ;
            StyleString = "" ;
            GxWebStd.gx_single_line_edit( context, edtHARDWARE_DESCRIPCION_Internalname, StringUtil.RTrim( A58HARDWARE_DESCRIPCION), "", 40, "chr", 1, "row", 40, 1, edtHARDWARE_DESCRIPCION_Enabled, 0, 0, 0, "", "", StyleString, ClassString, "", StringUtil.RTrim( context.localUtil.Format( A58HARDWARE_DESCRIPCION, "")), TempTags+" onchange=\"gx.evt.onchange(this)\" "+" onblur=\""+""+";gx.evt.onblur(24);\"", 0, edtHARDWARE_DESCRIPCION_Jsonclick, "", 0, 1, -1, true, "left", "HLP_THARDWARE_MAIN.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "<tr>") ;
            context.WriteHtmlText( "<td>") ;
            context.WriteHtmlText( "FECHA ALTA ") ;
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "<td>") ;
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 28,'',false,'',0)\"" ;
            ClassString = "Attribute" ;
            StyleString = "" ;
            context.WriteHtmlText( "<div id=\""+edtfecha_alta_Internalname+"_dp_container\" class=\"dp_container\" style=\"white-space:nowrap;display:inline;\">") ;
            GxWebStd.gx_single_line_edit( context, edtfecha_alta_Internalname, context.localUtil.Format(A182fecha_alta, "99/99/9999 99:99:99"), "", 19, "chr", 1, "row", 19, 1, edtfecha_alta_Enabled, 0, 0, 0, "", "", StyleString, ClassString, "", context.localUtil.Format( A182fecha_alta, "99/99/9999 99:99:99"), TempTags+" onchange=\"gx.evt.onchange(this)\" "+" onblur=\""+"gx.date.valid_date(this, 10,'DMY',8,24,'spa',false,0);"+";gx.evt.onblur(28);\"", 0, edtfecha_alta_Jsonclick, "", 0, 1, -1, true, "right", "HLP_THARDWARE_MAIN.htm");
            GxWebStd.gx_bitmap( context, edtfecha_alta_Internalname+"_dp_trigger", "", "calendar-img.gif", "", ((1==0)||(edtfecha_alta_Enabled==0) ? 0 : 1), 0, "Date selector", "Date selector", 0, 1, 0, "", 0, "", 0, 0, "", "", 0, "", "", "cursor: pointer;vertical-align:text-bottom", "", "", "", "", "", "HLP_THARDWARE_MAIN.htm");
            context.WriteHtmlTextNl( "</div>") ;
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "<tr>") ;
            context.WriteHtmlText( "<td>") ;
            /* Text block */
            ClassString = "TextBlock" ;
            StyleString = "" ;
            GxWebStd.gx_label_ctrl( context, lblTextblock3_Internalname, 1, 1, 0, "TIPO HARDWARE", "", "", "", 0, lblTextblock3_Jsonclick, "", StyleString, ClassString, "HLP_THARDWARE_MAIN.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "<td>") ;
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 33,'',false,'',0)\"" ;
            ClassString = "Attribute" ;
            StyleString = "" ;
            GxWebStd.gx_single_line_edit( context, edtTIPOS_DE_HARDWARE_ID_Internalname, StringUtil.LTrim( StringUtil.NToC( (decimal)(A181TIPOS_DE_HARDWARE_ID), 4, 0, ",", "")), "", 4, "chr", 1, "row", 4, 1, edtTIPOS_DE_HARDWARE_ID_Enabled, 0, 0, 0, "", "", StyleString, ClassString, "", context.localUtil.Format( (decimal)(A181TIPOS_DE_HARDWARE_ID), "ZZZ9"), TempTags+" onchange=\"gx.evt.onchange(this)\" "+" onblur=\""+"gx.num.valid_integer( this,'.');"+";gx.evt.onblur(33);\"", 0, edtTIPOS_DE_HARDWARE_ID_Jsonclick, "", 0, 1, -1, true, "right", "HLP_THARDWARE_MAIN.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "<tr>") ;
            context.WriteHtmlText( "<td>") ;
            /* Text block */
            ClassString = "TextBlock" ;
            StyleString = "" ;
            GxWebStd.gx_label_ctrl( context, lblTextblock4_Internalname, 1, 1, 0, "DESCRIPCION TIPO DE HARDWARE", "", "", "", 0, lblTextblock4_Jsonclick, "", StyleString, ClassString, "HLP_THARDWARE_MAIN.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "<td>") ;
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 38,'',false,'',0)\"" ;
            ClassString = "Attribute" ;
            StyleString = "" ;
            GxWebStd.gx_single_line_edit( context, edtNOMBRE_DEL_TIPO_DE_HD_Internalname, StringUtil.RTrim( A187NOMBRE_DEL_TIPO_DE_HD), "", 20, "chr", 1, "row", 20, 1, edtNOMBRE_DEL_TIPO_DE_HD_Enabled, 0, 0, 0, "", "", StyleString, ClassString, "", StringUtil.RTrim( context.localUtil.Format( A187NOMBRE_DEL_TIPO_DE_HD, "XXXXXXXXXXXXXXXXXXXX")), TempTags+" onchange=\"gx.evt.onchange(this)\" "+" onblur=\""+""+";gx.evt.onblur(38);\"", 0, edtNOMBRE_DEL_TIPO_DE_HD_Jsonclick, "", 0, 1, -1, true, "left", "HLP_THARDWARE_MAIN.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "<tr>") ;
            context.WriteHtmlText( "<td>") ;
            /* Text block */
            ClassString = "TextBlock" ;
            StyleString = "" ;
            GxWebStd.gx_label_ctrl( context, lblTextblock12_Internalname, 1, 1, 0, "DIRECCIONAMIENTO DEL TIPO DE HDW.", "", "", "", 0, lblTextblock12_Jsonclick, "", StyleString, ClassString, "HLP_THARDWARE_MAIN.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "<td>") ;
            ClassString = "Attribute" ;
            StyleString = "" ;
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 43,'',false,'',0)\"" ;
            /* ComboBox */
            GxWebStd.gx_combobox_ctrl1( context, cmbTH_DIREC, cmbTH_DIREC_Internalname, StringUtil.Str( (decimal)(A313TH_DIREC), 2, 0), "", "int", 1, cmbTH_DIREC.Enabled, 0, 1, 0, 2, "chr", 0, "", StyleString, ClassString, "", 0, cmbTH_DIREC_Jsonclick, "", TempTags+" onchange=\"gx.evt.onchange(this)\" "+" onblur=\""+""+";gx.evt.onblur(43);\"", true, "HLP_THARDWARE_MAIN.htm");
            cmbTH_DIREC.CurrentValue = StringUtil.Str( (decimal)(A313TH_DIREC), 2, 0) ;
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, cmbTH_DIREC_Internalname, "Values", (String)(cmbTH_DIREC.ToJavascriptSource()));
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "<tr>") ;
            context.WriteHtmlText( "<td>") ;
            /* Text block */
            ClassString = "TextBlock" ;
            StyleString = "" ;
            GxWebStd.gx_label_ctrl( context, lblTextblock7_Internalname, 1, 1, 0, "MODELO ID", "", "", "", 0, lblTextblock7_Jsonclick, "", StyleString, ClassString, "HLP_THARDWARE_MAIN.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "<td>") ;
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 48,'',false,'',0)\"" ;
            ClassString = "Attribute" ;
            StyleString = "" ;
            GxWebStd.gx_single_line_edit( context, edtMODELO_DE_COMPONENTES_ID_Internalname, StringUtil.LTrim( StringUtil.NToC( (decimal)(A183MODELO_DE_COMPONENTES_ID), 4, 0, ",", "")), "", 4, "chr", 1, "row", 4, 1, edtMODELO_DE_COMPONENTES_ID_Enabled, 0, 0, 0, "", "", StyleString, ClassString, "", context.localUtil.Format( (decimal)(A183MODELO_DE_COMPONENTES_ID), "ZZZ9"), TempTags+" onchange=\"gx.evt.onchange(this)\" "+" onblur=\""+"gx.num.valid_integer( this,'.');"+";gx.evt.onblur(48);\"", 0, edtMODELO_DE_COMPONENTES_ID_Jsonclick, "", 0, 1, -1, true, "right", "HLP_THARDWARE_MAIN.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "<tr>") ;
            context.WriteHtmlText( "<td>") ;
            /* Text block */
            ClassString = "TextBlock" ;
            StyleString = "" ;
            GxWebStd.gx_label_ctrl( context, lblTextblock8_Internalname, 1, 1, 0, "DESCRIPCION MODELO", "", "", "", 0, lblTextblock8_Jsonclick, "", StyleString, ClassString, "HLP_THARDWARE_MAIN.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "<td>") ;
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 53,'',false,'',0)\"" ;
            ClassString = "Attribute" ;
            StyleString = "" ;
            GxWebStd.gx_single_line_edit( context, edtMODELO_DE_COMPONENTES_NOMBRE_Internalname, StringUtil.RTrim( A188MODELO_DE_COMPONENTES_NOMBRE), "", 20, "chr", 1, "row", 20, 1, edtMODELO_DE_COMPONENTES_NOMBRE_Enabled, 0, 0, 0, "", "", StyleString, ClassString, "", StringUtil.RTrim( context.localUtil.Format( A188MODELO_DE_COMPONENTES_NOMBRE, "XXXXXXXXXXXXXXXXXXXX")), TempTags+" onchange=\"gx.evt.onchange(this)\" "+" onblur=\""+""+";gx.evt.onblur(53);\"", 0, edtMODELO_DE_COMPONENTES_NOMBRE_Jsonclick, "", 0, 1, -1, true, "left", "HLP_THARDWARE_MAIN.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "<tr>") ;
            context.WriteHtmlText( "<td>") ;
            /* Text block */
            ClassString = "TextBlock" ;
            StyleString = "" ;
            GxWebStd.gx_label_ctrl( context, lblTextblock5_Internalname, 1, 1, 0, "MARCA ID", "", "", "", 0, lblTextblock5_Jsonclick, "", StyleString, ClassString, "HLP_THARDWARE_MAIN.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "<td>") ;
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 58,'',false,'',0)\"" ;
            ClassString = "Attribute" ;
            StyleString = "" ;
            GxWebStd.gx_single_line_edit( context, edtMARCAS_ID_Internalname, StringUtil.LTrim( StringUtil.NToC( (decimal)(A189MARCAS_ID), 4, 0, ",", "")), "", 4, "chr", 1, "row", 4, 1, edtMARCAS_ID_Enabled, 0, 0, 0, "", "", StyleString, ClassString, "", context.localUtil.Format( (decimal)(A189MARCAS_ID), "ZZZ9"), TempTags+" onchange=\"gx.evt.onchange(this)\" "+" onblur=\""+"gx.num.valid_integer( this,'.');"+";gx.evt.onblur(58);\"", 0, edtMARCAS_ID_Jsonclick, "", 0, 1, -1, true, "right", "HLP_THARDWARE_MAIN.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "<tr>") ;
            context.WriteHtmlText( "<td>") ;
            /* Text block */
            ClassString = "TextBlock" ;
            StyleString = "" ;
            GxWebStd.gx_label_ctrl( context, lblTextblock6_Internalname, 1, 1, 0, "DESCRIPCION MARCA", "", "", "", 0, lblTextblock6_Jsonclick, "", StyleString, ClassString, "HLP_THARDWARE_MAIN.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "<td>") ;
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 63,'',false,'',0)\"" ;
            ClassString = "Attribute" ;
            StyleString = "" ;
            GxWebStd.gx_single_line_edit( context, edtMARCAS_DESCRIPCION_Internalname, StringUtil.RTrim( A190MARCAS_DESCRIPCION), "", 20, "chr", 1, "row", 20, 1, edtMARCAS_DESCRIPCION_Enabled, 0, 0, 0, "", "", StyleString, ClassString, "", StringUtil.RTrim( context.localUtil.Format( A190MARCAS_DESCRIPCION, "XXXXXXXXXXXXXXXXXXXX")), TempTags+" onchange=\"gx.evt.onchange(this)\" "+" onblur=\""+""+";gx.evt.onblur(63);\"", 0, edtMARCAS_DESCRIPCION_Jsonclick, "", 0, 1, -1, true, "left", "HLP_THARDWARE_MAIN.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "<tr>") ;
            context.WriteHtmlText( "<td>") ;
            /* Text block */
            ClassString = "TextBlock" ;
            StyleString = "" ;
            GxWebStd.gx_label_ctrl( context, lblTextblock9_Internalname, 1, 1, 0, "NRO BIEN HARDWARE", "", "", "", 0, lblTextblock9_Jsonclick, "", StyleString, ClassString, "HLP_THARDWARE_MAIN.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "<td>") ;
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 68,'',false,'',0)\"" ;
            ClassString = "Attribute" ;
            StyleString = "" ;
            GxWebStd.gx_single_line_edit( context, edtHARDWARE_NRO_BIEN_Internalname, StringUtil.LTrim( StringUtil.NToC( (decimal)(A184HARDWARE_NRO_BIEN), 10, 0, ",", "")), "", 10, "chr", 1, "row", 10, 1, edtHARDWARE_NRO_BIEN_Enabled, 0, 0, 0, "", "", StyleString, ClassString, "", context.localUtil.Format( (decimal)(A184HARDWARE_NRO_BIEN), "ZZZZZZZZZ9"), TempTags+" onchange=\"gx.evt.onchange(this)\" "+" onblur=\""+"gx.num.valid_integer( this,'.');"+";gx.evt.onblur(68);\"", 0, edtHARDWARE_NRO_BIEN_Jsonclick, "", 0, 1, -1, true, "right", "HLP_THARDWARE_MAIN.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "<tr>") ;
            context.WriteHtmlText( "<td style=\"height:21px\">") ;
            /* Text block */
            ClassString = "TextBlock" ;
            StyleString = "" ;
            GxWebStd.gx_label_ctrl( context, lblTextblock10_Internalname, 1, 1, 0, "NRO SERIE HARDWARE", "", "", "", 0, lblTextblock10_Jsonclick, "", StyleString, ClassString, "HLP_THARDWARE_MAIN.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "<td>") ;
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 73,'',false,'',0)\"" ;
            ClassString = "Attribute" ;
            StyleString = "" ;
            GxWebStd.gx_single_line_edit( context, edtHARDWARE_NRO_SERIE_Internalname, StringUtil.RTrim( A9HARDWARE_NRO_SERIE), "", 20, "chr", 1, "row", 20, 1, edtHARDWARE_NRO_SERIE_Enabled, 0, 0, 0, "", "", StyleString, ClassString, "", StringUtil.RTrim( context.localUtil.Format( A9HARDWARE_NRO_SERIE, "")), TempTags+" onchange=\"gx.evt.onchange(this)\" "+" onblur=\""+""+";gx.evt.onblur(73);\"", 0, edtHARDWARE_NRO_SERIE_Jsonclick, "", 0, 1, -1, true, "left", "HLP_THARDWARE_MAIN.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "<tr>") ;
            context.WriteHtmlText( "<td style=\"height:21px\">") ;
            context.WriteHtmlText( "ACTIVO ") ;
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "<td>") ;
            ClassString = "Attribute" ;
            StyleString = "" ;
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 77,'',false,'',0)\"" ;
            /* ComboBox */
            GxWebStd.gx_combobox_ctrl1( context, cmbACTIVO, cmbACTIVO_Internalname, A185ACTIVO, "", "char", 1, cmbACTIVO.Enabled, 0, 1, 0, 2, "chr", 0, "", StyleString, ClassString, "", 0, cmbACTIVO_Jsonclick, "", TempTags+" onchange=\"gx.evt.onchange(this)\" "+" onblur=\""+""+";gx.evt.onblur(77);\"", true, "HLP_THARDWARE_MAIN.htm");
            cmbACTIVO.CurrentValue = A185ACTIVO ;
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, cmbACTIVO_Internalname, "Values", (String)(cmbACTIVO.ToJavascriptSource()));
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "<tr>") ;
            context.WriteHtmlText( "<td>") ;
            context.WriteHtmlText( "FECHA BAJA ") ;
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "<td>") ;
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 81,'',false,'',0)\"" ;
            ClassString = "Attribute" ;
            StyleString = "" ;
            context.WriteHtmlText( "<div id=\""+edtfecha_baja_Internalname+"_dp_container\" class=\"dp_container\" style=\"white-space:nowrap;display:inline;\">") ;
            GxWebStd.gx_single_line_edit( context, edtfecha_baja_Internalname, context.localUtil.Format(A186fecha_baja, "99/99/9999 99:99:99"), "", 19, "chr", 1, "row", 19, 1, edtfecha_baja_Enabled, 0, 0, 0, "", "", StyleString, ClassString, "", context.localUtil.Format( A186fecha_baja, "99/99/9999 99:99:99"), TempTags+" onchange=\"gx.evt.onchange(this)\" "+" onblur=\""+"gx.date.valid_date(this, 10,'DMY',8,24,'spa',false,0);"+";gx.evt.onblur(81);\"", 0, edtfecha_baja_Jsonclick, "", 0, 1, -1, true, "right", "HLP_THARDWARE_MAIN.htm");
            GxWebStd.gx_bitmap( context, edtfecha_baja_Internalname+"_dp_trigger", "", "calendar-img.gif", "", ((1==0)||(edtfecha_baja_Enabled==0) ? 0 : 1), 0, "Date selector", "Date selector", 0, 1, 0, "", 0, "", 0, 0, "", "", 0, "", "", "cursor: pointer;vertical-align:text-bottom", "", "", "", "", "", "HLP_THARDWARE_MAIN.htm");
            context.WriteHtmlTextNl( "</div>") ;
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "<tr>") ;
            context.WriteHtmlText( "<td style=\"height:15px\">") ;
            /* Text block */
            ClassString = "TextBlock" ;
            StyleString = "" ;
            GxWebStd.gx_label_ctrl( context, lblTextblock2_Internalname, 1, 1, 0, "PRUEBA MICRÓFONO Y AUDIO", "", "", "", 0, lblTextblock2_Jsonclick, "", StyleString, ClassString, "HLP_THARDWARE_MAIN.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "<td>") ;
            /* Radio button */
            ClassString = "Attribute" ;
            StyleString = "" ;
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 86,'',false,'',0)\"" ;
            GxWebStd.gx_radio_ctrl( context, radPRUEBA_MICROFONO_AUDIO, radPRUEBA_MICROFONO_AUDIO_Internalname, A192PRUEBA_MICROFONO_AUDIO, "", 1, radPRUEBA_MICROFONO_AUDIO.Enabled, 0, 0, StyleString, ClassString, 0, radPRUEBA_MICROFONO_AUDIO_Jsonclick, "", TempTags+" onclick=\"gx.evt.onchange(this);\" "+" onblur=\""+""+";gx.evt.onblur(86);\"", "HLP_THARDWARE_MAIN.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "<tr>") ;
            context.WriteHtmlText( "<td style=\"height:15px\">") ;
            /* Text block */
            ClassString = "TextBlock" ;
            StyleString = "" ;
            GxWebStd.gx_label_ctrl( context, lblTextblock11_Internalname, 1, 1, 0, "RESPONSABLE ARMADO DE PC", "", "", "", 0, lblTextblock11_Jsonclick, "", StyleString, ClassString, "HLP_THARDWARE_MAIN.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "<td>") ;
            ClassString = "Attribute" ;
            StyleString = "" ;
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 91,'',false,'',0)\"" ;
            /* ComboBox */
            GxWebStd.gx_combobox_ctrl1( context, dynRESPONSABLE_ARMADO_PC, dynRESPONSABLE_ARMADO_PC_Internalname, A193RESPONSABLE_ARMADO_PC, "", "char", 1, dynRESPONSABLE_ARMADO_PC.Enabled, 0, 1, 0, 50, "chr", 0, "", StyleString, ClassString, "", 0, dynRESPONSABLE_ARMADO_PC_Jsonclick, "", TempTags+" onchange=\"gx.evt.onchange(this)\" "+" onblur=\""+""+";gx.evt.onblur(91);\"", true, "HLP_THARDWARE_MAIN.htm");
            dynRESPONSABLE_ARMADO_PC.CurrentValue = A193RESPONSABLE_ARMADO_PC ;
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, dynRESPONSABLE_ARMADO_PC_Internalname, "Values", (String)(dynRESPONSABLE_ARMADO_PC.ToJavascriptSource()));
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "<tr>") ;
            context.WriteHtmlText( "<td>") ;
            /* Text block */
            ClassString = "TextBlock" ;
            StyleString = "" ;
            GxWebStd.gx_label_ctrl( context, lblTextblock13_Internalname, 1, 1, 0, "TIPO DRI. IP", "", "", "", 0, lblTextblock13_Jsonclick, "", StyleString, ClassString, "HLP_THARDWARE_MAIN.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "<td>") ;
            ClassString = "Attribute" ;
            StyleString = "" ;
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 96,'',false,'',0)\"" ;
            /* ComboBox */
            GxWebStd.gx_combobox_ctrl1( context, cmbTIPO_DIR_IP, cmbTIPO_DIR_IP_Internalname, StringUtil.Str( (decimal)(A299TIPO_DIR_IP), 2, 0), "", "int", 1, cmbTIPO_DIR_IP.Enabled, 1, 1, 0, 2, "chr", 0, "", StyleString, ClassString, "", 0, cmbTIPO_DIR_IP_Jsonclick, "", TempTags+" onchange=\"gx.evt.onchange(this)\" "+" onblur=\""+""+";gx.evt.onblur(96);\"", true, "HLP_THARDWARE_MAIN.htm");
            cmbTIPO_DIR_IP.CurrentValue = StringUtil.Str( (decimal)(A299TIPO_DIR_IP), 2, 0) ;
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, cmbTIPO_DIR_IP_Internalname, "Values", (String)(cmbTIPO_DIR_IP.ToJavascriptSource()));
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "<tr>") ;
            context.WriteHtmlText( "<td>") ;
            /* Text block */
            ClassString = "TextBlock" ;
            StyleString = "" ;
            GxWebStd.gx_label_ctrl( context, lblTextblock15_Internalname, 1, 1, 0, "UBICACIÓN DE RED", "", "", "", 0, lblTextblock15_Jsonclick, "", StyleString, ClassString, "HLP_THARDWARE_MAIN.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "<td>") ;
            ClassString = "Attribute" ;
            StyleString = "" ;
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 101,'',false,'',0)\"" ;
            /* ComboBox */
            GxWebStd.gx_combobox_ctrl1( context, dynTHARDWARE_UBI, dynTHARDWARE_UBI_Internalname, StringUtil.Str( (decimal)(A194THARDWARE_UBI), 10, 0), "", "int", 1, dynTHARDWARE_UBI.Enabled, 1, 1, 0, 30, "chr", 0, "", StyleString, ClassString, "", 0, dynTHARDWARE_UBI_Jsonclick, "", TempTags+" onchange=\"gx.evt.onchange(this)\" "+" onblur=\""+""+";gx.evt.onblur(101);\"", true, "HLP_THARDWARE_MAIN.htm");
            dynTHARDWARE_UBI.CurrentValue = StringUtil.Str( (decimal)(A194THARDWARE_UBI), 10, 0) ;
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, dynTHARDWARE_UBI_Internalname, "Values", (String)(dynTHARDWARE_UBI.ToJavascriptSource()));
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "<tr>") ;
            context.WriteHtmlText( "<td>") ;
            /* Text block */
            ClassString = "TextBlock" ;
            StyleString = "" ;
            GxWebStd.gx_label_ctrl( context, lblTextblock16_Internalname, 1, 1, 0, "RED", "", "", "", 0, lblTextblock16_Jsonclick, "", StyleString, ClassString, "HLP_THARDWARE_MAIN.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "<td>") ;
            ClassString = "Attribute" ;
            StyleString = "" ;
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 106,'',false,'',0)\"" ;
            /* ComboBox */
            GxWebStd.gx_combobox_ctrl1( context, dynHARDWARE_RED, dynHARDWARE_RED_Internalname, StringUtil.Str( (decimal)(A311HARDWARE_RED), 10, 0), "", "int", 1, dynHARDWARE_RED.Enabled, 1, 1, 0, 30, "chr", 0, "", StyleString, ClassString, "", 0, dynHARDWARE_RED_Jsonclick, "", TempTags+" onchange=\"gx.evt.onchange(this)\" "+" onblur=\""+""+";gx.evt.onblur(106);\"", true, "HLP_THARDWARE_MAIN.htm");
            dynHARDWARE_RED.CurrentValue = StringUtil.Str( (decimal)(A311HARDWARE_RED), 10, 0) ;
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, dynHARDWARE_RED_Internalname, "Values", (String)(dynHARDWARE_RED.ToJavascriptSource()));
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "<tr>") ;
            context.WriteHtmlText( "<td>") ;
            /* Text block */
            ClassString = "TextBlock" ;
            StyleString = "" ;
            GxWebStd.gx_label_ctrl( context, lblTextblock17_Internalname, 1, 1, 0, "DIRECCIÓN IP DESDE", "", "", "", 0, lblTextblock17_Jsonclick, "", StyleString, ClassString, "HLP_THARDWARE_MAIN.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "<td>") ;
            /* Single line edit */
            ClassString = "Attribute" ;
            StyleString = "" ;
            GxWebStd.gx_single_line_edit( context, edtavRed_direcciondesde_Internalname, StringUtil.RTrim( AV15Red_DireccionDesde), "", 15, "chr", 1, "row", 15, 1, edtavRed_direcciondesde_Enabled, 0, 0, 0, "", "", StyleString, ClassString, "", StringUtil.RTrim( context.localUtil.Format( AV15Red_DireccionDesde, "XXXXXXXXXXXXXXX")), "", 0, edtavRed_direcciondesde_Jsonclick, "", 0, 1, -1, true, "left", "HLP_THARDWARE_MAIN.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "<tr>") ;
            context.WriteHtmlText( "<td>") ;
            /* Text block */
            ClassString = "TextBlock" ;
            StyleString = "" ;
            GxWebStd.gx_label_ctrl( context, lblTextblock18_Internalname, 1, 1, 0, "DIRECCIÓN IP HASTA", "", "", "", 0, lblTextblock18_Jsonclick, "", StyleString, ClassString, "HLP_THARDWARE_MAIN.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "<td>") ;
            /* Single line edit */
            ClassString = "Attribute" ;
            StyleString = "" ;
            GxWebStd.gx_single_line_edit( context, edtavRed_direccionhasta_Internalname, StringUtil.RTrim( AV19Red_DireccionHasta), "", 15, "chr", 1, "row", 15, 1, edtavRed_direccionhasta_Enabled, 0, 0, 0, "", "", StyleString, ClassString, "", StringUtil.RTrim( context.localUtil.Format( AV19Red_DireccionHasta, "XXXXXXXXXXXXXXX")), "", 0, edtavRed_direccionhasta_Jsonclick, "", 0, 1, -1, true, "left", "HLP_THARDWARE_MAIN.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "<tr>") ;
            context.WriteHtmlText( "<td>") ;
            /* Text block */
            ClassString = "TextBlock" ;
            StyleString = "" ;
            GxWebStd.gx_label_ctrl( context, lblTextblock19_Internalname, 1, 1, 0, "MÁSCARA DE RED", "", "", "", 0, lblTextblock19_Jsonclick, "", StyleString, ClassString, "HLP_THARDWARE_MAIN.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "<td>") ;
            /* Single line edit */
            ClassString = "Attribute" ;
            StyleString = "" ;
            GxWebStd.gx_single_line_edit( context, edtavRed_mascara_Internalname, StringUtil.RTrim( AV20Red_Mascara), "", 15, "chr", 1, "row", 15, 1, edtavRed_mascara_Enabled, 0, 0, 0, "", "", StyleString, ClassString, "", StringUtil.RTrim( context.localUtil.Format( AV20Red_Mascara, "XXXXXXXXXXXXXXX")), "", 0, edtavRed_mascara_Jsonclick, "", 0, 1, -1, true, "left", "HLP_THARDWARE_MAIN.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "<tr>") ;
            context.WriteHtmlText( "<td>") ;
            /* Text block */
            ClassString = "TextBlock" ;
            StyleString = "" ;
            GxWebStd.gx_label_ctrl( context, lblTextblock20_Internalname, 1, 1, 0, "PUERTA DE ENLACE", "", "", "", 0, lblTextblock20_Jsonclick, "", StyleString, ClassString, "HLP_THARDWARE_MAIN.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "<td>") ;
            /* Single line edit */
            ClassString = "Attribute" ;
            StyleString = "" ;
            GxWebStd.gx_single_line_edit( context, edtavRed_puertaenlace_Internalname, StringUtil.RTrim( AV21Red_PuertaEnlace), "", 15, "chr", 1, "row", 15, 1, edtavRed_puertaenlace_Enabled, 0, 0, 0, "", "", StyleString, ClassString, "", StringUtil.RTrim( context.localUtil.Format( AV21Red_PuertaEnlace, "XXXXXXXXXXXXXXX")), "", 0, edtavRed_puertaenlace_Jsonclick, "", 0, 1, -1, true, "left", "HLP_THARDWARE_MAIN.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "<tr>") ;
            context.WriteHtmlText( "<td>") ;
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "<td>") ;
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "<tr>") ;
            context.WriteHtmlText( "<td>") ;
            /* Text block */
            ClassString = "TextBlock" ;
            StyleString = "" ;
            GxWebStd.gx_label_ctrl( context, lblTextblock14_Internalname, 1, 1, 0, "DIRECCIÓN IP", "", "", "", 0, lblTextblock14_Jsonclick, "", StyleString, ClassString, "HLP_THARDWARE_MAIN.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "<td>") ;
            /* Single line edit */
            ClassString = "Attribute" ;
            StyleString = "" ;
            GxWebStd.gx_single_line_edit( context, edtavRed_direcciondesdeb1_Internalname, StringUtil.LTrim( StringUtil.NToC( (decimal)(AV16Red_DireccionDesdeB1), 3, 0, ",", "")), "", 3, "chr", 1, "row", 3, 1, edtavRed_direcciondesdeb1_Enabled, 0, 0, 0, "", "", StyleString, ClassString, "", context.localUtil.Format( (decimal)(AV16Red_DireccionDesdeB1), "ZZ9"), "", 0, edtavRed_direcciondesdeb1_Jsonclick, "", 0, 1, -1, true, "right", "HLP_THARDWARE_MAIN.htm");
            context.WriteHtmlText( ".") ;
            /* Single line edit */
            ClassString = "Attribute" ;
            StyleString = "" ;
            GxWebStd.gx_single_line_edit( context, edtavRed_direcciondesdeb2_Internalname, StringUtil.LTrim( StringUtil.NToC( (decimal)(AV17Red_DireccionDesdeB2), 3, 0, ",", "")), "", 3, "chr", 1, "row", 3, 1, edtavRed_direcciondesdeb2_Enabled, 0, 0, 0, "", "", StyleString, ClassString, "", context.localUtil.Format( (decimal)(AV17Red_DireccionDesdeB2), "ZZ9"), "", 0, edtavRed_direcciondesdeb2_Jsonclick, "", 0, 1, -1, true, "right", "HLP_THARDWARE_MAIN.htm");
            context.WriteHtmlText( ".") ;
            /* Single line edit */
            ClassString = "Attribute" ;
            StyleString = "" ;
            GxWebStd.gx_single_line_edit( context, edtavRed_direcciondesdeb3_Internalname, StringUtil.LTrim( StringUtil.NToC( (decimal)(AV18Red_DireccionDesdeB3), 3, 0, ",", "")), "", 3, "chr", 1, "row", 3, 1, edtavRed_direcciondesdeb3_Enabled, 0, 0, 0, "", "", StyleString, ClassString, "", context.localUtil.Format( (decimal)(AV18Red_DireccionDesdeB3), "ZZ9"), "", 0, edtavRed_direcciondesdeb3_Jsonclick, "", 0, 1, -1, true, "right", "HLP_THARDWARE_MAIN.htm");
            context.WriteHtmlText( ".") ;
            /* Single line edit */
            ClassString = "Attribute" ;
            StyleString = "" ;
            GxWebStd.gx_single_line_edit( context, edtHARDWARE_IP_Internalname, StringUtil.LTrim( StringUtil.NToC( (decimal)(A312HARDWARE_IP), 3, 0, ",", "")), "", 3, "chr", 1, "row", 3, 1, edtHARDWARE_IP_Enabled, 0, 0, 0, "", "", StyleString, ClassString, "", context.localUtil.Format( (decimal)(A312HARDWARE_IP), "ZZ9"), "", 0, edtHARDWARE_IP_Jsonclick, "", 0, 1, -1, true, "right", "HLP_THARDWARE_MAIN.htm");
            context.WriteHtmlText( "&nbsp; ") ;
            /* Active images/pictures */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 138,'',false,'',0)\"" ;
            ClassString = "Image" ;
            StyleString = "" ;
            GxWebStd.gx_bitmap( context, imgPrompt1_Internalname, "", context.GetImagePath( "d7b24a73-cf93-7b40-b367-44c13e5748f9", "", "Modern"), "Modern", imgPrompt1_Visible, 1, "", "", 0, 0, 0, "", 0, "", 0, 0, "", "", 7, imgPrompt1_Jsonclick, "'"+""+"'"+",false,"+"'"+"e110n23_client"+"'", StyleString, ClassString, "", ""+TempTags, "", "", "HLP_THARDWARE_MAIN.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "<tr>") ;
            context.WriteHtmlText( "<td>") ;
            /* Text block */
            ClassString = "TextBlock" ;
            StyleString = "" ;
            GxWebStd.gx_label_ctrl( context, lblTextblock21_Internalname, 1, 1, 0, "UBICACIÓN AUXILIAR", "", "", "", 0, lblTextblock21_Jsonclick, "", StyleString, ClassString, "HLP_THARDWARE_MAIN.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "<td>") ;
            ClassString = "Attribute" ;
            StyleString = "" ;
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 143,'',false,'',0)\"" ;
            /* ComboBox */
            GxWebStd.gx_combobox_ctrl1( context, dynHARDWARE_UBA, dynHARDWARE_UBA_Internalname, StringUtil.Str( (decimal)(A314HARDWARE_UBA), 10, 0), "", "int", 1, dynHARDWARE_UBA.Enabled, 0, 1, 0, 30, "chr", 0, "", StyleString, ClassString, "", 0, dynHARDWARE_UBA_Jsonclick, "", TempTags+" onchange=\"gx.evt.onchange(this)\" "+" onblur=\""+""+";gx.evt.onblur(143);\"", true, "HLP_THARDWARE_MAIN.htm");
            dynHARDWARE_UBA.CurrentValue = StringUtil.Str( (decimal)(A314HARDWARE_UBA), 10, 0) ;
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, dynHARDWARE_UBA_Internalname, "Values", (String)(dynHARDWARE_UBA.ToJavascriptSource()));
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "<tr>") ;
            context.WriteHtmlText( "<td>") ;
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "<td>") ;
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "<tr>") ;
            context.WriteHtmlText( "<td>") ;
            /* Text block */
            ClassString = "TextBlock" ;
            StyleString = "" ;
            GxWebStd.gx_label_ctrl( context, lblTxt_trazabilidad_Internalname, 1, 1, 0, "ASOCIAR A TRAZABILIDAD", "", "", "", 0, lblTxt_trazabilidad_Jsonclick, "", StyleString, ClassString, "HLP_THARDWARE_MAIN.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "<td>") ;
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 151,'',false,'',0)\"" ;
            ClassString = "Attribute" ;
            StyleString = "" ;
            GxWebStd.gx_single_line_edit( context, edtHDW_IDT_Internalname, StringUtil.LTrim( StringUtil.NToC( (decimal)(A104HDW_IDT), 8, 0, ",", "")), "", 8, "chr", 1, "row", 8, 1, edtHDW_IDT_Enabled, 0, 0, 0, "", "", StyleString, ClassString, "", context.localUtil.Format( (decimal)(A104HDW_IDT), "ZZZZZZZ9"), TempTags+" onchange=\"gx.evt.onchange(this)\" "+" onblur=\""+"gx.num.valid_integer( this,'.');"+";gx.evt.onblur(151);\"", 0, edtHDW_IDT_Jsonclick, "", 0, 1, -1, true, "right", "HLP_THARDWARE_MAIN.htm");
            /* Static images/pictures */
            ClassString = "Image" ;
            StyleString = "" ;
            GxWebStd.gx_bitmap( context, imgprompt_104_Internalname, "", "prompt.gif", "Modern", imgprompt_104_Visible, 1, "", "", 0, 0, 0, "", 0, "", 0, 0, imgprompt_104_Link, "", 0, "", "", StyleString, ClassString, "", "", "''", "", "HLP_THARDWARE_MAIN.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "</tbody>") ;
            /* End of table */
            context.WriteHtmlText( "</table>") ;
            wb_table2_15_0N23e( true) ;
         }
         else
         {
            wb_table2_15_0N23e( false) ;
         }
      }

      protected void UserMain( )
      {
         standaloneStartup( ) ;
      }

      protected void standaloneStartup( )
      {
         standaloneStartupServer( ) ;
         disable_std_buttons( ) ;
         enableDisable( ) ;
         Process( ) ;
      }

      protected void standaloneStartupServer( )
      {
         /* Execute Start event if defined. */
         context.wbGlbDoneStart = 0 ;
         /* Execute user event: E120N2 */
         E120N2 ();
         context.wbGlbDoneStart = 1 ;
         assign_properties_default( ) ;
         if ( AnyError == 0 )
         {
            if ( StringUtil.StrCmp(context.GetRequestMethod( ), "POST") == 0 )
            {
               /* Read saved SDTs. */
               /* Read variables values. */
               A10HARDWARE_ID = (short)(context.localUtil.CToN( cgiGet( edtHARDWARE_ID_Internalname), ",", ".")) ;
               n10HARDWARE_ID = false ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A10HARDWARE_ID", StringUtil.LTrim( StringUtil.Str( (decimal)(A10HARDWARE_ID), 4, 0)));
               A58HARDWARE_DESCRIPCION = cgiGet( edtHARDWARE_DESCRIPCION_Internalname) ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A58HARDWARE_DESCRIPCION", A58HARDWARE_DESCRIPCION);
               if ( context.localUtil.VCDateTime( cgiGet( edtfecha_alta_Internalname), 4, 0) == 0 )
               {
                  GX_msglist.addItem(context.GetMessage( "GXM_baddatetime", new   object[]  {"fecha_alta"}), 1, "FECHA_ALTA");
                  AnyError = 1 ;
                  GX_FocusControl = edtfecha_alta_Internalname ;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
                  wbErr = true ;
                  A182fecha_alta = (DateTime)(DateTime.MinValue) ;
                  n182fecha_alta = false ;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A182fecha_alta", context.localUtil.TToC( A182fecha_alta, 10, 8, 0, 3, "/", ":", " "));
               }
               else
               {
                  A182fecha_alta = context.localUtil.CToT( cgiGet( edtfecha_alta_Internalname)) ;
                  n182fecha_alta = false ;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A182fecha_alta", context.localUtil.TToC( A182fecha_alta, 10, 8, 0, 3, "/", ":", " "));
               }
               n182fecha_alta = ((DateTime.MinValue==A182fecha_alta) ? true : false) ;
               if ( ! context.localUtil.VCNumber( cgiGet( edtTIPOS_DE_HARDWARE_ID_Internalname), "ZZZ9") || ( context.localUtil.CToN( cgiGet( edtTIPOS_DE_HARDWARE_ID_Internalname), ",", ".") < Convert.ToDecimal( 0 )) || ( ( context.localUtil.CToN( cgiGet( edtTIPOS_DE_HARDWARE_ID_Internalname), ",", ".") > Convert.ToDecimal( 9999 )) ) )
               {
                  GX_msglist.addItem(context.GetMessage( "GXM_badnum"), 1, "TIPOS_DE_HARDWARE_ID");
                  AnyError = 1 ;
                  GX_FocusControl = edtTIPOS_DE_HARDWARE_ID_Internalname ;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
                  wbErr = true ;
                  A181TIPOS_DE_HARDWARE_ID = 0 ;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A181TIPOS_DE_HARDWARE_ID", StringUtil.LTrim( StringUtil.Str( (decimal)(A181TIPOS_DE_HARDWARE_ID), 4, 0)));
               }
               else
               {
                  A181TIPOS_DE_HARDWARE_ID = (short)(context.localUtil.CToN( cgiGet( edtTIPOS_DE_HARDWARE_ID_Internalname), ",", ".")) ;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A181TIPOS_DE_HARDWARE_ID", StringUtil.LTrim( StringUtil.Str( (decimal)(A181TIPOS_DE_HARDWARE_ID), 4, 0)));
               }
               A187NOMBRE_DEL_TIPO_DE_HD = cgiGet( edtNOMBRE_DEL_TIPO_DE_HD_Internalname) ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A187NOMBRE_DEL_TIPO_DE_HD", A187NOMBRE_DEL_TIPO_DE_HD);
               cmbTH_DIREC.CurrentValue = cgiGet( cmbTH_DIREC_Internalname) ;
               A313TH_DIREC = (short)(NumberUtil.Val( cgiGet( cmbTH_DIREC_Internalname), ".")) ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A313TH_DIREC", StringUtil.LTrim( StringUtil.Str( (decimal)(A313TH_DIREC), 2, 0)));
               if ( ! context.localUtil.VCNumber( cgiGet( edtMODELO_DE_COMPONENTES_ID_Internalname), "ZZZ9") || ( context.localUtil.CToN( cgiGet( edtMODELO_DE_COMPONENTES_ID_Internalname), ",", ".") < Convert.ToDecimal( 0 )) || ( ( context.localUtil.CToN( cgiGet( edtMODELO_DE_COMPONENTES_ID_Internalname), ",", ".") > Convert.ToDecimal( 9999 )) ) )
               {
                  GX_msglist.addItem(context.GetMessage( "GXM_badnum"), 1, "MODELO_DE_COMPONENTES_ID");
                  AnyError = 1 ;
                  GX_FocusControl = edtMODELO_DE_COMPONENTES_ID_Internalname ;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
                  wbErr = true ;
                  A183MODELO_DE_COMPONENTES_ID = 0 ;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A183MODELO_DE_COMPONENTES_ID", StringUtil.LTrim( StringUtil.Str( (decimal)(A183MODELO_DE_COMPONENTES_ID), 4, 0)));
               }
               else
               {
                  A183MODELO_DE_COMPONENTES_ID = (short)(context.localUtil.CToN( cgiGet( edtMODELO_DE_COMPONENTES_ID_Internalname), ",", ".")) ;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A183MODELO_DE_COMPONENTES_ID", StringUtil.LTrim( StringUtil.Str( (decimal)(A183MODELO_DE_COMPONENTES_ID), 4, 0)));
               }
               A188MODELO_DE_COMPONENTES_NOMBRE = cgiGet( edtMODELO_DE_COMPONENTES_NOMBRE_Internalname) ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A188MODELO_DE_COMPONENTES_NOMBRE", A188MODELO_DE_COMPONENTES_NOMBRE);
               if ( ! context.localUtil.VCNumber( cgiGet( edtMARCAS_ID_Internalname), "ZZZ9") || ( context.localUtil.CToN( cgiGet( edtMARCAS_ID_Internalname), ",", ".") < Convert.ToDecimal( 0 )) || ( ( context.localUtil.CToN( cgiGet( edtMARCAS_ID_Internalname), ",", ".") > Convert.ToDecimal( 9999 )) ) )
               {
                  GX_msglist.addItem(context.GetMessage( "GXM_badnum"), 1, "MARCAS_ID");
                  AnyError = 1 ;
                  GX_FocusControl = edtMARCAS_ID_Internalname ;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
                  wbErr = true ;
                  A189MARCAS_ID = 0 ;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A189MARCAS_ID", StringUtil.LTrim( StringUtil.Str( (decimal)(A189MARCAS_ID), 4, 0)));
               }
               else
               {
                  A189MARCAS_ID = (short)(context.localUtil.CToN( cgiGet( edtMARCAS_ID_Internalname), ",", ".")) ;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A189MARCAS_ID", StringUtil.LTrim( StringUtil.Str( (decimal)(A189MARCAS_ID), 4, 0)));
               }
               A190MARCAS_DESCRIPCION = cgiGet( edtMARCAS_DESCRIPCION_Internalname) ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A190MARCAS_DESCRIPCION", A190MARCAS_DESCRIPCION);
               if ( ! context.localUtil.VCNumber( cgiGet( edtHARDWARE_NRO_BIEN_Internalname), "ZZZZZZZZZ9") || ( context.localUtil.CToN( cgiGet( edtHARDWARE_NRO_BIEN_Internalname), ",", ".") < Convert.ToDecimal( 0 )) || ( ( context.localUtil.CToN( cgiGet( edtHARDWARE_NRO_BIEN_Internalname), ",", ".") > Convert.ToDecimal( 9999999999L )) ) )
               {
                  GX_msglist.addItem(context.GetMessage( "GXM_badnum"), 1, "HARDWARE_NRO_BIEN");
                  AnyError = 1 ;
                  GX_FocusControl = edtHARDWARE_NRO_BIEN_Internalname ;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
                  wbErr = true ;
                  A184HARDWARE_NRO_BIEN = 0 ;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A184HARDWARE_NRO_BIEN", StringUtil.LTrim( StringUtil.Str( (decimal)(A184HARDWARE_NRO_BIEN), 10, 0)));
               }
               else
               {
                  A184HARDWARE_NRO_BIEN = (long)(context.localUtil.CToN( cgiGet( edtHARDWARE_NRO_BIEN_Internalname), ",", ".")) ;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A184HARDWARE_NRO_BIEN", StringUtil.LTrim( StringUtil.Str( (decimal)(A184HARDWARE_NRO_BIEN), 10, 0)));
               }
               A9HARDWARE_NRO_SERIE = cgiGet( edtHARDWARE_NRO_SERIE_Internalname) ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A9HARDWARE_NRO_SERIE", A9HARDWARE_NRO_SERIE);
               cmbACTIVO.CurrentValue = cgiGet( cmbACTIVO_Internalname) ;
               A185ACTIVO = cgiGet( cmbACTIVO_Internalname) ;
               n185ACTIVO = false ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A185ACTIVO", A185ACTIVO);
               n185ACTIVO = (String.IsNullOrEmpty(StringUtil.RTrim( A185ACTIVO)) ? true : false) ;
               if ( context.localUtil.VCDateTime( cgiGet( edtfecha_baja_Internalname), 4, 0) == 0 )
               {
                  GX_msglist.addItem(context.GetMessage( "GXM_baddatetime", new   object[]  {"fecha_baja"}), 1, "FECHA_BAJA");
                  AnyError = 1 ;
                  GX_FocusControl = edtfecha_baja_Internalname ;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
                  wbErr = true ;
                  A186fecha_baja = (DateTime)(DateTime.MinValue) ;
                  n186fecha_baja = false ;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A186fecha_baja", context.localUtil.TToC( A186fecha_baja, 10, 8, 0, 3, "/", ":", " "));
               }
               else
               {
                  A186fecha_baja = context.localUtil.CToT( cgiGet( edtfecha_baja_Internalname)) ;
                  n186fecha_baja = false ;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A186fecha_baja", context.localUtil.TToC( A186fecha_baja, 10, 8, 0, 3, "/", ":", " "));
               }
               n186fecha_baja = ((DateTime.MinValue==A186fecha_baja) ? true : false) ;
               A192PRUEBA_MICROFONO_AUDIO = cgiGet( radPRUEBA_MICROFONO_AUDIO_Internalname) ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A192PRUEBA_MICROFONO_AUDIO", A192PRUEBA_MICROFONO_AUDIO);
               dynRESPONSABLE_ARMADO_PC.CurrentValue = cgiGet( dynRESPONSABLE_ARMADO_PC_Internalname) ;
               A193RESPONSABLE_ARMADO_PC = cgiGet( dynRESPONSABLE_ARMADO_PC_Internalname) ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A193RESPONSABLE_ARMADO_PC", A193RESPONSABLE_ARMADO_PC);
               cmbTIPO_DIR_IP.CurrentValue = cgiGet( cmbTIPO_DIR_IP_Internalname) ;
               A299TIPO_DIR_IP = (short)(NumberUtil.Val( cgiGet( cmbTIPO_DIR_IP_Internalname), ".")) ;
               n299TIPO_DIR_IP = false ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A299TIPO_DIR_IP", StringUtil.LTrim( StringUtil.Str( (decimal)(A299TIPO_DIR_IP), 2, 0)));
               n299TIPO_DIR_IP = ((0==A299TIPO_DIR_IP) ? true : false) ;
               dynTHARDWARE_UBI.CurrentValue = cgiGet( dynTHARDWARE_UBI_Internalname) ;
               A194THARDWARE_UBI = (long)(NumberUtil.Val( cgiGet( dynTHARDWARE_UBI_Internalname), ".")) ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A194THARDWARE_UBI", StringUtil.LTrim( StringUtil.Str( (decimal)(A194THARDWARE_UBI), 10, 0)));
               dynHARDWARE_RED.CurrentValue = cgiGet( dynHARDWARE_RED_Internalname) ;
               A311HARDWARE_RED = (long)(NumberUtil.Val( cgiGet( dynHARDWARE_RED_Internalname), ".")) ;
               n311HARDWARE_RED = false ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A311HARDWARE_RED", StringUtil.LTrim( StringUtil.Str( (decimal)(A311HARDWARE_RED), 10, 0)));
               n311HARDWARE_RED = ((0==A311HARDWARE_RED) ? true : false) ;
               AV15Red_DireccionDesde = cgiGet( edtavRed_direcciondesde_Internalname) ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV15Red_DireccionDesde", AV15Red_DireccionDesde);
               AV19Red_DireccionHasta = cgiGet( edtavRed_direccionhasta_Internalname) ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV19Red_DireccionHasta", AV19Red_DireccionHasta);
               AV20Red_Mascara = cgiGet( edtavRed_mascara_Internalname) ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV20Red_Mascara", AV20Red_Mascara);
               AV21Red_PuertaEnlace = cgiGet( edtavRed_puertaenlace_Internalname) ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV21Red_PuertaEnlace", AV21Red_PuertaEnlace);
               AV16Red_DireccionDesdeB1 = (short)(context.localUtil.CToN( cgiGet( edtavRed_direcciondesdeb1_Internalname), ",", ".")) ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV16Red_DireccionDesdeB1", StringUtil.LTrim( StringUtil.Str( (decimal)(AV16Red_DireccionDesdeB1), 3, 0)));
               AV17Red_DireccionDesdeB2 = (short)(context.localUtil.CToN( cgiGet( edtavRed_direcciondesdeb2_Internalname), ",", ".")) ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV17Red_DireccionDesdeB2", StringUtil.LTrim( StringUtil.Str( (decimal)(AV17Red_DireccionDesdeB2), 3, 0)));
               AV18Red_DireccionDesdeB3 = (short)(context.localUtil.CToN( cgiGet( edtavRed_direcciondesdeb3_Internalname), ",", ".")) ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV18Red_DireccionDesdeB3", StringUtil.LTrim( StringUtil.Str( (decimal)(AV18Red_DireccionDesdeB3), 3, 0)));
               A312HARDWARE_IP = (short)(context.localUtil.CToN( cgiGet( edtHARDWARE_IP_Internalname), ",", ".")) ;
               n312HARDWARE_IP = false ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A312HARDWARE_IP", StringUtil.LTrim( StringUtil.Str( (decimal)(A312HARDWARE_IP), 3, 0)));
               dynHARDWARE_UBA.CurrentValue = cgiGet( dynHARDWARE_UBA_Internalname) ;
               A314HARDWARE_UBA = (long)(NumberUtil.Val( cgiGet( dynHARDWARE_UBA_Internalname), ".")) ;
               n314HARDWARE_UBA = false ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A314HARDWARE_UBA", StringUtil.LTrim( StringUtil.Str( (decimal)(A314HARDWARE_UBA), 10, 0)));
               n314HARDWARE_UBA = ((0==A314HARDWARE_UBA) ? true : false) ;
               if ( ! context.localUtil.VCNumber( cgiGet( edtHDW_IDT_Internalname), "ZZZZZZZ9") || ( context.localUtil.CToN( cgiGet( edtHDW_IDT_Internalname), ",", ".") < Convert.ToDecimal( 0 )) || ( ( context.localUtil.CToN( cgiGet( edtHDW_IDT_Internalname), ",", ".") > Convert.ToDecimal( 99999999 )) ) )
               {
                  GX_msglist.addItem(context.GetMessage( "GXM_badnum"), 1, "HDW_IDT");
                  AnyError = 1 ;
                  GX_FocusControl = edtHDW_IDT_Internalname ;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
                  wbErr = true ;
                  A104HDW_IDT = 0 ;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A104HDW_IDT", StringUtil.LTrim( StringUtil.Str( (decimal)(A104HDW_IDT), 8, 0)));
               }
               else
               {
                  A104HDW_IDT = (int)(context.localUtil.CToN( cgiGet( edtHDW_IDT_Internalname), ",", ".")) ;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A104HDW_IDT", StringUtil.LTrim( StringUtil.Str( (decimal)(A104HDW_IDT), 8, 0)));
               }
               /* Read saved values. */
               Z10HARDWARE_ID = (short)(context.localUtil.CToN( cgiGet( "Z10HARDWARE_ID"), ",", ".")) ;
               Z194THARDWARE_UBI = (long)(context.localUtil.CToN( cgiGet( "Z194THARDWARE_UBI"), ",", ".")) ;
               Z311HARDWARE_RED = (long)(context.localUtil.CToN( cgiGet( "Z311HARDWARE_RED"), ",", ".")) ;
               Z312HARDWARE_IP = (short)(context.localUtil.CToN( cgiGet( "Z312HARDWARE_IP"), ",", ".")) ;
               Z299TIPO_DIR_IP = (short)(context.localUtil.CToN( cgiGet( "Z299TIPO_DIR_IP"), ",", ".")) ;
               Z181TIPOS_DE_HARDWARE_ID = (short)(context.localUtil.CToN( cgiGet( "Z181TIPOS_DE_HARDWARE_ID"), ",", ".")) ;
               Z58HARDWARE_DESCRIPCION = cgiGet( "Z58HARDWARE_DESCRIPCION") ;
               Z182fecha_alta = context.localUtil.CToT( cgiGet( "Z182fecha_alta")) ;
               Z187NOMBRE_DEL_TIPO_DE_HD = cgiGet( "Z187NOMBRE_DEL_TIPO_DE_HD") ;
               Z313TH_DIREC = (short)(context.localUtil.CToN( cgiGet( "Z313TH_DIREC"), ",", ".")) ;
               Z183MODELO_DE_COMPONENTES_ID = (short)(context.localUtil.CToN( cgiGet( "Z183MODELO_DE_COMPONENTES_ID"), ",", ".")) ;
               Z188MODELO_DE_COMPONENTES_NOMBRE = cgiGet( "Z188MODELO_DE_COMPONENTES_NOMBRE") ;
               Z189MARCAS_ID = (short)(context.localUtil.CToN( cgiGet( "Z189MARCAS_ID"), ",", ".")) ;
               Z190MARCAS_DESCRIPCION = cgiGet( "Z190MARCAS_DESCRIPCION") ;
               Z184HARDWARE_NRO_BIEN = (long)(context.localUtil.CToN( cgiGet( "Z184HARDWARE_NRO_BIEN"), ",", ".")) ;
               Z9HARDWARE_NRO_SERIE = cgiGet( "Z9HARDWARE_NRO_SERIE") ;
               Z185ACTIVO = cgiGet( "Z185ACTIVO") ;
               Z186fecha_baja = context.localUtil.CToT( cgiGet( "Z186fecha_baja")) ;
               Z192PRUEBA_MICROFONO_AUDIO = cgiGet( "Z192PRUEBA_MICROFONO_AUDIO") ;
               Z193RESPONSABLE_ARMADO_PC = cgiGet( "Z193RESPONSABLE_ARMADO_PC") ;
               Z104HDW_IDT = (int)(context.localUtil.CToN( cgiGet( "Z104HDW_IDT"), ",", ".")) ;
               Z314HARDWARE_UBA = (long)(context.localUtil.CToN( cgiGet( "Z314HARDWARE_UBA"), ",", ".")) ;
               IsConfirmed = (short)(context.localUtil.CToN( cgiGet( "IsConfirmed"), ",", ".")) ;
               IsModified = (short)(context.localUtil.CToN( cgiGet( "IsModified"), ",", ".")) ;
               Gx_mode = cgiGet( "Mode") ;
               AV30USUARIO = cgiGet( "vUSUARIO") ;
               AV29SISTEMA = cgiGet( "vSISTEMA") ;
               AV12HARDWARE_ID = (short)(context.localUtil.CToN( cgiGet( "vHARDWARE_ID"), ",", ".")) ;
               Gx_BScreen = (short)(context.localUtil.CToN( cgiGet( "vGXBSCREEN"), ",", ".")) ;
               AV36error = (short)(context.localUtil.CToN( cgiGet( "vERROR"), ",", ".")) ;
               AV34mensaje = cgiGet( "vMENSAJE") ;
               AV37error_2 = (short)(context.localUtil.CToN( cgiGet( "vERROR_2"), ",", ".")) ;
               AV33validado = (short)(context.localUtil.CToN( cgiGet( "vVALIDADO"), ",", ".")) ;
               Gx_mode = cgiGet( "vMODE") ;
               /* Read subfile selected row values. */
               /* Read hidden variables. */
               standaloneNotModal( ) ;
            }
            else
            {
               standaloneNotModal( ) ;
               if ( StringUtil.StrCmp(gxfirstwebparm, "viewer") == 0 )
               {
                  Gx_mode = "DSP" ;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
                  A10HARDWARE_ID = (short)(NumberUtil.Val( GetNextPar( ), ".")) ;
                  n10HARDWARE_ID = false ;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A10HARDWARE_ID", StringUtil.LTrim( StringUtil.Str( (decimal)(A10HARDWARE_ID), 4, 0)));
                  getEqualNoModal( ) ;
                  Gx_mode = "DSP" ;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
                  disable_std_buttons( ) ;
                  standaloneModal( ) ;
               }
               else
               {
                  if ( StringUtil.StrCmp(Gx_mode, "DSP") == 0 )
                  {
                     sMode23 = Gx_mode ;
                     Gx_mode = "UPD" ;
                     context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
                     Gx_mode = sMode23 ;
                     context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
                  }
                  standaloneModal( ) ;
                  if ( StringUtil.StrCmp(Gx_mode, "INS") != 0 )
                  {
                     getByPrimaryKey( ) ;
                     if ( RcdFound23 == 1 )
                     {
                        if ( StringUtil.StrCmp(Gx_mode, "DLT") == 0 )
                        {
                           /* Confirm record */
                           CONFIRM_0N0( ) ;
                           if ( AnyError == 0 )
                           {
                              GX_FocusControl = bttBtn_enter_Internalname ;
                              context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
                           }
                        }
                     }
                     else
                     {
                        GX_msglist.addItem(context.GetMessage( "GXM_noinsert"), 1, "HARDWARE_ID");
                        AnyError = 1 ;
                     }
                  }
               }
            }
         }
      }

      protected void Process( )
      {
         if ( StringUtil.StrCmp(context.GetRequestMethod( ), "POST") == 0 )
         {
            /* Read Transaction buttons. */
            sEvt = cgiGet( "_EventName") ;
            EvtGridId = cgiGet( "_EventGridId") ;
            EvtRowId = cgiGet( "_EventRowId") ;
            if ( StringUtil.Len( sEvt) > 0 )
            {
               sEvtType = StringUtil.Left( sEvt, 1) ;
               sEvt = StringUtil.Right( sEvt, (short)(StringUtil.Len( sEvt)-1)) ;
               if ( StringUtil.StrCmp(sEvtType, "M") != 0 )
               {
                  if ( StringUtil.StrCmp(sEvtType, "E") == 0 )
                  {
                     sEvtType = StringUtil.Right( sEvt, 1) ;
                     if ( StringUtil.StrCmp(sEvtType, ".") == 0 )
                     {
                        sEvt = StringUtil.Left( sEvt, (short)(StringUtil.Len( sEvt)-1)) ;
                        if ( StringUtil.StrCmp(sEvt, "START") == 0 )
                        {
                           context.wbHandled = 1 ;
                           dynload_actions( ) ;
                           /* Execute user event: E120N2 */
                           E120N2 ();
                        }
                        else if ( StringUtil.StrCmp(sEvt, "AFTER TRN") == 0 )
                        {
                           context.wbHandled = 1 ;
                           dynload_actions( ) ;
                           /* Execute user event: E130N2 */
                           E130N2 ();
                        }
                        else if ( StringUtil.StrCmp(sEvt, "ENTER") == 0 )
                        {
                           context.wbHandled = 1 ;
                           btn_enter( ) ;
                           /* No code required for Cancel button. It is implemented as the Reset button. */
                        }
                        else if ( StringUtil.StrCmp(sEvt, "CHECK") == 0 )
                        {
                           context.wbHandled = 1 ;
                           btn_Check( ) ;
                        }
                     }
                     else
                     {
                     }
                  }
                  context.wbHandled = 1 ;
               }
            }
         }
      }

      protected void AfterTrn( )
      {
         if ( trnEnded == 1 )
         {
            /* Execute user event: E130N2 */
            E130N2 ();
            trnEnded = 0 ;
            standaloneNotModal( ) ;
            standaloneModal( ) ;
            if ( ( StringUtil.StrCmp(Gx_mode, "INS") == 0 )  )
            {
               /* Clear variables for new insertion. */
               InitAll0N23( ) ;
               standaloneNotModal( ) ;
               standaloneModal( ) ;
            }
         }
      }

      public override String ToString( )
      {
         return "" ;
      }

      public GxContentInfo GetContentInfo( )
      {
         return (GxContentInfo)(null) ;
      }

      protected void disable_std_buttons( )
      {
         bttBtn_delete_Visible = 0 ;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, bttBtn_delete_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(bttBtn_delete_Visible), 5, 0)));
         bttBtn_first_Visible = 0 ;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, bttBtn_first_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(bttBtn_first_Visible), 5, 0)));
         bttBtn_previous_Visible = 0 ;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, bttBtn_previous_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(bttBtn_previous_Visible), 5, 0)));
         bttBtn_next_Visible = 0 ;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, bttBtn_next_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(bttBtn_next_Visible), 5, 0)));
         bttBtn_last_Visible = 0 ;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, bttBtn_last_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(bttBtn_last_Visible), 5, 0)));
         bttBtn_select_Visible = 0 ;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, bttBtn_select_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(bttBtn_select_Visible), 5, 0)));
         if ( ( StringUtil.StrCmp(Gx_mode, "DSP") == 0 ) || ( StringUtil.StrCmp(Gx_mode, "DLT") == 0 ) )
         {
            bttBtn_delete_Visible = 0 ;
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, bttBtn_delete_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(bttBtn_delete_Visible), 5, 0)));
            if ( StringUtil.StrCmp(Gx_mode, "DSP") == 0 )
            {
               bttBtn_enter_Visible = 0 ;
               context.httpAjaxContext.ajax_rsp_assign_prop("", false, bttBtn_enter_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(bttBtn_enter_Visible), 5, 0)));
            }
            edtHARDWARE_ID_Enabled = 0 ;
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtHARDWARE_ID_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtHARDWARE_ID_Enabled), 5, 0)));
            edtHARDWARE_DESCRIPCION_Enabled = 0 ;
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtHARDWARE_DESCRIPCION_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtHARDWARE_DESCRIPCION_Enabled), 5, 0)));
            edtfecha_alta_Enabled = 0 ;
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtfecha_alta_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtfecha_alta_Enabled), 5, 0)));
            edtTIPOS_DE_HARDWARE_ID_Enabled = 0 ;
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtTIPOS_DE_HARDWARE_ID_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtTIPOS_DE_HARDWARE_ID_Enabled), 5, 0)));
            edtNOMBRE_DEL_TIPO_DE_HD_Enabled = 0 ;
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtNOMBRE_DEL_TIPO_DE_HD_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtNOMBRE_DEL_TIPO_DE_HD_Enabled), 5, 0)));
            cmbTH_DIREC.Enabled = 0 ;
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, cmbTH_DIREC_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(cmbTH_DIREC.Enabled), 5, 0)));
            edtMODELO_DE_COMPONENTES_ID_Enabled = 0 ;
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtMODELO_DE_COMPONENTES_ID_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtMODELO_DE_COMPONENTES_ID_Enabled), 5, 0)));
            edtMODELO_DE_COMPONENTES_NOMBRE_Enabled = 0 ;
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtMODELO_DE_COMPONENTES_NOMBRE_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtMODELO_DE_COMPONENTES_NOMBRE_Enabled), 5, 0)));
            edtMARCAS_ID_Enabled = 0 ;
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtMARCAS_ID_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtMARCAS_ID_Enabled), 5, 0)));
            edtMARCAS_DESCRIPCION_Enabled = 0 ;
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtMARCAS_DESCRIPCION_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtMARCAS_DESCRIPCION_Enabled), 5, 0)));
            edtHARDWARE_NRO_BIEN_Enabled = 0 ;
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtHARDWARE_NRO_BIEN_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtHARDWARE_NRO_BIEN_Enabled), 5, 0)));
            edtHARDWARE_NRO_SERIE_Enabled = 0 ;
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtHARDWARE_NRO_SERIE_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtHARDWARE_NRO_SERIE_Enabled), 5, 0)));
            cmbACTIVO.Enabled = 0 ;
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, cmbACTIVO_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(cmbACTIVO.Enabled), 5, 0)));
            edtfecha_baja_Enabled = 0 ;
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtfecha_baja_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtfecha_baja_Enabled), 5, 0)));
            radPRUEBA_MICROFONO_AUDIO.Enabled = 0 ;
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, radPRUEBA_MICROFONO_AUDIO_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(radPRUEBA_MICROFONO_AUDIO.Enabled), 5, 0)));
            dynRESPONSABLE_ARMADO_PC.Enabled = 0 ;
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, dynRESPONSABLE_ARMADO_PC_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(dynRESPONSABLE_ARMADO_PC.Enabled), 5, 0)));
            cmbTIPO_DIR_IP.Enabled = 0 ;
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, cmbTIPO_DIR_IP_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(cmbTIPO_DIR_IP.Enabled), 5, 0)));
            dynTHARDWARE_UBI.Enabled = 0 ;
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, dynTHARDWARE_UBI_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(dynTHARDWARE_UBI.Enabled), 5, 0)));
            dynHARDWARE_RED.Enabled = 0 ;
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, dynHARDWARE_RED_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(dynHARDWARE_RED.Enabled), 5, 0)));
            edtavRed_direcciondesde_Enabled = 0 ;
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavRed_direcciondesde_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavRed_direcciondesde_Enabled), 5, 0)));
            edtavRed_direccionhasta_Enabled = 0 ;
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavRed_direccionhasta_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavRed_direccionhasta_Enabled), 5, 0)));
            edtavRed_mascara_Enabled = 0 ;
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavRed_mascara_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavRed_mascara_Enabled), 5, 0)));
            edtavRed_puertaenlace_Enabled = 0 ;
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavRed_puertaenlace_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavRed_puertaenlace_Enabled), 5, 0)));
            edtavRed_direcciondesdeb1_Enabled = 0 ;
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavRed_direcciondesdeb1_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavRed_direcciondesdeb1_Enabled), 5, 0)));
            edtavRed_direcciondesdeb2_Enabled = 0 ;
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavRed_direcciondesdeb2_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavRed_direcciondesdeb2_Enabled), 5, 0)));
            edtavRed_direcciondesdeb3_Enabled = 0 ;
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavRed_direcciondesdeb3_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavRed_direcciondesdeb3_Enabled), 5, 0)));
            edtHARDWARE_IP_Enabled = 0 ;
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtHARDWARE_IP_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtHARDWARE_IP_Enabled), 5, 0)));
            dynHARDWARE_UBA.Enabled = 0 ;
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, dynHARDWARE_UBA_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(dynHARDWARE_UBA.Enabled), 5, 0)));
            edtHDW_IDT_Enabled = 0 ;
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtHDW_IDT_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtHDW_IDT_Enabled), 5, 0)));
         }
      }

      protected void set_caption( )
      {
         if ( ( IsConfirmed == 1 ) && ( AnyError == 0 ) )
         {
            if ( StringUtil.StrCmp(Gx_mode, "DLT") == 0 )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_confdelete"), 0, "");
            }
            else
            {
               GX_msglist.addItem(context.GetMessage( "GXM_mustconfirm"), 0, "");
            }
         }
      }

      protected void CONFIRM_0N0( )
      {
         BeforeValidate0N23( ) ;
         if ( AnyError == 0 )
         {
            if ( StringUtil.StrCmp(Gx_mode, "DLT") == 0 )
            {
               OnDeleteControls0N23( ) ;
            }
            else
            {
               CheckExtendedTable0N23( ) ;
               if ( AnyError == 0 )
               {
               }
               CloseExtendedTableCursors0N23( ) ;
            }
         }
         if ( AnyError == 0 )
         {
            IsConfirmed = 1 ;
         }
         if ( AnyError == 0 )
         {
            ConfirmValues0N0( ) ;
         }
      }

      protected void ResetCaption0N0( )
      {
      }

      protected void E120N2( )
      {
         /* Start Routine */
         AV32THARDWARE_UBI = (long)(NumberUtil.Val( AV23SESION.Get("THARDWARE_UBI"), ".")) ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV32THARDWARE_UBI", StringUtil.LTrim( StringUtil.Str( (decimal)(AV32THARDWARE_UBI), 10, 0)));
         AV31HARDWARE_RED = (long)(NumberUtil.Val( AV23SESION.Get("HARDWARE_RED"), ".")) ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV31HARDWARE_RED", StringUtil.LTrim( StringUtil.Str( (decimal)(AV31HARDWARE_RED), 10, 0)));
         AV35TIPO_DIR_IP = (short)(NumberUtil.Val( AV23SESION.Get("TIPO_DIR_IP"), ".")) ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV35TIPO_DIR_IP", StringUtil.LTrim( StringUtil.Str( (decimal)(AV35TIPO_DIR_IP), 2, 0)));
         AV7ACTIVO = AV23SESION.Get("ACTIVO") ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV7ACTIVO", AV7ACTIVO);
         if ( StringUtil.StrCmp(Gx_mode, "INS") == 0 )
         {
            imgPrompt1_Visible = 1 ;
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, imgPrompt1_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(imgPrompt1_Visible), 5, 0)));
         }
         else if ( StringUtil.StrCmp(Gx_mode, "UPD") == 0 )
         {
            imgPrompt1_Visible = 1 ;
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, imgPrompt1_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(imgPrompt1_Visible), 5, 0)));
         }
         else if ( StringUtil.StrCmp(Gx_mode, "DSP") == 0 )
         {
            imgPrompt1_Visible = 0 ;
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, imgPrompt1_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(imgPrompt1_Visible), 5, 0)));
            if ( ( AV35TIPO_DIR_IP == 2 ) && ( StringUtil.StrCmp(AV7ACTIVO, "No") != 0 ) )
            {
               new phdw_ip_5(context ).execute(  AV32THARDWARE_UBI,  AV31HARDWARE_RED,  AV12HARDWARE_ID, out  AV15Red_DireccionDesde, out  AV19Red_DireccionHasta, out  AV20Red_Mascara, out  AV21Red_PuertaEnlace, out  AV16Red_DireccionDesdeB1, out  AV17Red_DireccionDesdeB2, out  AV18Red_DireccionDesdeB3) ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV32THARDWARE_UBI", StringUtil.LTrim( StringUtil.Str( (decimal)(AV32THARDWARE_UBI), 10, 0)));
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV31HARDWARE_RED", StringUtil.LTrim( StringUtil.Str( (decimal)(AV31HARDWARE_RED), 10, 0)));
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV12HARDWARE_ID", StringUtil.LTrim( StringUtil.Str( (decimal)(AV12HARDWARE_ID), 4, 0)));
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV15Red_DireccionDesde", AV15Red_DireccionDesde);
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV19Red_DireccionHasta", AV19Red_DireccionHasta);
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV20Red_Mascara", AV20Red_Mascara);
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV21Red_PuertaEnlace", AV21Red_PuertaEnlace);
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV16Red_DireccionDesdeB1", StringUtil.LTrim( StringUtil.Str( (decimal)(AV16Red_DireccionDesdeB1), 3, 0)));
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV17Red_DireccionDesdeB2", StringUtil.LTrim( StringUtil.Str( (decimal)(AV17Red_DireccionDesdeB2), 3, 0)));
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV18Red_DireccionDesdeB3", StringUtil.LTrim( StringUtil.Str( (decimal)(AV18Red_DireccionDesdeB3), 3, 0)));
            }
         }
         else if ( StringUtil.StrCmp(Gx_mode, "DLT") == 0 )
         {
            imgPrompt1_Visible = 0 ;
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, imgPrompt1_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(imgPrompt1_Visible), 5, 0)));
            if ( ( AV35TIPO_DIR_IP == 2 ) && ( StringUtil.StrCmp(AV7ACTIVO, "No") != 0 ) )
            {
               new phdw_ip_5(context ).execute(  AV32THARDWARE_UBI,  AV31HARDWARE_RED,  AV12HARDWARE_ID, out  AV15Red_DireccionDesde, out  AV19Red_DireccionHasta, out  AV20Red_Mascara, out  AV21Red_PuertaEnlace, out  AV16Red_DireccionDesdeB1, out  AV17Red_DireccionDesdeB2, out  AV18Red_DireccionDesdeB3) ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV32THARDWARE_UBI", StringUtil.LTrim( StringUtil.Str( (decimal)(AV32THARDWARE_UBI), 10, 0)));
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV31HARDWARE_RED", StringUtil.LTrim( StringUtil.Str( (decimal)(AV31HARDWARE_RED), 10, 0)));
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV12HARDWARE_ID", StringUtil.LTrim( StringUtil.Str( (decimal)(AV12HARDWARE_ID), 4, 0)));
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV15Red_DireccionDesde", AV15Red_DireccionDesde);
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV19Red_DireccionHasta", AV19Red_DireccionHasta);
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV20Red_Mascara", AV20Red_Mascara);
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV21Red_PuertaEnlace", AV21Red_PuertaEnlace);
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV16Red_DireccionDesdeB1", StringUtil.LTrim( StringUtil.Str( (decimal)(AV16Red_DireccionDesdeB1), 3, 0)));
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV17Red_DireccionDesdeB2", StringUtil.LTrim( StringUtil.Str( (decimal)(AV17Red_DireccionDesdeB2), 3, 0)));
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV18Red_DireccionDesdeB3", StringUtil.LTrim( StringUtil.Str( (decimal)(AV18Red_DireccionDesdeB3), 3, 0)));
            }
         }
      }

      protected void E130N2( )
      {
         /* After Trn Routine */
         if ( StringUtil.StrCmp(Gx_mode, "INS") == 0 )
         {
            if ( A104HDW_IDT != 0 )
            {
               new ptbus030_(context ).execute(  A104HDW_IDT,  AV13HDW_IDT,  A10HARDWARE_ID,  AV30USUARIO) ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A104HDW_IDT", StringUtil.LTrim( StringUtil.Str( (decimal)(A104HDW_IDT), 8, 0)));
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV13HDW_IDT", StringUtil.LTrim( StringUtil.Str( (decimal)(AV13HDW_IDT), 8, 0)));
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A10HARDWARE_ID", StringUtil.LTrim( StringUtil.Str( (decimal)(A10HARDWARE_ID), 4, 0)));
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV30USUARIO", AV30USUARIO);
            }
         }
         else if ( StringUtil.StrCmp(Gx_mode, "UPD") == 0 )
         {
            AV13HDW_IDT = (int)(NumberUtil.Val( AV23SESION.Get("HDW_IDT"), ".")) ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV13HDW_IDT", StringUtil.LTrim( StringUtil.Str( (decimal)(AV13HDW_IDT), 8, 0)));
            if ( A104HDW_IDT != AV13HDW_IDT )
            {
               new ptbus030_(context ).execute(  A104HDW_IDT,  AV13HDW_IDT,  A10HARDWARE_ID,  AV30USUARIO) ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A104HDW_IDT", StringUtil.LTrim( StringUtil.Str( (decimal)(A104HDW_IDT), 8, 0)));
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV13HDW_IDT", StringUtil.LTrim( StringUtil.Str( (decimal)(AV13HDW_IDT), 8, 0)));
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A10HARDWARE_ID", StringUtil.LTrim( StringUtil.Str( (decimal)(A10HARDWARE_ID), 4, 0)));
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV30USUARIO", AV30USUARIO);
            }
         }
         context.setWebReturnParms(new Object[] {(short)AV12HARDWARE_ID,(String)Gx_mode,(String)AV29SISTEMA,(String)AV30USUARIO});
         context.nUserReturn = 1 ;
         returnInSub = true;
         if (true) return;
      }

      protected void ZM0N23( short GX_JID )
      {
         if ( ( GX_JID == 43 ) || ( GX_JID == 0 ) )
         {
            if ( StringUtil.StrCmp(Gx_mode, "INS") != 0 )
            {
               Z194THARDWARE_UBI = T000N3_A194THARDWARE_UBI[0] ;
               Z311HARDWARE_RED = T000N3_A311HARDWARE_RED[0] ;
               Z312HARDWARE_IP = T000N3_A312HARDWARE_IP[0] ;
               Z299TIPO_DIR_IP = T000N3_A299TIPO_DIR_IP[0] ;
               Z181TIPOS_DE_HARDWARE_ID = T000N3_A181TIPOS_DE_HARDWARE_ID[0] ;
               Z58HARDWARE_DESCRIPCION = T000N3_A58HARDWARE_DESCRIPCION[0] ;
               Z182fecha_alta = T000N3_A182fecha_alta[0] ;
               Z187NOMBRE_DEL_TIPO_DE_HD = T000N3_A187NOMBRE_DEL_TIPO_DE_HD[0] ;
               Z313TH_DIREC = T000N3_A313TH_DIREC[0] ;
               Z183MODELO_DE_COMPONENTES_ID = T000N3_A183MODELO_DE_COMPONENTES_ID[0] ;
               Z188MODELO_DE_COMPONENTES_NOMBRE = T000N3_A188MODELO_DE_COMPONENTES_NOMBRE[0] ;
               Z189MARCAS_ID = T000N3_A189MARCAS_ID[0] ;
               Z190MARCAS_DESCRIPCION = T000N3_A190MARCAS_DESCRIPCION[0] ;
               Z184HARDWARE_NRO_BIEN = T000N3_A184HARDWARE_NRO_BIEN[0] ;
               Z9HARDWARE_NRO_SERIE = T000N3_A9HARDWARE_NRO_SERIE[0] ;
               Z185ACTIVO = T000N3_A185ACTIVO[0] ;
               Z186fecha_baja = T000N3_A186fecha_baja[0] ;
               Z192PRUEBA_MICROFONO_AUDIO = T000N3_A192PRUEBA_MICROFONO_AUDIO[0] ;
               Z193RESPONSABLE_ARMADO_PC = T000N3_A193RESPONSABLE_ARMADO_PC[0] ;
               Z104HDW_IDT = T000N3_A104HDW_IDT[0] ;
               Z314HARDWARE_UBA = T000N3_A314HARDWARE_UBA[0] ;
            }
            else
            {
               Z194THARDWARE_UBI = A194THARDWARE_UBI ;
               Z311HARDWARE_RED = A311HARDWARE_RED ;
               Z312HARDWARE_IP = A312HARDWARE_IP ;
               Z299TIPO_DIR_IP = A299TIPO_DIR_IP ;
               Z181TIPOS_DE_HARDWARE_ID = A181TIPOS_DE_HARDWARE_ID ;
               Z58HARDWARE_DESCRIPCION = A58HARDWARE_DESCRIPCION ;
               Z182fecha_alta = A182fecha_alta ;
               Z187NOMBRE_DEL_TIPO_DE_HD = A187NOMBRE_DEL_TIPO_DE_HD ;
               Z313TH_DIREC = A313TH_DIREC ;
               Z183MODELO_DE_COMPONENTES_ID = A183MODELO_DE_COMPONENTES_ID ;
               Z188MODELO_DE_COMPONENTES_NOMBRE = A188MODELO_DE_COMPONENTES_NOMBRE ;
               Z189MARCAS_ID = A189MARCAS_ID ;
               Z190MARCAS_DESCRIPCION = A190MARCAS_DESCRIPCION ;
               Z184HARDWARE_NRO_BIEN = A184HARDWARE_NRO_BIEN ;
               Z9HARDWARE_NRO_SERIE = A9HARDWARE_NRO_SERIE ;
               Z185ACTIVO = A185ACTIVO ;
               Z186fecha_baja = A186fecha_baja ;
               Z192PRUEBA_MICROFONO_AUDIO = A192PRUEBA_MICROFONO_AUDIO ;
               Z193RESPONSABLE_ARMADO_PC = A193RESPONSABLE_ARMADO_PC ;
               Z104HDW_IDT = A104HDW_IDT ;
               Z314HARDWARE_UBA = A314HARDWARE_UBA ;
            }
         }
         if ( GX_JID == -43 )
         {
            Z10HARDWARE_ID = A10HARDWARE_ID ;
            Z194THARDWARE_UBI = A194THARDWARE_UBI ;
            Z311HARDWARE_RED = A311HARDWARE_RED ;
            Z312HARDWARE_IP = A312HARDWARE_IP ;
            Z299TIPO_DIR_IP = A299TIPO_DIR_IP ;
            Z181TIPOS_DE_HARDWARE_ID = A181TIPOS_DE_HARDWARE_ID ;
            Z58HARDWARE_DESCRIPCION = A58HARDWARE_DESCRIPCION ;
            Z182fecha_alta = A182fecha_alta ;
            Z187NOMBRE_DEL_TIPO_DE_HD = A187NOMBRE_DEL_TIPO_DE_HD ;
            Z313TH_DIREC = A313TH_DIREC ;
            Z183MODELO_DE_COMPONENTES_ID = A183MODELO_DE_COMPONENTES_ID ;
            Z188MODELO_DE_COMPONENTES_NOMBRE = A188MODELO_DE_COMPONENTES_NOMBRE ;
            Z189MARCAS_ID = A189MARCAS_ID ;
            Z190MARCAS_DESCRIPCION = A190MARCAS_DESCRIPCION ;
            Z184HARDWARE_NRO_BIEN = A184HARDWARE_NRO_BIEN ;
            Z9HARDWARE_NRO_SERIE = A9HARDWARE_NRO_SERIE ;
            Z185ACTIVO = A185ACTIVO ;
            Z186fecha_baja = A186fecha_baja ;
            Z192PRUEBA_MICROFONO_AUDIO = A192PRUEBA_MICROFONO_AUDIO ;
            Z193RESPONSABLE_ARMADO_PC = A193RESPONSABLE_ARMADO_PC ;
            Z104HDW_IDT = A104HDW_IDT ;
            Z314HARDWARE_UBA = A314HARDWARE_UBA ;
         }
      }

      protected void standaloneNotModal( )
      {
         GXARESPONSABLE_ARMADO_PC_html0N23( ) ;
         GXATHARDWARE_UBI_html0N23( ) ;
         GXAHARDWARE_UBA_html0N23( ) ;
         edtHARDWARE_IP_Enabled = 0 ;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtHARDWARE_IP_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtHARDWARE_IP_Enabled), 5, 0)));
         edtHARDWARE_ID_Enabled = 0 ;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtHARDWARE_ID_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtHARDWARE_ID_Enabled), 5, 0)));
         Gx_BScreen = 0 ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_BScreen", StringUtil.Str( (decimal)(Gx_BScreen), 1, 0));
         imgprompt_104_Link = ((StringUtil.StrCmp(Gx_mode, "DSP")==0) ? "" : "javascript:"+"gx.popup.openPrompt('"+"htbus030_2.aspx"+"',["+"{Ctrl:gx.dom.el('"+"HDW_IDT"+"'), id:'"+"HDW_IDT"+"'"+",isOut:true,isKey:false,isLastKey:false}"+"],"+"null"+","+"'', false"+","+"false"+","+"false"+");") ;
         edtHARDWARE_IP_Enabled = 0 ;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtHARDWARE_IP_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtHARDWARE_IP_Enabled), 5, 0)));
         edtHARDWARE_ID_Enabled = 0 ;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtHARDWARE_ID_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtHARDWARE_ID_Enabled), 5, 0)));
         bttBtn_delete_Enabled = 0 ;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, bttBtn_delete_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(bttBtn_delete_Enabled), 5, 0)));
         if ( StringUtil.StrCmp(Gx_mode, "INS") != 0 )
         {
            A10HARDWARE_ID = AV12HARDWARE_ID ;
            n10HARDWARE_ID = false ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A10HARDWARE_ID", StringUtil.LTrim( StringUtil.Str( (decimal)(A10HARDWARE_ID), 4, 0)));
         }
      }

      protected void standaloneModal( )
      {
         if ( StringUtil.StrCmp(Gx_mode, "DSP") == 0 )
         {
            bttBtn_enter_Enabled = 0 ;
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, bttBtn_enter_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(bttBtn_enter_Enabled), 5, 0)));
         }
         else
         {
            bttBtn_enter_Enabled = 1 ;
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, bttBtn_enter_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(bttBtn_enter_Enabled), 5, 0)));
         }
         if ( StringUtil.StrCmp(Gx_mode, "DSP") == 0 )
         {
            bttBtn_check_Enabled = 0 ;
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, bttBtn_check_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(bttBtn_check_Enabled), 5, 0)));
         }
         else
         {
            bttBtn_check_Enabled = 1 ;
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, bttBtn_check_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(bttBtn_check_Enabled), 5, 0)));
         }
         if ( ( StringUtil.StrCmp(Gx_mode, "INS") == 0 )  && (0==A104HDW_IDT) && ( Gx_BScreen == 0 ) )
         {
            A104HDW_IDT = 0 ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A104HDW_IDT", StringUtil.LTrim( StringUtil.Str( (decimal)(A104HDW_IDT), 8, 0)));
         }
         if ( ( StringUtil.StrCmp(Gx_mode, "INS") == 0 )  && String.IsNullOrEmpty(StringUtil.RTrim( A185ACTIVO)) && ( Gx_BScreen == 0 ) )
         {
            A185ACTIVO = "Si" ;
            n185ACTIVO = false ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A185ACTIVO", A185ACTIVO);
         }
         if ( ( StringUtil.StrCmp(Gx_mode, "INS") == 0 )  && String.IsNullOrEmpty(StringUtil.RTrim( A192PRUEBA_MICROFONO_AUDIO)) && ( Gx_BScreen == 0 ) )
         {
            A192PRUEBA_MICROFONO_AUDIO = "No" ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A192PRUEBA_MICROFONO_AUDIO", A192PRUEBA_MICROFONO_AUDIO);
         }
         if ( ( StringUtil.StrCmp(Gx_mode, "INS") == 0 ) && ( Gx_BScreen == 0 ) )
         {
            if ( StringUtil.StrCmp(A185ACTIVO, "No") == 0 )
            {
               A299TIPO_DIR_IP = 0 ;
               n299TIPO_DIR_IP = false ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A299TIPO_DIR_IP", StringUtil.LTrim( StringUtil.Str( (decimal)(A299TIPO_DIR_IP), 2, 0)));
            }
            if ( ( A299TIPO_DIR_IP == 2 ) && ( StringUtil.StrCmp(A185ACTIVO, "No") != 0 ) )
            {
               dynTHARDWARE_UBI.Enabled = 1 ;
               context.httpAjaxContext.ajax_rsp_assign_prop("", false, dynTHARDWARE_UBI_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(dynTHARDWARE_UBI.Enabled), 5, 0)));
            }
            else
            {
               if ( A299TIPO_DIR_IP != 2 )
               {
                  dynTHARDWARE_UBI.Enabled = 0 ;
                  context.httpAjaxContext.ajax_rsp_assign_prop("", false, dynTHARDWARE_UBI_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(dynTHARDWARE_UBI.Enabled), 5, 0)));
               }
               else
               {
                  if ( StringUtil.StrCmp(A185ACTIVO, "No") == 0 )
                  {
                     dynTHARDWARE_UBI.Enabled = 0 ;
                     context.httpAjaxContext.ajax_rsp_assign_prop("", false, dynTHARDWARE_UBI_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(dynTHARDWARE_UBI.Enabled), 5, 0)));
                  }
               }
            }
            if ( ( A299TIPO_DIR_IP == 2 ) && ( StringUtil.StrCmp(A185ACTIVO, "No") != 0 ) )
            {
               dynHARDWARE_RED.Enabled = 1 ;
               context.httpAjaxContext.ajax_rsp_assign_prop("", false, dynHARDWARE_RED_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(dynHARDWARE_RED.Enabled), 5, 0)));
            }
            else
            {
               if ( A299TIPO_DIR_IP != 2 )
               {
                  dynHARDWARE_RED.Enabled = 0 ;
                  context.httpAjaxContext.ajax_rsp_assign_prop("", false, dynHARDWARE_RED_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(dynHARDWARE_RED.Enabled), 5, 0)));
               }
               else
               {
                  if ( StringUtil.StrCmp(A185ACTIVO, "No") == 0 )
                  {
                     dynHARDWARE_RED.Enabled = 0 ;
                     context.httpAjaxContext.ajax_rsp_assign_prop("", false, dynHARDWARE_RED_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(dynHARDWARE_RED.Enabled), 5, 0)));
                  }
               }
            }
            if ( A299TIPO_DIR_IP != 2 )
            {
               A311HARDWARE_RED = 0 ;
               n311HARDWARE_RED = false ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A311HARDWARE_RED", StringUtil.LTrim( StringUtil.Str( (decimal)(A311HARDWARE_RED), 10, 0)));
            }
            else
            {
               if ( StringUtil.StrCmp(A185ACTIVO, "No") == 0 )
               {
                  A311HARDWARE_RED = 0 ;
                  n311HARDWARE_RED = false ;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A311HARDWARE_RED", StringUtil.LTrim( StringUtil.Str( (decimal)(A311HARDWARE_RED), 10, 0)));
               }
            }
            if ( A299TIPO_DIR_IP != 2 )
            {
               A312HARDWARE_IP = 0 ;
               n312HARDWARE_IP = false ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A312HARDWARE_IP", StringUtil.LTrim( StringUtil.Str( (decimal)(A312HARDWARE_IP), 3, 0)));
            }
            else
            {
               if ( StringUtil.StrCmp(A185ACTIVO, "No") == 0 )
               {
                  A312HARDWARE_IP = 0 ;
                  n312HARDWARE_IP = false ;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A312HARDWARE_IP", StringUtil.LTrim( StringUtil.Str( (decimal)(A312HARDWARE_IP), 3, 0)));
               }
            }
            if ( ( A299TIPO_DIR_IP != 2 ) && true /* After */ )
            {
               AV15Red_DireccionDesde = "0.0.0.0" ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV15Red_DireccionDesde", AV15Red_DireccionDesde);
            }
            else
            {
               if ( ( StringUtil.StrCmp(A185ACTIVO, "No") == 0 ) && true /* After */ )
               {
                  AV15Red_DireccionDesde = "0.0.0.0" ;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV15Red_DireccionDesde", AV15Red_DireccionDesde);
               }
            }
            if ( ( A299TIPO_DIR_IP != 2 ) && true /* After */ )
            {
               AV19Red_DireccionHasta = "0.0.0.0" ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV19Red_DireccionHasta", AV19Red_DireccionHasta);
            }
            else
            {
               if ( ( StringUtil.StrCmp(A185ACTIVO, "No") == 0 ) && true /* After */ )
               {
                  AV19Red_DireccionHasta = "0.0.0.0" ;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV19Red_DireccionHasta", AV19Red_DireccionHasta);
               }
            }
            if ( ( A299TIPO_DIR_IP != 2 ) && true /* After */ )
            {
               AV20Red_Mascara = "0.0.0.0" ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV20Red_Mascara", AV20Red_Mascara);
            }
            else
            {
               if ( ( StringUtil.StrCmp(A185ACTIVO, "No") == 0 ) && true /* After */ )
               {
                  AV20Red_Mascara = "0.0.0.0" ;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV20Red_Mascara", AV20Red_Mascara);
               }
            }
            if ( ( A299TIPO_DIR_IP != 2 ) && true /* After */ )
            {
               AV21Red_PuertaEnlace = "0.0.0.0" ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV21Red_PuertaEnlace", AV21Red_PuertaEnlace);
            }
            else
            {
               if ( ( StringUtil.StrCmp(A185ACTIVO, "No") == 0 ) && true /* After */ )
               {
                  AV21Red_PuertaEnlace = "0.0.0.0" ;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV21Red_PuertaEnlace", AV21Red_PuertaEnlace);
               }
            }
            if ( ( A299TIPO_DIR_IP != 2 ) && true /* After */ )
            {
               AV16Red_DireccionDesdeB1 = 0 ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV16Red_DireccionDesdeB1", StringUtil.LTrim( StringUtil.Str( (decimal)(AV16Red_DireccionDesdeB1), 3, 0)));
            }
            else
            {
               if ( ( StringUtil.StrCmp(A185ACTIVO, "No") == 0 ) && true /* After */ )
               {
                  AV16Red_DireccionDesdeB1 = 0 ;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV16Red_DireccionDesdeB1", StringUtil.LTrim( StringUtil.Str( (decimal)(AV16Red_DireccionDesdeB1), 3, 0)));
               }
            }
            if ( ( A299TIPO_DIR_IP != 2 ) && true /* After */ )
            {
               AV17Red_DireccionDesdeB2 = 0 ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV17Red_DireccionDesdeB2", StringUtil.LTrim( StringUtil.Str( (decimal)(AV17Red_DireccionDesdeB2), 3, 0)));
            }
            else
            {
               if ( ( StringUtil.StrCmp(A185ACTIVO, "No") == 0 ) && true /* After */ )
               {
                  AV17Red_DireccionDesdeB2 = 0 ;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV17Red_DireccionDesdeB2", StringUtil.LTrim( StringUtil.Str( (decimal)(AV17Red_DireccionDesdeB2), 3, 0)));
               }
            }
            if ( ( A299TIPO_DIR_IP != 2 ) && true /* After */ )
            {
               AV18Red_DireccionDesdeB3 = 0 ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV18Red_DireccionDesdeB3", StringUtil.LTrim( StringUtil.Str( (decimal)(AV18Red_DireccionDesdeB3), 3, 0)));
            }
            else
            {
               if ( ( StringUtil.StrCmp(A185ACTIVO, "No") == 0 ) && true /* After */ )
               {
                  AV18Red_DireccionDesdeB3 = 0 ;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV18Red_DireccionDesdeB3", StringUtil.LTrim( StringUtil.Str( (decimal)(AV18Red_DireccionDesdeB3), 3, 0)));
               }
            }
            if ( StringUtil.StrCmp(A185ACTIVO, "No") == 0 )
            {
               cmbTIPO_DIR_IP.Enabled = 0 ;
               context.httpAjaxContext.ajax_rsp_assign_prop("", false, cmbTIPO_DIR_IP_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(cmbTIPO_DIR_IP.Enabled), 5, 0)));
            }
            else
            {
               if ( StringUtil.StrCmp(A185ACTIVO, "No") != 0 )
               {
                  cmbTIPO_DIR_IP.Enabled = 1 ;
                  context.httpAjaxContext.ajax_rsp_assign_prop("", false, cmbTIPO_DIR_IP_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(cmbTIPO_DIR_IP.Enabled), 5, 0)));
               }
            }
         }
      }

      protected void Load0N23( )
      {
         /* Using cursor T000N4 */
         pr_default.execute(2, new Object[] {n10HARDWARE_ID, A10HARDWARE_ID});
         if ( (pr_default.getStatus(2) != 101) )
         {
            RcdFound23 = 1 ;
            A194THARDWARE_UBI = T000N4_A194THARDWARE_UBI[0] ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A194THARDWARE_UBI", StringUtil.LTrim( StringUtil.Str( (decimal)(A194THARDWARE_UBI), 10, 0)));
            A311HARDWARE_RED = T000N4_A311HARDWARE_RED[0] ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A311HARDWARE_RED", StringUtil.LTrim( StringUtil.Str( (decimal)(A311HARDWARE_RED), 10, 0)));
            n311HARDWARE_RED = T000N4_n311HARDWARE_RED[0] ;
            A312HARDWARE_IP = T000N4_A312HARDWARE_IP[0] ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A312HARDWARE_IP", StringUtil.LTrim( StringUtil.Str( (decimal)(A312HARDWARE_IP), 3, 0)));
            n312HARDWARE_IP = T000N4_n312HARDWARE_IP[0] ;
            A299TIPO_DIR_IP = T000N4_A299TIPO_DIR_IP[0] ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A299TIPO_DIR_IP", StringUtil.LTrim( StringUtil.Str( (decimal)(A299TIPO_DIR_IP), 2, 0)));
            n299TIPO_DIR_IP = T000N4_n299TIPO_DIR_IP[0] ;
            A181TIPOS_DE_HARDWARE_ID = T000N4_A181TIPOS_DE_HARDWARE_ID[0] ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A181TIPOS_DE_HARDWARE_ID", StringUtil.LTrim( StringUtil.Str( (decimal)(A181TIPOS_DE_HARDWARE_ID), 4, 0)));
            A58HARDWARE_DESCRIPCION = T000N4_A58HARDWARE_DESCRIPCION[0] ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A58HARDWARE_DESCRIPCION", A58HARDWARE_DESCRIPCION);
            A182fecha_alta = T000N4_A182fecha_alta[0] ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A182fecha_alta", context.localUtil.TToC( A182fecha_alta, 10, 8, 0, 3, "/", ":", " "));
            n182fecha_alta = T000N4_n182fecha_alta[0] ;
            A187NOMBRE_DEL_TIPO_DE_HD = T000N4_A187NOMBRE_DEL_TIPO_DE_HD[0] ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A187NOMBRE_DEL_TIPO_DE_HD", A187NOMBRE_DEL_TIPO_DE_HD);
            A313TH_DIREC = T000N4_A313TH_DIREC[0] ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A313TH_DIREC", StringUtil.LTrim( StringUtil.Str( (decimal)(A313TH_DIREC), 2, 0)));
            A183MODELO_DE_COMPONENTES_ID = T000N4_A183MODELO_DE_COMPONENTES_ID[0] ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A183MODELO_DE_COMPONENTES_ID", StringUtil.LTrim( StringUtil.Str( (decimal)(A183MODELO_DE_COMPONENTES_ID), 4, 0)));
            A188MODELO_DE_COMPONENTES_NOMBRE = T000N4_A188MODELO_DE_COMPONENTES_NOMBRE[0] ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A188MODELO_DE_COMPONENTES_NOMBRE", A188MODELO_DE_COMPONENTES_NOMBRE);
            A189MARCAS_ID = T000N4_A189MARCAS_ID[0] ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A189MARCAS_ID", StringUtil.LTrim( StringUtil.Str( (decimal)(A189MARCAS_ID), 4, 0)));
            A190MARCAS_DESCRIPCION = T000N4_A190MARCAS_DESCRIPCION[0] ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A190MARCAS_DESCRIPCION", A190MARCAS_DESCRIPCION);
            A184HARDWARE_NRO_BIEN = T000N4_A184HARDWARE_NRO_BIEN[0] ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A184HARDWARE_NRO_BIEN", StringUtil.LTrim( StringUtil.Str( (decimal)(A184HARDWARE_NRO_BIEN), 10, 0)));
            A9HARDWARE_NRO_SERIE = T000N4_A9HARDWARE_NRO_SERIE[0] ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A9HARDWARE_NRO_SERIE", A9HARDWARE_NRO_SERIE);
            A185ACTIVO = T000N4_A185ACTIVO[0] ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A185ACTIVO", A185ACTIVO);
            n185ACTIVO = T000N4_n185ACTIVO[0] ;
            A186fecha_baja = T000N4_A186fecha_baja[0] ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A186fecha_baja", context.localUtil.TToC( A186fecha_baja, 10, 8, 0, 3, "/", ":", " "));
            n186fecha_baja = T000N4_n186fecha_baja[0] ;
            A192PRUEBA_MICROFONO_AUDIO = T000N4_A192PRUEBA_MICROFONO_AUDIO[0] ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A192PRUEBA_MICROFONO_AUDIO", A192PRUEBA_MICROFONO_AUDIO);
            A193RESPONSABLE_ARMADO_PC = T000N4_A193RESPONSABLE_ARMADO_PC[0] ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A193RESPONSABLE_ARMADO_PC", A193RESPONSABLE_ARMADO_PC);
            A104HDW_IDT = T000N4_A104HDW_IDT[0] ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A104HDW_IDT", StringUtil.LTrim( StringUtil.Str( (decimal)(A104HDW_IDT), 8, 0)));
            A314HARDWARE_UBA = T000N4_A314HARDWARE_UBA[0] ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A314HARDWARE_UBA", StringUtil.LTrim( StringUtil.Str( (decimal)(A314HARDWARE_UBA), 10, 0)));
            n314HARDWARE_UBA = T000N4_n314HARDWARE_UBA[0] ;
            ZM0N23( -43) ;
         }
         pr_default.close(2);
         OnLoadActions0N23( ) ;
      }

      protected void OnLoadActions0N23( )
      {
         if ( StringUtil.StrCmp(A185ACTIVO, "No") == 0 )
         {
            A299TIPO_DIR_IP = 0 ;
            n299TIPO_DIR_IP = false ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A299TIPO_DIR_IP", StringUtil.LTrim( StringUtil.Str( (decimal)(A299TIPO_DIR_IP), 2, 0)));
         }
         if ( ( A299TIPO_DIR_IP == 2 ) && ( StringUtil.StrCmp(A185ACTIVO, "No") != 0 ) )
         {
            dynTHARDWARE_UBI.Enabled = 1 ;
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, dynTHARDWARE_UBI_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(dynTHARDWARE_UBI.Enabled), 5, 0)));
         }
         else
         {
            if ( A299TIPO_DIR_IP != 2 )
            {
               dynTHARDWARE_UBI.Enabled = 0 ;
               context.httpAjaxContext.ajax_rsp_assign_prop("", false, dynTHARDWARE_UBI_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(dynTHARDWARE_UBI.Enabled), 5, 0)));
            }
            else
            {
               if ( StringUtil.StrCmp(A185ACTIVO, "No") == 0 )
               {
                  dynTHARDWARE_UBI.Enabled = 0 ;
                  context.httpAjaxContext.ajax_rsp_assign_prop("", false, dynTHARDWARE_UBI_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(dynTHARDWARE_UBI.Enabled), 5, 0)));
               }
            }
         }
         if ( ( A299TIPO_DIR_IP == 2 ) && ( StringUtil.StrCmp(A185ACTIVO, "No") != 0 ) )
         {
            dynHARDWARE_RED.Enabled = 1 ;
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, dynHARDWARE_RED_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(dynHARDWARE_RED.Enabled), 5, 0)));
         }
         else
         {
            if ( A299TIPO_DIR_IP != 2 )
            {
               dynHARDWARE_RED.Enabled = 0 ;
               context.httpAjaxContext.ajax_rsp_assign_prop("", false, dynHARDWARE_RED_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(dynHARDWARE_RED.Enabled), 5, 0)));
            }
            else
            {
               if ( StringUtil.StrCmp(A185ACTIVO, "No") == 0 )
               {
                  dynHARDWARE_RED.Enabled = 0 ;
                  context.httpAjaxContext.ajax_rsp_assign_prop("", false, dynHARDWARE_RED_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(dynHARDWARE_RED.Enabled), 5, 0)));
               }
            }
         }
         if ( A299TIPO_DIR_IP != 2 )
         {
            A311HARDWARE_RED = 0 ;
            n311HARDWARE_RED = false ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A311HARDWARE_RED", StringUtil.LTrim( StringUtil.Str( (decimal)(A311HARDWARE_RED), 10, 0)));
         }
         else
         {
            if ( StringUtil.StrCmp(A185ACTIVO, "No") == 0 )
            {
               A311HARDWARE_RED = 0 ;
               n311HARDWARE_RED = false ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A311HARDWARE_RED", StringUtil.LTrim( StringUtil.Str( (decimal)(A311HARDWARE_RED), 10, 0)));
            }
         }
         if ( A299TIPO_DIR_IP != 2 )
         {
            A312HARDWARE_IP = 0 ;
            n312HARDWARE_IP = false ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A312HARDWARE_IP", StringUtil.LTrim( StringUtil.Str( (decimal)(A312HARDWARE_IP), 3, 0)));
         }
         else
         {
            if ( StringUtil.StrCmp(A185ACTIVO, "No") == 0 )
            {
               A312HARDWARE_IP = 0 ;
               n312HARDWARE_IP = false ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A312HARDWARE_IP", StringUtil.LTrim( StringUtil.Str( (decimal)(A312HARDWARE_IP), 3, 0)));
            }
         }
         if ( ( A299TIPO_DIR_IP != 2 ) && true /* After */ )
         {
            AV15Red_DireccionDesde = "0.0.0.0" ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV15Red_DireccionDesde", AV15Red_DireccionDesde);
         }
         else
         {
            if ( ( StringUtil.StrCmp(A185ACTIVO, "No") == 0 ) && true /* After */ )
            {
               AV15Red_DireccionDesde = "0.0.0.0" ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV15Red_DireccionDesde", AV15Red_DireccionDesde);
            }
         }
         if ( ( A299TIPO_DIR_IP != 2 ) && true /* After */ )
         {
            AV19Red_DireccionHasta = "0.0.0.0" ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV19Red_DireccionHasta", AV19Red_DireccionHasta);
         }
         else
         {
            if ( ( StringUtil.StrCmp(A185ACTIVO, "No") == 0 ) && true /* After */ )
            {
               AV19Red_DireccionHasta = "0.0.0.0" ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV19Red_DireccionHasta", AV19Red_DireccionHasta);
            }
         }
         if ( ( A299TIPO_DIR_IP != 2 ) && true /* After */ )
         {
            AV20Red_Mascara = "0.0.0.0" ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV20Red_Mascara", AV20Red_Mascara);
         }
         else
         {
            if ( ( StringUtil.StrCmp(A185ACTIVO, "No") == 0 ) && true /* After */ )
            {
               AV20Red_Mascara = "0.0.0.0" ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV20Red_Mascara", AV20Red_Mascara);
            }
         }
         if ( ( A299TIPO_DIR_IP != 2 ) && true /* After */ )
         {
            AV21Red_PuertaEnlace = "0.0.0.0" ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV21Red_PuertaEnlace", AV21Red_PuertaEnlace);
         }
         else
         {
            if ( ( StringUtil.StrCmp(A185ACTIVO, "No") == 0 ) && true /* After */ )
            {
               AV21Red_PuertaEnlace = "0.0.0.0" ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV21Red_PuertaEnlace", AV21Red_PuertaEnlace);
            }
         }
         if ( ( A299TIPO_DIR_IP != 2 ) && true /* After */ )
         {
            AV16Red_DireccionDesdeB1 = 0 ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV16Red_DireccionDesdeB1", StringUtil.LTrim( StringUtil.Str( (decimal)(AV16Red_DireccionDesdeB1), 3, 0)));
         }
         else
         {
            if ( ( StringUtil.StrCmp(A185ACTIVO, "No") == 0 ) && true /* After */ )
            {
               AV16Red_DireccionDesdeB1 = 0 ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV16Red_DireccionDesdeB1", StringUtil.LTrim( StringUtil.Str( (decimal)(AV16Red_DireccionDesdeB1), 3, 0)));
            }
         }
         if ( ( A299TIPO_DIR_IP != 2 ) && true /* After */ )
         {
            AV17Red_DireccionDesdeB2 = 0 ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV17Red_DireccionDesdeB2", StringUtil.LTrim( StringUtil.Str( (decimal)(AV17Red_DireccionDesdeB2), 3, 0)));
         }
         else
         {
            if ( ( StringUtil.StrCmp(A185ACTIVO, "No") == 0 ) && true /* After */ )
            {
               AV17Red_DireccionDesdeB2 = 0 ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV17Red_DireccionDesdeB2", StringUtil.LTrim( StringUtil.Str( (decimal)(AV17Red_DireccionDesdeB2), 3, 0)));
            }
         }
         if ( ( A299TIPO_DIR_IP != 2 ) && true /* After */ )
         {
            AV18Red_DireccionDesdeB3 = 0 ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV18Red_DireccionDesdeB3", StringUtil.LTrim( StringUtil.Str( (decimal)(AV18Red_DireccionDesdeB3), 3, 0)));
         }
         else
         {
            if ( ( StringUtil.StrCmp(A185ACTIVO, "No") == 0 ) && true /* After */ )
            {
               AV18Red_DireccionDesdeB3 = 0 ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV18Red_DireccionDesdeB3", StringUtil.LTrim( StringUtil.Str( (decimal)(AV18Red_DireccionDesdeB3), 3, 0)));
            }
         }
         if ( StringUtil.StrCmp(A185ACTIVO, "No") == 0 )
         {
            cmbTIPO_DIR_IP.Enabled = 0 ;
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, cmbTIPO_DIR_IP_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(cmbTIPO_DIR_IP.Enabled), 5, 0)));
         }
         else
         {
            if ( StringUtil.StrCmp(A185ACTIVO, "No") != 0 )
            {
               cmbTIPO_DIR_IP.Enabled = 1 ;
               context.httpAjaxContext.ajax_rsp_assign_prop("", false, cmbTIPO_DIR_IP_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(cmbTIPO_DIR_IP.Enabled), 5, 0)));
            }
         }
         if ( A299TIPO_DIR_IP != 2 )
         {
            A194THARDWARE_UBI = 0 ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A194THARDWARE_UBI", StringUtil.LTrim( StringUtil.Str( (decimal)(A194THARDWARE_UBI), 10, 0)));
         }
         else
         {
            if ( StringUtil.StrCmp(A185ACTIVO, "No") == 0 )
            {
               A194THARDWARE_UBI = 0 ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A194THARDWARE_UBI", StringUtil.LTrim( StringUtil.Str( (decimal)(A194THARDWARE_UBI), 10, 0)));
            }
            else
            {
               if ( ( StringUtil.StrCmp(Gx_mode, "INS") == 0 )  && (0==A194THARDWARE_UBI) && ( Gx_BScreen == 0 ) )
               {
                  A194THARDWARE_UBI = 1 ;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A194THARDWARE_UBI", StringUtil.LTrim( StringUtil.Str( (decimal)(A194THARDWARE_UBI), 10, 0)));
               }
            }
         }
         GXAHARDWARE_RED_html0N23( A194THARDWARE_UBI) ;
      }

      protected void CheckExtendedTable0N23( )
      {
         Gx_BScreen = 1 ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_BScreen", StringUtil.Str( (decimal)(Gx_BScreen), 1, 0));
         standaloneModal( ) ;
         if ( ( A299TIPO_DIR_IP == 2 ) && ( StringUtil.StrCmp(A185ACTIVO, "No") != 0 ) && true /* After */ && ( StringUtil.StrCmp(Gx_mode, "INS") != 0 ) )
         {
            new phdw_ip_5(context ).execute(  A194THARDWARE_UBI,  A311HARDWARE_RED,  A10HARDWARE_ID, out  AV15Red_DireccionDesde, out  AV19Red_DireccionHasta, out  AV20Red_Mascara, out  AV21Red_PuertaEnlace, out  AV16Red_DireccionDesdeB1, out  AV17Red_DireccionDesdeB2, out  AV18Red_DireccionDesdeB3) ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A194THARDWARE_UBI", StringUtil.LTrim( StringUtil.Str( (decimal)(A194THARDWARE_UBI), 10, 0)));
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A311HARDWARE_RED", StringUtil.LTrim( StringUtil.Str( (decimal)(A311HARDWARE_RED), 10, 0)));
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A10HARDWARE_ID", StringUtil.LTrim( StringUtil.Str( (decimal)(A10HARDWARE_ID), 4, 0)));
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV15Red_DireccionDesde", AV15Red_DireccionDesde);
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV19Red_DireccionHasta", AV19Red_DireccionHasta);
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV20Red_Mascara", AV20Red_Mascara);
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV21Red_PuertaEnlace", AV21Red_PuertaEnlace);
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV16Red_DireccionDesdeB1", StringUtil.LTrim( StringUtil.Str( (decimal)(AV16Red_DireccionDesdeB1), 3, 0)));
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV17Red_DireccionDesdeB2", StringUtil.LTrim( StringUtil.Str( (decimal)(AV17Red_DireccionDesdeB2), 3, 0)));
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV18Red_DireccionDesdeB3", StringUtil.LTrim( StringUtil.Str( (decimal)(AV18Red_DireccionDesdeB3), 3, 0)));
         }
         if ( ( StringUtil.StrCmp(A185ACTIVO, "No") != 0 ) && ( A299TIPO_DIR_IP == 2 ) )
         {
            new phdw_ip_6(context ).execute(  A10HARDWARE_ID,  A194THARDWARE_UBI,  A311HARDWARE_RED,  A312HARDWARE_IP, out  AV33validado, out  AV34mensaje) ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A10HARDWARE_ID", StringUtil.LTrim( StringUtil.Str( (decimal)(A10HARDWARE_ID), 4, 0)));
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A194THARDWARE_UBI", StringUtil.LTrim( StringUtil.Str( (decimal)(A194THARDWARE_UBI), 10, 0)));
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A311HARDWARE_RED", StringUtil.LTrim( StringUtil.Str( (decimal)(A311HARDWARE_RED), 10, 0)));
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A312HARDWARE_IP", StringUtil.LTrim( StringUtil.Str( (decimal)(A312HARDWARE_IP), 3, 0)));
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV33validado", StringUtil.Str( (decimal)(AV33validado), 1, 0));
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV34mensaje", AV34mensaje);
         }
         if ( ( ( StringUtil.StrCmp(StringUtil.Trim( A58HARDWARE_DESCRIPCION), "") == 0 ) ) && ( true /* After */ ) )
         {
            GX_msglist.addItem("Debe cargar una descripción.", 1, "");
            AnyError = 1 ;
         }
         if ( ! ( (DateTime.MinValue==A182fecha_alta) || ( A182fecha_alta >= context.localUtil.YMDHMSToT( 1753, 1, 1, 0, 0, 0) ) ) )
         {
            GX_msglist.addItem("Campo fecha_alta fuera de rango", "OutOfRange", 1, "");
            AnyError = 1 ;
         }
         if ( ( (DateTime.MinValue==A182fecha_alta) ) && ( true /* After */ ) )
         {
            GX_msglist.addItem("Debe cargar una fecha de alta.", 1, "");
            AnyError = 1 ;
         }
         if ( String.IsNullOrEmpty(StringUtil.RTrim( A9HARDWARE_NRO_SERIE)) && (0==A184HARDWARE_NRO_BIEN) )
         {
            GX_msglist.addItem("Al menos el nro. de serie o el nro. de bien deben tener un valor.", 1, "");
            AnyError = 1 ;
         }
         if ( StringUtil.StrCmp(A185ACTIVO, "No") == 0 )
         {
            A299TIPO_DIR_IP = 0 ;
            n299TIPO_DIR_IP = false ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A299TIPO_DIR_IP", StringUtil.LTrim( StringUtil.Str( (decimal)(A299TIPO_DIR_IP), 2, 0)));
         }
         if ( ( A299TIPO_DIR_IP == 2 ) && ( StringUtil.StrCmp(A185ACTIVO, "No") != 0 ) )
         {
            dynTHARDWARE_UBI.Enabled = 1 ;
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, dynTHARDWARE_UBI_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(dynTHARDWARE_UBI.Enabled), 5, 0)));
         }
         else
         {
            if ( A299TIPO_DIR_IP != 2 )
            {
               dynTHARDWARE_UBI.Enabled = 0 ;
               context.httpAjaxContext.ajax_rsp_assign_prop("", false, dynTHARDWARE_UBI_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(dynTHARDWARE_UBI.Enabled), 5, 0)));
            }
            else
            {
               if ( StringUtil.StrCmp(A185ACTIVO, "No") == 0 )
               {
                  dynTHARDWARE_UBI.Enabled = 0 ;
                  context.httpAjaxContext.ajax_rsp_assign_prop("", false, dynTHARDWARE_UBI_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(dynTHARDWARE_UBI.Enabled), 5, 0)));
               }
            }
         }
         if ( ( A299TIPO_DIR_IP == 2 ) && ( StringUtil.StrCmp(A185ACTIVO, "No") != 0 ) )
         {
            dynHARDWARE_RED.Enabled = 1 ;
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, dynHARDWARE_RED_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(dynHARDWARE_RED.Enabled), 5, 0)));
         }
         else
         {
            if ( A299TIPO_DIR_IP != 2 )
            {
               dynHARDWARE_RED.Enabled = 0 ;
               context.httpAjaxContext.ajax_rsp_assign_prop("", false, dynHARDWARE_RED_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(dynHARDWARE_RED.Enabled), 5, 0)));
            }
            else
            {
               if ( StringUtil.StrCmp(A185ACTIVO, "No") == 0 )
               {
                  dynHARDWARE_RED.Enabled = 0 ;
                  context.httpAjaxContext.ajax_rsp_assign_prop("", false, dynHARDWARE_RED_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(dynHARDWARE_RED.Enabled), 5, 0)));
               }
            }
         }
         if ( A299TIPO_DIR_IP != 2 )
         {
            A311HARDWARE_RED = 0 ;
            n311HARDWARE_RED = false ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A311HARDWARE_RED", StringUtil.LTrim( StringUtil.Str( (decimal)(A311HARDWARE_RED), 10, 0)));
         }
         else
         {
            if ( StringUtil.StrCmp(A185ACTIVO, "No") == 0 )
            {
               A311HARDWARE_RED = 0 ;
               n311HARDWARE_RED = false ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A311HARDWARE_RED", StringUtil.LTrim( StringUtil.Str( (decimal)(A311HARDWARE_RED), 10, 0)));
            }
         }
         if ( A299TIPO_DIR_IP != 2 )
         {
            A312HARDWARE_IP = 0 ;
            n312HARDWARE_IP = false ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A312HARDWARE_IP", StringUtil.LTrim( StringUtil.Str( (decimal)(A312HARDWARE_IP), 3, 0)));
         }
         else
         {
            if ( StringUtil.StrCmp(A185ACTIVO, "No") == 0 )
            {
               A312HARDWARE_IP = 0 ;
               n312HARDWARE_IP = false ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A312HARDWARE_IP", StringUtil.LTrim( StringUtil.Str( (decimal)(A312HARDWARE_IP), 3, 0)));
            }
         }
         if ( ( A299TIPO_DIR_IP != 2 ) && true /* After */ )
         {
            AV15Red_DireccionDesde = "0.0.0.0" ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV15Red_DireccionDesde", AV15Red_DireccionDesde);
         }
         else
         {
            if ( ( StringUtil.StrCmp(A185ACTIVO, "No") == 0 ) && true /* After */ )
            {
               AV15Red_DireccionDesde = "0.0.0.0" ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV15Red_DireccionDesde", AV15Red_DireccionDesde);
            }
         }
         if ( ( A299TIPO_DIR_IP != 2 ) && true /* After */ )
         {
            AV19Red_DireccionHasta = "0.0.0.0" ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV19Red_DireccionHasta", AV19Red_DireccionHasta);
         }
         else
         {
            if ( ( StringUtil.StrCmp(A185ACTIVO, "No") == 0 ) && true /* After */ )
            {
               AV19Red_DireccionHasta = "0.0.0.0" ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV19Red_DireccionHasta", AV19Red_DireccionHasta);
            }
         }
         if ( ( A299TIPO_DIR_IP != 2 ) && true /* After */ )
         {
            AV20Red_Mascara = "0.0.0.0" ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV20Red_Mascara", AV20Red_Mascara);
         }
         else
         {
            if ( ( StringUtil.StrCmp(A185ACTIVO, "No") == 0 ) && true /* After */ )
            {
               AV20Red_Mascara = "0.0.0.0" ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV20Red_Mascara", AV20Red_Mascara);
            }
         }
         if ( ( A299TIPO_DIR_IP != 2 ) && true /* After */ )
         {
            AV21Red_PuertaEnlace = "0.0.0.0" ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV21Red_PuertaEnlace", AV21Red_PuertaEnlace);
         }
         else
         {
            if ( ( StringUtil.StrCmp(A185ACTIVO, "No") == 0 ) && true /* After */ )
            {
               AV21Red_PuertaEnlace = "0.0.0.0" ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV21Red_PuertaEnlace", AV21Red_PuertaEnlace);
            }
         }
         if ( ( A299TIPO_DIR_IP != 2 ) && true /* After */ )
         {
            AV16Red_DireccionDesdeB1 = 0 ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV16Red_DireccionDesdeB1", StringUtil.LTrim( StringUtil.Str( (decimal)(AV16Red_DireccionDesdeB1), 3, 0)));
         }
         else
         {
            if ( ( StringUtil.StrCmp(A185ACTIVO, "No") == 0 ) && true /* After */ )
            {
               AV16Red_DireccionDesdeB1 = 0 ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV16Red_DireccionDesdeB1", StringUtil.LTrim( StringUtil.Str( (decimal)(AV16Red_DireccionDesdeB1), 3, 0)));
            }
         }
         if ( ( A299TIPO_DIR_IP != 2 ) && true /* After */ )
         {
            AV17Red_DireccionDesdeB2 = 0 ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV17Red_DireccionDesdeB2", StringUtil.LTrim( StringUtil.Str( (decimal)(AV17Red_DireccionDesdeB2), 3, 0)));
         }
         else
         {
            if ( ( StringUtil.StrCmp(A185ACTIVO, "No") == 0 ) && true /* After */ )
            {
               AV17Red_DireccionDesdeB2 = 0 ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV17Red_DireccionDesdeB2", StringUtil.LTrim( StringUtil.Str( (decimal)(AV17Red_DireccionDesdeB2), 3, 0)));
            }
         }
         if ( ( A299TIPO_DIR_IP != 2 ) && true /* After */ )
         {
            AV18Red_DireccionDesdeB3 = 0 ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV18Red_DireccionDesdeB3", StringUtil.LTrim( StringUtil.Str( (decimal)(AV18Red_DireccionDesdeB3), 3, 0)));
         }
         else
         {
            if ( ( StringUtil.StrCmp(A185ACTIVO, "No") == 0 ) && true /* After */ )
            {
               AV18Red_DireccionDesdeB3 = 0 ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV18Red_DireccionDesdeB3", StringUtil.LTrim( StringUtil.Str( (decimal)(AV18Red_DireccionDesdeB3), 3, 0)));
            }
         }
         if ( StringUtil.StrCmp(A185ACTIVO, "No") == 0 )
         {
            cmbTIPO_DIR_IP.Enabled = 0 ;
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, cmbTIPO_DIR_IP_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(cmbTIPO_DIR_IP.Enabled), 5, 0)));
         }
         else
         {
            if ( StringUtil.StrCmp(A185ACTIVO, "No") != 0 )
            {
               cmbTIPO_DIR_IP.Enabled = 1 ;
               context.httpAjaxContext.ajax_rsp_assign_prop("", false, cmbTIPO_DIR_IP_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(cmbTIPO_DIR_IP.Enabled), 5, 0)));
            }
         }
         if ( ( String.IsNullOrEmpty(StringUtil.RTrim( A185ACTIVO)) ) && ( true /* After */ ) )
         {
            GX_msglist.addItem("El bien debe tener un estado.", 1, "");
            AnyError = 1 ;
         }
         if ( ! ( (DateTime.MinValue==A186fecha_baja) || ( A186fecha_baja >= context.localUtil.YMDHMSToT( 1753, 1, 1, 0, 0, 0) ) ) )
         {
            GX_msglist.addItem("Campo fecha_baja fuera de rango", "OutOfRange", 1, "");
            AnyError = 1 ;
         }
         if ( ( ( StringUtil.StrCmp(A185ACTIVO, "No") == 0 ) ) && ( (DateTime.MinValue==A186fecha_baja) ) && ( true /* After */ ) )
         {
            GX_msglist.addItem("Debe cargar una fecha de baja.", 1, "");
            AnyError = 1 ;
         }
         if ( ! (DateTime.MinValue==A186fecha_baja) && ( A104HDW_IDT != 0 ) && true /* After */ )
         {
            new ptbus033(context ).execute(  A104HDW_IDT, out  AV37error_2) ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A104HDW_IDT", StringUtil.LTrim( StringUtil.Str( (decimal)(A104HDW_IDT), 8, 0)));
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV37error_2", StringUtil.Str( (decimal)(AV37error_2), 1, 0));
         }
         if ( ( AV37error_2 == 1 ) && ! (DateTime.MinValue==A186fecha_baja) && ( A104HDW_IDT != 0 ) && true /* After */ )
         {
            GX_msglist.addItem("No puede dar de baja este equipo porque no está dado de baja en trazabilidad de bienes de uso.", 1, "");
            AnyError = 1 ;
         }
         if ( ( (0==A299TIPO_DIR_IP) ) && ( ( StringUtil.StrCmp(A185ACTIVO, "No") != 0 ) ) && ( ( A313TH_DIREC == 2 ) ) && ( true /* After */ ) )
         {
            GX_msglist.addItem("Debe especificar un tipo de dirección IP.", 1, "");
            AnyError = 1 ;
         }
         if ( ! ( (0==A299TIPO_DIR_IP) ) && ( ( StringUtil.StrCmp(A185ACTIVO, "No") != 0 ) ) && ( ( A313TH_DIREC == 1 ) ) && ( true /* After */ ) )
         {
            GX_msglist.addItem("El tipo de hardware no es direccionable.", 1, "");
            AnyError = 1 ;
         }
         if ( ( A299TIPO_DIR_IP == 2 ) && ( StringUtil.StrCmp(A185ACTIVO, "No") != 0 ) && true /* After */ && ( ( StringUtil.StrCmp(Gx_mode, "INS") == 0 ) || ( StringUtil.StrCmp(Gx_mode, "UPD") == 0 ) ) )
         {
            new phdw_ip_5(context ).execute(  A194THARDWARE_UBI,  A311HARDWARE_RED,  A10HARDWARE_ID, out  AV15Red_DireccionDesde, out  AV19Red_DireccionHasta, out  AV20Red_Mascara, out  AV21Red_PuertaEnlace, out  AV16Red_DireccionDesdeB1, out  AV17Red_DireccionDesdeB2, out  AV18Red_DireccionDesdeB3) ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A194THARDWARE_UBI", StringUtil.LTrim( StringUtil.Str( (decimal)(A194THARDWARE_UBI), 10, 0)));
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A311HARDWARE_RED", StringUtil.LTrim( StringUtil.Str( (decimal)(A311HARDWARE_RED), 10, 0)));
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A10HARDWARE_ID", StringUtil.LTrim( StringUtil.Str( (decimal)(A10HARDWARE_ID), 4, 0)));
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV15Red_DireccionDesde", AV15Red_DireccionDesde);
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV19Red_DireccionHasta", AV19Red_DireccionHasta);
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV20Red_Mascara", AV20Red_Mascara);
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV21Red_PuertaEnlace", AV21Red_PuertaEnlace);
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV16Red_DireccionDesdeB1", StringUtil.LTrim( StringUtil.Str( (decimal)(AV16Red_DireccionDesdeB1), 3, 0)));
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV17Red_DireccionDesdeB2", StringUtil.LTrim( StringUtil.Str( (decimal)(AV17Red_DireccionDesdeB2), 3, 0)));
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV18Red_DireccionDesdeB3", StringUtil.LTrim( StringUtil.Str( (decimal)(AV18Red_DireccionDesdeB3), 3, 0)));
         }
         if ( ( A104HDW_IDT != 0 ) && true /* After */ )
         {
            new ptbus032_1(context ).execute(  A10HARDWARE_ID,  A104HDW_IDT, out  AV36error, out  AV34mensaje) ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A10HARDWARE_ID", StringUtil.LTrim( StringUtil.Str( (decimal)(A10HARDWARE_ID), 4, 0)));
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A104HDW_IDT", StringUtil.LTrim( StringUtil.Str( (decimal)(A104HDW_IDT), 8, 0)));
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV36error", StringUtil.Str( (decimal)(AV36error), 1, 0));
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV34mensaje", AV34mensaje);
         }
         if ( ( AV36error == 1 ) && ( A104HDW_IDT != 0 ) && true /* After */ )
         {
            GX_msglist.addItem(AV34mensaje, 1, "");
            AnyError = 1 ;
         }
         if ( A299TIPO_DIR_IP != 2 )
         {
            A194THARDWARE_UBI = 0 ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A194THARDWARE_UBI", StringUtil.LTrim( StringUtil.Str( (decimal)(A194THARDWARE_UBI), 10, 0)));
         }
         else
         {
            if ( StringUtil.StrCmp(A185ACTIVO, "No") == 0 )
            {
               A194THARDWARE_UBI = 0 ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A194THARDWARE_UBI", StringUtil.LTrim( StringUtil.Str( (decimal)(A194THARDWARE_UBI), 10, 0)));
            }
            else
            {
               if ( ( StringUtil.StrCmp(Gx_mode, "INS") == 0 )  && (0==A194THARDWARE_UBI) && ( Gx_BScreen == 0 ) )
               {
                  A194THARDWARE_UBI = 1 ;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A194THARDWARE_UBI", StringUtil.LTrim( StringUtil.Str( (decimal)(A194THARDWARE_UBI), 10, 0)));
               }
            }
         }
         GXAHARDWARE_RED_html0N23( A194THARDWARE_UBI) ;
      }

      protected void CloseExtendedTableCursors0N23( )
      {
      }

      protected void enableDisable( )
      {
      }

      protected void GetKey0N23( )
      {
         /* Using cursor T000N5 */
         pr_default.execute(3, new Object[] {n10HARDWARE_ID, A10HARDWARE_ID});
         if ( (pr_default.getStatus(3) != 101) )
         {
            RcdFound23 = 1 ;
         }
         else
         {
            RcdFound23 = 0 ;
         }
         pr_default.close(3);
      }

      protected void getByPrimaryKey( )
      {
         /* Using cursor T000N3 */
         pr_default.execute(1, new Object[] {n10HARDWARE_ID, A10HARDWARE_ID});
         if ( (pr_default.getStatus(1) != 101) )
         {
            ZM0N23( 43) ;
            RcdFound23 = 1 ;
            A10HARDWARE_ID = T000N3_A10HARDWARE_ID[0] ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A10HARDWARE_ID", StringUtil.LTrim( StringUtil.Str( (decimal)(A10HARDWARE_ID), 4, 0)));
            n10HARDWARE_ID = T000N3_n10HARDWARE_ID[0] ;
            A194THARDWARE_UBI = T000N3_A194THARDWARE_UBI[0] ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A194THARDWARE_UBI", StringUtil.LTrim( StringUtil.Str( (decimal)(A194THARDWARE_UBI), 10, 0)));
            A311HARDWARE_RED = T000N3_A311HARDWARE_RED[0] ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A311HARDWARE_RED", StringUtil.LTrim( StringUtil.Str( (decimal)(A311HARDWARE_RED), 10, 0)));
            n311HARDWARE_RED = T000N3_n311HARDWARE_RED[0] ;
            A312HARDWARE_IP = T000N3_A312HARDWARE_IP[0] ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A312HARDWARE_IP", StringUtil.LTrim( StringUtil.Str( (decimal)(A312HARDWARE_IP), 3, 0)));
            n312HARDWARE_IP = T000N3_n312HARDWARE_IP[0] ;
            A299TIPO_DIR_IP = T000N3_A299TIPO_DIR_IP[0] ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A299TIPO_DIR_IP", StringUtil.LTrim( StringUtil.Str( (decimal)(A299TIPO_DIR_IP), 2, 0)));
            n299TIPO_DIR_IP = T000N3_n299TIPO_DIR_IP[0] ;
            A181TIPOS_DE_HARDWARE_ID = T000N3_A181TIPOS_DE_HARDWARE_ID[0] ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A181TIPOS_DE_HARDWARE_ID", StringUtil.LTrim( StringUtil.Str( (decimal)(A181TIPOS_DE_HARDWARE_ID), 4, 0)));
            A58HARDWARE_DESCRIPCION = T000N3_A58HARDWARE_DESCRIPCION[0] ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A58HARDWARE_DESCRIPCION", A58HARDWARE_DESCRIPCION);
            A182fecha_alta = T000N3_A182fecha_alta[0] ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A182fecha_alta", context.localUtil.TToC( A182fecha_alta, 10, 8, 0, 3, "/", ":", " "));
            n182fecha_alta = T000N3_n182fecha_alta[0] ;
            A187NOMBRE_DEL_TIPO_DE_HD = T000N3_A187NOMBRE_DEL_TIPO_DE_HD[0] ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A187NOMBRE_DEL_TIPO_DE_HD", A187NOMBRE_DEL_TIPO_DE_HD);
            A313TH_DIREC = T000N3_A313TH_DIREC[0] ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A313TH_DIREC", StringUtil.LTrim( StringUtil.Str( (decimal)(A313TH_DIREC), 2, 0)));
            A183MODELO_DE_COMPONENTES_ID = T000N3_A183MODELO_DE_COMPONENTES_ID[0] ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A183MODELO_DE_COMPONENTES_ID", StringUtil.LTrim( StringUtil.Str( (decimal)(A183MODELO_DE_COMPONENTES_ID), 4, 0)));
            A188MODELO_DE_COMPONENTES_NOMBRE = T000N3_A188MODELO_DE_COMPONENTES_NOMBRE[0] ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A188MODELO_DE_COMPONENTES_NOMBRE", A188MODELO_DE_COMPONENTES_NOMBRE);
            A189MARCAS_ID = T000N3_A189MARCAS_ID[0] ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A189MARCAS_ID", StringUtil.LTrim( StringUtil.Str( (decimal)(A189MARCAS_ID), 4, 0)));
            A190MARCAS_DESCRIPCION = T000N3_A190MARCAS_DESCRIPCION[0] ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A190MARCAS_DESCRIPCION", A190MARCAS_DESCRIPCION);
            A184HARDWARE_NRO_BIEN = T000N3_A184HARDWARE_NRO_BIEN[0] ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A184HARDWARE_NRO_BIEN", StringUtil.LTrim( StringUtil.Str( (decimal)(A184HARDWARE_NRO_BIEN), 10, 0)));
            A9HARDWARE_NRO_SERIE = T000N3_A9HARDWARE_NRO_SERIE[0] ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A9HARDWARE_NRO_SERIE", A9HARDWARE_NRO_SERIE);
            A185ACTIVO = T000N3_A185ACTIVO[0] ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A185ACTIVO", A185ACTIVO);
            n185ACTIVO = T000N3_n185ACTIVO[0] ;
            A186fecha_baja = T000N3_A186fecha_baja[0] ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A186fecha_baja", context.localUtil.TToC( A186fecha_baja, 10, 8, 0, 3, "/", ":", " "));
            n186fecha_baja = T000N3_n186fecha_baja[0] ;
            A192PRUEBA_MICROFONO_AUDIO = T000N3_A192PRUEBA_MICROFONO_AUDIO[0] ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A192PRUEBA_MICROFONO_AUDIO", A192PRUEBA_MICROFONO_AUDIO);
            A193RESPONSABLE_ARMADO_PC = T000N3_A193RESPONSABLE_ARMADO_PC[0] ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A193RESPONSABLE_ARMADO_PC", A193RESPONSABLE_ARMADO_PC);
            A104HDW_IDT = T000N3_A104HDW_IDT[0] ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A104HDW_IDT", StringUtil.LTrim( StringUtil.Str( (decimal)(A104HDW_IDT), 8, 0)));
            A314HARDWARE_UBA = T000N3_A314HARDWARE_UBA[0] ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A314HARDWARE_UBA", StringUtil.LTrim( StringUtil.Str( (decimal)(A314HARDWARE_UBA), 10, 0)));
            n314HARDWARE_UBA = T000N3_n314HARDWARE_UBA[0] ;
            Z10HARDWARE_ID = A10HARDWARE_ID ;
            sMode23 = Gx_mode ;
            Gx_mode = "DSP" ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
            Load0N23( ) ;
            Gx_mode = sMode23 ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
         }
         else
         {
            RcdFound23 = 0 ;
            InitializeNonKey0N23( ) ;
            sMode23 = Gx_mode ;
            Gx_mode = "DSP" ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
            standaloneModal( ) ;
            Gx_mode = sMode23 ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
         }
         pr_default.close(1);
      }

      protected void getEqualNoModal( )
      {
         GetKey0N23( ) ;
         if ( RcdFound23 == 0 )
         {
         }
         else
         {
         }
         getByPrimaryKey( ) ;
      }

      protected void move_next( )
      {
         RcdFound23 = 0 ;
         /* Using cursor T000N6 */
         pr_default.execute(4, new Object[] {n10HARDWARE_ID, A10HARDWARE_ID});
         if ( (pr_default.getStatus(4) != 101) )
         {
            while ( (pr_default.getStatus(4) != 101) && ( ( T000N6_A10HARDWARE_ID[0] < A10HARDWARE_ID ) ) )
            {
               pr_default.readNext(4);
            }
            if ( (pr_default.getStatus(4) != 101) && ( ( T000N6_A10HARDWARE_ID[0] > A10HARDWARE_ID ) ) )
            {
               A10HARDWARE_ID = T000N6_A10HARDWARE_ID[0] ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A10HARDWARE_ID", StringUtil.LTrim( StringUtil.Str( (decimal)(A10HARDWARE_ID), 4, 0)));
               n10HARDWARE_ID = T000N6_n10HARDWARE_ID[0] ;
               RcdFound23 = 1 ;
            }
         }
         pr_default.close(1);
      }

      protected void move_previous( )
      {
         RcdFound23 = 0 ;
         /* Using cursor T000N7 */
         pr_default.execute(5, new Object[] {n10HARDWARE_ID, A10HARDWARE_ID});
         if ( (pr_default.getStatus(5) != 101) )
         {
            while ( (pr_default.getStatus(5) != 101) && ( ( T000N7_A10HARDWARE_ID[0] > A10HARDWARE_ID ) ) )
            {
               pr_default.readNext(5);
            }
            if ( (pr_default.getStatus(5) != 101) && ( ( T000N7_A10HARDWARE_ID[0] < A10HARDWARE_ID ) ) )
            {
               A10HARDWARE_ID = T000N7_A10HARDWARE_ID[0] ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A10HARDWARE_ID", StringUtil.LTrim( StringUtil.Str( (decimal)(A10HARDWARE_ID), 4, 0)));
               n10HARDWARE_ID = T000N7_n10HARDWARE_ID[0] ;
               RcdFound23 = 1 ;
            }
         }
         pr_default.close(0);
      }

      protected void btn_enter( )
      {
         nKeyPressed = 1 ;
         GetKey0N23( ) ;
         if ( RcdFound23 == 1 )
         {
            if ( StringUtil.StrCmp(Gx_mode, "INS") == 0 )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_noupdate"), "DuplicatePrimaryKey", 1, "HARDWARE_ID");
               AnyError = 1 ;
            }
            else if ( A10HARDWARE_ID != Z10HARDWARE_ID )
            {
               A10HARDWARE_ID = Z10HARDWARE_ID ;
               n10HARDWARE_ID = false ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A10HARDWARE_ID", StringUtil.LTrim( StringUtil.Str( (decimal)(A10HARDWARE_ID), 4, 0)));
               GX_msglist.addItem(context.GetMessage( "GXM_getbeforeupd"), "CandidateKeyNotFound", 1, "HARDWARE_ID");
               AnyError = 1 ;
            }
            else if ( StringUtil.StrCmp(Gx_mode, "DLT") == 0 )
            {
               delete( ) ;
               AfterTrn( ) ;
               GX_FocusControl = edtHARDWARE_DESCRIPCION_Internalname ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
            }
            else
            {
               /* Update record */
               Update0N23( ) ;
               GX_FocusControl = edtHARDWARE_DESCRIPCION_Internalname ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
            }
         }
         else
         {
            if ( A10HARDWARE_ID != Z10HARDWARE_ID )
            {
               /* Insert record */
               Insert0N23( ) ;
               GX_FocusControl = edtHARDWARE_DESCRIPCION_Internalname ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
            }
            else
            {
               if ( StringUtil.StrCmp(Gx_mode, "UPD") == 0 )
               {
                  GX_msglist.addItem(context.GetMessage( "GXM_recdeleted"), 1, "HARDWARE_ID");
                  AnyError = 1 ;
               }
               else
               {
                  /* Insert record */
                  Insert0N23( ) ;
                  GX_FocusControl = edtHARDWARE_DESCRIPCION_Internalname ;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
               }
            }
         }
         AfterTrn( ) ;
         if ( ( StringUtil.StrCmp(Gx_mode, "UPD") == 0 ) || ( StringUtil.StrCmp(Gx_mode, "DLT") == 0 ) )
         {
            if ( AnyError == 0 )
            {
               context.nUserReturn = 1 ;
            }
         }
      }

      protected void btn_delete( )
      {
         if ( A10HARDWARE_ID != Z10HARDWARE_ID )
         {
            A10HARDWARE_ID = Z10HARDWARE_ID ;
            n10HARDWARE_ID = false ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A10HARDWARE_ID", StringUtil.LTrim( StringUtil.Str( (decimal)(A10HARDWARE_ID), 4, 0)));
            GX_msglist.addItem(context.GetMessage( "GXM_getbeforedlt"), 1, "HARDWARE_ID");
            AnyError = 1 ;
         }
         else
         {
            delete( ) ;
            AfterTrn( ) ;
            GX_FocusControl = edtHARDWARE_DESCRIPCION_Internalname ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
         }
         if ( AnyError != 0 )
         {
         }
      }

      protected void btn_Check( )
      {
         nKeyPressed = 3 ;
         IsConfirmed = 0 ;
         GetKey0N23( ) ;
         if ( RcdFound23 == 1 )
         {
            if ( StringUtil.StrCmp(Gx_mode, "INS") == 0 )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_noupdate"), "DuplicatePrimaryKey", 1, "HARDWARE_ID");
               AnyError = 1 ;
            }
            else if ( A10HARDWARE_ID != Z10HARDWARE_ID )
            {
               A10HARDWARE_ID = Z10HARDWARE_ID ;
               n10HARDWARE_ID = false ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A10HARDWARE_ID", StringUtil.LTrim( StringUtil.Str( (decimal)(A10HARDWARE_ID), 4, 0)));
               GX_msglist.addItem(context.GetMessage( "GXM_getbeforeupd"), "DuplicatePrimaryKey", 1, "HARDWARE_ID");
               AnyError = 1 ;
            }
            else if ( StringUtil.StrCmp(Gx_mode, "DLT") == 0 )
            {
               delete_Check( ) ;
            }
            else
            {
               update_Check( ) ;
            }
         }
         else
         {
            if ( A10HARDWARE_ID != Z10HARDWARE_ID )
            {
               insert_Check( ) ;
            }
            else
            {
               if ( StringUtil.StrCmp(Gx_mode, "UPD") == 0 )
               {
                  GX_msglist.addItem(context.GetMessage( "GXM_recdeleted"), 1, "HARDWARE_ID");
                  AnyError = 1 ;
               }
               else
               {
                  insert_Check( ) ;
               }
            }
         }
         pr_default.close(5);
         pr_default.close(4);
         context.RollbackDataStores("THARDWARE_MAIN");
         GX_FocusControl = edtHARDWARE_DESCRIPCION_Internalname ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
      }

      protected void insert_Check( )
      {
         CONFIRM_0N0( ) ;
         IsConfirmed = 0 ;
      }

      protected void update_Check( )
      {
         insert_Check( ) ;
      }

      protected void delete_Check( )
      {
         insert_Check( ) ;
      }

      protected void CheckOptimisticConcurrency0N23( )
      {
         if ( StringUtil.StrCmp(Gx_mode, "INS") != 0 )
         {
            /* Using cursor T000N8 */
            pr_default.execute(6, new Object[] {n10HARDWARE_ID, A10HARDWARE_ID});
            if ( (pr_default.getStatus(6) == 103) )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_lock", new   object[]  {"HARDWARE"}), "RecordIsLocked", 1, "");
               AnyError = 1 ;
               return  ;
            }
            Gx_longc = false ;
            if ( (pr_default.getStatus(6) == 101) || ( Z194THARDWARE_UBI != T000N8_A194THARDWARE_UBI[0] ) || ( Z311HARDWARE_RED != T000N8_A311HARDWARE_RED[0] ) || ( Z312HARDWARE_IP != T000N8_A312HARDWARE_IP[0] ) || ( Z299TIPO_DIR_IP != T000N8_A299TIPO_DIR_IP[0] ) || ( Z181TIPOS_DE_HARDWARE_ID != T000N8_A181TIPOS_DE_HARDWARE_ID[0] ) )
            {
               Gx_longc = true ;
            }
            if ( Gx_longc || ( StringUtil.StrCmp(Z58HARDWARE_DESCRIPCION, T000N8_A58HARDWARE_DESCRIPCION[0]) != 0 ) || ( Z182fecha_alta != T000N8_A182fecha_alta[0] ) || ( StringUtil.StrCmp(Z187NOMBRE_DEL_TIPO_DE_HD, T000N8_A187NOMBRE_DEL_TIPO_DE_HD[0]) != 0 ) || ( Z313TH_DIREC != T000N8_A313TH_DIREC[0] ) || ( Z183MODELO_DE_COMPONENTES_ID != T000N8_A183MODELO_DE_COMPONENTES_ID[0] ) )
            {
               Gx_longc = true ;
            }
            if ( Gx_longc || ( StringUtil.StrCmp(Z188MODELO_DE_COMPONENTES_NOMBRE, T000N8_A188MODELO_DE_COMPONENTES_NOMBRE[0]) != 0 ) || ( Z189MARCAS_ID != T000N8_A189MARCAS_ID[0] ) || ( StringUtil.StrCmp(Z190MARCAS_DESCRIPCION, T000N8_A190MARCAS_DESCRIPCION[0]) != 0 ) || ( Z184HARDWARE_NRO_BIEN != T000N8_A184HARDWARE_NRO_BIEN[0] ) || ( StringUtil.StrCmp(Z9HARDWARE_NRO_SERIE, T000N8_A9HARDWARE_NRO_SERIE[0]) != 0 ) )
            {
               Gx_longc = true ;
            }
            if ( Gx_longc || ( StringUtil.StrCmp(Z185ACTIVO, T000N8_A185ACTIVO[0]) != 0 ) || ( Z186fecha_baja != T000N8_A186fecha_baja[0] ) || ( StringUtil.StrCmp(Z192PRUEBA_MICROFONO_AUDIO, T000N8_A192PRUEBA_MICROFONO_AUDIO[0]) != 0 ) || ( StringUtil.StrCmp(Z193RESPONSABLE_ARMADO_PC, T000N8_A193RESPONSABLE_ARMADO_PC[0]) != 0 ) || ( Z104HDW_IDT != T000N8_A104HDW_IDT[0] ) )
            {
               Gx_longc = true ;
            }
            if ( Gx_longc || ( Z314HARDWARE_UBA != T000N8_A314HARDWARE_UBA[0] ) )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_waschg", new   object[]  {"HARDWARE"}), "RecordWasChanged", 1, "");
               AnyError = 1 ;
               return  ;
            }
         }
      }

      protected void Insert0N23( )
      {
         BeforeValidate0N23( ) ;
         if ( AnyError == 0 )
         {
            CheckExtendedTable0N23( ) ;
         }
         if ( AnyError == 0 )
         {
            ZM0N23( 0) ;
            CheckOptimisticConcurrency0N23( ) ;
            if ( AnyError == 0 )
            {
               AfterConfirm0N23( ) ;
               if ( AnyError == 0 )
               {
                  BeforeInsert0N23( ) ;
                  if ( AnyError == 0 )
                  {
                     /* Using cursor T000N9 */
                     pr_default.execute(7, new Object[] {A194THARDWARE_UBI, n311HARDWARE_RED, A311HARDWARE_RED, n312HARDWARE_IP, A312HARDWARE_IP, n299TIPO_DIR_IP, A299TIPO_DIR_IP, A181TIPOS_DE_HARDWARE_ID, A58HARDWARE_DESCRIPCION, n182fecha_alta, A182fecha_alta, A187NOMBRE_DEL_TIPO_DE_HD, A313TH_DIREC, A183MODELO_DE_COMPONENTES_ID, A188MODELO_DE_COMPONENTES_NOMBRE, A189MARCAS_ID, A190MARCAS_DESCRIPCION, A184HARDWARE_NRO_BIEN, A9HARDWARE_NRO_SERIE, n185ACTIVO, A185ACTIVO, n186fecha_baja, A186fecha_baja, A192PRUEBA_MICROFONO_AUDIO, A193RESPONSABLE_ARMADO_PC, A104HDW_IDT, n314HARDWARE_UBA, A314HARDWARE_UBA});
                     pr_default.close(7);
                     /* Retrieving last key number assigned */
                     /* Using cursor T000N10 */
                     pr_default.execute(8);
                     A10HARDWARE_ID = T000N10_A10HARDWARE_ID[0] ;
                     context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A10HARDWARE_ID", StringUtil.LTrim( StringUtil.Str( (decimal)(A10HARDWARE_ID), 4, 0)));
                     n10HARDWARE_ID = T000N10_n10HARDWARE_ID[0] ;
                     pr_default.close(8);
                     if ( AnyError == 0 )
                     {
                        /* Start of After( level) rules */
                        if ( ( ( A312HARDWARE_IP == 0 ) ) && ( ( A299TIPO_DIR_IP == 2 ) ) && ( ( StringUtil.StrCmp(A185ACTIVO, "No") != 0 ) ) )
                        {
                           GX_msglist.addItem("Debe seleccionar una dirección IP.", 1, "");
                           AnyError = 1 ;
                        }
                        if ( ( ( AV33validado == 0 ) ) && ( ( A299TIPO_DIR_IP == 2 ) ) && ( ( StringUtil.StrCmp(A185ACTIVO, "No") != 0 ) ) )
                        {
                           GX_msglist.addItem(AV34mensaje, 1, "");
                           AnyError = 1 ;
                        }
                        /* Start of After( Insert) rules */
                        /* End of After( Insert) rules */
                        if ( AnyError == 0 )
                        {
                           /* Save values for previous() function. */
                           GX_msglist.addItem(context.GetMessage( "GXM_sucadded"), 0, "");
                           ResetCaption0N0( ) ;
                        }
                     }
                  }
                  else
                  {
                     GX_msglist.addItem(context.GetMessage( "GXM_unexp"), 1, "");
                     AnyError = 1 ;
                  }
               }
            }
            else
            {
               Load0N23( ) ;
            }
            EndLevel0N23( ) ;
         }
         CloseExtendedTableCursors0N23( ) ;
      }

      protected void Update0N23( )
      {
         BeforeValidate0N23( ) ;
         if ( AnyError == 0 )
         {
            CheckExtendedTable0N23( ) ;
         }
         if ( AnyError == 0 )
         {
            CheckOptimisticConcurrency0N23( ) ;
            if ( AnyError == 0 )
            {
               AfterConfirm0N23( ) ;
               if ( AnyError == 0 )
               {
                  BeforeUpdate0N23( ) ;
                  if ( AnyError == 0 )
                  {
                     /* Using cursor T000N11 */
                     pr_default.execute(9, new Object[] {A194THARDWARE_UBI, n311HARDWARE_RED, A311HARDWARE_RED, n312HARDWARE_IP, A312HARDWARE_IP, n299TIPO_DIR_IP, A299TIPO_DIR_IP, A181TIPOS_DE_HARDWARE_ID, A58HARDWARE_DESCRIPCION, n182fecha_alta, A182fecha_alta, A187NOMBRE_DEL_TIPO_DE_HD, A313TH_DIREC, A183MODELO_DE_COMPONENTES_ID, A188MODELO_DE_COMPONENTES_NOMBRE, A189MARCAS_ID, A190MARCAS_DESCRIPCION, A184HARDWARE_NRO_BIEN, A9HARDWARE_NRO_SERIE, n185ACTIVO, A185ACTIVO, n186fecha_baja, A186fecha_baja, A192PRUEBA_MICROFONO_AUDIO, A193RESPONSABLE_ARMADO_PC, A104HDW_IDT, n314HARDWARE_UBA, A314HARDWARE_UBA, n10HARDWARE_ID, A10HARDWARE_ID});
                     pr_default.close(9);
                     if ( (pr_default.getStatus(9) == 103) )
                     {
                        GX_msglist.addItem(context.GetMessage( "GXM_lock", new   object[]  {"HARDWARE"}), "RecordIsLocked", 1, "");
                        AnyError = 1 ;
                     }
                     DeferredUpdate0N23( ) ;
                     if ( AnyError == 0 )
                     {
                        /* Start of After( level) rules */
                        if ( ( ( A312HARDWARE_IP == 0 ) ) && ( ( A299TIPO_DIR_IP == 2 ) ) && ( ( StringUtil.StrCmp(A185ACTIVO, "No") != 0 ) ) )
                        {
                           GX_msglist.addItem("Debe seleccionar una dirección IP.", 1, "");
                           AnyError = 1 ;
                        }
                        if ( ( ( AV33validado == 0 ) ) && ( ( A299TIPO_DIR_IP == 2 ) ) && ( ( StringUtil.StrCmp(A185ACTIVO, "No") != 0 ) ) )
                        {
                           GX_msglist.addItem(AV34mensaje, 1, "");
                           AnyError = 1 ;
                        }
                        /* Start of After( update) rules */
                        /* End of After( update) rules */
                        if ( AnyError == 0 )
                        {
                           if ( ( StringUtil.StrCmp(Gx_mode, "UPD") == 0 ) || ( StringUtil.StrCmp(Gx_mode, "DLT") == 0 ) )
                           {
                              if ( AnyError == 0 )
                              {
                                 context.nUserReturn = 1 ;
                              }
                           }
                        }
                     }
                     else
                     {
                        GX_msglist.addItem(context.GetMessage( "GXM_unexp"), 1, "");
                        AnyError = 1 ;
                     }
                  }
               }
            }
            EndLevel0N23( ) ;
         }
         CloseExtendedTableCursors0N23( ) ;
      }

      protected void DeferredUpdate0N23( )
      {
      }

      protected void delete( )
      {
         BeforeValidate0N23( ) ;
         if ( AnyError == 0 )
         {
            CheckOptimisticConcurrency0N23( ) ;
         }
         if ( AnyError == 0 )
         {
            OnDeleteControls0N23( ) ;
            AfterConfirm0N23( ) ;
            if ( AnyError == 0 )
            {
               BeforeDelete0N23( ) ;
               if ( AnyError == 0 )
               {
                  /* No cascading delete specified. */
                  /* Using cursor T000N12 */
                  pr_default.execute(10, new Object[] {n10HARDWARE_ID, A10HARDWARE_ID});
                  pr_default.close(10);
                  if ( AnyError == 0 )
                  {
                     /* Start of After( level) rules */
                     if ( ( ( A312HARDWARE_IP == 0 ) ) && ( ( A299TIPO_DIR_IP == 2 ) ) && ( ( StringUtil.StrCmp(A185ACTIVO, "No") != 0 ) ) )
                     {
                        GX_msglist.addItem("Debe seleccionar una dirección IP.", 1, "");
                        AnyError = 1 ;
                     }
                     if ( ( ( AV33validado == 0 ) ) && ( ( A299TIPO_DIR_IP == 2 ) ) && ( ( StringUtil.StrCmp(A185ACTIVO, "No") != 0 ) ) )
                     {
                        GX_msglist.addItem(AV34mensaje, 1, "");
                        AnyError = 1 ;
                     }
                     /* Start of After( delete) rules */
                     /* End of After( delete) rules */
                     if ( AnyError == 0 )
                     {
                        if ( ( StringUtil.StrCmp(Gx_mode, "UPD") == 0 ) || ( StringUtil.StrCmp(Gx_mode, "DLT") == 0 ) )
                        {
                           if ( AnyError == 0 )
                           {
                              context.nUserReturn = 1 ;
                           }
                        }
                     }
                  }
                  else
                  {
                     GX_msglist.addItem(context.GetMessage( "GXM_unexp"), 1, "");
                     AnyError = 1 ;
                  }
               }
            }
         }
         sMode23 = Gx_mode ;
         Gx_mode = "DLT" ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
         EndLevel0N23( ) ;
         Gx_mode = sMode23 ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
      }

      protected void OnDeleteControls0N23( )
      {
         standaloneModal( ) ;
         if ( AnyError == 0 )
         {
            /* Delete mode formulas */
            if ( StringUtil.StrCmp(A185ACTIVO, "No") == 0 )
            {
               cmbTIPO_DIR_IP.Enabled = 0 ;
               context.httpAjaxContext.ajax_rsp_assign_prop("", false, cmbTIPO_DIR_IP_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(cmbTIPO_DIR_IP.Enabled), 5, 0)));
            }
            else
            {
               if ( StringUtil.StrCmp(A185ACTIVO, "No") != 0 )
               {
                  cmbTIPO_DIR_IP.Enabled = 1 ;
                  context.httpAjaxContext.ajax_rsp_assign_prop("", false, cmbTIPO_DIR_IP_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(cmbTIPO_DIR_IP.Enabled), 5, 0)));
               }
            }
            if ( ( A299TIPO_DIR_IP == 2 ) && ( StringUtil.StrCmp(A185ACTIVO, "No") != 0 ) )
            {
               dynTHARDWARE_UBI.Enabled = 1 ;
               context.httpAjaxContext.ajax_rsp_assign_prop("", false, dynTHARDWARE_UBI_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(dynTHARDWARE_UBI.Enabled), 5, 0)));
            }
            else
            {
               if ( A299TIPO_DIR_IP != 2 )
               {
                  dynTHARDWARE_UBI.Enabled = 0 ;
                  context.httpAjaxContext.ajax_rsp_assign_prop("", false, dynTHARDWARE_UBI_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(dynTHARDWARE_UBI.Enabled), 5, 0)));
               }
               else
               {
                  if ( StringUtil.StrCmp(A185ACTIVO, "No") == 0 )
                  {
                     dynTHARDWARE_UBI.Enabled = 0 ;
                     context.httpAjaxContext.ajax_rsp_assign_prop("", false, dynTHARDWARE_UBI_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(dynTHARDWARE_UBI.Enabled), 5, 0)));
                  }
               }
            }
            if ( ( A299TIPO_DIR_IP == 2 ) && ( StringUtil.StrCmp(A185ACTIVO, "No") != 0 ) )
            {
               dynHARDWARE_RED.Enabled = 1 ;
               context.httpAjaxContext.ajax_rsp_assign_prop("", false, dynHARDWARE_RED_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(dynHARDWARE_RED.Enabled), 5, 0)));
            }
            else
            {
               if ( A299TIPO_DIR_IP != 2 )
               {
                  dynHARDWARE_RED.Enabled = 0 ;
                  context.httpAjaxContext.ajax_rsp_assign_prop("", false, dynHARDWARE_RED_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(dynHARDWARE_RED.Enabled), 5, 0)));
               }
               else
               {
                  if ( StringUtil.StrCmp(A185ACTIVO, "No") == 0 )
                  {
                     dynHARDWARE_RED.Enabled = 0 ;
                     context.httpAjaxContext.ajax_rsp_assign_prop("", false, dynHARDWARE_RED_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(dynHARDWARE_RED.Enabled), 5, 0)));
                  }
               }
            }
            if ( ( A299TIPO_DIR_IP != 2 ) && true /* After */ )
            {
               AV15Red_DireccionDesde = "0.0.0.0" ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV15Red_DireccionDesde", AV15Red_DireccionDesde);
            }
            else
            {
               if ( ( StringUtil.StrCmp(A185ACTIVO, "No") == 0 ) && true /* After */ )
               {
                  AV15Red_DireccionDesde = "0.0.0.0" ;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV15Red_DireccionDesde", AV15Red_DireccionDesde);
               }
            }
            if ( ( A299TIPO_DIR_IP != 2 ) && true /* After */ )
            {
               AV19Red_DireccionHasta = "0.0.0.0" ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV19Red_DireccionHasta", AV19Red_DireccionHasta);
            }
            else
            {
               if ( ( StringUtil.StrCmp(A185ACTIVO, "No") == 0 ) && true /* After */ )
               {
                  AV19Red_DireccionHasta = "0.0.0.0" ;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV19Red_DireccionHasta", AV19Red_DireccionHasta);
               }
            }
            if ( ( A299TIPO_DIR_IP != 2 ) && true /* After */ )
            {
               AV20Red_Mascara = "0.0.0.0" ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV20Red_Mascara", AV20Red_Mascara);
            }
            else
            {
               if ( ( StringUtil.StrCmp(A185ACTIVO, "No") == 0 ) && true /* After */ )
               {
                  AV20Red_Mascara = "0.0.0.0" ;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV20Red_Mascara", AV20Red_Mascara);
               }
            }
            if ( ( A299TIPO_DIR_IP != 2 ) && true /* After */ )
            {
               AV21Red_PuertaEnlace = "0.0.0.0" ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV21Red_PuertaEnlace", AV21Red_PuertaEnlace);
            }
            else
            {
               if ( ( StringUtil.StrCmp(A185ACTIVO, "No") == 0 ) && true /* After */ )
               {
                  AV21Red_PuertaEnlace = "0.0.0.0" ;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV21Red_PuertaEnlace", AV21Red_PuertaEnlace);
               }
            }
            if ( ( A299TIPO_DIR_IP != 2 ) && true /* After */ )
            {
               AV16Red_DireccionDesdeB1 = 0 ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV16Red_DireccionDesdeB1", StringUtil.LTrim( StringUtil.Str( (decimal)(AV16Red_DireccionDesdeB1), 3, 0)));
            }
            else
            {
               if ( ( StringUtil.StrCmp(A185ACTIVO, "No") == 0 ) && true /* After */ )
               {
                  AV16Red_DireccionDesdeB1 = 0 ;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV16Red_DireccionDesdeB1", StringUtil.LTrim( StringUtil.Str( (decimal)(AV16Red_DireccionDesdeB1), 3, 0)));
               }
            }
            if ( ( A299TIPO_DIR_IP != 2 ) && true /* After */ )
            {
               AV17Red_DireccionDesdeB2 = 0 ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV17Red_DireccionDesdeB2", StringUtil.LTrim( StringUtil.Str( (decimal)(AV17Red_DireccionDesdeB2), 3, 0)));
            }
            else
            {
               if ( ( StringUtil.StrCmp(A185ACTIVO, "No") == 0 ) && true /* After */ )
               {
                  AV17Red_DireccionDesdeB2 = 0 ;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV17Red_DireccionDesdeB2", StringUtil.LTrim( StringUtil.Str( (decimal)(AV17Red_DireccionDesdeB2), 3, 0)));
               }
            }
            if ( ( A299TIPO_DIR_IP != 2 ) && true /* After */ )
            {
               AV18Red_DireccionDesdeB3 = 0 ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV18Red_DireccionDesdeB3", StringUtil.LTrim( StringUtil.Str( (decimal)(AV18Red_DireccionDesdeB3), 3, 0)));
            }
            else
            {
               if ( ( StringUtil.StrCmp(A185ACTIVO, "No") == 0 ) && true /* After */ )
               {
                  AV18Red_DireccionDesdeB3 = 0 ;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV18Red_DireccionDesdeB3", StringUtil.LTrim( StringUtil.Str( (decimal)(AV18Red_DireccionDesdeB3), 3, 0)));
               }
            }
            GXAHARDWARE_RED_html0N23( A194THARDWARE_UBI) ;
         }
         if ( AnyError == 0 )
         {
            /* Using cursor T000N13 */
            pr_default.execute(11, new Object[] {n10HARDWARE_ID, A10HARDWARE_ID});
            if ( (pr_default.getStatus(11) != 101) )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_del", new   object[]  {"Bienes de Uso (Trazabilidad)"}), "CannotDeleteReferencedRecord", 1, "");
               AnyError = 1 ;
            }
            pr_default.close(11);
         }
      }

      protected void EndLevel0N23( )
      {
         if ( StringUtil.StrCmp(Gx_mode, "INS") != 0 )
         {
            pr_default.close(6);
         }
         if ( AnyError == 0 )
         {
            BeforeComplete0N23( ) ;
         }
         if ( AnyError == 0 )
         {
            pr_default.close(5);
            pr_default.close(4);
            context.CommitDataStores("THARDWARE_MAIN");
            if ( AnyError == 0 )
            {
               ConfirmValues0N0( ) ;
            }
            /* After transaction rules */
            /* Execute 'After Trn' event if defined. */
            trnEnded = 1 ;
         }
         else
         {
            pr_default.close(5);
            pr_default.close(4);
            context.RollbackDataStores("THARDWARE_MAIN");
         }
         IsModified = 0 ;
         if ( AnyError != 0 )
         {
            context.wjLoc = "" ;
            context.nUserReturn = 0 ;
         }
      }

      protected void ScanStart0N23( )
      {
         /* Using cursor T000N14 */
         pr_default.execute(12);
         RcdFound23 = 0 ;
         if ( (pr_default.getStatus(12) != 101) )
         {
            RcdFound23 = 1 ;
            A10HARDWARE_ID = T000N14_A10HARDWARE_ID[0] ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A10HARDWARE_ID", StringUtil.LTrim( StringUtil.Str( (decimal)(A10HARDWARE_ID), 4, 0)));
            n10HARDWARE_ID = T000N14_n10HARDWARE_ID[0] ;
         }
         /* Load Subordinate Levels */
      }

      protected void ScanNext0N23( )
      {
         pr_default.readNext(12);
         RcdFound23 = 0 ;
         if ( (pr_default.getStatus(12) != 101) )
         {
            RcdFound23 = 1 ;
            A10HARDWARE_ID = T000N14_A10HARDWARE_ID[0] ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A10HARDWARE_ID", StringUtil.LTrim( StringUtil.Str( (decimal)(A10HARDWARE_ID), 4, 0)));
            n10HARDWARE_ID = T000N14_n10HARDWARE_ID[0] ;
         }
      }

      protected void ScanEnd0N23( )
      {
      }

      protected void AfterConfirm0N23( )
      {
         /* After Confirm Rules */
      }

      protected void BeforeInsert0N23( )
      {
         /* Before Insert Rules */
      }

      protected void BeforeUpdate0N23( )
      {
         /* Before Update Rules */
      }

      protected void BeforeDelete0N23( )
      {
         /* Before Delete Rules */
      }

      protected void BeforeComplete0N23( )
      {
         /* Before Complete Rules */
      }

      protected void BeforeValidate0N23( )
      {
         /* Before Validate Rules */
      }

      protected void assign_properties_default( )
      {
      }

      protected void ConfirmValues0N0( )
      {
      }

      public override void RenderHtmlHeaders( )
      {
         GxWebStd.gx_html_headers( context, 0, "", "", Form.Meta, Form.Metaequiv, "IE=EmulateIE7");
      }

      public override void RenderHtmlOpenForm( )
      {
         context.WriteHtmlText( "<title>") ;
         context.WriteHtmlText( Form.Caption) ;
         context.WriteHtmlTextNl( "</title>") ;
         if ( StringUtil.Len( sDynURL) > 0 )
         {
            context.WriteHtmlText( "<BASE href=\""+sDynURL+"\" />") ;
         }
         define_styles( ) ;
         MasterPageObj.master_styles();
         if ( ! context.isSmartDevice( ) )
         {
            context.AddJavascriptSource("gxgral.js", "?42940");
            context.AddJavascriptSource("gxcfg.js", "?42940");
         }
         else
         {
            context.AddJavascriptSource("gxapiSD.js", "?42940");
            context.AddJavascriptSource("gxfxSD.js", "?42940");
            context.AddJavascriptSource("gxtypesSD.js", "?42940");
            context.AddJavascriptSource("gxpopupSD.js", "?42940");
            context.AddJavascriptSource("gxfrmutlSD.js", "?42940");
            context.AddJavascriptSource("gxgridSD.js", "?42940");
            context.AddJavascriptSource("JavaScripTableSD.js", "?42940");
            context.AddJavascriptSource("rijndaelSD.js", "?42940");
            context.AddJavascriptSource("gxgralSD.js", "?42940");
            context.AddJavascriptSource("gxcfg.js", "?42940");
         }
         context.AddJavascriptSource("calendar.js", "?42940");
         context.AddJavascriptSource("calendar-setup.js", "?42940");
         context.AddJavascriptSource("calendar-es.js", "?42940");
         context.WriteHtmlText( Form.Headerrawhtml) ;
         context.CloseHtmlHeader();
         FormProcess = " onkeyup=\"gx.evt.onkeyup(event)\" onkeypress=\"gx.evt.onkeypress(event,true,false)\" onkeydown=\"gx.evt.onkeypress(null,true,false)\"" ;
         context.WriteHtmlText( "<body") ;
         if ( ! ( String.IsNullOrEmpty(StringUtil.RTrim( Form.Background)) ) )
         {
            context.WriteHtmlText( " background=\""+context.convertURL( Form.Background)+"\"") ;
         }
         context.WriteHtmlText( " "+"class=\"Form\""+" "+" style=\"-moz-opacity:0;opacity:0;"+"background-color:"+context.BuildHTMLColor( Form.Backcolor)+"\""+FormProcess+">") ;
         context.skipLines(1);
         context.WriteHtmlTextNl( "<form id=\"MAINFORM\" onsubmit=\"try{return gx.csv.validForm()}catch(e){return true;}\" name=\"MAINFORM\" method=\"post\" action=\""+formatLink("thardware_main.aspx") + "?" + UrlEncode("" +AV12HARDWARE_ID) + "," + UrlEncode(StringUtil.RTrim(Gx_mode)) + "," + UrlEncode(StringUtil.RTrim(AV29SISTEMA)) + "," + UrlEncode(StringUtil.RTrim(AV30USUARIO))+"\" class=\""+"Form"+"\">") ;
         GxWebStd.gx_hidden_field( context, "_EventName", "");
         GxWebStd.gx_hidden_field( context, "_EventGridId", "");
         GxWebStd.gx_hidden_field( context, "_EventRowId", "");
      }

      public override void RenderHtmlCloseForm( )
      {
         /* Send hidden variables. */
         /* Send saved values. */
         GxWebStd.gx_hidden_field( context, "Z10HARDWARE_ID", StringUtil.LTrim( StringUtil.NToC( (decimal)(Z10HARDWARE_ID), 4, 0, ",", "")));
         GxWebStd.gx_hidden_field( context, "Z194THARDWARE_UBI", StringUtil.LTrim( StringUtil.NToC( (decimal)(Z194THARDWARE_UBI), 10, 0, ",", "")));
         GxWebStd.gx_hidden_field( context, "Z311HARDWARE_RED", StringUtil.LTrim( StringUtil.NToC( (decimal)(Z311HARDWARE_RED), 10, 0, ",", "")));
         GxWebStd.gx_hidden_field( context, "Z312HARDWARE_IP", StringUtil.LTrim( StringUtil.NToC( (decimal)(Z312HARDWARE_IP), 3, 0, ",", "")));
         GxWebStd.gx_hidden_field( context, "Z299TIPO_DIR_IP", StringUtil.LTrim( StringUtil.NToC( (decimal)(Z299TIPO_DIR_IP), 2, 0, ",", "")));
         GxWebStd.gx_hidden_field( context, "Z181TIPOS_DE_HARDWARE_ID", StringUtil.LTrim( StringUtil.NToC( (decimal)(Z181TIPOS_DE_HARDWARE_ID), 4, 0, ",", "")));
         GxWebStd.gx_hidden_field( context, "Z58HARDWARE_DESCRIPCION", StringUtil.RTrim( Z58HARDWARE_DESCRIPCION));
         GxWebStd.gx_hidden_field( context, "Z182fecha_alta", context.localUtil.TToC( Z182fecha_alta, 10, 8, 0, 3, "/", ":", " "));
         GxWebStd.gx_hidden_field( context, "Z187NOMBRE_DEL_TIPO_DE_HD", StringUtil.RTrim( Z187NOMBRE_DEL_TIPO_DE_HD));
         GxWebStd.gx_hidden_field( context, "Z313TH_DIREC", StringUtil.LTrim( StringUtil.NToC( (decimal)(Z313TH_DIREC), 2, 0, ",", "")));
         GxWebStd.gx_hidden_field( context, "Z183MODELO_DE_COMPONENTES_ID", StringUtil.LTrim( StringUtil.NToC( (decimal)(Z183MODELO_DE_COMPONENTES_ID), 4, 0, ",", "")));
         GxWebStd.gx_hidden_field( context, "Z188MODELO_DE_COMPONENTES_NOMBRE", StringUtil.RTrim( Z188MODELO_DE_COMPONENTES_NOMBRE));
         GxWebStd.gx_hidden_field( context, "Z189MARCAS_ID", StringUtil.LTrim( StringUtil.NToC( (decimal)(Z189MARCAS_ID), 4, 0, ",", "")));
         GxWebStd.gx_hidden_field( context, "Z190MARCAS_DESCRIPCION", StringUtil.RTrim( Z190MARCAS_DESCRIPCION));
         GxWebStd.gx_hidden_field( context, "Z184HARDWARE_NRO_BIEN", StringUtil.LTrim( StringUtil.NToC( (decimal)(Z184HARDWARE_NRO_BIEN), 10, 0, ",", "")));
         GxWebStd.gx_hidden_field( context, "Z9HARDWARE_NRO_SERIE", StringUtil.RTrim( Z9HARDWARE_NRO_SERIE));
         GxWebStd.gx_hidden_field( context, "Z185ACTIVO", StringUtil.RTrim( Z185ACTIVO));
         GxWebStd.gx_hidden_field( context, "Z186fecha_baja", context.localUtil.TToC( Z186fecha_baja, 10, 8, 0, 3, "/", ":", " "));
         GxWebStd.gx_hidden_field( context, "Z192PRUEBA_MICROFONO_AUDIO", StringUtil.RTrim( Z192PRUEBA_MICROFONO_AUDIO));
         GxWebStd.gx_hidden_field( context, "Z193RESPONSABLE_ARMADO_PC", StringUtil.RTrim( Z193RESPONSABLE_ARMADO_PC));
         GxWebStd.gx_hidden_field( context, "Z104HDW_IDT", StringUtil.LTrim( StringUtil.NToC( (decimal)(Z104HDW_IDT), 8, 0, ",", "")));
         GxWebStd.gx_hidden_field( context, "Z314HARDWARE_UBA", StringUtil.LTrim( StringUtil.NToC( (decimal)(Z314HARDWARE_UBA), 10, 0, ",", "")));
         GxWebStd.gx_hidden_field( context, "IsConfirmed", StringUtil.LTrim( StringUtil.NToC( (decimal)(IsConfirmed), 4, 0, ",", "")));
         GxWebStd.gx_hidden_field( context, "IsModified", StringUtil.LTrim( StringUtil.NToC( (decimal)(IsModified), 4, 0, ",", "")));
         GxWebStd.gx_hidden_field( context, "Mode", StringUtil.RTrim( Gx_mode));
         GxWebStd.gx_hidden_field( context, "vUSUARIO", StringUtil.RTrim( AV30USUARIO));
         GxWebStd.gx_hidden_field( context, "vSISTEMA", StringUtil.RTrim( AV29SISTEMA));
         GxWebStd.gx_hidden_field( context, "vHARDWARE_ID", StringUtil.LTrim( StringUtil.NToC( (decimal)(AV12HARDWARE_ID), 4, 0, ",", "")));
         GxWebStd.gx_hidden_field( context, "vGXBSCREEN", StringUtil.LTrim( StringUtil.NToC( (decimal)(Gx_BScreen), 1, 0, ",", "")));
         GxWebStd.gx_hidden_field( context, "vERROR", StringUtil.LTrim( StringUtil.NToC( (decimal)(AV36error), 1, 0, ",", "")));
         GxWebStd.gx_hidden_field( context, "vMENSAJE", StringUtil.RTrim( AV34mensaje));
         GxWebStd.gx_hidden_field( context, "vERROR_2", StringUtil.LTrim( StringUtil.NToC( (decimal)(AV37error_2), 1, 0, ",", "")));
         GxWebStd.gx_hidden_field( context, "vVALIDADO", StringUtil.LTrim( StringUtil.NToC( (decimal)(AV33validado), 1, 0, ",", "")));
         GxWebStd.gx_hidden_field( context, "vMODE", StringUtil.RTrim( Gx_mode));
         GxWebStd.gx_hidden_field( context, "GX_FocusControl", GX_FocusControl);
         SendAjaxEncryptionKey();
         SendComponentObjects();
         SendServerCommands();
         SendState();
         context.WriteHtmlTextNl( "</form>") ;
         include_jscripts( ) ;
      }

      public override short ExecuteStartEvent( )
      {
         standaloneStartup( ) ;
         gxajaxcallmode = (short)((isAjaxCallMode( ) ? 1 : 0)) ;
         return gxajaxcallmode ;
      }

      public override void RenderHtmlContent( )
      {
         Draw( ) ;
      }

      public override void DispatchEvents( )
      {
         Process( ) ;
      }

      public override bool HasEnterEvent( )
      {
         return true ;
      }

      public override String GetPgmname( )
      {
         return "THARDWARE_MAIN" ;
      }

      public override String GetPgmdesc( )
      {
         return "Asministración de Hardware" ;
      }

      public override GXWebForm GetForm( )
      {
         return Form ;
      }

      public override String GetSelfLink( )
      {
         return formatLink("thardware_main.aspx") + "?" + UrlEncode("" +AV12HARDWARE_ID) + "," + UrlEncode(StringUtil.RTrim(Gx_mode)) + "," + UrlEncode(StringUtil.RTrim(AV29SISTEMA)) + "," + UrlEncode(StringUtil.RTrim(AV30USUARIO)) ;
      }

      protected void InitializeNonKey0N23( )
      {
         AV36error = 0 ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV36error", StringUtil.Str( (decimal)(AV36error), 1, 0));
         AV34mensaje = "" ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV34mensaje", AV34mensaje);
         AV37error_2 = 0 ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV37error_2", StringUtil.Str( (decimal)(AV37error_2), 1, 0));
         A311HARDWARE_RED = 0 ;
         n311HARDWARE_RED = false ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A311HARDWARE_RED", StringUtil.LTrim( StringUtil.Str( (decimal)(A311HARDWARE_RED), 10, 0)));
         n311HARDWARE_RED = ((0==A311HARDWARE_RED) ? true : false) ;
         A312HARDWARE_IP = 0 ;
         n312HARDWARE_IP = false ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A312HARDWARE_IP", StringUtil.LTrim( StringUtil.Str( (decimal)(A312HARDWARE_IP), 3, 0)));
         n312HARDWARE_IP = ((0==A312HARDWARE_IP) ? true : false) ;
         A299TIPO_DIR_IP = 0 ;
         n299TIPO_DIR_IP = false ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A299TIPO_DIR_IP", StringUtil.LTrim( StringUtil.Str( (decimal)(A299TIPO_DIR_IP), 2, 0)));
         n299TIPO_DIR_IP = ((0==A299TIPO_DIR_IP) ? true : false) ;
         AV33validado = 0 ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV33validado", StringUtil.Str( (decimal)(AV33validado), 1, 0));
         A181TIPOS_DE_HARDWARE_ID = 0 ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A181TIPOS_DE_HARDWARE_ID", StringUtil.LTrim( StringUtil.Str( (decimal)(A181TIPOS_DE_HARDWARE_ID), 4, 0)));
         A58HARDWARE_DESCRIPCION = "" ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A58HARDWARE_DESCRIPCION", A58HARDWARE_DESCRIPCION);
         A182fecha_alta = (DateTime)(DateTime.MinValue) ;
         n182fecha_alta = false ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A182fecha_alta", context.localUtil.TToC( A182fecha_alta, 10, 8, 0, 3, "/", ":", " "));
         n182fecha_alta = ((DateTime.MinValue==A182fecha_alta) ? true : false) ;
         A187NOMBRE_DEL_TIPO_DE_HD = "" ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A187NOMBRE_DEL_TIPO_DE_HD", A187NOMBRE_DEL_TIPO_DE_HD);
         A313TH_DIREC = 0 ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A313TH_DIREC", StringUtil.LTrim( StringUtil.Str( (decimal)(A313TH_DIREC), 2, 0)));
         A183MODELO_DE_COMPONENTES_ID = 0 ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A183MODELO_DE_COMPONENTES_ID", StringUtil.LTrim( StringUtil.Str( (decimal)(A183MODELO_DE_COMPONENTES_ID), 4, 0)));
         A188MODELO_DE_COMPONENTES_NOMBRE = "" ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A188MODELO_DE_COMPONENTES_NOMBRE", A188MODELO_DE_COMPONENTES_NOMBRE);
         A189MARCAS_ID = 0 ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A189MARCAS_ID", StringUtil.LTrim( StringUtil.Str( (decimal)(A189MARCAS_ID), 4, 0)));
         A190MARCAS_DESCRIPCION = "" ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A190MARCAS_DESCRIPCION", A190MARCAS_DESCRIPCION);
         A184HARDWARE_NRO_BIEN = 0 ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A184HARDWARE_NRO_BIEN", StringUtil.LTrim( StringUtil.Str( (decimal)(A184HARDWARE_NRO_BIEN), 10, 0)));
         A9HARDWARE_NRO_SERIE = "" ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A9HARDWARE_NRO_SERIE", A9HARDWARE_NRO_SERIE);
         A186fecha_baja = (DateTime)(DateTime.MinValue) ;
         n186fecha_baja = false ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A186fecha_baja", context.localUtil.TToC( A186fecha_baja, 10, 8, 0, 3, "/", ":", " "));
         n186fecha_baja = ((DateTime.MinValue==A186fecha_baja) ? true : false) ;
         A193RESPONSABLE_ARMADO_PC = "" ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A193RESPONSABLE_ARMADO_PC", A193RESPONSABLE_ARMADO_PC);
         A314HARDWARE_UBA = 0 ;
         n314HARDWARE_UBA = false ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A314HARDWARE_UBA", StringUtil.LTrim( StringUtil.Str( (decimal)(A314HARDWARE_UBA), 10, 0)));
         n314HARDWARE_UBA = ((0==A314HARDWARE_UBA) ? true : false) ;
         A194THARDWARE_UBI = 1 ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A194THARDWARE_UBI", StringUtil.LTrim( StringUtil.Str( (decimal)(A194THARDWARE_UBI), 10, 0)));
         A185ACTIVO = "Si" ;
         n185ACTIVO = false ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A185ACTIVO", A185ACTIVO);
         A192PRUEBA_MICROFONO_AUDIO = "No" ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A192PRUEBA_MICROFONO_AUDIO", A192PRUEBA_MICROFONO_AUDIO);
         A104HDW_IDT = 0 ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A104HDW_IDT", StringUtil.LTrim( StringUtil.Str( (decimal)(A104HDW_IDT), 8, 0)));
      }

      protected void InitAll0N23( )
      {
         A10HARDWARE_ID = 0 ;
         n10HARDWARE_ID = false ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A10HARDWARE_ID", StringUtil.LTrim( StringUtil.Str( (decimal)(A10HARDWARE_ID), 4, 0)));
         InitializeNonKey0N23( ) ;
      }

      protected void StandaloneModalInsert( )
      {
         A104HDW_IDT = i104HDW_IDT ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A104HDW_IDT", StringUtil.LTrim( StringUtil.Str( (decimal)(A104HDW_IDT), 8, 0)));
         A185ACTIVO = i185ACTIVO ;
         n185ACTIVO = false ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A185ACTIVO", A185ACTIVO);
         A192PRUEBA_MICROFONO_AUDIO = i192PRUEBA_MICROFONO_AUDIO ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A192PRUEBA_MICROFONO_AUDIO", A192PRUEBA_MICROFONO_AUDIO);
      }

      protected void define_styles( )
      {
         AddStyleSheetFile("calendar-system.css", "?84120");
         AddThemeStyleSheetFile("", "Modern.css", "?19542497");
         idxLst = 1 ;
         while ( idxLst <= Form.Jscriptsrc.Count )
         {
            context.AddJavascriptSource(StringUtil.RTrim( Form.Jscriptsrc.Item(idxLst)), "?11193148");
            idxLst = (int)(idxLst+1) ;
         }
         /* End function define_styles */
      }

      protected void include_jscripts( )
      {
         context.AddJavascriptSource("messages.spa.js", "?42940");
         context.AddJavascriptSource("thardware_main.js", "?11193148");
         /* End function include_jscripts */
      }

      protected void init_default_properties( )
      {
         bttBtn_first_Internalname = "BTN_FIRST" ;
         bttBtn_previous_Internalname = "BTN_PREVIOUS" ;
         bttBtn_next_Internalname = "BTN_NEXT" ;
         bttBtn_last_Internalname = "BTN_LAST" ;
         bttBtn_select_Internalname = "BTN_SELECT" ;
         lblTextblock1_Internalname = "TEXTBLOCK1" ;
         edtHARDWARE_ID_Internalname = "HARDWARE_ID" ;
         edtHARDWARE_DESCRIPCION_Internalname = "HARDWARE_DESCRIPCION" ;
         edtfecha_alta_Internalname = "FECHA_ALTA" ;
         lblTextblock3_Internalname = "TEXTBLOCK3" ;
         edtTIPOS_DE_HARDWARE_ID_Internalname = "TIPOS_DE_HARDWARE_ID" ;
         lblTextblock4_Internalname = "TEXTBLOCK4" ;
         edtNOMBRE_DEL_TIPO_DE_HD_Internalname = "NOMBRE_DEL_TIPO_DE_HD" ;
         lblTextblock12_Internalname = "TEXTBLOCK12" ;
         cmbTH_DIREC_Internalname = "TH_DIREC" ;
         lblTextblock7_Internalname = "TEXTBLOCK7" ;
         edtMODELO_DE_COMPONENTES_ID_Internalname = "MODELO_DE_COMPONENTES_ID" ;
         lblTextblock8_Internalname = "TEXTBLOCK8" ;
         edtMODELO_DE_COMPONENTES_NOMBRE_Internalname = "MODELO_DE_COMPONENTES_NOMBRE" ;
         lblTextblock5_Internalname = "TEXTBLOCK5" ;
         edtMARCAS_ID_Internalname = "MARCAS_ID" ;
         lblTextblock6_Internalname = "TEXTBLOCK6" ;
         edtMARCAS_DESCRIPCION_Internalname = "MARCAS_DESCRIPCION" ;
         lblTextblock9_Internalname = "TEXTBLOCK9" ;
         edtHARDWARE_NRO_BIEN_Internalname = "HARDWARE_NRO_BIEN" ;
         lblTextblock10_Internalname = "TEXTBLOCK10" ;
         edtHARDWARE_NRO_SERIE_Internalname = "HARDWARE_NRO_SERIE" ;
         cmbACTIVO_Internalname = "ACTIVO" ;
         edtfecha_baja_Internalname = "FECHA_BAJA" ;
         lblTextblock2_Internalname = "TEXTBLOCK2" ;
         radPRUEBA_MICROFONO_AUDIO_Internalname = "PRUEBA_MICROFONO_AUDIO" ;
         lblTextblock11_Internalname = "TEXTBLOCK11" ;
         dynRESPONSABLE_ARMADO_PC_Internalname = "RESPONSABLE_ARMADO_PC" ;
         lblTextblock13_Internalname = "TEXTBLOCK13" ;
         cmbTIPO_DIR_IP_Internalname = "TIPO_DIR_IP" ;
         lblTextblock15_Internalname = "TEXTBLOCK15" ;
         dynTHARDWARE_UBI_Internalname = "THARDWARE_UBI" ;
         lblTextblock16_Internalname = "TEXTBLOCK16" ;
         dynHARDWARE_RED_Internalname = "HARDWARE_RED" ;
         lblTextblock17_Internalname = "TEXTBLOCK17" ;
         edtavRed_direcciondesde_Internalname = "vRED_DIRECCIONDESDE" ;
         lblTextblock18_Internalname = "TEXTBLOCK18" ;
         edtavRed_direccionhasta_Internalname = "vRED_DIRECCIONHASTA" ;
         lblTextblock19_Internalname = "TEXTBLOCK19" ;
         edtavRed_mascara_Internalname = "vRED_MASCARA" ;
         lblTextblock20_Internalname = "TEXTBLOCK20" ;
         edtavRed_puertaenlace_Internalname = "vRED_PUERTAENLACE" ;
         lblTextblock14_Internalname = "TEXTBLOCK14" ;
         edtavRed_direcciondesdeb1_Internalname = "vRED_DIRECCIONDESDEB1" ;
         edtavRed_direcciondesdeb2_Internalname = "vRED_DIRECCIONDESDEB2" ;
         edtavRed_direcciondesdeb3_Internalname = "vRED_DIRECCIONDESDEB3" ;
         edtHARDWARE_IP_Internalname = "HARDWARE_IP" ;
         imgPrompt1_Internalname = "PROMPT1" ;
         lblTextblock21_Internalname = "TEXTBLOCK21" ;
         dynHARDWARE_UBA_Internalname = "HARDWARE_UBA" ;
         lblTxt_trazabilidad_Internalname = "TXT_TRAZABILIDAD" ;
         edtHDW_IDT_Internalname = "HDW_IDT" ;
         tblTable2_Internalname = "TABLE2" ;
         bttBtn_enter_Internalname = "BTN_ENTER" ;
         bttBtn_check_Internalname = "BTN_CHECK" ;
         bttBtn_cancel_Internalname = "BTN_CANCEL" ;
         bttBtn_delete_Internalname = "BTN_DELETE" ;
         tblTable1_Internalname = "TABLE1" ;
         Form.Internalname = "FORM" ;
         imgprompt_104_Internalname = "PROMPT_104" ;
      }

      public override void initialize_properties( )
      {
         init_default_properties( ) ;
         Form.Headerrawhtml = "" ;
         Form.Background = "" ;
         Form.Backcolor = (int)(0xFFFFFF) ;
         Form.Caption = "Asministración de Hardware" ;
         imgprompt_104_Visible = 1 ;
         imgprompt_104_Link = "" ;
         edtHDW_IDT_Jsonclick = "" ;
         edtHDW_IDT_Enabled = 1 ;
         dynHARDWARE_UBA_Jsonclick = "" ;
         dynHARDWARE_UBA.Enabled = 1 ;
         imgPrompt1_Visible = 1 ;
         edtHARDWARE_IP_Jsonclick = "" ;
         edtHARDWARE_IP_Enabled = 0 ;
         edtavRed_direcciondesdeb3_Jsonclick = "" ;
         edtavRed_direcciondesdeb3_Enabled = 0 ;
         edtavRed_direcciondesdeb2_Jsonclick = "" ;
         edtavRed_direcciondesdeb2_Enabled = 0 ;
         edtavRed_direcciondesdeb1_Jsonclick = "" ;
         edtavRed_direcciondesdeb1_Enabled = 0 ;
         edtavRed_puertaenlace_Jsonclick = "" ;
         edtavRed_puertaenlace_Enabled = 0 ;
         edtavRed_mascara_Jsonclick = "" ;
         edtavRed_mascara_Enabled = 0 ;
         edtavRed_direccionhasta_Jsonclick = "" ;
         edtavRed_direccionhasta_Enabled = 0 ;
         edtavRed_direcciondesde_Jsonclick = "" ;
         edtavRed_direcciondesde_Enabled = 0 ;
         dynHARDWARE_RED_Jsonclick = "" ;
         dynHARDWARE_RED.Enabled = 1 ;
         dynTHARDWARE_UBI_Jsonclick = "" ;
         dynTHARDWARE_UBI.Enabled = 1 ;
         cmbTIPO_DIR_IP_Jsonclick = "" ;
         cmbTIPO_DIR_IP.Enabled = 1 ;
         dynRESPONSABLE_ARMADO_PC_Jsonclick = "" ;
         dynRESPONSABLE_ARMADO_PC.Enabled = 1 ;
         radPRUEBA_MICROFONO_AUDIO_Jsonclick = "" ;
         radPRUEBA_MICROFONO_AUDIO.Enabled = 1 ;
         edtfecha_baja_Jsonclick = "" ;
         edtfecha_baja_Enabled = 1 ;
         cmbACTIVO_Jsonclick = "" ;
         cmbACTIVO.Enabled = 1 ;
         edtHARDWARE_NRO_SERIE_Jsonclick = "" ;
         edtHARDWARE_NRO_SERIE_Enabled = 1 ;
         edtHARDWARE_NRO_BIEN_Jsonclick = "" ;
         edtHARDWARE_NRO_BIEN_Enabled = 1 ;
         edtMARCAS_DESCRIPCION_Jsonclick = "" ;
         edtMARCAS_DESCRIPCION_Enabled = 1 ;
         edtMARCAS_ID_Jsonclick = "" ;
         edtMARCAS_ID_Enabled = 1 ;
         edtMODELO_DE_COMPONENTES_NOMBRE_Jsonclick = "" ;
         edtMODELO_DE_COMPONENTES_NOMBRE_Enabled = 1 ;
         edtMODELO_DE_COMPONENTES_ID_Jsonclick = "" ;
         edtMODELO_DE_COMPONENTES_ID_Enabled = 1 ;
         cmbTH_DIREC_Jsonclick = "" ;
         cmbTH_DIREC.Enabled = 1 ;
         edtNOMBRE_DEL_TIPO_DE_HD_Jsonclick = "" ;
         edtNOMBRE_DEL_TIPO_DE_HD_Enabled = 1 ;
         edtTIPOS_DE_HARDWARE_ID_Jsonclick = "" ;
         edtTIPOS_DE_HARDWARE_ID_Enabled = 1 ;
         edtfecha_alta_Jsonclick = "" ;
         edtfecha_alta_Enabled = 1 ;
         edtHARDWARE_DESCRIPCION_Jsonclick = "" ;
         edtHARDWARE_DESCRIPCION_Enabled = 1 ;
         edtHARDWARE_ID_Jsonclick = "" ;
         edtHARDWARE_ID_Enabled = 0 ;
         bttBtn_delete_Enabled = 0 ;
         bttBtn_delete_Visible = 1 ;
         bttBtn_cancel_Visible = 1 ;
         bttBtn_check_Enabled = 1 ;
         bttBtn_check_Visible = 1 ;
         bttBtn_enter_Enabled = 1 ;
         bttBtn_enter_Visible = 1 ;
         bttBtn_select_Visible = 1 ;
         bttBtn_last_Visible = 1 ;
         bttBtn_next_Visible = 1 ;
         bttBtn_previous_Visible = 1 ;
         bttBtn_first_Visible = 1 ;
         context.GX_msglist.DisplayMode = 1 ;
      }

      protected void dynload_actions( )
      {
         GXAHARDWARE_RED_html0N23( A194THARDWARE_UBI) ;
         /* End function dynload_actions */
      }

      protected void GXDLARESPONSABLE_ARMADO_PC0N23( )
      {
         if ( ! context.isAjaxRequest( ) )
         {
            context.GX_webresponse.AppendHeader("Cache-Control", "max-age=0");
         }
         context.GX_webresponse.AddString("(new Array( new Array(");
         GXDLARESPONSABLE_ARMADO_PC_data0N23( ) ;
         gxdynajaxindex = 1 ;
         while ( gxdynajaxindex <= gxdynajaxctrlcodr.Count )
         {
            context.GX_webresponse.AddString(gxwrpcisep+"{c:\""+GXUtil.EncodeJSConstant( gxdynajaxctrlcodr.Item(gxdynajaxindex))+"\",d:\""+GXUtil.EncodeJSConstant( gxdynajaxctrldescr.Item(gxdynajaxindex))+"\"}");
            gxdynajaxindex = (int)(gxdynajaxindex+1) ;
            gxwrpcisep = "," ;
         }
         context.GX_webresponse.AddString(")");
         if ( gxdynajaxctrlcodr.Count == 0 )
         {
            context.GX_webresponse.AddString(",101");
         }
         context.GX_webresponse.AddString("))");
      }

      protected void GXARESPONSABLE_ARMADO_PC_html0N23( )
      {
         String gxdynajaxvalue ;
         GXDLARESPONSABLE_ARMADO_PC_data0N23( ) ;
         gxdynajaxindex = 1 ;
         dynRESPONSABLE_ARMADO_PC.removeAllItems();
         while ( gxdynajaxindex <= gxdynajaxctrlcodr.Count )
         {
            gxdynajaxvalue = gxdynajaxctrlcodr.Item(gxdynajaxindex) ;
            dynRESPONSABLE_ARMADO_PC.addItem(gxdynajaxvalue, gxdynajaxctrldescr.Item(gxdynajaxindex), 0);
            gxdynajaxindex = (int)(gxdynajaxindex+1) ;
         }
      }

      protected void GXDLARESPONSABLE_ARMADO_PC_data0N23( )
      {
         /* Using cursor T000N15 */
         pr_default.execute(13);
         gxdynajaxctrlcodr.Clear();
         gxdynajaxctrldescr.Clear();
         gxdynajaxctrlcodr.Add("");
         gxdynajaxctrldescr.Add("No asignado");
         while ( (pr_default.getStatus(13) != 101) )
         {
            gxdynajaxctrlcodr.Add(StringUtil.RTrim( T000N15_A6USU_COD[0]));
            gxdynajaxctrldescr.Add(StringUtil.RTrim( T000N15_A7USU_DES[0]));
            pr_default.readNext(13);
         }
         pr_default.close(13);
      }

      protected void GXDLATHARDWARE_UBI0N23( )
      {
         if ( ! context.isAjaxRequest( ) )
         {
            context.GX_webresponse.AppendHeader("Cache-Control", "max-age=0");
         }
         context.GX_webresponse.AddString("(new Array( new Array(");
         GXDLATHARDWARE_UBI_data0N23( ) ;
         gxdynajaxindex = 1 ;
         while ( gxdynajaxindex <= gxdynajaxctrlcodr.Count )
         {
            context.GX_webresponse.AddString(gxwrpcisep+"{c:\""+GXUtil.EncodeJSConstant( gxdynajaxctrlcodr.Item(gxdynajaxindex))+"\",d:\""+GXUtil.EncodeJSConstant( gxdynajaxctrldescr.Item(gxdynajaxindex))+"\"}");
            gxdynajaxindex = (int)(gxdynajaxindex+1) ;
            gxwrpcisep = "," ;
         }
         context.GX_webresponse.AddString(")");
         if ( gxdynajaxctrlcodr.Count == 0 )
         {
            context.GX_webresponse.AddString(",101");
         }
         context.GX_webresponse.AddString("))");
      }

      protected void GXATHARDWARE_UBI_html0N23( )
      {
         long gxdynajaxvalue ;
         GXDLATHARDWARE_UBI_data0N23( ) ;
         gxdynajaxindex = 1 ;
         dynTHARDWARE_UBI.removeAllItems();
         while ( gxdynajaxindex <= gxdynajaxctrlcodr.Count )
         {
            gxdynajaxvalue = (long)(NumberUtil.Val( gxdynajaxctrlcodr.Item(gxdynajaxindex), ".")) ;
            dynTHARDWARE_UBI.addItem(StringUtil.Str( (decimal)(gxdynajaxvalue), 10, 0), gxdynajaxctrldescr.Item(gxdynajaxindex), 0);
            gxdynajaxindex = (int)(gxdynajaxindex+1) ;
         }
      }

      protected void GXDLATHARDWARE_UBI_data0N23( )
      {
         /* Using cursor T000N16 */
         pr_default.execute(14);
         gxdynajaxctrlcodr.Clear();
         gxdynajaxctrldescr.Clear();
         gxdynajaxctrlcodr.Add(StringUtil.Str( (decimal)(0), 1, 0));
         gxdynajaxctrldescr.Add("Desconocida");
         while ( (pr_default.getStatus(14) != 101) )
         {
            gxdynajaxctrlcodr.Add(StringUtil.LTrim( StringUtil.NToC( (decimal)(T000N16_A306THDW_UBI_COD_[0]), 10, 0, ".", "")));
            gxdynajaxctrldescr.Add(StringUtil.RTrim( T000N16_A307THDW_UBI_DESC_[0]));
            pr_default.readNext(14);
         }
         pr_default.close(14);
      }

      protected void GXDLAHARDWARE_RED0N23( long A194THARDWARE_UBI )
      {
         if ( ! context.isAjaxRequest( ) )
         {
            context.GX_webresponse.AppendHeader("Cache-Control", "max-age=0");
         }
         context.GX_webresponse.AddString("(new Array( new Array(");
         GXDLAHARDWARE_RED_data0N23( A194THARDWARE_UBI) ;
         gxdynajaxindex = 1 ;
         while ( gxdynajaxindex <= gxdynajaxctrlcodr.Count )
         {
            context.GX_webresponse.AddString(gxwrpcisep+"{c:\""+GXUtil.EncodeJSConstant( gxdynajaxctrlcodr.Item(gxdynajaxindex))+"\",d:\""+GXUtil.EncodeJSConstant( gxdynajaxctrldescr.Item(gxdynajaxindex))+"\"}");
            gxdynajaxindex = (int)(gxdynajaxindex+1) ;
            gxwrpcisep = "," ;
         }
         context.GX_webresponse.AddString(")");
         if ( gxdynajaxctrlcodr.Count == 0 )
         {
            context.GX_webresponse.AddString(",101");
         }
         context.GX_webresponse.AddString("))");
      }

      protected void GXAHARDWARE_RED_html0N23( long A194THARDWARE_UBI )
      {
         long gxdynajaxvalue ;
         GXDLAHARDWARE_RED_data0N23( A194THARDWARE_UBI) ;
         gxdynajaxindex = 1 ;
         dynHARDWARE_RED.removeAllItems();
         while ( gxdynajaxindex <= gxdynajaxctrlcodr.Count )
         {
            gxdynajaxvalue = (long)(NumberUtil.Val( gxdynajaxctrlcodr.Item(gxdynajaxindex), ".")) ;
            dynHARDWARE_RED.addItem(StringUtil.Str( (decimal)(gxdynajaxvalue), 10, 0), gxdynajaxctrldescr.Item(gxdynajaxindex), 0);
            gxdynajaxindex = (int)(gxdynajaxindex+1) ;
         }
      }

      protected void GXDLAHARDWARE_RED_data0N23( long A194THARDWARE_UBI )
      {
         /* Using cursor T000N17 */
         pr_default.execute(15, new Object[] {A194THARDWARE_UBI});
         gxdynajaxctrlcodr.Clear();
         gxdynajaxctrldescr.Clear();
         while ( (pr_default.getStatus(15) != 101) )
         {
            gxdynajaxctrlcodr.Add(StringUtil.LTrim( StringUtil.NToC( (decimal)(T000N17_A300Red_Id[0]), 10, 0, ".", "")));
            gxdynajaxctrldescr.Add(StringUtil.RTrim( T000N17_A301Red_Descripcion[0]));
            pr_default.readNext(15);
         }
         pr_default.close(15);
      }

      protected void GXDLAHARDWARE_UBA0N23( )
      {
         if ( ! context.isAjaxRequest( ) )
         {
            context.GX_webresponse.AppendHeader("Cache-Control", "max-age=0");
         }
         context.GX_webresponse.AddString("(new Array( new Array(");
         GXDLAHARDWARE_UBA_data0N23( ) ;
         gxdynajaxindex = 1 ;
         while ( gxdynajaxindex <= gxdynajaxctrlcodr.Count )
         {
            context.GX_webresponse.AddString(gxwrpcisep+"{c:\""+GXUtil.EncodeJSConstant( gxdynajaxctrlcodr.Item(gxdynajaxindex))+"\",d:\""+GXUtil.EncodeJSConstant( gxdynajaxctrldescr.Item(gxdynajaxindex))+"\"}");
            gxdynajaxindex = (int)(gxdynajaxindex+1) ;
            gxwrpcisep = "," ;
         }
         context.GX_webresponse.AddString(")");
         if ( gxdynajaxctrlcodr.Count == 0 )
         {
            context.GX_webresponse.AddString(",101");
         }
         context.GX_webresponse.AddString("))");
      }

      protected void GXAHARDWARE_UBA_html0N23( )
      {
         long gxdynajaxvalue ;
         GXDLAHARDWARE_UBA_data0N23( ) ;
         gxdynajaxindex = 1 ;
         dynHARDWARE_UBA.removeAllItems();
         while ( gxdynajaxindex <= gxdynajaxctrlcodr.Count )
         {
            gxdynajaxvalue = (long)(NumberUtil.Val( gxdynajaxctrlcodr.Item(gxdynajaxindex), ".")) ;
            dynHARDWARE_UBA.addItem(StringUtil.Str( (decimal)(gxdynajaxvalue), 10, 0), gxdynajaxctrldescr.Item(gxdynajaxindex), 0);
            gxdynajaxindex = (int)(gxdynajaxindex+1) ;
         }
      }

      protected void GXDLAHARDWARE_UBA_data0N23( )
      {
         /* Using cursor T000N18 */
         pr_default.execute(16);
         gxdynajaxctrlcodr.Clear();
         gxdynajaxctrldescr.Clear();
         gxdynajaxctrlcodr.Add(StringUtil.Str( (decimal)(0), 1, 0));
         gxdynajaxctrldescr.Add("Sin Especificar");
         while ( (pr_default.getStatus(16) != 101) )
         {
            gxdynajaxctrlcodr.Add(StringUtil.LTrim( StringUtil.NToC( (decimal)(T000N18_A306THDW_UBI_COD_[0]), 10, 0, ".", "")));
            gxdynajaxctrldescr.Add(StringUtil.RTrim( T000N18_A307THDW_UBI_DESC_[0]));
            pr_default.readNext(16);
         }
         pr_default.close(16);
      }

      protected void XC_35_0N23( short A10HARDWARE_ID ,
                                 int A104HDW_IDT )
      {
         if ( ( A104HDW_IDT != 0 ) && true /* After */ )
         {
            new ptbus032_1(context ).execute(  A10HARDWARE_ID,  A104HDW_IDT, out  AV36error, out  AV34mensaje) ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A10HARDWARE_ID", StringUtil.LTrim( StringUtil.Str( (decimal)(A10HARDWARE_ID), 4, 0)));
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A104HDW_IDT", StringUtil.LTrim( StringUtil.Str( (decimal)(A104HDW_IDT), 8, 0)));
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV36error", StringUtil.Str( (decimal)(AV36error), 1, 0));
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV34mensaje", AV34mensaje);
         }
         GxWebStd.set_html_headers( context, 0, "", "");
         context.GX_webresponse.AddString("new Array( new Array(");
         context.GX_webresponse.AddString("\""+GXUtil.EncodeJSConstant( StringUtil.LTrim( StringUtil.NToC( (decimal)(AV36error), 1, 0, ".", "")))+"\""+","+"\""+GXUtil.EncodeJSConstant( StringUtil.RTrim( AV34mensaje))+"\"");
         context.GX_webresponse.AddString(")");
         if ( true )
         {
            context.GX_webresponse.AddString(",");
            context.GX_webresponse.AddString("101");
         }
         context.GX_webresponse.AddString(")");
      }

      protected void XC_37_0N23( int A104HDW_IDT ,
                                 DateTime A186fecha_baja )
      {
         if ( ! (DateTime.MinValue==A186fecha_baja) && ( A104HDW_IDT != 0 ) && true /* After */ )
         {
            new ptbus033(context ).execute(  A104HDW_IDT, out  AV37error_2) ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A104HDW_IDT", StringUtil.LTrim( StringUtil.Str( (decimal)(A104HDW_IDT), 8, 0)));
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV37error_2", StringUtil.Str( (decimal)(AV37error_2), 1, 0));
         }
         GxWebStd.set_html_headers( context, 0, "", "");
         context.GX_webresponse.AddString("new Array( new Array(");
         context.GX_webresponse.AddString("\""+GXUtil.EncodeJSConstant( StringUtil.LTrim( StringUtil.NToC( (decimal)(AV37error_2), 1, 0, ".", "")))+"\"");
         context.GX_webresponse.AddString(")");
         if ( true )
         {
            context.GX_webresponse.AddString(",");
            context.GX_webresponse.AddString("101");
         }
         context.GX_webresponse.AddString(")");
      }

      protected void XC_39_0N23( long A194THARDWARE_UBI ,
                                 long A311HARDWARE_RED ,
                                 short A10HARDWARE_ID ,
                                 short A299TIPO_DIR_IP ,
                                 String A185ACTIVO ,
                                 String Gx_mode )
      {
         if ( ( A299TIPO_DIR_IP == 2 ) && ( StringUtil.StrCmp(A185ACTIVO, "No") != 0 ) && true /* After */ && ( ( StringUtil.StrCmp(Gx_mode, "INS") == 0 ) || ( StringUtil.StrCmp(Gx_mode, "UPD") == 0 ) ) )
         {
            new phdw_ip_5(context ).execute(  A194THARDWARE_UBI,  A311HARDWARE_RED,  A10HARDWARE_ID, out  AV15Red_DireccionDesde, out  AV19Red_DireccionHasta, out  AV20Red_Mascara, out  AV21Red_PuertaEnlace, out  AV16Red_DireccionDesdeB1, out  AV17Red_DireccionDesdeB2, out  AV18Red_DireccionDesdeB3) ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A194THARDWARE_UBI", StringUtil.LTrim( StringUtil.Str( (decimal)(A194THARDWARE_UBI), 10, 0)));
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A311HARDWARE_RED", StringUtil.LTrim( StringUtil.Str( (decimal)(A311HARDWARE_RED), 10, 0)));
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A10HARDWARE_ID", StringUtil.LTrim( StringUtil.Str( (decimal)(A10HARDWARE_ID), 4, 0)));
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV15Red_DireccionDesde", AV15Red_DireccionDesde);
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV19Red_DireccionHasta", AV19Red_DireccionHasta);
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV20Red_Mascara", AV20Red_Mascara);
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV21Red_PuertaEnlace", AV21Red_PuertaEnlace);
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV16Red_DireccionDesdeB1", StringUtil.LTrim( StringUtil.Str( (decimal)(AV16Red_DireccionDesdeB1), 3, 0)));
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV17Red_DireccionDesdeB2", StringUtil.LTrim( StringUtil.Str( (decimal)(AV17Red_DireccionDesdeB2), 3, 0)));
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV18Red_DireccionDesdeB3", StringUtil.LTrim( StringUtil.Str( (decimal)(AV18Red_DireccionDesdeB3), 3, 0)));
         }
         GxWebStd.set_html_headers( context, 0, "", "");
         context.GX_webresponse.AddString("new Array( new Array(");
         context.GX_webresponse.AddString("\""+GXUtil.EncodeJSConstant( StringUtil.RTrim( AV15Red_DireccionDesde))+"\""+","+"\""+GXUtil.EncodeJSConstant( StringUtil.RTrim( AV19Red_DireccionHasta))+"\""+","+"\""+GXUtil.EncodeJSConstant( StringUtil.RTrim( AV20Red_Mascara))+"\""+","+"\""+GXUtil.EncodeJSConstant( StringUtil.RTrim( AV21Red_PuertaEnlace))+"\""+","+"\""+GXUtil.EncodeJSConstant( StringUtil.LTrim( StringUtil.NToC( (decimal)(AV16Red_DireccionDesdeB1), 3, 0, ".", "")))+"\""+","+"\""+GXUtil.EncodeJSConstant( StringUtil.LTrim( StringUtil.NToC( (decimal)(AV17Red_DireccionDesdeB2), 3, 0, ".", "")))+"\""+","+"\""+GXUtil.EncodeJSConstant( StringUtil.LTrim( StringUtil.NToC( (decimal)(AV18Red_DireccionDesdeB3), 3, 0, ".", "")))+"\"");
         context.GX_webresponse.AddString(")");
         if ( true )
         {
            context.GX_webresponse.AddString(",");
            context.GX_webresponse.AddString("101");
         }
         context.GX_webresponse.AddString(")");
      }

      protected void XC_40_0N23( long A194THARDWARE_UBI ,
                                 long A311HARDWARE_RED ,
                                 short A10HARDWARE_ID ,
                                 short A299TIPO_DIR_IP ,
                                 String A185ACTIVO ,
                                 String Gx_mode )
      {
         if ( ( A299TIPO_DIR_IP == 2 ) && ( StringUtil.StrCmp(A185ACTIVO, "No") != 0 ) && true /* After */ && ( StringUtil.StrCmp(Gx_mode, "INS") != 0 ) )
         {
            new phdw_ip_5(context ).execute(  A194THARDWARE_UBI,  A311HARDWARE_RED,  A10HARDWARE_ID, out  AV15Red_DireccionDesde, out  AV19Red_DireccionHasta, out  AV20Red_Mascara, out  AV21Red_PuertaEnlace, out  AV16Red_DireccionDesdeB1, out  AV17Red_DireccionDesdeB2, out  AV18Red_DireccionDesdeB3) ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A194THARDWARE_UBI", StringUtil.LTrim( StringUtil.Str( (decimal)(A194THARDWARE_UBI), 10, 0)));
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A311HARDWARE_RED", StringUtil.LTrim( StringUtil.Str( (decimal)(A311HARDWARE_RED), 10, 0)));
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A10HARDWARE_ID", StringUtil.LTrim( StringUtil.Str( (decimal)(A10HARDWARE_ID), 4, 0)));
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV15Red_DireccionDesde", AV15Red_DireccionDesde);
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV19Red_DireccionHasta", AV19Red_DireccionHasta);
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV20Red_Mascara", AV20Red_Mascara);
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV21Red_PuertaEnlace", AV21Red_PuertaEnlace);
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV16Red_DireccionDesdeB1", StringUtil.LTrim( StringUtil.Str( (decimal)(AV16Red_DireccionDesdeB1), 3, 0)));
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV17Red_DireccionDesdeB2", StringUtil.LTrim( StringUtil.Str( (decimal)(AV17Red_DireccionDesdeB2), 3, 0)));
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV18Red_DireccionDesdeB3", StringUtil.LTrim( StringUtil.Str( (decimal)(AV18Red_DireccionDesdeB3), 3, 0)));
         }
         GxWebStd.set_html_headers( context, 0, "", "");
         context.GX_webresponse.AddString("new Array( new Array(");
         context.GX_webresponse.AddString("\""+GXUtil.EncodeJSConstant( StringUtil.RTrim( AV15Red_DireccionDesde))+"\""+","+"\""+GXUtil.EncodeJSConstant( StringUtil.RTrim( AV19Red_DireccionHasta))+"\""+","+"\""+GXUtil.EncodeJSConstant( StringUtil.RTrim( AV20Red_Mascara))+"\""+","+"\""+GXUtil.EncodeJSConstant( StringUtil.RTrim( AV21Red_PuertaEnlace))+"\""+","+"\""+GXUtil.EncodeJSConstant( StringUtil.LTrim( StringUtil.NToC( (decimal)(AV16Red_DireccionDesdeB1), 3, 0, ".", "")))+"\""+","+"\""+GXUtil.EncodeJSConstant( StringUtil.LTrim( StringUtil.NToC( (decimal)(AV17Red_DireccionDesdeB2), 3, 0, ".", "")))+"\""+","+"\""+GXUtil.EncodeJSConstant( StringUtil.LTrim( StringUtil.NToC( (decimal)(AV18Red_DireccionDesdeB3), 3, 0, ".", "")))+"\"");
         context.GX_webresponse.AddString(")");
         if ( true )
         {
            context.GX_webresponse.AddString(",");
            context.GX_webresponse.AddString("101");
         }
         context.GX_webresponse.AddString(")");
      }

      protected void XC_41_0N23( short A10HARDWARE_ID ,
                                 long A194THARDWARE_UBI ,
                                 long A311HARDWARE_RED ,
                                 short A312HARDWARE_IP ,
                                 String A185ACTIVO ,
                                 short A299TIPO_DIR_IP )
      {
         if ( ( StringUtil.StrCmp(A185ACTIVO, "No") != 0 ) && ( A299TIPO_DIR_IP == 2 ) )
         {
            new phdw_ip_6(context ).execute(  A10HARDWARE_ID,  A194THARDWARE_UBI,  A311HARDWARE_RED,  A312HARDWARE_IP, out  AV33validado, out  AV34mensaje) ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A10HARDWARE_ID", StringUtil.LTrim( StringUtil.Str( (decimal)(A10HARDWARE_ID), 4, 0)));
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A194THARDWARE_UBI", StringUtil.LTrim( StringUtil.Str( (decimal)(A194THARDWARE_UBI), 10, 0)));
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A311HARDWARE_RED", StringUtil.LTrim( StringUtil.Str( (decimal)(A311HARDWARE_RED), 10, 0)));
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A312HARDWARE_IP", StringUtil.LTrim( StringUtil.Str( (decimal)(A312HARDWARE_IP), 3, 0)));
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV33validado", StringUtil.Str( (decimal)(AV33validado), 1, 0));
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV34mensaje", AV34mensaje);
         }
         GxWebStd.set_html_headers( context, 0, "", "");
         context.GX_webresponse.AddString("new Array( new Array(");
         context.GX_webresponse.AddString("\""+GXUtil.EncodeJSConstant( StringUtil.LTrim( StringUtil.NToC( (decimal)(AV33validado), 1, 0, ".", "")))+"\""+","+"\""+GXUtil.EncodeJSConstant( StringUtil.RTrim( AV34mensaje))+"\"");
         context.GX_webresponse.AddString(")");
         if ( true )
         {
            context.GX_webresponse.AddString(",");
            context.GX_webresponse.AddString("101");
         }
         context.GX_webresponse.AddString(")");
      }

      public void Valid_Hardware_id( String GX_Parm1 ,
                                     GXCombobox cmbGX_Parm2 ,
                                     GXCombobox cmbGX_Parm3 ,
                                     GXCombobox dynGX_Parm4 ,
                                     GXCombobox dynGX_Parm5 ,
                                     short GX_Parm6 ,
                                     String GX_Parm7 ,
                                     String GX_Parm8 ,
                                     String GX_Parm9 ,
                                     String GX_Parm10 ,
                                     short GX_Parm11 ,
                                     short GX_Parm12 ,
                                     short GX_Parm13 )
      {
         Gx_mode = GX_Parm1 ;
         cmbACTIVO = cmbGX_Parm2 ;
         A185ACTIVO = cmbACTIVO.CurrentValue ;
         n185ACTIVO = false ;
         cmbTIPO_DIR_IP = cmbGX_Parm3 ;
         A299TIPO_DIR_IP = (short)(NumberUtil.Val( cmbTIPO_DIR_IP.CurrentValue, ".")) ;
         n299TIPO_DIR_IP = false ;
         dynHARDWARE_RED = dynGX_Parm4 ;
         A311HARDWARE_RED = (long)(NumberUtil.Val( dynHARDWARE_RED.CurrentValue, ".")) ;
         n311HARDWARE_RED = false ;
         dynTHARDWARE_UBI = dynGX_Parm5 ;
         A194THARDWARE_UBI = (long)(NumberUtil.Val( dynTHARDWARE_UBI.CurrentValue, ".")) ;
         A10HARDWARE_ID = GX_Parm6 ;
         n10HARDWARE_ID = false ;
         AV15Red_DireccionDesde = GX_Parm7 ;
         AV19Red_DireccionHasta = GX_Parm8 ;
         AV20Red_Mascara = GX_Parm9 ;
         AV21Red_PuertaEnlace = GX_Parm10 ;
         AV16Red_DireccionDesdeB1 = GX_Parm11 ;
         AV17Red_DireccionDesdeB2 = GX_Parm12 ;
         AV18Red_DireccionDesdeB3 = GX_Parm13 ;
         if ( ( A299TIPO_DIR_IP == 2 ) && ( StringUtil.StrCmp(A185ACTIVO, "No") != 0 ) && true /* After */ && ( StringUtil.StrCmp(Gx_mode, "INS") != 0 ) )
         {
            new phdw_ip_5(context ).execute(  A194THARDWARE_UBI,  A311HARDWARE_RED,  A10HARDWARE_ID, out  AV15Red_DireccionDesde, out  AV19Red_DireccionHasta, out  AV20Red_Mascara, out  AV21Red_PuertaEnlace, out  AV16Red_DireccionDesdeB1, out  AV17Red_DireccionDesdeB2, out  AV18Red_DireccionDesdeB3) ;
         }
         dynload_actions( ) ;
         if ( AnyError == 1 )
         {
         }
         isValidOutput.Add((Object)(StringUtil.RTrim( AV15Red_DireccionDesde)));
         isValidOutput.Add((Object)(StringUtil.RTrim( AV19Red_DireccionHasta)));
         isValidOutput.Add((Object)(StringUtil.RTrim( AV20Red_Mascara)));
         isValidOutput.Add((Object)(StringUtil.RTrim( AV21Red_PuertaEnlace)));
         isValidOutput.Add((Object)(StringUtil.LTrim( StringUtil.NToC( (decimal)(AV16Red_DireccionDesdeB1), 3, 0, ".", ""))));
         isValidOutput.Add((Object)(StringUtil.LTrim( StringUtil.NToC( (decimal)(AV17Red_DireccionDesdeB2), 3, 0, ".", ""))));
         isValidOutput.Add((Object)(StringUtil.LTrim( StringUtil.NToC( (decimal)(AV18Red_DireccionDesdeB3), 3, 0, ".", ""))));
         isValidOutput.Add((Object)(context.GX_msglist.ToJavascriptSource()));
         context.GX_webresponse.AddString(isValidOutput.ToJSonString());
      }

      public void Valid_Fecha_baja( int GX_Parm1 ,
                                    DateTime GX_Parm2 ,
                                    short GX_Parm3 )
      {
         A104HDW_IDT = GX_Parm1 ;
         A186fecha_baja = GX_Parm2 ;
         n186fecha_baja = false ;
         AV37error_2 = GX_Parm3 ;
         if ( ! ( (DateTime.MinValue==A186fecha_baja) || ( A186fecha_baja >= context.localUtil.YMDHMSToT( 1753, 1, 1, 0, 0, 0) ) ) )
         {
            GX_msglist.addItem("Campo fecha_baja fuera de rango", "OutOfRange", 1, "FECHA_BAJA");
            AnyError = 1 ;
            GX_FocusControl = edtfecha_baja_Internalname ;
         }
         if ( ( ( StringUtil.StrCmp(A185ACTIVO, "No") == 0 ) ) && ( (DateTime.MinValue==A186fecha_baja) ) && ( true /* After */ ) )
         {
            GX_msglist.addItem("Debe cargar una fecha de baja.", 1, "FECHA_BAJA");
            AnyError = 1 ;
            GX_FocusControl = edtfecha_baja_Internalname ;
         }
         if ( ! (DateTime.MinValue==A186fecha_baja) && ( A104HDW_IDT != 0 ) && true /* After */ )
         {
            new ptbus033(context ).execute(  A104HDW_IDT, out  AV37error_2) ;
         }
         if ( ( AV37error_2 == 1 ) && ! (DateTime.MinValue==A186fecha_baja) && ( A104HDW_IDT != 0 ) && true /* After */ )
         {
            GX_msglist.addItem("No puede dar de baja este equipo porque no está dado de baja en trazabilidad de bienes de uso.", 1, "FECHA_BAJA");
            AnyError = 1 ;
            GX_FocusControl = edtfecha_baja_Internalname ;
         }
         dynload_actions( ) ;
         if ( AnyError == 1 )
         {
         }
         isValidOutput.Add((Object)(StringUtil.LTrim( StringUtil.NToC( (decimal)(AV37error_2), 1, 0, ".", ""))));
         isValidOutput.Add((Object)(context.GX_msglist.ToJavascriptSource()));
         context.GX_webresponse.AddString(isValidOutput.ToJSonString());
      }

      public void Valid_Tipo_dir_ip( String GX_Parm1 ,
                                     GXCombobox cmbGX_Parm2 ,
                                     GXCombobox cmbGX_Parm3 ,
                                     short GX_Parm4 ,
                                     GXCombobox dynGX_Parm5 ,
                                     GXCombobox dynGX_Parm6 ,
                                     short GX_Parm7 ,
                                     String GX_Parm8 ,
                                     String GX_Parm9 ,
                                     String GX_Parm10 ,
                                     String GX_Parm11 ,
                                     short GX_Parm12 ,
                                     short GX_Parm13 ,
                                     short GX_Parm14 )
      {
         Gx_mode = GX_Parm1 ;
         cmbTIPO_DIR_IP = cmbGX_Parm2 ;
         A299TIPO_DIR_IP = (short)(NumberUtil.Val( cmbTIPO_DIR_IP.CurrentValue, ".")) ;
         n299TIPO_DIR_IP = false ;
         cmbACTIVO = cmbGX_Parm3 ;
         A185ACTIVO = cmbACTIVO.CurrentValue ;
         n185ACTIVO = false ;
         Gx_BScreen = GX_Parm4 ;
         dynTHARDWARE_UBI = dynGX_Parm5 ;
         A194THARDWARE_UBI = (long)(NumberUtil.Val( dynTHARDWARE_UBI.CurrentValue, ".")) ;
         dynHARDWARE_RED = dynGX_Parm6 ;
         A311HARDWARE_RED = (long)(NumberUtil.Val( dynHARDWARE_RED.CurrentValue, ".")) ;
         n311HARDWARE_RED = false ;
         A312HARDWARE_IP = GX_Parm7 ;
         n312HARDWARE_IP = false ;
         AV15Red_DireccionDesde = GX_Parm8 ;
         AV19Red_DireccionHasta = GX_Parm9 ;
         AV20Red_Mascara = GX_Parm10 ;
         AV21Red_PuertaEnlace = GX_Parm11 ;
         AV16Red_DireccionDesdeB1 = GX_Parm12 ;
         AV17Red_DireccionDesdeB2 = GX_Parm13 ;
         AV18Red_DireccionDesdeB3 = GX_Parm14 ;
         if ( ( A299TIPO_DIR_IP == 2 ) && ( StringUtil.StrCmp(A185ACTIVO, "No") != 0 ) )
         {
            dynTHARDWARE_UBI.Enabled = 1 ;
         }
         else
         {
            if ( A299TIPO_DIR_IP != 2 )
            {
               dynTHARDWARE_UBI.Enabled = 0 ;
            }
            else
            {
               if ( StringUtil.StrCmp(A185ACTIVO, "No") == 0 )
               {
                  dynTHARDWARE_UBI.Enabled = 0 ;
               }
            }
         }
         if ( ( A299TIPO_DIR_IP == 2 ) && ( StringUtil.StrCmp(A185ACTIVO, "No") != 0 ) )
         {
            dynHARDWARE_RED.Enabled = 1 ;
         }
         else
         {
            if ( A299TIPO_DIR_IP != 2 )
            {
               dynHARDWARE_RED.Enabled = 0 ;
            }
            else
            {
               if ( StringUtil.StrCmp(A185ACTIVO, "No") == 0 )
               {
                  dynHARDWARE_RED.Enabled = 0 ;
               }
            }
         }
         if ( A299TIPO_DIR_IP != 2 )
         {
            A194THARDWARE_UBI = 0 ;
         }
         else
         {
            if ( StringUtil.StrCmp(A185ACTIVO, "No") == 0 )
            {
               A194THARDWARE_UBI = 0 ;
            }
            else
            {
               if ( ( StringUtil.StrCmp(Gx_mode, "INS") == 0 )  && (0==A194THARDWARE_UBI) && ( Gx_BScreen == 0 ) )
               {
                  A194THARDWARE_UBI = 1 ;
               }
            }
         }
         if ( A299TIPO_DIR_IP != 2 )
         {
            A311HARDWARE_RED = 0 ;
            n311HARDWARE_RED = false ;
         }
         else
         {
            if ( StringUtil.StrCmp(A185ACTIVO, "No") == 0 )
            {
               A311HARDWARE_RED = 0 ;
               n311HARDWARE_RED = false ;
            }
         }
         if ( A299TIPO_DIR_IP != 2 )
         {
            A312HARDWARE_IP = 0 ;
            n312HARDWARE_IP = false ;
         }
         else
         {
            if ( StringUtil.StrCmp(A185ACTIVO, "No") == 0 )
            {
               A312HARDWARE_IP = 0 ;
               n312HARDWARE_IP = false ;
            }
         }
         if ( ( A299TIPO_DIR_IP != 2 ) && true /* After */ )
         {
            AV15Red_DireccionDesde = "0.0.0.0" ;
         }
         else
         {
            if ( ( StringUtil.StrCmp(A185ACTIVO, "No") == 0 ) && true /* After */ )
            {
               AV15Red_DireccionDesde = "0.0.0.0" ;
            }
         }
         if ( ( A299TIPO_DIR_IP != 2 ) && true /* After */ )
         {
            AV19Red_DireccionHasta = "0.0.0.0" ;
         }
         else
         {
            if ( ( StringUtil.StrCmp(A185ACTIVO, "No") == 0 ) && true /* After */ )
            {
               AV19Red_DireccionHasta = "0.0.0.0" ;
            }
         }
         if ( ( A299TIPO_DIR_IP != 2 ) && true /* After */ )
         {
            AV20Red_Mascara = "0.0.0.0" ;
         }
         else
         {
            if ( ( StringUtil.StrCmp(A185ACTIVO, "No") == 0 ) && true /* After */ )
            {
               AV20Red_Mascara = "0.0.0.0" ;
            }
         }
         if ( ( A299TIPO_DIR_IP != 2 ) && true /* After */ )
         {
            AV21Red_PuertaEnlace = "0.0.0.0" ;
         }
         else
         {
            if ( ( StringUtil.StrCmp(A185ACTIVO, "No") == 0 ) && true /* After */ )
            {
               AV21Red_PuertaEnlace = "0.0.0.0" ;
            }
         }
         if ( ( A299TIPO_DIR_IP != 2 ) && true /* After */ )
         {
            AV16Red_DireccionDesdeB1 = 0 ;
         }
         else
         {
            if ( ( StringUtil.StrCmp(A185ACTIVO, "No") == 0 ) && true /* After */ )
            {
               AV16Red_DireccionDesdeB1 = 0 ;
            }
         }
         if ( ( A299TIPO_DIR_IP != 2 ) && true /* After */ )
         {
            AV17Red_DireccionDesdeB2 = 0 ;
         }
         else
         {
            if ( ( StringUtil.StrCmp(A185ACTIVO, "No") == 0 ) && true /* After */ )
            {
               AV17Red_DireccionDesdeB2 = 0 ;
            }
         }
         if ( ( A299TIPO_DIR_IP != 2 ) && true /* After */ )
         {
            AV18Red_DireccionDesdeB3 = 0 ;
         }
         else
         {
            if ( ( StringUtil.StrCmp(A185ACTIVO, "No") == 0 ) && true /* After */ )
            {
               AV18Red_DireccionDesdeB3 = 0 ;
            }
         }
         if ( ( (0==A299TIPO_DIR_IP) ) && ( ( StringUtil.StrCmp(A185ACTIVO, "No") != 0 ) ) && ( ( A313TH_DIREC == 2 ) ) && ( true /* After */ ) )
         {
            GX_msglist.addItem("Debe especificar un tipo de dirección IP.", 1, "TIPO_DIR_IP");
            AnyError = 1 ;
            GX_FocusControl = cmbTIPO_DIR_IP_Internalname ;
         }
         if ( ! ( (0==A299TIPO_DIR_IP) ) && ( ( StringUtil.StrCmp(A185ACTIVO, "No") != 0 ) ) && ( ( A313TH_DIREC == 1 ) ) && ( true /* After */ ) )
         {
            GX_msglist.addItem("El tipo de hardware no es direccionable.", 1, "TIPO_DIR_IP");
            AnyError = 1 ;
            GX_FocusControl = cmbTIPO_DIR_IP_Internalname ;
         }
         dynload_actions( ) ;
         if ( AnyError == 1 )
         {
         }
         GXATHARDWARE_UBI_html0N23( ) ;
         dynTHARDWARE_UBI.CurrentValue = StringUtil.Str( (decimal)(A194THARDWARE_UBI), 10, 0) ;
         dynHARDWARE_RED.CurrentValue = StringUtil.Str( (decimal)(A311HARDWARE_RED), 10, 0) ;
         isValidOutput.Add((Object)(dynTHARDWARE_UBI.Enabled));
         isValidOutput.Add((Object)(dynHARDWARE_RED.Enabled));
         isValidOutput.Add((Object)(dynTHARDWARE_UBI));
         isValidOutput.Add((Object)(dynHARDWARE_RED));
         isValidOutput.Add((Object)(StringUtil.LTrim( StringUtil.NToC( (decimal)(A312HARDWARE_IP), 3, 0, ".", ""))));
         isValidOutput.Add((Object)(StringUtil.RTrim( AV15Red_DireccionDesde)));
         isValidOutput.Add((Object)(StringUtil.RTrim( AV19Red_DireccionHasta)));
         isValidOutput.Add((Object)(StringUtil.RTrim( AV20Red_Mascara)));
         isValidOutput.Add((Object)(StringUtil.RTrim( AV21Red_PuertaEnlace)));
         isValidOutput.Add((Object)(StringUtil.LTrim( StringUtil.NToC( (decimal)(AV16Red_DireccionDesdeB1), 3, 0, ".", ""))));
         isValidOutput.Add((Object)(StringUtil.LTrim( StringUtil.NToC( (decimal)(AV17Red_DireccionDesdeB2), 3, 0, ".", ""))));
         isValidOutput.Add((Object)(StringUtil.LTrim( StringUtil.NToC( (decimal)(AV18Red_DireccionDesdeB3), 3, 0, ".", ""))));
         isValidOutput.Add((Object)(context.GX_msglist.ToJavascriptSource()));
         context.GX_webresponse.AddString(isValidOutput.ToJSonString());
      }

      public void Valid_Thardware_ubi( GXCombobox dynGX_Parm1 ,
                                       GXCombobox dynGX_Parm2 )
      {
         dynTHARDWARE_UBI = dynGX_Parm1 ;
         A194THARDWARE_UBI = (long)(NumberUtil.Val( dynTHARDWARE_UBI.CurrentValue, ".")) ;
         dynHARDWARE_RED = dynGX_Parm2 ;
         A311HARDWARE_RED = (long)(NumberUtil.Val( dynHARDWARE_RED.CurrentValue, ".")) ;
         n311HARDWARE_RED = false ;
         GXAHARDWARE_RED_html0N23( A194THARDWARE_UBI) ;
         dynload_actions( ) ;
         if ( AnyError == 1 )
         {
         }
         dynHARDWARE_RED.CurrentValue = StringUtil.Str( (decimal)(A311HARDWARE_RED), 10, 0) ;
         isValidOutput.Add((Object)(dynHARDWARE_RED));
         isValidOutput.Add((Object)(context.GX_msglist.ToJavascriptSource()));
         context.GX_webresponse.AddString(isValidOutput.ToJSonString());
      }

      public void Valid_Hardware_red( String GX_Parm1 ,
                                      GXCombobox dynGX_Parm2 ,
                                      short GX_Parm3 ,
                                      GXCombobox dynGX_Parm4 ,
                                      short GX_Parm5 ,
                                      GXCombobox cmbGX_Parm6 ,
                                      GXCombobox cmbGX_Parm7 ,
                                      String GX_Parm8 ,
                                      String GX_Parm9 ,
                                      String GX_Parm10 ,
                                      String GX_Parm11 ,
                                      short GX_Parm12 ,
                                      short GX_Parm13 ,
                                      short GX_Parm14 ,
                                      short GX_Parm15 ,
                                      String GX_Parm16 )
      {
         Gx_mode = GX_Parm1 ;
         dynHARDWARE_RED = dynGX_Parm2 ;
         A311HARDWARE_RED = (long)(NumberUtil.Val( dynHARDWARE_RED.CurrentValue, ".")) ;
         n311HARDWARE_RED = false ;
         A10HARDWARE_ID = GX_Parm3 ;
         n10HARDWARE_ID = false ;
         dynTHARDWARE_UBI = dynGX_Parm4 ;
         A194THARDWARE_UBI = (long)(NumberUtil.Val( dynTHARDWARE_UBI.CurrentValue, ".")) ;
         A312HARDWARE_IP = GX_Parm5 ;
         n312HARDWARE_IP = false ;
         cmbACTIVO = cmbGX_Parm6 ;
         A185ACTIVO = cmbACTIVO.CurrentValue ;
         n185ACTIVO = false ;
         cmbTIPO_DIR_IP = cmbGX_Parm7 ;
         A299TIPO_DIR_IP = (short)(NumberUtil.Val( cmbTIPO_DIR_IP.CurrentValue, ".")) ;
         n299TIPO_DIR_IP = false ;
         AV15Red_DireccionDesde = GX_Parm8 ;
         AV19Red_DireccionHasta = GX_Parm9 ;
         AV20Red_Mascara = GX_Parm10 ;
         AV21Red_PuertaEnlace = GX_Parm11 ;
         AV16Red_DireccionDesdeB1 = GX_Parm12 ;
         AV17Red_DireccionDesdeB2 = GX_Parm13 ;
         AV18Red_DireccionDesdeB3 = GX_Parm14 ;
         AV33validado = GX_Parm15 ;
         AV34mensaje = GX_Parm16 ;
         if ( ( A299TIPO_DIR_IP == 2 ) && ( StringUtil.StrCmp(A185ACTIVO, "No") != 0 ) && true /* After */ && ( ( StringUtil.StrCmp(Gx_mode, "INS") == 0 ) || ( StringUtil.StrCmp(Gx_mode, "UPD") == 0 ) ) )
         {
            new phdw_ip_5(context ).execute(  A194THARDWARE_UBI,  A311HARDWARE_RED,  A10HARDWARE_ID, out  AV15Red_DireccionDesde, out  AV19Red_DireccionHasta, out  AV20Red_Mascara, out  AV21Red_PuertaEnlace, out  AV16Red_DireccionDesdeB1, out  AV17Red_DireccionDesdeB2, out  AV18Red_DireccionDesdeB3) ;
         }
         if ( ( StringUtil.StrCmp(A185ACTIVO, "No") != 0 ) && ( A299TIPO_DIR_IP == 2 ) )
         {
            new phdw_ip_6(context ).execute(  A10HARDWARE_ID,  A194THARDWARE_UBI,  A311HARDWARE_RED,  A312HARDWARE_IP, out  AV33validado, out  AV34mensaje) ;
         }
         dynload_actions( ) ;
         if ( AnyError == 1 )
         {
         }
         isValidOutput.Add((Object)(StringUtil.RTrim( AV15Red_DireccionDesde)));
         isValidOutput.Add((Object)(StringUtil.RTrim( AV19Red_DireccionHasta)));
         isValidOutput.Add((Object)(StringUtil.RTrim( AV20Red_Mascara)));
         isValidOutput.Add((Object)(StringUtil.RTrim( AV21Red_PuertaEnlace)));
         isValidOutput.Add((Object)(StringUtil.LTrim( StringUtil.NToC( (decimal)(AV16Red_DireccionDesdeB1), 3, 0, ".", ""))));
         isValidOutput.Add((Object)(StringUtil.LTrim( StringUtil.NToC( (decimal)(AV17Red_DireccionDesdeB2), 3, 0, ".", ""))));
         isValidOutput.Add((Object)(StringUtil.LTrim( StringUtil.NToC( (decimal)(AV18Red_DireccionDesdeB3), 3, 0, ".", ""))));
         isValidOutput.Add((Object)(StringUtil.LTrim( StringUtil.NToC( (decimal)(AV33validado), 1, 0, ".", ""))));
         isValidOutput.Add((Object)(StringUtil.RTrim( AV34mensaje)));
         isValidOutput.Add((Object)(context.GX_msglist.ToJavascriptSource()));
         context.GX_webresponse.AddString(isValidOutput.ToJSonString());
      }

      public void Valid_Hdw_idt( short GX_Parm1 ,
                                 int GX_Parm2 ,
                                 short GX_Parm3 ,
                                 String GX_Parm4 )
      {
         A10HARDWARE_ID = GX_Parm1 ;
         n10HARDWARE_ID = false ;
         A104HDW_IDT = GX_Parm2 ;
         AV36error = GX_Parm3 ;
         AV34mensaje = GX_Parm4 ;
         if ( ( A104HDW_IDT != 0 ) && true /* After */ )
         {
            new ptbus032_1(context ).execute(  A10HARDWARE_ID,  A104HDW_IDT, out  AV36error, out  AV34mensaje) ;
         }
         if ( ( AV36error == 1 ) && ( A104HDW_IDT != 0 ) && true /* After */ )
         {
            GX_msglist.addItem(AV34mensaje, 1, "HDW_IDT");
            AnyError = 1 ;
            GX_FocusControl = edtHDW_IDT_Internalname ;
         }
         dynload_actions( ) ;
         if ( AnyError == 1 )
         {
         }
         isValidOutput.Add((Object)(StringUtil.LTrim( StringUtil.NToC( (decimal)(AV36error), 1, 0, ".", ""))));
         isValidOutput.Add((Object)(StringUtil.RTrim( AV34mensaje)));
         isValidOutput.Add((Object)(context.GX_msglist.ToJavascriptSource()));
         context.GX_webresponse.AddString(isValidOutput.ToJSonString());
      }

      protected void cleanup( )
      {
         flushBuffer();
         CloseOpenCursors();
         if ( IsMain )
         {
            context.CloseConnections() ;
         }
      }

      protected void CloseOpenCursors( )
      {
         pr_default.close(12);
         pr_default.close(5);
         pr_default.close(4);
      }

      public override void initialize( )
      {
         sPrefix = "" ;
         wcpOGx_mode = "" ;
         wcpOAV29SISTEMA = "" ;
         wcpOAV30USUARIO = "" ;
         scmdbuf = "" ;
         gxfirstwebparm = "" ;
         gxfirstwebparm_bkp = "" ;
         A186fecha_baja = (DateTime)(DateTime.MinValue) ;
         A185ACTIVO = "" ;
         PreviousTooltip = "" ;
         PreviousCaption = "" ;
         Form = new GXWebForm();
         GX_FocusControl = "" ;
         sStyleString = "" ;
         TempTags = "" ;
         ClassString = "" ;
         StyleString = "" ;
         bttBtn_first_Jsonclick = "" ;
         bttBtn_previous_Jsonclick = "" ;
         bttBtn_next_Jsonclick = "" ;
         bttBtn_last_Jsonclick = "" ;
         bttBtn_select_Jsonclick = "" ;
         bttBtn_enter_Jsonclick = "" ;
         bttBtn_check_Jsonclick = "" ;
         bttBtn_cancel_Jsonclick = "" ;
         bttBtn_delete_Jsonclick = "" ;
         lblTextblock1_Jsonclick = "" ;
         A58HARDWARE_DESCRIPCION = "" ;
         A182fecha_alta = (DateTime)(DateTime.MinValue) ;
         lblTextblock3_Jsonclick = "" ;
         lblTextblock4_Jsonclick = "" ;
         A187NOMBRE_DEL_TIPO_DE_HD = "" ;
         lblTextblock12_Jsonclick = "" ;
         lblTextblock7_Jsonclick = "" ;
         lblTextblock8_Jsonclick = "" ;
         A188MODELO_DE_COMPONENTES_NOMBRE = "" ;
         lblTextblock5_Jsonclick = "" ;
         lblTextblock6_Jsonclick = "" ;
         A190MARCAS_DESCRIPCION = "" ;
         lblTextblock9_Jsonclick = "" ;
         lblTextblock10_Jsonclick = "" ;
         A9HARDWARE_NRO_SERIE = "" ;
         lblTextblock2_Jsonclick = "" ;
         A192PRUEBA_MICROFONO_AUDIO = "" ;
         lblTextblock11_Jsonclick = "" ;
         A193RESPONSABLE_ARMADO_PC = "" ;
         lblTextblock13_Jsonclick = "" ;
         lblTextblock15_Jsonclick = "" ;
         lblTextblock16_Jsonclick = "" ;
         lblTextblock17_Jsonclick = "" ;
         AV15Red_DireccionDesde = "" ;
         lblTextblock18_Jsonclick = "" ;
         AV19Red_DireccionHasta = "" ;
         lblTextblock19_Jsonclick = "" ;
         AV20Red_Mascara = "" ;
         lblTextblock20_Jsonclick = "" ;
         AV21Red_PuertaEnlace = "" ;
         lblTextblock14_Jsonclick = "" ;
         imgPrompt1_Jsonclick = "" ;
         lblTextblock21_Jsonclick = "" ;
         lblTxt_trazabilidad_Jsonclick = "" ;
         Z58HARDWARE_DESCRIPCION = "" ;
         Z182fecha_alta = (DateTime)(DateTime.MinValue) ;
         Z187NOMBRE_DEL_TIPO_DE_HD = "" ;
         Z188MODELO_DE_COMPONENTES_NOMBRE = "" ;
         Z190MARCAS_DESCRIPCION = "" ;
         Z9HARDWARE_NRO_SERIE = "" ;
         Z185ACTIVO = "" ;
         Z186fecha_baja = (DateTime)(DateTime.MinValue) ;
         Z192PRUEBA_MICROFONO_AUDIO = "" ;
         Z193RESPONSABLE_ARMADO_PC = "" ;
         AV34mensaje = "" ;
         sMode23 = "" ;
         sEvt = "" ;
         EvtGridId = "" ;
         EvtRowId = "" ;
         sEvtType = "" ;
         AV32THARDWARE_UBI = 1 ;
         AV23SESION = new GxWebSession( context);
         AV7ACTIVO = "" ;
         AV13HDW_IDT = 0 ;
         T000N4_A10HARDWARE_ID = new short[1] ;
         T000N4_n10HARDWARE_ID = new bool[] {false} ;
         T000N4_A194THARDWARE_UBI = new long[1] ;
         T000N4_A311HARDWARE_RED = new long[1] ;
         T000N4_n311HARDWARE_RED = new bool[] {false} ;
         T000N4_A312HARDWARE_IP = new short[1] ;
         T000N4_n312HARDWARE_IP = new bool[] {false} ;
         T000N4_A299TIPO_DIR_IP = new short[1] ;
         T000N4_n299TIPO_DIR_IP = new bool[] {false} ;
         T000N4_A181TIPOS_DE_HARDWARE_ID = new short[1] ;
         T000N4_A58HARDWARE_DESCRIPCION = new String[] {""} ;
         T000N4_A182fecha_alta = new DateTime[] {DateTime.MinValue} ;
         T000N4_n182fecha_alta = new bool[] {false} ;
         T000N4_A187NOMBRE_DEL_TIPO_DE_HD = new String[] {""} ;
         T000N4_A313TH_DIREC = new short[1] ;
         T000N4_A183MODELO_DE_COMPONENTES_ID = new short[1] ;
         T000N4_A188MODELO_DE_COMPONENTES_NOMBRE = new String[] {""} ;
         T000N4_A189MARCAS_ID = new short[1] ;
         T000N4_A190MARCAS_DESCRIPCION = new String[] {""} ;
         T000N4_A184HARDWARE_NRO_BIEN = new long[1] ;
         T000N4_A9HARDWARE_NRO_SERIE = new String[] {""} ;
         T000N4_A185ACTIVO = new String[] {""} ;
         T000N4_n185ACTIVO = new bool[] {false} ;
         T000N4_A186fecha_baja = new DateTime[] {DateTime.MinValue} ;
         T000N4_n186fecha_baja = new bool[] {false} ;
         T000N4_A192PRUEBA_MICROFONO_AUDIO = new String[] {""} ;
         T000N4_A193RESPONSABLE_ARMADO_PC = new String[] {""} ;
         T000N4_A104HDW_IDT = new int[1] ;
         T000N4_A314HARDWARE_UBA = new long[1] ;
         T000N4_n314HARDWARE_UBA = new bool[] {false} ;
         T000N5_A10HARDWARE_ID = new short[1] ;
         T000N5_n10HARDWARE_ID = new bool[] {false} ;
         T000N3_A10HARDWARE_ID = new short[1] ;
         T000N3_n10HARDWARE_ID = new bool[] {false} ;
         T000N3_A194THARDWARE_UBI = new long[1] ;
         T000N3_A311HARDWARE_RED = new long[1] ;
         T000N3_n311HARDWARE_RED = new bool[] {false} ;
         T000N3_A312HARDWARE_IP = new short[1] ;
         T000N3_n312HARDWARE_IP = new bool[] {false} ;
         T000N3_A299TIPO_DIR_IP = new short[1] ;
         T000N3_n299TIPO_DIR_IP = new bool[] {false} ;
         T000N3_A181TIPOS_DE_HARDWARE_ID = new short[1] ;
         T000N3_A58HARDWARE_DESCRIPCION = new String[] {""} ;
         T000N3_A182fecha_alta = new DateTime[] {DateTime.MinValue} ;
         T000N3_n182fecha_alta = new bool[] {false} ;
         T000N3_A187NOMBRE_DEL_TIPO_DE_HD = new String[] {""} ;
         T000N3_A313TH_DIREC = new short[1] ;
         T000N3_A183MODELO_DE_COMPONENTES_ID = new short[1] ;
         T000N3_A188MODELO_DE_COMPONENTES_NOMBRE = new String[] {""} ;
         T000N3_A189MARCAS_ID = new short[1] ;
         T000N3_A190MARCAS_DESCRIPCION = new String[] {""} ;
         T000N3_A184HARDWARE_NRO_BIEN = new long[1] ;
         T000N3_A9HARDWARE_NRO_SERIE = new String[] {""} ;
         T000N3_A185ACTIVO = new String[] {""} ;
         T000N3_n185ACTIVO = new bool[] {false} ;
         T000N3_A186fecha_baja = new DateTime[] {DateTime.MinValue} ;
         T000N3_n186fecha_baja = new bool[] {false} ;
         T000N3_A192PRUEBA_MICROFONO_AUDIO = new String[] {""} ;
         T000N3_A193RESPONSABLE_ARMADO_PC = new String[] {""} ;
         T000N3_A104HDW_IDT = new int[1] ;
         T000N3_A314HARDWARE_UBA = new long[1] ;
         T000N3_n314HARDWARE_UBA = new bool[] {false} ;
         T000N6_A10HARDWARE_ID = new short[1] ;
         T000N6_n10HARDWARE_ID = new bool[] {false} ;
         T000N7_A10HARDWARE_ID = new short[1] ;
         T000N7_n10HARDWARE_ID = new bool[] {false} ;
         T000N8_A10HARDWARE_ID = new short[1] ;
         T000N8_n10HARDWARE_ID = new bool[] {false} ;
         T000N8_A194THARDWARE_UBI = new long[1] ;
         T000N8_A311HARDWARE_RED = new long[1] ;
         T000N8_n311HARDWARE_RED = new bool[] {false} ;
         T000N8_A312HARDWARE_IP = new short[1] ;
         T000N8_n312HARDWARE_IP = new bool[] {false} ;
         T000N8_A299TIPO_DIR_IP = new short[1] ;
         T000N8_n299TIPO_DIR_IP = new bool[] {false} ;
         T000N8_A181TIPOS_DE_HARDWARE_ID = new short[1] ;
         T000N8_A58HARDWARE_DESCRIPCION = new String[] {""} ;
         T000N8_A182fecha_alta = new DateTime[] {DateTime.MinValue} ;
         T000N8_n182fecha_alta = new bool[] {false} ;
         T000N8_A187NOMBRE_DEL_TIPO_DE_HD = new String[] {""} ;
         T000N8_A313TH_DIREC = new short[1] ;
         T000N8_A183MODELO_DE_COMPONENTES_ID = new short[1] ;
         T000N8_A188MODELO_DE_COMPONENTES_NOMBRE = new String[] {""} ;
         T000N8_A189MARCAS_ID = new short[1] ;
         T000N8_A190MARCAS_DESCRIPCION = new String[] {""} ;
         T000N8_A184HARDWARE_NRO_BIEN = new long[1] ;
         T000N8_A9HARDWARE_NRO_SERIE = new String[] {""} ;
         T000N8_A185ACTIVO = new String[] {""} ;
         T000N8_n185ACTIVO = new bool[] {false} ;
         T000N8_A186fecha_baja = new DateTime[] {DateTime.MinValue} ;
         T000N8_n186fecha_baja = new bool[] {false} ;
         T000N8_A192PRUEBA_MICROFONO_AUDIO = new String[] {""} ;
         T000N8_A193RESPONSABLE_ARMADO_PC = new String[] {""} ;
         T000N8_A104HDW_IDT = new int[1] ;
         T000N8_A314HARDWARE_UBA = new long[1] ;
         T000N8_n314HARDWARE_UBA = new bool[] {false} ;
         T000N10_A10HARDWARE_ID = new short[1] ;
         T000N10_n10HARDWARE_ID = new bool[] {false} ;
         T000N13_A11TTBUS_Id = new int[1] ;
         T000N14_A10HARDWARE_ID = new short[1] ;
         T000N14_n10HARDWARE_ID = new bool[] {false} ;
         sDynURL = "" ;
         FormProcess = "" ;
         GXt_char2 = "" ;
         GXt_char1 = "" ;
         i185ACTIVO = "" ;
         i192PRUEBA_MICROFONO_AUDIO = "" ;
         gxdynajaxctrlcodr = new GeneXus.Utils.GxStringCollection();
         gxdynajaxctrldescr = new GeneXus.Utils.GxStringCollection();
         gxwrpcisep = "" ;
         T000N15_A6USU_COD = new String[] {""} ;
         T000N15_A7USU_DES = new String[] {""} ;
         T000N15_A180USU_INT = new String[] {""} ;
         T000N16_A306THDW_UBI_COD_ = new long[1] ;
         T000N16_A307THDW_UBI_DESC_ = new String[] {""} ;
         T000N17_A300Red_Id = new long[1] ;
         T000N17_A301Red_Descripcion = new String[] {""} ;
         T000N17_A306THDW_UBI_COD_ = new long[1] ;
         T000N18_A306THDW_UBI_COD_ = new long[1] ;
         T000N18_A307THDW_UBI_DESC_ = new String[] {""} ;
         GXt_char3 = "" ;
         isValidOutput = new GxUnknownObjectCollection();
         pr_default = new DataStoreProvider(context, new GeneXus.Programs.thardware_main__default(),
            new Object[][] {
                new Object[] {
               T000N2_A10HARDWARE_ID, T000N2_A194THARDWARE_UBI, T000N2_A311HARDWARE_RED, T000N2_n311HARDWARE_RED, T000N2_A312HARDWARE_IP, T000N2_n312HARDWARE_IP, T000N2_A299TIPO_DIR_IP, T000N2_n299TIPO_DIR_IP, T000N2_A181TIPOS_DE_HARDWARE_ID, T000N2_A58HARDWARE_DESCRIPCION,
               T000N2_A182fecha_alta, T000N2_n182fecha_alta, T000N2_A187NOMBRE_DEL_TIPO_DE_HD, T000N2_A313TH_DIREC, T000N2_A183MODELO_DE_COMPONENTES_ID, T000N2_A188MODELO_DE_COMPONENTES_NOMBRE, T000N2_A189MARCAS_ID, T000N2_A190MARCAS_DESCRIPCION, T000N2_A184HARDWARE_NRO_BIEN, T000N2_A9HARDWARE_NRO_SERIE,
               T000N2_A185ACTIVO, T000N2_n185ACTIVO, T000N2_A186fecha_baja, T000N2_n186fecha_baja, T000N2_A192PRUEBA_MICROFONO_AUDIO, T000N2_A193RESPONSABLE_ARMADO_PC, T000N2_A104HDW_IDT, T000N2_A314HARDWARE_UBA, T000N2_n314HARDWARE_UBA
               }
               , new Object[] {
               T000N3_A10HARDWARE_ID, T000N3_A194THARDWARE_UBI, T000N3_A311HARDWARE_RED, T000N3_n311HARDWARE_RED, T000N3_A312HARDWARE_IP, T000N3_n312HARDWARE_IP, T000N3_A299TIPO_DIR_IP, T000N3_n299TIPO_DIR_IP, T000N3_A181TIPOS_DE_HARDWARE_ID, T000N3_A58HARDWARE_DESCRIPCION,
               T000N3_A182fecha_alta, T000N3_n182fecha_alta, T000N3_A187NOMBRE_DEL_TIPO_DE_HD, T000N3_A313TH_DIREC, T000N3_A183MODELO_DE_COMPONENTES_ID, T000N3_A188MODELO_DE_COMPONENTES_NOMBRE, T000N3_A189MARCAS_ID, T000N3_A190MARCAS_DESCRIPCION, T000N3_A184HARDWARE_NRO_BIEN, T000N3_A9HARDWARE_NRO_SERIE,
               T000N3_A185ACTIVO, T000N3_n185ACTIVO, T000N3_A186fecha_baja, T000N3_n186fecha_baja, T000N3_A192PRUEBA_MICROFONO_AUDIO, T000N3_A193RESPONSABLE_ARMADO_PC, T000N3_A104HDW_IDT, T000N3_A314HARDWARE_UBA, T000N3_n314HARDWARE_UBA
               }
               , new Object[] {
               T000N4_A10HARDWARE_ID, T000N4_A194THARDWARE_UBI, T000N4_A311HARDWARE_RED, T000N4_n311HARDWARE_RED, T000N4_A312HARDWARE_IP, T000N4_n312HARDWARE_IP, T000N4_A299TIPO_DIR_IP, T000N4_n299TIPO_DIR_IP, T000N4_A181TIPOS_DE_HARDWARE_ID, T000N4_A58HARDWARE_DESCRIPCION,
               T000N4_A182fecha_alta, T000N4_n182fecha_alta, T000N4_A187NOMBRE_DEL_TIPO_DE_HD, T000N4_A313TH_DIREC, T000N4_A183MODELO_DE_COMPONENTES_ID, T000N4_A188MODELO_DE_COMPONENTES_NOMBRE, T000N4_A189MARCAS_ID, T000N4_A190MARCAS_DESCRIPCION, T000N4_A184HARDWARE_NRO_BIEN, T000N4_A9HARDWARE_NRO_SERIE,
               T000N4_A185ACTIVO, T000N4_n185ACTIVO, T000N4_A186fecha_baja, T000N4_n186fecha_baja, T000N4_A192PRUEBA_MICROFONO_AUDIO, T000N4_A193RESPONSABLE_ARMADO_PC, T000N4_A104HDW_IDT, T000N4_A314HARDWARE_UBA, T000N4_n314HARDWARE_UBA
               }
               , new Object[] {
               T000N5_A10HARDWARE_ID
               }
               , new Object[] {
               T000N6_A10HARDWARE_ID
               }
               , new Object[] {
               T000N7_A10HARDWARE_ID
               }
               , new Object[] {
               T000N8_A10HARDWARE_ID, T000N8_A194THARDWARE_UBI, T000N8_A311HARDWARE_RED, T000N8_n311HARDWARE_RED, T000N8_A312HARDWARE_IP, T000N8_n312HARDWARE_IP, T000N8_A299TIPO_DIR_IP, T000N8_n299TIPO_DIR_IP, T000N8_A181TIPOS_DE_HARDWARE_ID, T000N8_A58HARDWARE_DESCRIPCION,
               T000N8_A182fecha_alta, T000N8_n182fecha_alta, T000N8_A187NOMBRE_DEL_TIPO_DE_HD, T000N8_A313TH_DIREC, T000N8_A183MODELO_DE_COMPONENTES_ID, T000N8_A188MODELO_DE_COMPONENTES_NOMBRE, T000N8_A189MARCAS_ID, T000N8_A190MARCAS_DESCRIPCION, T000N8_A184HARDWARE_NRO_BIEN, T000N8_A9HARDWARE_NRO_SERIE,
               T000N8_A185ACTIVO, T000N8_n185ACTIVO, T000N8_A186fecha_baja, T000N8_n186fecha_baja, T000N8_A192PRUEBA_MICROFONO_AUDIO, T000N8_A193RESPONSABLE_ARMADO_PC, T000N8_A104HDW_IDT, T000N8_A314HARDWARE_UBA, T000N8_n314HARDWARE_UBA
               }
               , new Object[] {
               }
               , new Object[] {
               T000N10_A10HARDWARE_ID
               }
               , new Object[] {
               }
               , new Object[] {
               }
               , new Object[] {
               T000N13_A11TTBUS_Id
               }
               , new Object[] {
               T000N14_A10HARDWARE_ID
               }
               , new Object[] {
               T000N15_A6USU_COD, T000N15_A7USU_DES, T000N15_A180USU_INT
               }
               , new Object[] {
               T000N16_A306THDW_UBI_COD_, T000N16_A307THDW_UBI_DESC_
               }
               , new Object[] {
               T000N17_A300Red_Id, T000N17_A301Red_Descripcion, T000N17_A306THDW_UBI_COD_
               }
               , new Object[] {
               T000N18_A306THDW_UBI_COD_, T000N18_A307THDW_UBI_DESC_
               }
            }
         );
         Z104HDW_IDT = 0 ;
         Z194THARDWARE_UBI = 1 ;
         A192PRUEBA_MICROFONO_AUDIO = "No" ;
         Z185ACTIVO = "Si" ;
         n185ACTIVO = false ;
      }

      private short wcpOAV12HARDWARE_ID ;
      private short GxWebError ;
      private short A10HARDWARE_ID ;
      private short A299TIPO_DIR_IP ;
      private short A312HARDWARE_IP ;
      private short AV12HARDWARE_ID ;
      private short A313TH_DIREC ;
      private short IsConfirmed ;
      private short IsModified ;
      private short AnyError ;
      private short nKeyPressed ;
      private short initialized ;
      private short A181TIPOS_DE_HARDWARE_ID ;
      private short A183MODELO_DE_COMPONENTES_ID ;
      private short A189MARCAS_ID ;
      private short AV16Red_DireccionDesdeB1 ;
      private short AV17Red_DireccionDesdeB2 ;
      private short AV18Red_DireccionDesdeB3 ;
      private short Z10HARDWARE_ID ;
      private short Z312HARDWARE_IP ;
      private short Z299TIPO_DIR_IP ;
      private short Z181TIPOS_DE_HARDWARE_ID ;
      private short Z313TH_DIREC ;
      private short Z183MODELO_DE_COMPONENTES_ID ;
      private short Z189MARCAS_ID ;
      private short Gx_BScreen ;
      private short AV36error ;
      private short AV37error_2 ;
      private short AV33validado ;
      private short RcdFound23 ;
      private short AV35TIPO_DIR_IP ;
      private short GX_JID ;
      private short gxajaxcallmode ;
      private int A104HDW_IDT ;
      private int trnEnded ;
      private int bttBtn_first_Visible ;
      private int bttBtn_previous_Visible ;
      private int bttBtn_next_Visible ;
      private int bttBtn_last_Visible ;
      private int bttBtn_select_Visible ;
      private int bttBtn_enter_Visible ;
      private int bttBtn_enter_Enabled ;
      private int bttBtn_check_Visible ;
      private int bttBtn_check_Enabled ;
      private int bttBtn_cancel_Visible ;
      private int bttBtn_delete_Visible ;
      private int bttBtn_delete_Enabled ;
      private int edtHARDWARE_ID_Enabled ;
      private int edtHARDWARE_DESCRIPCION_Enabled ;
      private int edtfecha_alta_Enabled ;
      private int edtTIPOS_DE_HARDWARE_ID_Enabled ;
      private int edtNOMBRE_DEL_TIPO_DE_HD_Enabled ;
      private int edtMODELO_DE_COMPONENTES_ID_Enabled ;
      private int edtMODELO_DE_COMPONENTES_NOMBRE_Enabled ;
      private int edtMARCAS_ID_Enabled ;
      private int edtMARCAS_DESCRIPCION_Enabled ;
      private int edtHARDWARE_NRO_BIEN_Enabled ;
      private int edtHARDWARE_NRO_SERIE_Enabled ;
      private int edtfecha_baja_Enabled ;
      private int edtavRed_direcciondesde_Enabled ;
      private int edtavRed_direccionhasta_Enabled ;
      private int edtavRed_mascara_Enabled ;
      private int edtavRed_puertaenlace_Enabled ;
      private int edtavRed_direcciondesdeb1_Enabled ;
      private int edtavRed_direcciondesdeb2_Enabled ;
      private int edtavRed_direcciondesdeb3_Enabled ;
      private int edtHARDWARE_IP_Enabled ;
      private int imgPrompt1_Visible ;
      private int edtHDW_IDT_Enabled ;
      private int imgprompt_104_Visible ;
      private int Z104HDW_IDT ;
      private int AV13HDW_IDT ;
      private int i104HDW_IDT ;
      private int idxLst ;
      private int gxdynajaxindex ;
      private long A194THARDWARE_UBI ;
      private long A311HARDWARE_RED ;
      private long A184HARDWARE_NRO_BIEN ;
      private long A314HARDWARE_UBA ;
      private long Z194THARDWARE_UBI ;
      private long Z311HARDWARE_RED ;
      private long Z184HARDWARE_NRO_BIEN ;
      private long Z314HARDWARE_UBA ;
      private long AV32THARDWARE_UBI ;
      private long AV31HARDWARE_RED ;
      private String sPrefix ;
      private String wcpOGx_mode ;
      private String wcpOAV29SISTEMA ;
      private String wcpOAV30USUARIO ;
      private String scmdbuf ;
      private String gxfirstwebparm ;
      private String gxfirstwebparm_bkp ;
      private String A185ACTIVO ;
      private String Gx_mode ;
      private String AV29SISTEMA ;
      private String AV30USUARIO ;
      private String PreviousTooltip ;
      private String PreviousCaption ;
      private String GX_FocusControl ;
      private String edtHARDWARE_DESCRIPCION_Internalname ;
      private String sStyleString ;
      private String tblTable1_Internalname ;
      private String TempTags ;
      private String ClassString ;
      private String StyleString ;
      private String bttBtn_first_Internalname ;
      private String bttBtn_first_Jsonclick ;
      private String bttBtn_previous_Internalname ;
      private String bttBtn_previous_Jsonclick ;
      private String bttBtn_next_Internalname ;
      private String bttBtn_next_Jsonclick ;
      private String bttBtn_last_Internalname ;
      private String bttBtn_last_Jsonclick ;
      private String bttBtn_select_Internalname ;
      private String bttBtn_select_Jsonclick ;
      private String bttBtn_enter_Internalname ;
      private String bttBtn_enter_Jsonclick ;
      private String bttBtn_check_Internalname ;
      private String bttBtn_check_Jsonclick ;
      private String bttBtn_cancel_Internalname ;
      private String bttBtn_cancel_Jsonclick ;
      private String bttBtn_delete_Internalname ;
      private String bttBtn_delete_Jsonclick ;
      private String tblTable2_Internalname ;
      private String lblTextblock1_Internalname ;
      private String lblTextblock1_Jsonclick ;
      private String edtHARDWARE_ID_Internalname ;
      private String edtHARDWARE_ID_Jsonclick ;
      private String edtHARDWARE_DESCRIPCION_Jsonclick ;
      private String edtfecha_alta_Internalname ;
      private String edtfecha_alta_Jsonclick ;
      private String lblTextblock3_Internalname ;
      private String lblTextblock3_Jsonclick ;
      private String edtTIPOS_DE_HARDWARE_ID_Internalname ;
      private String edtTIPOS_DE_HARDWARE_ID_Jsonclick ;
      private String lblTextblock4_Internalname ;
      private String lblTextblock4_Jsonclick ;
      private String edtNOMBRE_DEL_TIPO_DE_HD_Internalname ;
      private String A187NOMBRE_DEL_TIPO_DE_HD ;
      private String edtNOMBRE_DEL_TIPO_DE_HD_Jsonclick ;
      private String lblTextblock12_Internalname ;
      private String lblTextblock12_Jsonclick ;
      private String cmbTH_DIREC_Internalname ;
      private String cmbTH_DIREC_Jsonclick ;
      private String lblTextblock7_Internalname ;
      private String lblTextblock7_Jsonclick ;
      private String edtMODELO_DE_COMPONENTES_ID_Internalname ;
      private String edtMODELO_DE_COMPONENTES_ID_Jsonclick ;
      private String lblTextblock8_Internalname ;
      private String lblTextblock8_Jsonclick ;
      private String edtMODELO_DE_COMPONENTES_NOMBRE_Internalname ;
      private String A188MODELO_DE_COMPONENTES_NOMBRE ;
      private String edtMODELO_DE_COMPONENTES_NOMBRE_Jsonclick ;
      private String lblTextblock5_Internalname ;
      private String lblTextblock5_Jsonclick ;
      private String edtMARCAS_ID_Internalname ;
      private String edtMARCAS_ID_Jsonclick ;
      private String lblTextblock6_Internalname ;
      private String lblTextblock6_Jsonclick ;
      private String edtMARCAS_DESCRIPCION_Internalname ;
      private String A190MARCAS_DESCRIPCION ;
      private String edtMARCAS_DESCRIPCION_Jsonclick ;
      private String lblTextblock9_Internalname ;
      private String lblTextblock9_Jsonclick ;
      private String edtHARDWARE_NRO_BIEN_Internalname ;
      private String edtHARDWARE_NRO_BIEN_Jsonclick ;
      private String lblTextblock10_Internalname ;
      private String lblTextblock10_Jsonclick ;
      private String edtHARDWARE_NRO_SERIE_Internalname ;
      private String edtHARDWARE_NRO_SERIE_Jsonclick ;
      private String cmbACTIVO_Internalname ;
      private String cmbACTIVO_Jsonclick ;
      private String edtfecha_baja_Internalname ;
      private String edtfecha_baja_Jsonclick ;
      private String lblTextblock2_Internalname ;
      private String lblTextblock2_Jsonclick ;
      private String radPRUEBA_MICROFONO_AUDIO_Internalname ;
      private String A192PRUEBA_MICROFONO_AUDIO ;
      private String radPRUEBA_MICROFONO_AUDIO_Jsonclick ;
      private String lblTextblock11_Internalname ;
      private String lblTextblock11_Jsonclick ;
      private String dynRESPONSABLE_ARMADO_PC_Internalname ;
      private String A193RESPONSABLE_ARMADO_PC ;
      private String dynRESPONSABLE_ARMADO_PC_Jsonclick ;
      private String lblTextblock13_Internalname ;
      private String lblTextblock13_Jsonclick ;
      private String cmbTIPO_DIR_IP_Internalname ;
      private String cmbTIPO_DIR_IP_Jsonclick ;
      private String lblTextblock15_Internalname ;
      private String lblTextblock15_Jsonclick ;
      private String dynTHARDWARE_UBI_Internalname ;
      private String dynTHARDWARE_UBI_Jsonclick ;
      private String lblTextblock16_Internalname ;
      private String lblTextblock16_Jsonclick ;
      private String dynHARDWARE_RED_Internalname ;
      private String dynHARDWARE_RED_Jsonclick ;
      private String lblTextblock17_Internalname ;
      private String lblTextblock17_Jsonclick ;
      private String edtavRed_direcciondesde_Internalname ;
      private String AV15Red_DireccionDesde ;
      private String edtavRed_direcciondesde_Jsonclick ;
      private String lblTextblock18_Internalname ;
      private String lblTextblock18_Jsonclick ;
      private String edtavRed_direccionhasta_Internalname ;
      private String AV19Red_DireccionHasta ;
      private String edtavRed_direccionhasta_Jsonclick ;
      private String lblTextblock19_Internalname ;
      private String lblTextblock19_Jsonclick ;
      private String edtavRed_mascara_Internalname ;
      private String AV20Red_Mascara ;
      private String edtavRed_mascara_Jsonclick ;
      private String lblTextblock20_Internalname ;
      private String lblTextblock20_Jsonclick ;
      private String edtavRed_puertaenlace_Internalname ;
      private String AV21Red_PuertaEnlace ;
      private String edtavRed_puertaenlace_Jsonclick ;
      private String lblTextblock14_Internalname ;
      private String lblTextblock14_Jsonclick ;
      private String edtavRed_direcciondesdeb1_Internalname ;
      private String edtavRed_direcciondesdeb1_Jsonclick ;
      private String edtavRed_direcciondesdeb2_Internalname ;
      private String edtavRed_direcciondesdeb2_Jsonclick ;
      private String edtavRed_direcciondesdeb3_Internalname ;
      private String edtavRed_direcciondesdeb3_Jsonclick ;
      private String edtHARDWARE_IP_Internalname ;
      private String edtHARDWARE_IP_Jsonclick ;
      private String imgPrompt1_Internalname ;
      private String imgPrompt1_Jsonclick ;
      private String lblTextblock21_Internalname ;
      private String lblTextblock21_Jsonclick ;
      private String dynHARDWARE_UBA_Internalname ;
      private String dynHARDWARE_UBA_Jsonclick ;
      private String lblTxt_trazabilidad_Internalname ;
      private String lblTxt_trazabilidad_Jsonclick ;
      private String edtHDW_IDT_Internalname ;
      private String edtHDW_IDT_Jsonclick ;
      private String imgprompt_104_Internalname ;
      private String imgprompt_104_Link ;
      private String Z187NOMBRE_DEL_TIPO_DE_HD ;
      private String Z188MODELO_DE_COMPONENTES_NOMBRE ;
      private String Z190MARCAS_DESCRIPCION ;
      private String Z185ACTIVO ;
      private String Z192PRUEBA_MICROFONO_AUDIO ;
      private String Z193RESPONSABLE_ARMADO_PC ;
      private String AV34mensaje ;
      private String sMode23 ;
      private String sEvt ;
      private String EvtGridId ;
      private String EvtRowId ;
      private String sEvtType ;
      private String AV7ACTIVO ;
      private String sDynURL ;
      private String FormProcess ;
      private String GXt_char2 ;
      private String GXt_char1 ;
      private String i185ACTIVO ;
      private String i192PRUEBA_MICROFONO_AUDIO ;
      private String gxwrpcisep ;
      private String GXt_char3 ;
      private DateTime A186fecha_baja ;
      private DateTime A182fecha_alta ;
      private DateTime Z182fecha_alta ;
      private DateTime Z186fecha_baja ;
      private bool entryPointCalled ;
      private bool n10HARDWARE_ID ;
      private bool n186fecha_baja ;
      private bool n311HARDWARE_RED ;
      private bool n299TIPO_DIR_IP ;
      private bool n185ACTIVO ;
      private bool n312HARDWARE_IP ;
      private bool wbErr ;
      private bool n182fecha_alta ;
      private bool n314HARDWARE_UBA ;
      private bool returnInSub ;
      private bool Gx_longc ;
      private String A58HARDWARE_DESCRIPCION ;
      private String A9HARDWARE_NRO_SERIE ;
      private String Z58HARDWARE_DESCRIPCION ;
      private String Z9HARDWARE_NRO_SERIE ;
      private GxWebSession AV23SESION ;
      private GeneXus.Utils.GxStringCollection gxdynajaxctrlcodr ;
      private GeneXus.Utils.GxStringCollection gxdynajaxctrldescr ;
      private GxUnknownObjectCollection isValidOutput ;
      private GXMasterPage MasterPageObj ;
      private IGxDataStore dsDESARROLLO ;
      private IGxDataStore dssoporte_notebook ;
      private IGxDataStore dsDefault ;
      private short aP0_HARDWARE_ID ;
      private String aP1_Gx_mode ;
      private String aP2_SISTEMA ;
      private String aP3_USUARIO ;
      private GXCombobox cmbTH_DIREC ;
      private GXCombobox cmbACTIVO ;
      private GXRadio radPRUEBA_MICROFONO_AUDIO ;
      private GXCombobox dynRESPONSABLE_ARMADO_PC ;
      private GXCombobox cmbTIPO_DIR_IP ;
      private GXCombobox dynTHARDWARE_UBI ;
      private GXCombobox dynHARDWARE_RED ;
      private GXCombobox dynHARDWARE_UBA ;
      private IDataStoreProvider pr_default ;
      private short[] T000N4_A10HARDWARE_ID ;
      private bool[] T000N4_n10HARDWARE_ID ;
      private long[] T000N4_A194THARDWARE_UBI ;
      private long[] T000N4_A311HARDWARE_RED ;
      private bool[] T000N4_n311HARDWARE_RED ;
      private short[] T000N4_A312HARDWARE_IP ;
      private bool[] T000N4_n312HARDWARE_IP ;
      private short[] T000N4_A299TIPO_DIR_IP ;
      private bool[] T000N4_n299TIPO_DIR_IP ;
      private short[] T000N4_A181TIPOS_DE_HARDWARE_ID ;
      private String[] T000N4_A58HARDWARE_DESCRIPCION ;
      private DateTime[] T000N4_A182fecha_alta ;
      private bool[] T000N4_n182fecha_alta ;
      private String[] T000N4_A187NOMBRE_DEL_TIPO_DE_HD ;
      private short[] T000N4_A313TH_DIREC ;
      private short[] T000N4_A183MODELO_DE_COMPONENTES_ID ;
      private String[] T000N4_A188MODELO_DE_COMPONENTES_NOMBRE ;
      private short[] T000N4_A189MARCAS_ID ;
      private String[] T000N4_A190MARCAS_DESCRIPCION ;
      private long[] T000N4_A184HARDWARE_NRO_BIEN ;
      private String[] T000N4_A9HARDWARE_NRO_SERIE ;
      private String[] T000N4_A185ACTIVO ;
      private bool[] T000N4_n185ACTIVO ;
      private DateTime[] T000N4_A186fecha_baja ;
      private bool[] T000N4_n186fecha_baja ;
      private String[] T000N4_A192PRUEBA_MICROFONO_AUDIO ;
      private String[] T000N4_A193RESPONSABLE_ARMADO_PC ;
      private int[] T000N4_A104HDW_IDT ;
      private long[] T000N4_A314HARDWARE_UBA ;
      private bool[] T000N4_n314HARDWARE_UBA ;
      private short[] T000N5_A10HARDWARE_ID ;
      private bool[] T000N5_n10HARDWARE_ID ;
      private short[] T000N3_A10HARDWARE_ID ;
      private bool[] T000N3_n10HARDWARE_ID ;
      private long[] T000N3_A194THARDWARE_UBI ;
      private long[] T000N3_A311HARDWARE_RED ;
      private bool[] T000N3_n311HARDWARE_RED ;
      private short[] T000N3_A312HARDWARE_IP ;
      private bool[] T000N3_n312HARDWARE_IP ;
      private short[] T000N3_A299TIPO_DIR_IP ;
      private bool[] T000N3_n299TIPO_DIR_IP ;
      private short[] T000N3_A181TIPOS_DE_HARDWARE_ID ;
      private String[] T000N3_A58HARDWARE_DESCRIPCION ;
      private DateTime[] T000N3_A182fecha_alta ;
      private bool[] T000N3_n182fecha_alta ;
      private String[] T000N3_A187NOMBRE_DEL_TIPO_DE_HD ;
      private short[] T000N3_A313TH_DIREC ;
      private short[] T000N3_A183MODELO_DE_COMPONENTES_ID ;
      private String[] T000N3_A188MODELO_DE_COMPONENTES_NOMBRE ;
      private short[] T000N3_A189MARCAS_ID ;
      private String[] T000N3_A190MARCAS_DESCRIPCION ;
      private long[] T000N3_A184HARDWARE_NRO_BIEN ;
      private String[] T000N3_A9HARDWARE_NRO_SERIE ;
      private String[] T000N3_A185ACTIVO ;
      private bool[] T000N3_n185ACTIVO ;
      private DateTime[] T000N3_A186fecha_baja ;
      private bool[] T000N3_n186fecha_baja ;
      private String[] T000N3_A192PRUEBA_MICROFONO_AUDIO ;
      private String[] T000N3_A193RESPONSABLE_ARMADO_PC ;
      private int[] T000N3_A104HDW_IDT ;
      private long[] T000N3_A314HARDWARE_UBA ;
      private bool[] T000N3_n314HARDWARE_UBA ;
      private short[] T000N6_A10HARDWARE_ID ;
      private bool[] T000N6_n10HARDWARE_ID ;
      private short[] T000N7_A10HARDWARE_ID ;
      private bool[] T000N7_n10HARDWARE_ID ;
      private short[] T000N8_A10HARDWARE_ID ;
      private bool[] T000N8_n10HARDWARE_ID ;
      private long[] T000N8_A194THARDWARE_UBI ;
      private long[] T000N8_A311HARDWARE_RED ;
      private bool[] T000N8_n311HARDWARE_RED ;
      private short[] T000N8_A312HARDWARE_IP ;
      private bool[] T000N8_n312HARDWARE_IP ;
      private short[] T000N8_A299TIPO_DIR_IP ;
      private bool[] T000N8_n299TIPO_DIR_IP ;
      private short[] T000N8_A181TIPOS_DE_HARDWARE_ID ;
      private String[] T000N8_A58HARDWARE_DESCRIPCION ;
      private DateTime[] T000N8_A182fecha_alta ;
      private bool[] T000N8_n182fecha_alta ;
      private String[] T000N8_A187NOMBRE_DEL_TIPO_DE_HD ;
      private short[] T000N8_A313TH_DIREC ;
      private short[] T000N8_A183MODELO_DE_COMPONENTES_ID ;
      private String[] T000N8_A188MODELO_DE_COMPONENTES_NOMBRE ;
      private short[] T000N8_A189MARCAS_ID ;
      private String[] T000N8_A190MARCAS_DESCRIPCION ;
      private long[] T000N8_A184HARDWARE_NRO_BIEN ;
      private String[] T000N8_A9HARDWARE_NRO_SERIE ;
      private String[] T000N8_A185ACTIVO ;
      private bool[] T000N8_n185ACTIVO ;
      private DateTime[] T000N8_A186fecha_baja ;
      private bool[] T000N8_n186fecha_baja ;
      private String[] T000N8_A192PRUEBA_MICROFONO_AUDIO ;
      private String[] T000N8_A193RESPONSABLE_ARMADO_PC ;
      private int[] T000N8_A104HDW_IDT ;
      private long[] T000N8_A314HARDWARE_UBA ;
      private bool[] T000N8_n314HARDWARE_UBA ;
      private short[] T000N10_A10HARDWARE_ID ;
      private bool[] T000N10_n10HARDWARE_ID ;
      private int[] T000N13_A11TTBUS_Id ;
      private short[] T000N14_A10HARDWARE_ID ;
      private bool[] T000N14_n10HARDWARE_ID ;
      private String[] T000N15_A6USU_COD ;
      private String[] T000N15_A7USU_DES ;
      private String[] T000N15_A180USU_INT ;
      private long[] T000N16_A306THDW_UBI_COD_ ;
      private String[] T000N16_A307THDW_UBI_DESC_ ;
      private long[] T000N17_A300Red_Id ;
      private String[] T000N17_A301Red_Descripcion ;
      private long[] T000N17_A306THDW_UBI_COD_ ;
      private long[] T000N18_A306THDW_UBI_COD_ ;
      private String[] T000N18_A307THDW_UBI_DESC_ ;
      private short[] T000N2_A10HARDWARE_ID ;
      private long[] T000N2_A194THARDWARE_UBI ;
      private long[] T000N2_A311HARDWARE_RED ;
      private short[] T000N2_A312HARDWARE_IP ;
      private short[] T000N2_A299TIPO_DIR_IP ;
      private short[] T000N2_A181TIPOS_DE_HARDWARE_ID ;
      private String[] T000N2_A58HARDWARE_DESCRIPCION ;
      private DateTime[] T000N2_A182fecha_alta ;
      private String[] T000N2_A187NOMBRE_DEL_TIPO_DE_HD ;
      private short[] T000N2_A313TH_DIREC ;
      private short[] T000N2_A183MODELO_DE_COMPONENTES_ID ;
      private String[] T000N2_A188MODELO_DE_COMPONENTES_NOMBRE ;
      private short[] T000N2_A189MARCAS_ID ;
      private String[] T000N2_A190MARCAS_DESCRIPCION ;
      private long[] T000N2_A184HARDWARE_NRO_BIEN ;
      private String[] T000N2_A9HARDWARE_NRO_SERIE ;
      private String[] T000N2_A185ACTIVO ;
      private DateTime[] T000N2_A186fecha_baja ;
      private String[] T000N2_A192PRUEBA_MICROFONO_AUDIO ;
      private String[] T000N2_A193RESPONSABLE_ARMADO_PC ;
      private int[] T000N2_A104HDW_IDT ;
      private long[] T000N2_A314HARDWARE_UBA ;
      private bool[] T000N2_n311HARDWARE_RED ;
      private bool[] T000N2_n312HARDWARE_IP ;
      private bool[] T000N2_n299TIPO_DIR_IP ;
      private bool[] T000N2_n182fecha_alta ;
      private bool[] T000N2_n185ACTIVO ;
      private bool[] T000N2_n186fecha_baja ;
      private bool[] T000N2_n314HARDWARE_UBA ;
      private GXWebForm Form ;
   }

   public class thardware_main__default : DataStoreHelperBase, IDataStoreHelper
   {
      public ICursor[] getCursors( )
      {
         cursorDefinitions();
         return new Cursor[] {
          new ForEachCursor(def[0])
         ,new ForEachCursor(def[1])
         ,new ForEachCursor(def[2])
         ,new ForEachCursor(def[3])
         ,new ForEachCursor(def[4])
         ,new ForEachCursor(def[5])
         ,new ForEachCursor(def[6])
         ,new UpdateCursor(def[7])
         ,new ForEachCursor(def[8])
         ,new UpdateCursor(def[9])
         ,new UpdateCursor(def[10])
         ,new ForEachCursor(def[11])
         ,new ForEachCursor(def[12])
         ,new ForEachCursor(def[13])
         ,new ForEachCursor(def[14])
         ,new ForEachCursor(def[15])
         ,new ForEachCursor(def[16])
       };
    }

    private static CursorDef[] def;
    private void cursorDefinitions( )
    {
       if ( def == null )
       {
          Object[] prmT000N2 ;
          prmT000N2 = new Object[] {
          new Object[] {"@HARDWARE_ID",SqlDbType.SmallInt,4,0}
          } ;
          Object[] prmT000N4 ;
          prmT000N4 = new Object[] {
          new Object[] {"@HARDWARE_ID",SqlDbType.SmallInt,4,0}
          } ;
          Object[] prmT000N5 ;
          prmT000N5 = new Object[] {
          new Object[] {"@HARDWARE_ID",SqlDbType.SmallInt,4,0}
          } ;
          Object[] prmT000N3 ;
          prmT000N3 = new Object[] {
          new Object[] {"@HARDWARE_ID",SqlDbType.SmallInt,4,0}
          } ;
          Object[] prmT000N6 ;
          prmT000N6 = new Object[] {
          new Object[] {"@HARDWARE_ID",SqlDbType.SmallInt,4,0}
          } ;
          Object[] prmT000N7 ;
          prmT000N7 = new Object[] {
          new Object[] {"@HARDWARE_ID",SqlDbType.SmallInt,4,0}
          } ;
          Object[] prmT000N8 ;
          prmT000N8 = new Object[] {
          new Object[] {"@HARDWARE_ID",SqlDbType.SmallInt,4,0}
          } ;
          Object[] prmT000N9 ;
          prmT000N9 = new Object[] {
          new Object[] {"@THARDWARE_UBI",SqlDbType.Decimal,10,0} ,
          new Object[] {"@HARDWARE_RED",SqlDbType.Decimal,10,0} ,
          new Object[] {"@HARDWARE_IP",SqlDbType.SmallInt,3,0} ,
          new Object[] {"@TIPO_DIR_IP",SqlDbType.SmallInt,2,0} ,
          new Object[] {"@TIPOS_DE_HARDWARE_ID",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@HARDWARE_DESCRIPCION",SqlDbType.VarChar,40,0} ,
          new Object[] {"@fecha_alta",SqlDbType.DateTime,10,8} ,
          new Object[] {"@NOMBRE_DEL_TIPO_DE_HD",SqlDbType.Char,20,0} ,
          new Object[] {"@TH_DIREC",SqlDbType.SmallInt,2,0} ,
          new Object[] {"@MODELO_DE_COMPONENTES_ID",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@MODELO_DE_COMPONENTES_NOMBRE",SqlDbType.Char,20,0} ,
          new Object[] {"@MARCAS_ID",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@MARCAS_DESCRIPCION",SqlDbType.Char,20,0} ,
          new Object[] {"@HARDWARE_NRO_BIEN",SqlDbType.Decimal,10,0} ,
          new Object[] {"@HARDWARE_NRO_SERIE",SqlDbType.VarChar,20,0} ,
          new Object[] {"@ACTIVO",SqlDbType.Char,2,0} ,
          new Object[] {"@fecha_baja",SqlDbType.DateTime,10,8} ,
          new Object[] {"@PRUEBA_MICROFONO_AUDIO",SqlDbType.Char,2,0} ,
          new Object[] {"@RESPONSABLE_ARMADO_PC",SqlDbType.Char,15,0} ,
          new Object[] {"@HDW_IDT",SqlDbType.Int,8,0} ,
          new Object[] {"@HARDWARE_UBA",SqlDbType.Decimal,10,0}
          } ;
          Object[] prmT000N10 ;
          prmT000N10 = new Object[] {
          } ;
          Object[] prmT000N11 ;
          prmT000N11 = new Object[] {
          new Object[] {"@THARDWARE_UBI",SqlDbType.Decimal,10,0} ,
          new Object[] {"@HARDWARE_RED",SqlDbType.Decimal,10,0} ,
          new Object[] {"@HARDWARE_IP",SqlDbType.SmallInt,3,0} ,
          new Object[] {"@TIPO_DIR_IP",SqlDbType.SmallInt,2,0} ,
          new Object[] {"@TIPOS_DE_HARDWARE_ID",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@HARDWARE_DESCRIPCION",SqlDbType.VarChar,40,0} ,
          new Object[] {"@fecha_alta",SqlDbType.DateTime,10,8} ,
          new Object[] {"@NOMBRE_DEL_TIPO_DE_HD",SqlDbType.Char,20,0} ,
          new Object[] {"@TH_DIREC",SqlDbType.SmallInt,2,0} ,
          new Object[] {"@MODELO_DE_COMPONENTES_ID",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@MODELO_DE_COMPONENTES_NOMBRE",SqlDbType.Char,20,0} ,
          new Object[] {"@MARCAS_ID",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@MARCAS_DESCRIPCION",SqlDbType.Char,20,0} ,
          new Object[] {"@HARDWARE_NRO_BIEN",SqlDbType.Decimal,10,0} ,
          new Object[] {"@HARDWARE_NRO_SERIE",SqlDbType.VarChar,20,0} ,
          new Object[] {"@ACTIVO",SqlDbType.Char,2,0} ,
          new Object[] {"@fecha_baja",SqlDbType.DateTime,10,8} ,
          new Object[] {"@PRUEBA_MICROFONO_AUDIO",SqlDbType.Char,2,0} ,
          new Object[] {"@RESPONSABLE_ARMADO_PC",SqlDbType.Char,15,0} ,
          new Object[] {"@HDW_IDT",SqlDbType.Int,8,0} ,
          new Object[] {"@HARDWARE_UBA",SqlDbType.Decimal,10,0} ,
          new Object[] {"@HARDWARE_ID",SqlDbType.SmallInt,4,0}
          } ;
          Object[] prmT000N12 ;
          prmT000N12 = new Object[] {
          new Object[] {"@HARDWARE_ID",SqlDbType.SmallInt,4,0}
          } ;
          Object[] prmT000N13 ;
          prmT000N13 = new Object[] {
          new Object[] {"@HARDWARE_ID",SqlDbType.SmallInt,4,0}
          } ;
          Object[] prmT000N14 ;
          prmT000N14 = new Object[] {
          } ;
          Object[] prmT000N15 ;
          prmT000N15 = new Object[] {
          } ;
          Object[] prmT000N16 ;
          prmT000N16 = new Object[] {
          } ;
          Object[] prmT000N17 ;
          prmT000N17 = new Object[] {
          new Object[] {"@THARDWARE_UBI",SqlDbType.Decimal,10,0}
          } ;
          Object[] prmT000N18 ;
          prmT000N18 = new Object[] {
          } ;
          def= new CursorDef[] {
              new CursorDef("T000N2", "SELECT [HARDWARE_ID], [THARDWARE_UBI], [HARDWARE_RED], [HARDWARE_IP], [TIPO_DIR_IP], [TIPOS_DE_HARDWARE_ID], [HARDWARE_DESCRIPCION], [fecha_alta], [NOMBRE_DEL_TIPO_DE_HD], [TH_DIREC], [MODELO_DE_COMPONENTES_ID], [MODELO_DE_COMPONENTES_NOMBRE], [MARCAS_ID], [MARCAS_DESCRIPCION], [HARDWARE_NRO_BIEN], [HARDWARE_NRO_SERIE], [ACTIVO], [fecha_baja], [PRUEBA_MICROFONO_AUDIO], [RESPONSABLE_ARMADO_PC], [HDW_IDT], [HARDWARE_UBA] FROM [HARDWARE] WITH (UPDLOCK) WHERE [HARDWARE_ID] = @HARDWARE_ID ",true, GxErrorMask.GX_NOMASK, false, this,prmT000N2,1,0,true,false )
             ,new CursorDef("T000N3", "SELECT [HARDWARE_ID], [THARDWARE_UBI], [HARDWARE_RED], [HARDWARE_IP], [TIPO_DIR_IP], [TIPOS_DE_HARDWARE_ID], [HARDWARE_DESCRIPCION], [fecha_alta], [NOMBRE_DEL_TIPO_DE_HD], [TH_DIREC], [MODELO_DE_COMPONENTES_ID], [MODELO_DE_COMPONENTES_NOMBRE], [MARCAS_ID], [MARCAS_DESCRIPCION], [HARDWARE_NRO_BIEN], [HARDWARE_NRO_SERIE], [ACTIVO], [fecha_baja], [PRUEBA_MICROFONO_AUDIO], [RESPONSABLE_ARMADO_PC], [HDW_IDT], [HARDWARE_UBA] FROM [HARDWARE] WITH (NOLOCK) WHERE [HARDWARE_ID] = @HARDWARE_ID ",true, GxErrorMask.GX_NOMASK, false, this,prmT000N3,1,0,true,false )
             ,new CursorDef("T000N4", "SELECT TM1.[HARDWARE_ID], TM1.[THARDWARE_UBI], TM1.[HARDWARE_RED], TM1.[HARDWARE_IP], TM1.[TIPO_DIR_IP], TM1.[TIPOS_DE_HARDWARE_ID], TM1.[HARDWARE_DESCRIPCION], TM1.[fecha_alta], TM1.[NOMBRE_DEL_TIPO_DE_HD], TM1.[TH_DIREC], TM1.[MODELO_DE_COMPONENTES_ID], TM1.[MODELO_DE_COMPONENTES_NOMBRE], TM1.[MARCAS_ID], TM1.[MARCAS_DESCRIPCION], TM1.[HARDWARE_NRO_BIEN], TM1.[HARDWARE_NRO_SERIE], TM1.[ACTIVO], TM1.[fecha_baja], TM1.[PRUEBA_MICROFONO_AUDIO], TM1.[RESPONSABLE_ARMADO_PC], TM1.[HDW_IDT], TM1.[HARDWARE_UBA] FROM [HARDWARE] TM1 WITH (NOLOCK) WHERE TM1.[HARDWARE_ID] = @HARDWARE_ID ORDER BY TM1.[HARDWARE_ID]  OPTION (FAST 100)",true, GxErrorMask.GX_NOMASK, false, this,prmT000N4,100,0,true,false )
             ,new CursorDef("T000N5", "SELECT [HARDWARE_ID] FROM [HARDWARE] WITH (NOLOCK) WHERE [HARDWARE_ID] = @HARDWARE_ID  OPTION (FAST 1)",true, GxErrorMask.GX_NOMASK, false, this,prmT000N5,1,0,true,false )
             ,new CursorDef("T000N6", "SELECT TOP 1 [HARDWARE_ID] FROM [HARDWARE] WITH (NOLOCK) WHERE ( [HARDWARE_ID] > @HARDWARE_ID) ORDER BY [HARDWARE_ID]  OPTION (FAST 1)",true, GxErrorMask.GX_NOMASK, false, this,prmT000N6,1,0,true,true )
             ,new CursorDef("T000N7", "SELECT TOP 1 [HARDWARE_ID] FROM [HARDWARE] WITH (NOLOCK) WHERE ( [HARDWARE_ID] < @HARDWARE_ID) ORDER BY [HARDWARE_ID] DESC  OPTION (FAST 1)",true, GxErrorMask.GX_NOMASK, false, this,prmT000N7,1,0,true,true )
             ,new CursorDef("T000N8", "SELECT [HARDWARE_ID], [THARDWARE_UBI], [HARDWARE_RED], [HARDWARE_IP], [TIPO_DIR_IP], [TIPOS_DE_HARDWARE_ID], [HARDWARE_DESCRIPCION], [fecha_alta], [NOMBRE_DEL_TIPO_DE_HD], [TH_DIREC], [MODELO_DE_COMPONENTES_ID], [MODELO_DE_COMPONENTES_NOMBRE], [MARCAS_ID], [MARCAS_DESCRIPCION], [HARDWARE_NRO_BIEN], [HARDWARE_NRO_SERIE], [ACTIVO], [fecha_baja], [PRUEBA_MICROFONO_AUDIO], [RESPONSABLE_ARMADO_PC], [HDW_IDT], [HARDWARE_UBA] FROM [HARDWARE] WITH (UPDLOCK) WHERE [HARDWARE_ID] = @HARDWARE_ID ",true, GxErrorMask.GX_NOMASK, false, this,prmT000N8,1,0,true,false )
             ,new CursorDef("T000N9", "INSERT INTO [HARDWARE] ([THARDWARE_UBI], [HARDWARE_RED], [HARDWARE_IP], [TIPO_DIR_IP], [TIPOS_DE_HARDWARE_ID], [HARDWARE_DESCRIPCION], [fecha_alta], [NOMBRE_DEL_TIPO_DE_HD], [TH_DIREC], [MODELO_DE_COMPONENTES_ID], [MODELO_DE_COMPONENTES_NOMBRE], [MARCAS_ID], [MARCAS_DESCRIPCION], [HARDWARE_NRO_BIEN], [HARDWARE_NRO_SERIE], [ACTIVO], [fecha_baja], [PRUEBA_MICROFONO_AUDIO], [RESPONSABLE_ARMADO_PC], [HDW_IDT], [HARDWARE_UBA]) VALUES (@THARDWARE_UBI, @HARDWARE_RED, @HARDWARE_IP, @TIPO_DIR_IP, @TIPOS_DE_HARDWARE_ID, @HARDWARE_DESCRIPCION, @fecha_alta, @NOMBRE_DEL_TIPO_DE_HD, @TH_DIREC, @MODELO_DE_COMPONENTES_ID, @MODELO_DE_COMPONENTES_NOMBRE, @MARCAS_ID, @MARCAS_DESCRIPCION, @HARDWARE_NRO_BIEN, @HARDWARE_NRO_SERIE, @ACTIVO, @fecha_baja, @PRUEBA_MICROFONO_AUDIO, @RESPONSABLE_ARMADO_PC, @HDW_IDT, @HARDWARE_UBA)", GxErrorMask.GX_NOMASK,prmT000N9)
             ,new CursorDef("T000N10", "SELECT Ident_Current('[HARDWARE]') ",true, GxErrorMask.GX_NOMASK, false, this,prmT000N10,1,0,true,false )
             ,new CursorDef("T000N11", "UPDATE [HARDWARE] SET [THARDWARE_UBI]=@THARDWARE_UBI, [HARDWARE_RED]=@HARDWARE_RED, [HARDWARE_IP]=@HARDWARE_IP, [TIPO_DIR_IP]=@TIPO_DIR_IP, [TIPOS_DE_HARDWARE_ID]=@TIPOS_DE_HARDWARE_ID, [HARDWARE_DESCRIPCION]=@HARDWARE_DESCRIPCION, [fecha_alta]=@fecha_alta, [NOMBRE_DEL_TIPO_DE_HD]=@NOMBRE_DEL_TIPO_DE_HD, [TH_DIREC]=@TH_DIREC, [MODELO_DE_COMPONENTES_ID]=@MODELO_DE_COMPONENTES_ID, [MODELO_DE_COMPONENTES_NOMBRE]=@MODELO_DE_COMPONENTES_NOMBRE, [MARCAS_ID]=@MARCAS_ID, [MARCAS_DESCRIPCION]=@MARCAS_DESCRIPCION, [HARDWARE_NRO_BIEN]=@HARDWARE_NRO_BIEN, [HARDWARE_NRO_SERIE]=@HARDWARE_NRO_SERIE, [ACTIVO]=@ACTIVO, [fecha_baja]=@fecha_baja, [PRUEBA_MICROFONO_AUDIO]=@PRUEBA_MICROFONO_AUDIO, [RESPONSABLE_ARMADO_PC]=@RESPONSABLE_ARMADO_PC, [HDW_IDT]=@HDW_IDT, [HARDWARE_UBA]=@HARDWARE_UBA  WHERE [HARDWARE_ID] = @HARDWARE_ID", GxErrorMask.GX_NOMASK,prmT000N11)
             ,new CursorDef("T000N12", "DELETE FROM [HARDWARE]  WHERE [HARDWARE_ID] = @HARDWARE_ID", GxErrorMask.GX_NOMASK,prmT000N12)
             ,new CursorDef("T000N13", "SELECT TOP 1 [TTBUS_Id] FROM [TTBUS000] WITH (NOLOCK) WHERE [HARDWARE_ID] = @HARDWARE_ID ",true, GxErrorMask.GX_NOMASK, false, this,prmT000N13,1,0,true,true )
             ,new CursorDef("T000N14", "SELECT [HARDWARE_ID] FROM [HARDWARE] WITH (NOLOCK) ORDER BY [HARDWARE_ID]  OPTION (FAST 100)",true, GxErrorMask.GX_NOMASK, false, this,prmT000N14,100,0,true,false )
             ,new CursorDef("T000N15", "SELECT [USU_COD], [USU_DES], [USU_INT] FROM [SEG002] WITH (NOLOCK) WHERE [USU_INT] = 'SISTEMAS' ",true, GxErrorMask.GX_NOMASK, false, this,prmT000N15,0,0,true,false )
             ,new CursorDef("T000N16", "SELECT [THDW_UBI_COD_], [THDW_UBI_DESC_] FROM [THDW_UBICACIONES_] WITH (NOLOCK) ORDER BY [THDW_UBI_DESC_] ",true, GxErrorMask.GX_NOMASK, false, this,prmT000N16,0,0,true,false )
             ,new CursorDef("T000N17", "SELECT [Red_Id], [Red_Descripcion], [THDW_UBI_COD_] FROM [THDW_REDES] WITH (NOLOCK) WHERE [THDW_UBI_COD_] = @THARDWARE_UBI ORDER BY [Red_Descripcion] ",true, GxErrorMask.GX_NOMASK, false, this,prmT000N17,0,0,true,false )
             ,new CursorDef("T000N18", "SELECT [THDW_UBI_COD_], [THDW_UBI_DESC_] FROM [THDW_UBICACIONES_] WITH (NOLOCK) ORDER BY [THDW_UBI_DESC_] ",true, GxErrorMask.GX_NOMASK, false, this,prmT000N18,0,0,true,false )
          };
       }
    }

    public void getResults( int cursor ,
                            IFieldGetter rslt ,
                            Object[] buf )
    {
       switch ( cursor )
       {
             case 0 :
                ((short[]) buf[0])[0] = rslt.getShort(1) ;
                ((long[]) buf[1])[0] = rslt.getLong(2) ;
                ((long[]) buf[2])[0] = rslt.getLong(3) ;
                ((bool[]) buf[3])[0] = rslt.wasNull(3);
                ((short[]) buf[4])[0] = rslt.getShort(4) ;
                ((bool[]) buf[5])[0] = rslt.wasNull(4);
                ((short[]) buf[6])[0] = rslt.getShort(5) ;
                ((bool[]) buf[7])[0] = rslt.wasNull(5);
                ((short[]) buf[8])[0] = rslt.getShort(6) ;
                ((String[]) buf[9])[0] = rslt.getVarchar(7) ;
                ((DateTime[]) buf[10])[0] = rslt.getGXDateTime(8) ;
                ((bool[]) buf[11])[0] = rslt.wasNull(8);
                ((String[]) buf[12])[0] = rslt.getString(9, 20) ;
                ((short[]) buf[13])[0] = rslt.getShort(10) ;
                ((short[]) buf[14])[0] = rslt.getShort(11) ;
                ((String[]) buf[15])[0] = rslt.getString(12, 20) ;
                ((short[]) buf[16])[0] = rslt.getShort(13) ;
                ((String[]) buf[17])[0] = rslt.getString(14, 20) ;
                ((long[]) buf[18])[0] = rslt.getLong(15) ;
                ((String[]) buf[19])[0] = rslt.getVarchar(16) ;
                ((String[]) buf[20])[0] = rslt.getString(17, 2) ;
                ((bool[]) buf[21])[0] = rslt.wasNull(17);
                ((DateTime[]) buf[22])[0] = rslt.getGXDateTime(18) ;
                ((bool[]) buf[23])[0] = rslt.wasNull(18);
                ((String[]) buf[24])[0] = rslt.getString(19, 2) ;
                ((String[]) buf[25])[0] = rslt.getString(20, 15) ;
                ((int[]) buf[26])[0] = rslt.getInt(21) ;
                ((long[]) buf[27])[0] = rslt.getLong(22) ;
                ((bool[]) buf[28])[0] = rslt.wasNull(22);
                break;
             case 1 :
                ((short[]) buf[0])[0] = rslt.getShort(1) ;
                ((long[]) buf[1])[0] = rslt.getLong(2) ;
                ((long[]) buf[2])[0] = rslt.getLong(3) ;
                ((bool[]) buf[3])[0] = rslt.wasNull(3);
                ((short[]) buf[4])[0] = rslt.getShort(4) ;
                ((bool[]) buf[5])[0] = rslt.wasNull(4);
                ((short[]) buf[6])[0] = rslt.getShort(5) ;
                ((bool[]) buf[7])[0] = rslt.wasNull(5);
                ((short[]) buf[8])[0] = rslt.getShort(6) ;
                ((String[]) buf[9])[0] = rslt.getVarchar(7) ;
                ((DateTime[]) buf[10])[0] = rslt.getGXDateTime(8) ;
                ((bool[]) buf[11])[0] = rslt.wasNull(8);
                ((String[]) buf[12])[0] = rslt.getString(9, 20) ;
                ((short[]) buf[13])[0] = rslt.getShort(10) ;
                ((short[]) buf[14])[0] = rslt.getShort(11) ;
                ((String[]) buf[15])[0] = rslt.getString(12, 20) ;
                ((short[]) buf[16])[0] = rslt.getShort(13) ;
                ((String[]) buf[17])[0] = rslt.getString(14, 20) ;
                ((long[]) buf[18])[0] = rslt.getLong(15) ;
                ((String[]) buf[19])[0] = rslt.getVarchar(16) ;
                ((String[]) buf[20])[0] = rslt.getString(17, 2) ;
                ((bool[]) buf[21])[0] = rslt.wasNull(17);
                ((DateTime[]) buf[22])[0] = rslt.getGXDateTime(18) ;
                ((bool[]) buf[23])[0] = rslt.wasNull(18);
                ((String[]) buf[24])[0] = rslt.getString(19, 2) ;
                ((String[]) buf[25])[0] = rslt.getString(20, 15) ;
                ((int[]) buf[26])[0] = rslt.getInt(21) ;
                ((long[]) buf[27])[0] = rslt.getLong(22) ;
                ((bool[]) buf[28])[0] = rslt.wasNull(22);
                break;
             case 2 :
                ((short[]) buf[0])[0] = rslt.getShort(1) ;
                ((long[]) buf[1])[0] = rslt.getLong(2) ;
                ((long[]) buf[2])[0] = rslt.getLong(3) ;
                ((bool[]) buf[3])[0] = rslt.wasNull(3);
                ((short[]) buf[4])[0] = rslt.getShort(4) ;
                ((bool[]) buf[5])[0] = rslt.wasNull(4);
                ((short[]) buf[6])[0] = rslt.getShort(5) ;
                ((bool[]) buf[7])[0] = rslt.wasNull(5);
                ((short[]) buf[8])[0] = rslt.getShort(6) ;
                ((String[]) buf[9])[0] = rslt.getVarchar(7) ;
                ((DateTime[]) buf[10])[0] = rslt.getGXDateTime(8) ;
                ((bool[]) buf[11])[0] = rslt.wasNull(8);
                ((String[]) buf[12])[0] = rslt.getString(9, 20) ;
                ((short[]) buf[13])[0] = rslt.getShort(10) ;
                ((short[]) buf[14])[0] = rslt.getShort(11) ;
                ((String[]) buf[15])[0] = rslt.getString(12, 20) ;
                ((short[]) buf[16])[0] = rslt.getShort(13) ;
                ((String[]) buf[17])[0] = rslt.getString(14, 20) ;
                ((long[]) buf[18])[0] = rslt.getLong(15) ;
                ((String[]) buf[19])[0] = rslt.getVarchar(16) ;
                ((String[]) buf[20])[0] = rslt.getString(17, 2) ;
                ((bool[]) buf[21])[0] = rslt.wasNull(17);
                ((DateTime[]) buf[22])[0] = rslt.getGXDateTime(18) ;
                ((bool[]) buf[23])[0] = rslt.wasNull(18);
                ((String[]) buf[24])[0] = rslt.getString(19, 2) ;
                ((String[]) buf[25])[0] = rslt.getString(20, 15) ;
                ((int[]) buf[26])[0] = rslt.getInt(21) ;
                ((long[]) buf[27])[0] = rslt.getLong(22) ;
                ((bool[]) buf[28])[0] = rslt.wasNull(22);
                break;
             case 3 :
                ((short[]) buf[0])[0] = rslt.getShort(1) ;
                break;
             case 4 :
                ((short[]) buf[0])[0] = rslt.getShort(1) ;
                break;
             case 5 :
                ((short[]) buf[0])[0] = rslt.getShort(1) ;
                break;
             case 6 :
                ((short[]) buf[0])[0] = rslt.getShort(1) ;
                ((long[]) buf[1])[0] = rslt.getLong(2) ;
                ((long[]) buf[2])[0] = rslt.getLong(3) ;
                ((bool[]) buf[3])[0] = rslt.wasNull(3);
                ((short[]) buf[4])[0] = rslt.getShort(4) ;
                ((bool[]) buf[5])[0] = rslt.wasNull(4);
                ((short[]) buf[6])[0] = rslt.getShort(5) ;
                ((bool[]) buf[7])[0] = rslt.wasNull(5);
                ((short[]) buf[8])[0] = rslt.getShort(6) ;
                ((String[]) buf[9])[0] = rslt.getVarchar(7) ;
                ((DateTime[]) buf[10])[0] = rslt.getGXDateTime(8) ;
                ((bool[]) buf[11])[0] = rslt.wasNull(8);
                ((String[]) buf[12])[0] = rslt.getString(9, 20) ;
                ((short[]) buf[13])[0] = rslt.getShort(10) ;
                ((short[]) buf[14])[0] = rslt.getShort(11) ;
                ((String[]) buf[15])[0] = rslt.getString(12, 20) ;
                ((short[]) buf[16])[0] = rslt.getShort(13) ;
                ((String[]) buf[17])[0] = rslt.getString(14, 20) ;
                ((long[]) buf[18])[0] = rslt.getLong(15) ;
                ((String[]) buf[19])[0] = rslt.getVarchar(16) ;
                ((String[]) buf[20])[0] = rslt.getString(17, 2) ;
                ((bool[]) buf[21])[0] = rslt.wasNull(17);
                ((DateTime[]) buf[22])[0] = rslt.getGXDateTime(18) ;
                ((bool[]) buf[23])[0] = rslt.wasNull(18);
                ((String[]) buf[24])[0] = rslt.getString(19, 2) ;
                ((String[]) buf[25])[0] = rslt.getString(20, 15) ;
                ((int[]) buf[26])[0] = rslt.getInt(21) ;
                ((long[]) buf[27])[0] = rslt.getLong(22) ;
                ((bool[]) buf[28])[0] = rslt.wasNull(22);
                break;
             case 8 :
                ((short[]) buf[0])[0] = rslt.getShort(1) ;
                break;
             case 11 :
                ((int[]) buf[0])[0] = rslt.getInt(1) ;
                break;
             case 12 :
                ((short[]) buf[0])[0] = rslt.getShort(1) ;
                break;
             case 13 :
                ((String[]) buf[0])[0] = rslt.getString(1, 16) ;
                ((String[]) buf[1])[0] = rslt.getString(2, 50) ;
                ((String[]) buf[2])[0] = rslt.getString(3, 10) ;
                break;
             case 14 :
                ((long[]) buf[0])[0] = rslt.getLong(1) ;
                ((String[]) buf[1])[0] = rslt.getString(2, 30) ;
                break;
             case 15 :
                ((long[]) buf[0])[0] = rslt.getLong(1) ;
                ((String[]) buf[1])[0] = rslt.getString(2, 30) ;
                ((long[]) buf[2])[0] = rslt.getLong(3) ;
                break;
             case 16 :
                ((long[]) buf[0])[0] = rslt.getLong(1) ;
                ((String[]) buf[1])[0] = rslt.getString(2, 30) ;
                break;
       }
    }

    public void setParameters( int cursor ,
                               IFieldSetter stmt ,
                               Object[] parms )
    {
       switch ( cursor )
       {
             case 0 :
                if ( (bool)parms[0] )
                {
                   stmt.setNull( 1 , SqlDbType.SmallInt );
                }
                else
                {
                   stmt.SetParameter(1, (short)parms[1]);
                }
                break;
             case 1 :
                if ( (bool)parms[0] )
                {
                   stmt.setNull( 1 , SqlDbType.SmallInt );
                }
                else
                {
                   stmt.SetParameter(1, (short)parms[1]);
                }
                break;
             case 2 :
                if ( (bool)parms[0] )
                {
                   stmt.setNull( 1 , SqlDbType.SmallInt );
                }
                else
                {
                   stmt.SetParameter(1, (short)parms[1]);
                }
                break;
             case 3 :
                if ( (bool)parms[0] )
                {
                   stmt.setNull( 1 , SqlDbType.SmallInt );
                }
                else
                {
                   stmt.SetParameter(1, (short)parms[1]);
                }
                break;
             case 4 :
                if ( (bool)parms[0] )
                {
                   stmt.setNull( 1 , SqlDbType.SmallInt );
                }
                else
                {
                   stmt.SetParameter(1, (short)parms[1]);
                }
                break;
             case 5 :
                if ( (bool)parms[0] )
                {
                   stmt.setNull( 1 , SqlDbType.SmallInt );
                }
                else
                {
                   stmt.SetParameter(1, (short)parms[1]);
                }
                break;
             case 6 :
                if ( (bool)parms[0] )
                {
                   stmt.setNull( 1 , SqlDbType.SmallInt );
                }
                else
                {
                   stmt.SetParameter(1, (short)parms[1]);
                }
                break;
             case 7 :
                stmt.SetParameter(1, (long)parms[0]);
                if ( (bool)parms[1] )
                {
                   stmt.setNull( 2 , SqlDbType.Decimal );
                }
                else
                {
                   stmt.SetParameter(2, (long)parms[2]);
                }
                if ( (bool)parms[3] )
                {
                   stmt.setNull( 3 , SqlDbType.SmallInt );
                }
                else
                {
                   stmt.SetParameter(3, (short)parms[4]);
                }
                if ( (bool)parms[5] )
                {
                   stmt.setNull( 4 , SqlDbType.SmallInt );
                }
                else
                {
                   stmt.SetParameter(4, (short)parms[6]);
                }
                stmt.SetParameter(5, (short)parms[7]);
                stmt.SetParameter(6, (String)parms[8]);
                if ( (bool)parms[9] )
                {
                   stmt.setNull( 7 , SqlDbType.DateTime );
                }
                else
                {
                   stmt.SetParameter(7, (DateTime)parms[10]);
                }
                stmt.SetParameter(8, (String)parms[11]);
                stmt.SetParameter(9, (short)parms[12]);
                stmt.SetParameter(10, (short)parms[13]);
                stmt.SetParameter(11, (String)parms[14]);
                stmt.SetParameter(12, (short)parms[15]);
                stmt.SetParameter(13, (String)parms[16]);
                stmt.SetParameter(14, (long)parms[17]);
                stmt.SetParameter(15, (String)parms[18]);
                if ( (bool)parms[19] )
                {
                   stmt.setNull( 16 , SqlDbType.Char );
                }
                else
                {
                   stmt.SetParameter(16, (String)parms[20]);
                }
                if ( (bool)parms[21] )
                {
                   stmt.setNull( 17 , SqlDbType.DateTime );
                }
                else
                {
                   stmt.SetParameter(17, (DateTime)parms[22]);
                }
                stmt.SetParameter(18, (String)parms[23]);
                stmt.SetParameter(19, (String)parms[24]);
                stmt.SetParameter(20, (int)parms[25]);
                if ( (bool)parms[26] )
                {
                   stmt.setNull( 21 , SqlDbType.Decimal );
                }
                else
                {
                   stmt.SetParameter(21, (long)parms[27]);
                }
                break;
             case 9 :
                stmt.SetParameter(1, (long)parms[0]);
                if ( (bool)parms[1] )
                {
                   stmt.setNull( 2 , SqlDbType.Decimal );
                }
                else
                {
                   stmt.SetParameter(2, (long)parms[2]);
                }
                if ( (bool)parms[3] )
                {
                   stmt.setNull( 3 , SqlDbType.SmallInt );
                }
                else
                {
                   stmt.SetParameter(3, (short)parms[4]);
                }
                if ( (bool)parms[5] )
                {
                   stmt.setNull( 4 , SqlDbType.SmallInt );
                }
                else
                {
                   stmt.SetParameter(4, (short)parms[6]);
                }
                stmt.SetParameter(5, (short)parms[7]);
                stmt.SetParameter(6, (String)parms[8]);
                if ( (bool)parms[9] )
                {
                   stmt.setNull( 7 , SqlDbType.DateTime );
                }
                else
                {
                   stmt.SetParameter(7, (DateTime)parms[10]);
                }
                stmt.SetParameter(8, (String)parms[11]);
                stmt.SetParameter(9, (short)parms[12]);
                stmt.SetParameter(10, (short)parms[13]);
                stmt.SetParameter(11, (String)parms[14]);
                stmt.SetParameter(12, (short)parms[15]);
                stmt.SetParameter(13, (String)parms[16]);
                stmt.SetParameter(14, (long)parms[17]);
                stmt.SetParameter(15, (String)parms[18]);
                if ( (bool)parms[19] )
                {
                   stmt.setNull( 16 , SqlDbType.Char );
                }
                else
                {
                   stmt.SetParameter(16, (String)parms[20]);
                }
                if ( (bool)parms[21] )
                {
                   stmt.setNull( 17 , SqlDbType.DateTime );
                }
                else
                {
                   stmt.SetParameter(17, (DateTime)parms[22]);
                }
                stmt.SetParameter(18, (String)parms[23]);
                stmt.SetParameter(19, (String)parms[24]);
                stmt.SetParameter(20, (int)parms[25]);
                if ( (bool)parms[26] )
                {
                   stmt.setNull( 21 , SqlDbType.Decimal );
                }
                else
                {
                   stmt.SetParameter(21, (long)parms[27]);
                }
                if ( (bool)parms[28] )
                {
                   stmt.setNull( 22 , SqlDbType.SmallInt );
                }
                else
                {
                   stmt.SetParameter(22, (short)parms[29]);
                }
                break;
             case 10 :
                if ( (bool)parms[0] )
                {
                   stmt.setNull( 1 , SqlDbType.SmallInt );
                }
                else
                {
                   stmt.SetParameter(1, (short)parms[1]);
                }
                break;
             case 11 :
                if ( (bool)parms[0] )
                {
                   stmt.setNull( 1 , SqlDbType.SmallInt );
                }
                else
                {
                   stmt.SetParameter(1, (short)parms[1]);
                }
                break;
             case 15 :
                stmt.SetParameter(1, (long)parms[0]);
                break;
       }
    }

 }

}
