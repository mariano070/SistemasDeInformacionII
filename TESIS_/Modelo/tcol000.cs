/*
               File: TCOL000
        Description: COLA DE PROCESOS BATCH
             Author: GeneXus C# Generator version 10_1_5-42940
       Generated on: 1/6/2014 11:19:26.58
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
   public class tcol000 : GXDataArea, System.Web.SessionState.IRequiresSessionState
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
            A79PRC_NRO = (long)(NumberUtil.Val( gxfirstwebparm, ".")) ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A79PRC_NRO", StringUtil.LTrim( StringUtil.Str( (decimal)(A79PRC_NRO), 10, 0)));
         }
         Form.Meta.addItem("Generator", "GeneXus C#", 0) ;
         Form.Meta.addItem("Version", "10_1_5-42940", 0) ;
         Form.Meta.addItem("Description", "COLA DE PROCESOS BATCH", 0) ;
         context.wjLoc = "" ;
         context.nUserReturn = 0 ;
         context.wbHandled = 0 ;
         if ( StringUtil.StrCmp(context.GetRequestMethod( ), "POST") == 0 )
         {
         }
         GX_FocusControl = edtPRC_INI_Internalname ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
         wbErr = false ;
         context.SetTheme("Modern");
      }

      public tcol000( )
      {
         context = new GxContext(  );
         DataStoreUtil.LoadDataStores( context);
         dsDESARROLLO = context.GetDataStore("DESARROLLO") ;
         dssoporte_notebook = context.GetDataStore("soporte_notebook") ;
         dsDefault = context.GetDataStore("Default") ;
         IsMain = true;
         context.SetTheme("Modern");
      }

      public tcol000( IGxContext context )
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

      public void execute( ref long aP0_PRC_NRO )
      {
         this.A79PRC_NRO = aP0_PRC_NRO;
         executePrivate();
         aP0_PRC_NRO=this.A79PRC_NRO;
      }

      void executePrivate( )
      {
         isStatic = false;
         webExecute();
      }

      protected override void createObjects( )
      {
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
            wb_table1_2_024( true) ;
         }
         return  ;
      }

      protected void wb_table1_2_024e( bool wbgen )
      {
         if ( wbgen )
         {
         }
         /* Execute Exit event if defined. */
      }

      protected void wb_table1_2_024( bool wbgen )
      {
         if ( wbgen )
         {
            /* Table start */
            sStyleString = "" ;
            GxWebStd.gx_table_start( context, tblTable1_Internalname, tblTable1_Internalname, "", "Table", 0, "", "", 1, 2, sStyleString, "", 0);
            context.WriteHtmlText( "<tbody>") ;
            context.WriteHtmlText( "<tr>") ;
            context.WriteHtmlText( "<td>") ;
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
            wb_table2_10_024( true) ;
         }
         return  ;
      }

      protected void wb_table2_10_024e( bool wbgen )
      {
         if ( wbgen )
         {
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "<tr>") ;
            context.WriteHtmlText( "<td>") ;
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 44,'',false,'',0)\"" ;
            ClassString = "BtnEnter" ;
            StyleString = "" ;
            GxWebStd.gx_button_ctrl( context, context.GetButtonType( ), bttBtn_enter_Internalname, "Confirmar", "Confirmar", "", StyleString, ClassString, bttBtn_enter_Visible, bttBtn_enter_Enabled, "rounded", 5, bttBtn_enter_Jsonclick, "EENTER.", TempTags, "", "", "HLP_TCOL000.htm");
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 45,'',false,'',0)\"" ;
            ClassString = "BtnCancel" ;
            StyleString = "" ;
            GxWebStd.gx_button_ctrl( context, context.GetButtonType( ), bttBtn_cancel_Internalname, "Cancelar", "Cancelar", "", StyleString, ClassString, bttBtn_cancel_Visible, 1, "rounded", 1, bttBtn_cancel_Jsonclick, "ECANCEL.", TempTags, "", "", "HLP_TCOL000.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "</tbody>") ;
            /* End of table */
            context.WriteHtmlText( "</table>") ;
            wb_table1_2_024e( true) ;
         }
         else
         {
            wb_table1_2_024e( false) ;
         }
      }

      protected void wb_table2_10_024( bool wbgen )
      {
         if ( wbgen )
         {
            /* Table start */
            sStyleString = "" ;
            GxWebStd.gx_table_start( context, tblTable2_Internalname, tblTable2_Internalname, "", "Table", 0, "", "", 1, 2, sStyleString, "", 0);
            context.WriteHtmlText( "<tbody>") ;
            context.WriteHtmlText( "<tr>") ;
            context.WriteHtmlText( "<td>") ;
            /* Text block */
            ClassString = "TextBlock" ;
            StyleString = "" ;
            GxWebStd.gx_label_ctrl( context, lblTextblock1_Internalname, 1, 1, 0, "NUMNERO DE PROCESO", "", "", "", 0, lblTextblock1_Jsonclick, "", StyleString, ClassString, "HLP_TCOL000.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "<td>") ;
            /* Single line edit */
            ClassString = "Attribute" ;
            StyleString = "" ;
            GxWebStd.gx_single_line_edit( context, edtPRC_NRO_Internalname, StringUtil.LTrim( StringUtil.NToC( (decimal)(A79PRC_NRO), 10, 0, ",", "")), "", 10, "chr", 1, "row", 10, 1, edtPRC_NRO_Enabled, 0, 0, 0, "", "", StyleString, ClassString, "", context.localUtil.Format( (decimal)(A79PRC_NRO), "ZZZZZZZZZ9"), "", 0, edtPRC_NRO_Jsonclick, "", 0, 1, -1, true, "right", "HLP_TCOL000.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "<tr>") ;
            context.WriteHtmlText( "<td>") ;
            /* Text block */
            ClassString = "TextBlock" ;
            StyleString = "" ;
            GxWebStd.gx_label_ctrl( context, lblTextblock2_Internalname, 1, 1, 0, "MOMENTO DE INGRESO EN COLA", "", "", "", 0, lblTextblock2_Jsonclick, "", StyleString, ClassString, "HLP_TCOL000.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "<td>") ;
            /* Single line edit */
            ClassString = "Attribute" ;
            StyleString = "background:transparent" ;
            context.WriteHtmlText( "<div id=\""+edtPRC_ING_Internalname+"_dp_container\" class=\"dp_container\" style=\"white-space:nowrap;display:inline;\">") ;
            GxWebStd.gx_single_line_edit( context, edtPRC_ING_Internalname, context.localUtil.Format(A92PRC_ING, "99/99/99 99:99"), "", 14, "chr", 1, "row", 14, 1, edtPRC_ING_Enabled, 0, 0, 0, "", "", StyleString, ClassString, "", context.localUtil.Format( A92PRC_ING, "99/99/99 99:99"), "", 0, edtPRC_ING_Jsonclick, "", 0, 1, 1, true, "right", "HLP_TCOL000.htm");
            GxWebStd.gx_bitmap( context, edtPRC_ING_Internalname+"_dp_trigger", "", "calendar-img.gif", "", ((1==0)||(edtPRC_ING_Enabled==0) ? 0 : 1), 0, "Date selector", "Date selector", 0, 1, 0, "", 0, "", 0, 0, "", "", 0, "", "", "cursor: pointer;vertical-align:text-bottom", "", "", "", "", "", "HLP_TCOL000.htm");
            context.WriteHtmlTextNl( "</div>") ;
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "<tr>") ;
            context.WriteHtmlText( "<td>") ;
            /* Text block */
            ClassString = "TextBlock" ;
            StyleString = "" ;
            GxWebStd.gx_label_ctrl( context, lblTextblock10_Internalname, 1, 1, 0, "USUARIO RESPONSABLE", "", "", "", 0, lblTextblock10_Jsonclick, "", StyleString, ClassString, "HLP_TCOL000.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "<td>") ;
            /* Single line edit */
            ClassString = "Attribute" ;
            StyleString = "background:transparent" ;
            GxWebStd.gx_single_line_edit( context, edtPRC_USR_Internalname, StringUtil.RTrim( A94PRC_USR), "", 16, "chr", 1, "row", 16, 1, edtPRC_USR_Enabled, 0, 0, 0, "", "", StyleString, ClassString, "", StringUtil.RTrim( context.localUtil.Format( A94PRC_USR, "@!")), "", 0, edtPRC_USR_Jsonclick, "", 0, 1, 1, true, "left", "HLP_TCOL000.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "<tr>") ;
            context.WriteHtmlText( "<td>") ;
            /* Text block */
            ClassString = "TextBlock" ;
            StyleString = "" ;
            GxWebStd.gx_label_ctrl( context, lblTextblock6_Internalname, 1, 1, 0, "DESCRIPCION DEL PROCESO", "", "", "", 0, lblTextblock6_Jsonclick, "", StyleString, ClassString, "HLP_TCOL000.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "<td>") ;
            /* Single line edit */
            ClassString = "Attribute" ;
            StyleString = "background:transparent" ;
            GxWebStd.gx_single_line_edit( context, edtPRC_DES_Internalname, StringUtil.RTrim( A95PRC_DES), "", 50, "chr", 1, "row", 50, 1, edtPRC_DES_Enabled, 0, 0, 0, "", "", StyleString, ClassString, "", StringUtil.RTrim( context.localUtil.Format( A95PRC_DES, "XXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX")), "", 0, edtPRC_DES_Jsonclick, "", 0, 1, 1, true, "left", "HLP_TCOL000.htm");
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
            GxWebStd.gx_label_ctrl( context, lblTextblock3_Internalname, 1, 1, 0, "MOMENTO INICIO", "", "", "", 0, lblTextblock3_Jsonclick, "", StyleString, ClassString, "HLP_TCOL000.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "<td>") ;
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 38,'',false,'',0)\"" ;
            ClassString = "Attribute" ;
            StyleString = "" ;
            context.WriteHtmlText( "<div id=\""+edtPRC_INI_Internalname+"_dp_container\" class=\"dp_container\" style=\"white-space:nowrap;display:inline;\">") ;
            GxWebStd.gx_single_line_edit( context, edtPRC_INI_Internalname, context.localUtil.Format(A96PRC_INI, "99/99/99 99:99"), "", 14, "chr", 1, "row", 14, 1, edtPRC_INI_Enabled, 0, 0, 0, "", "", StyleString, ClassString, "", context.localUtil.Format( A96PRC_INI, "99/99/99 99:99"), TempTags+" onchange=\"gx.evt.onchange(this)\" "+" onblur=\""+"gx.date.valid_date(this, 8,'DMY',5,24,'spa',false,0);"+";gx.evt.onblur(38);\"", 0, edtPRC_INI_Jsonclick, "", 0, 1, -1, true, "right", "HLP_TCOL000.htm");
            GxWebStd.gx_bitmap( context, edtPRC_INI_Internalname+"_dp_trigger", "", "calendar-img.gif", "", ((1==0)||(edtPRC_INI_Enabled==0) ? 0 : 1), 0, "Date selector", "Date selector", 0, 1, 0, "", 0, "", 0, 0, "", "", 0, "", "", "cursor: pointer;vertical-align:text-bottom", "", "", "", "", "", "HLP_TCOL000.htm");
            context.WriteHtmlTextNl( "</div>") ;
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "<tr>") ;
            context.WriteHtmlText( "<td>") ;
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "<td>") ;
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "</tbody>") ;
            /* End of table */
            context.WriteHtmlText( "</table>") ;
            wb_table2_10_024e( true) ;
         }
         else
         {
            wb_table2_10_024e( false) ;
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
         context.wbGlbDoneStart = 1 ;
         assign_properties_default( ) ;
         if ( AnyError == 0 )
         {
            if ( StringUtil.StrCmp(context.GetRequestMethod( ), "POST") == 0 )
            {
               /* Read saved SDTs. */
               /* Read variables values. */
               A79PRC_NRO = (long)(context.localUtil.CToN( cgiGet( edtPRC_NRO_Internalname), ",", ".")) ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A79PRC_NRO", StringUtil.LTrim( StringUtil.Str( (decimal)(A79PRC_NRO), 10, 0)));
               A92PRC_ING = context.localUtil.CToT( cgiGet( edtPRC_ING_Internalname)) ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A92PRC_ING", context.localUtil.TToC( A92PRC_ING, 8, 5, 0, 3, "/", ":", " "));
               A94PRC_USR = StringUtil.Upper( cgiGet( edtPRC_USR_Internalname)) ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A94PRC_USR", A94PRC_USR);
               A95PRC_DES = cgiGet( edtPRC_DES_Internalname) ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A95PRC_DES", A95PRC_DES);
               if ( context.localUtil.VCDateTime( cgiGet( edtPRC_INI_Internalname), 4, 0) == 0 )
               {
                  GX_msglist.addItem(context.GetMessage( "GXM_baddatetime", new   object[]  {"MOMENTO INICIO DE PROCESO"}), 1, "PRC_INI");
                  AnyError = 1 ;
                  GX_FocusControl = edtPRC_INI_Internalname ;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
                  wbErr = true ;
                  A96PRC_INI = (DateTime)(DateTime.MinValue) ;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A96PRC_INI", context.localUtil.TToC( A96PRC_INI, 8, 5, 0, 3, "/", ":", " "));
               }
               else
               {
                  A96PRC_INI = context.localUtil.CToT( cgiGet( edtPRC_INI_Internalname)) ;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A96PRC_INI", context.localUtil.TToC( A96PRC_INI, 8, 5, 0, 3, "/", ":", " "));
               }
               /* Read saved values. */
               Z79PRC_NRO = (long)(context.localUtil.CToN( cgiGet( "Z79PRC_NRO"), ",", ".")) ;
               Z92PRC_ING = context.localUtil.CToT( cgiGet( "Z92PRC_ING")) ;
               Z96PRC_INI = context.localUtil.CToT( cgiGet( "Z96PRC_INI")) ;
               Z157PRC_FIN = context.localUtil.CToT( cgiGet( "Z157PRC_FIN")) ;
               Z93PRC_NOM = cgiGet( "Z93PRC_NOM") ;
               Z95PRC_DES = cgiGet( "Z95PRC_DES") ;
               Z160PRC_INV = cgiGet( "Z160PRC_INV") ;
               Z80PRC_PAR = cgiGet( "Z80PRC_PAR") ;
               Z158PRC_EST = (short)(context.localUtil.CToN( cgiGet( "Z158PRC_EST"), ",", ".")) ;
               Z94PRC_USR = cgiGet( "Z94PRC_USR") ;
               Z159PRC_SAL = cgiGet( "Z159PRC_SAL") ;
               Z162PRC_PRS = cgiGet( "Z162PRC_PRS") ;
               Z161PRC_MSG = cgiGet( "Z161PRC_MSG") ;
               Z97PRC_EML = context.localUtil.CToT( cgiGet( "Z97PRC_EML")) ;
               Z163PRC_SRV = cgiGet( "Z163PRC_SRV") ;
               Z98PRC_VER = cgiGet( "Z98PRC_VER") ;
               A157PRC_FIN = context.localUtil.CToT( cgiGet( "Z157PRC_FIN")) ;
               A93PRC_NOM = cgiGet( "Z93PRC_NOM") ;
               A160PRC_INV = cgiGet( "Z160PRC_INV") ;
               A80PRC_PAR = cgiGet( "Z80PRC_PAR") ;
               A158PRC_EST = (short)(context.localUtil.CToN( cgiGet( "Z158PRC_EST"), ",", ".")) ;
               A159PRC_SAL = cgiGet( "Z159PRC_SAL") ;
               A162PRC_PRS = cgiGet( "Z162PRC_PRS") ;
               A161PRC_MSG = cgiGet( "Z161PRC_MSG") ;
               A97PRC_EML = context.localUtil.CToT( cgiGet( "Z97PRC_EML")) ;
               A163PRC_SRV = cgiGet( "Z163PRC_SRV") ;
               A98PRC_VER = cgiGet( "Z98PRC_VER") ;
               IsConfirmed = (short)(context.localUtil.CToN( cgiGet( "IsConfirmed"), ",", ".")) ;
               IsModified = (short)(context.localUtil.CToN( cgiGet( "IsModified"), ",", ".")) ;
               Gx_mode = cgiGet( "Mode") ;
               A157PRC_FIN = context.localUtil.CToT( cgiGet( "PRC_FIN")) ;
               A93PRC_NOM = cgiGet( "PRC_NOM") ;
               A160PRC_INV = cgiGet( "PRC_INV") ;
               A80PRC_PAR = cgiGet( "PRC_PAR") ;
               A158PRC_EST = (short)(context.localUtil.CToN( cgiGet( "PRC_EST"), ",", ".")) ;
               A159PRC_SAL = cgiGet( "PRC_SAL") ;
               A162PRC_PRS = cgiGet( "PRC_PRS") ;
               A161PRC_MSG = cgiGet( "PRC_MSG") ;
               A97PRC_EML = context.localUtil.CToT( cgiGet( "PRC_EML")) ;
               A163PRC_SRV = cgiGet( "PRC_SRV") ;
               A98PRC_VER = cgiGet( "PRC_VER") ;
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
                  A79PRC_NRO = (long)(NumberUtil.Val( GetNextPar( ), ".")) ;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A79PRC_NRO", StringUtil.LTrim( StringUtil.Str( (decimal)(A79PRC_NRO), 10, 0)));
                  getEqualNoModal( ) ;
                  Gx_mode = "DSP" ;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
                  disable_std_buttons_dsp( ) ;
                  standaloneModal( ) ;
               }
               else
               {
                  getEqualNoModal( ) ;
                  standaloneModal( ) ;
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
                        if ( StringUtil.StrCmp(sEvt, "AFTER TRN") == 0 )
                        {
                           context.wbHandled = 1 ;
                           dynload_actions( ) ;
                           /* Execute user event: E11022 */
                           E11022 ();
                        }
                        else if ( StringUtil.StrCmp(sEvt, "ENTER") == 0 )
                        {
                           context.wbHandled = 1 ;
                           btn_enter( ) ;
                           /* No code required for Cancel button. It is implemented as the Reset button. */
                        }
                        else if ( StringUtil.StrCmp(sEvt, "LSCR") == 0 )
                        {
                           context.wbHandled = 1 ;
                           AfterKeyLoadScreen( ) ;
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
            /* Execute user event: E11022 */
            E11022 ();
            trnEnded = 0 ;
            standaloneNotModal( ) ;
            standaloneModal( ) ;
            if ( ( StringUtil.StrCmp(Gx_mode, "INS") == 0 )  )
            {
               /* Clear variables for new insertion. */
               InitAll024( ) ;
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
      }

      protected void disable_std_buttons_dsp( )
      {
         if ( StringUtil.StrCmp(Gx_mode, "DSP") == 0 )
         {
            bttBtn_enter_Visible = 0 ;
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, bttBtn_enter_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(bttBtn_enter_Visible), 5, 0)));
         }
         edtPRC_NRO_Enabled = 0 ;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtPRC_NRO_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtPRC_NRO_Enabled), 5, 0)));
         edtPRC_ING_Enabled = 0 ;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtPRC_ING_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtPRC_ING_Enabled), 5, 0)));
         edtPRC_USR_Enabled = 0 ;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtPRC_USR_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtPRC_USR_Enabled), 5, 0)));
         edtPRC_DES_Enabled = 0 ;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtPRC_DES_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtPRC_DES_Enabled), 5, 0)));
         edtPRC_INI_Enabled = 0 ;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtPRC_INI_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtPRC_INI_Enabled), 5, 0)));
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

      protected void ResetCaption020( )
      {
      }

      protected void E11022( )
      {
         /* After Trn Routine */
         context.setWebReturnParms(new Object[] {(long)A79PRC_NRO});
         context.nUserReturn = 1 ;
         returnInSub = true;
         if (true) return;
      }

      protected void ZM024( short GX_JID )
      {
         if ( ( GX_JID == 5 ) || ( GX_JID == 0 ) )
         {
            if ( StringUtil.StrCmp(Gx_mode, "INS") != 0 )
            {
               Z92PRC_ING = T00023_A92PRC_ING[0] ;
               Z96PRC_INI = T00023_A96PRC_INI[0] ;
               Z157PRC_FIN = T00023_A157PRC_FIN[0] ;
               Z93PRC_NOM = T00023_A93PRC_NOM[0] ;
               Z95PRC_DES = T00023_A95PRC_DES[0] ;
               Z160PRC_INV = T00023_A160PRC_INV[0] ;
               Z80PRC_PAR = T00023_A80PRC_PAR[0] ;
               Z158PRC_EST = T00023_A158PRC_EST[0] ;
               Z94PRC_USR = T00023_A94PRC_USR[0] ;
               Z159PRC_SAL = T00023_A159PRC_SAL[0] ;
               Z162PRC_PRS = T00023_A162PRC_PRS[0] ;
               Z161PRC_MSG = T00023_A161PRC_MSG[0] ;
               Z97PRC_EML = T00023_A97PRC_EML[0] ;
               Z163PRC_SRV = T00023_A163PRC_SRV[0] ;
               Z98PRC_VER = T00023_A98PRC_VER[0] ;
            }
            else
            {
               Z92PRC_ING = A92PRC_ING ;
               Z96PRC_INI = A96PRC_INI ;
               Z157PRC_FIN = A157PRC_FIN ;
               Z93PRC_NOM = A93PRC_NOM ;
               Z95PRC_DES = A95PRC_DES ;
               Z160PRC_INV = A160PRC_INV ;
               Z80PRC_PAR = A80PRC_PAR ;
               Z158PRC_EST = A158PRC_EST ;
               Z94PRC_USR = A94PRC_USR ;
               Z159PRC_SAL = A159PRC_SAL ;
               Z162PRC_PRS = A162PRC_PRS ;
               Z161PRC_MSG = A161PRC_MSG ;
               Z97PRC_EML = A97PRC_EML ;
               Z163PRC_SRV = A163PRC_SRV ;
               Z98PRC_VER = A98PRC_VER ;
            }
         }
         if ( GX_JID == -5 )
         {
            Z79PRC_NRO = A79PRC_NRO ;
            Z92PRC_ING = A92PRC_ING ;
            Z96PRC_INI = A96PRC_INI ;
            Z157PRC_FIN = A157PRC_FIN ;
            Z93PRC_NOM = A93PRC_NOM ;
            Z95PRC_DES = A95PRC_DES ;
            Z160PRC_INV = A160PRC_INV ;
            Z80PRC_PAR = A80PRC_PAR ;
            Z158PRC_EST = A158PRC_EST ;
            Z94PRC_USR = A94PRC_USR ;
            Z159PRC_SAL = A159PRC_SAL ;
            Z162PRC_PRS = A162PRC_PRS ;
            Z161PRC_MSG = A161PRC_MSG ;
            Z97PRC_EML = A97PRC_EML ;
            Z163PRC_SRV = A163PRC_SRV ;
            Z98PRC_VER = A98PRC_VER ;
         }
      }

      protected void standaloneNotModal( )
      {
         edtPRC_ING_Enabled = 0 ;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtPRC_ING_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtPRC_ING_Enabled), 5, 0)));
         edtPRC_USR_Enabled = 0 ;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtPRC_USR_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtPRC_USR_Enabled), 5, 0)));
         edtPRC_DES_Enabled = 0 ;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtPRC_DES_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtPRC_DES_Enabled), 5, 0)));
         edtPRC_ING_Enabled = 0 ;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtPRC_ING_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtPRC_ING_Enabled), 5, 0)));
         edtPRC_USR_Enabled = 0 ;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtPRC_USR_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtPRC_USR_Enabled), 5, 0)));
         edtPRC_DES_Enabled = 0 ;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtPRC_DES_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtPRC_DES_Enabled), 5, 0)));
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
      }

      protected void Load024( )
      {
         /* Using cursor T00024 */
         pr_default.execute(2, new Object[] {A79PRC_NRO});
         if ( (pr_default.getStatus(2) != 101) )
         {
            RcdFound4 = 1 ;
            A92PRC_ING = T00024_A92PRC_ING[0] ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A92PRC_ING", context.localUtil.TToC( A92PRC_ING, 8, 5, 0, 3, "/", ":", " "));
            A96PRC_INI = T00024_A96PRC_INI[0] ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A96PRC_INI", context.localUtil.TToC( A96PRC_INI, 8, 5, 0, 3, "/", ":", " "));
            A157PRC_FIN = T00024_A157PRC_FIN[0] ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A157PRC_FIN", context.localUtil.TToC( A157PRC_FIN, 8, 5, 0, 3, "/", ":", " "));
            A93PRC_NOM = T00024_A93PRC_NOM[0] ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A93PRC_NOM", A93PRC_NOM);
            A95PRC_DES = T00024_A95PRC_DES[0] ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A95PRC_DES", A95PRC_DES);
            A160PRC_INV = T00024_A160PRC_INV[0] ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A160PRC_INV", A160PRC_INV);
            A80PRC_PAR = T00024_A80PRC_PAR[0] ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A80PRC_PAR", A80PRC_PAR);
            A158PRC_EST = T00024_A158PRC_EST[0] ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A158PRC_EST", StringUtil.Str( (decimal)(A158PRC_EST), 1, 0));
            A94PRC_USR = T00024_A94PRC_USR[0] ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A94PRC_USR", A94PRC_USR);
            A159PRC_SAL = T00024_A159PRC_SAL[0] ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A159PRC_SAL", A159PRC_SAL);
            A162PRC_PRS = T00024_A162PRC_PRS[0] ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A162PRC_PRS", A162PRC_PRS);
            A161PRC_MSG = T00024_A161PRC_MSG[0] ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A161PRC_MSG", A161PRC_MSG);
            A97PRC_EML = T00024_A97PRC_EML[0] ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A97PRC_EML", context.localUtil.TToC( A97PRC_EML, 8, 5, 0, 3, "/", ":", " "));
            A163PRC_SRV = T00024_A163PRC_SRV[0] ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A163PRC_SRV", A163PRC_SRV);
            A98PRC_VER = T00024_A98PRC_VER[0] ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A98PRC_VER", A98PRC_VER);
            ZM024( -5) ;
         }
         pr_default.close(2);
         OnLoadActions024( ) ;
      }

      protected void OnLoadActions024( )
      {
      }

      protected void CheckExtendedTable024( )
      {
         Gx_BScreen = 1 ;
         standaloneModal( ) ;
         if ( ! ( (DateTime.MinValue==A96PRC_INI) || ( A96PRC_INI >= context.localUtil.YMDHMSToT( 1753, 1, 1, 0, 0, 0) ) ) )
         {
            GX_msglist.addItem("Campo MOMENTO INICIO DE PROCESO fuera de rango", "OutOfRange", 1, "");
            AnyError = 1 ;
         }
      }

      protected void CloseExtendedTableCursors024( )
      {
      }

      protected void enableDisable( )
      {
      }

      protected void GetKey024( )
      {
         /* Using cursor T00025 */
         pr_default.execute(3, new Object[] {A79PRC_NRO});
         if ( (pr_default.getStatus(3) != 101) )
         {
            RcdFound4 = 1 ;
         }
         else
         {
            RcdFound4 = 0 ;
         }
         pr_default.close(3);
      }

      protected void getByPrimaryKey( )
      {
         /* Using cursor T00023 */
         pr_default.execute(1, new Object[] {A79PRC_NRO});
         if ( (pr_default.getStatus(1) != 101) && ( T00023_A79PRC_NRO[0] == A79PRC_NRO ) )
         {
            ZM024( 5) ;
            RcdFound4 = 1 ;
            A92PRC_ING = T00023_A92PRC_ING[0] ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A92PRC_ING", context.localUtil.TToC( A92PRC_ING, 8, 5, 0, 3, "/", ":", " "));
            A96PRC_INI = T00023_A96PRC_INI[0] ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A96PRC_INI", context.localUtil.TToC( A96PRC_INI, 8, 5, 0, 3, "/", ":", " "));
            A157PRC_FIN = T00023_A157PRC_FIN[0] ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A157PRC_FIN", context.localUtil.TToC( A157PRC_FIN, 8, 5, 0, 3, "/", ":", " "));
            A93PRC_NOM = T00023_A93PRC_NOM[0] ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A93PRC_NOM", A93PRC_NOM);
            A95PRC_DES = T00023_A95PRC_DES[0] ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A95PRC_DES", A95PRC_DES);
            A160PRC_INV = T00023_A160PRC_INV[0] ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A160PRC_INV", A160PRC_INV);
            A80PRC_PAR = T00023_A80PRC_PAR[0] ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A80PRC_PAR", A80PRC_PAR);
            A158PRC_EST = T00023_A158PRC_EST[0] ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A158PRC_EST", StringUtil.Str( (decimal)(A158PRC_EST), 1, 0));
            A94PRC_USR = T00023_A94PRC_USR[0] ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A94PRC_USR", A94PRC_USR);
            A159PRC_SAL = T00023_A159PRC_SAL[0] ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A159PRC_SAL", A159PRC_SAL);
            A162PRC_PRS = T00023_A162PRC_PRS[0] ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A162PRC_PRS", A162PRC_PRS);
            A161PRC_MSG = T00023_A161PRC_MSG[0] ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A161PRC_MSG", A161PRC_MSG);
            A97PRC_EML = T00023_A97PRC_EML[0] ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A97PRC_EML", context.localUtil.TToC( A97PRC_EML, 8, 5, 0, 3, "/", ":", " "));
            A163PRC_SRV = T00023_A163PRC_SRV[0] ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A163PRC_SRV", A163PRC_SRV);
            A98PRC_VER = T00023_A98PRC_VER[0] ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A98PRC_VER", A98PRC_VER);
            Z79PRC_NRO = A79PRC_NRO ;
            sMode4 = Gx_mode ;
            Gx_mode = "DSP" ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
            standaloneModal( ) ;
            Load024( ) ;
            Gx_mode = sMode4 ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
         }
         else
         {
            RcdFound4 = 0 ;
            InitializeNonKey024( ) ;
            sMode4 = Gx_mode ;
            Gx_mode = "DSP" ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
            standaloneModal( ) ;
            Gx_mode = sMode4 ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
         }
         pr_default.close(1);
      }

      protected void getEqualNoModal( )
      {
         GetKey024( ) ;
         if ( RcdFound4 == 0 )
         {
            Gx_mode = "INS" ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
         }
         else
         {
            Gx_mode = "UPD" ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
         }
         getByPrimaryKey( ) ;
      }

      protected void move_next( )
      {
         RcdFound4 = 0 ;
         /* Using cursor T00026 */
         pr_default.execute(4, new Object[] {A79PRC_NRO});
         if ( (pr_default.getStatus(4) != 101) )
         {
            while ( (pr_default.getStatus(4) != 101) && ( T00026_A79PRC_NRO[0] == A79PRC_NRO ) )
            {
               pr_default.readNext(4);
            }
            if ( (pr_default.getStatus(4) != 101) && ( T00026_A79PRC_NRO[0] == A79PRC_NRO ) )
            {
               RcdFound4 = 1 ;
            }
         }
         pr_default.close(1);
      }

      protected void move_previous( )
      {
         RcdFound4 = 0 ;
         /* Using cursor T00027 */
         pr_default.execute(5, new Object[] {A79PRC_NRO});
         if ( (pr_default.getStatus(5) != 101) )
         {
            while ( (pr_default.getStatus(5) != 101) && ( T00027_A79PRC_NRO[0] == A79PRC_NRO ) )
            {
               pr_default.readNext(5);
            }
            if ( (pr_default.getStatus(5) != 101) && ( T00027_A79PRC_NRO[0] == A79PRC_NRO ) )
            {
               RcdFound4 = 1 ;
            }
         }
         pr_default.close(0);
      }

      protected void btn_enter( )
      {
         nKeyPressed = 1 ;
         GetKey024( ) ;
         if ( RcdFound4 == 1 )
         {
            if ( StringUtil.StrCmp(Gx_mode, "INS") == 0 )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_noupdate"), "DuplicatePrimaryKey", 1, "PRC_NRO");
               AnyError = 1 ;
            }
            else if ( A79PRC_NRO != Z79PRC_NRO )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_getbeforeupd"), "CandidateKeyNotFound", 1, "PRC_NRO");
               AnyError = 1 ;
            }
            else if ( StringUtil.StrCmp(Gx_mode, "DLT") == 0 )
            {
               delete( ) ;
               AfterTrn( ) ;
               GX_FocusControl = edtPRC_INI_Internalname ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
            }
            else
            {
               Gx_mode = "UPD" ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
               /* Update record */
               Update024( ) ;
               GX_FocusControl = edtPRC_INI_Internalname ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
            }
         }
         else
         {
            if ( A79PRC_NRO != Z79PRC_NRO )
            {
               Gx_mode = "INS" ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
               /* Insert record */
               Insert024( ) ;
               GX_FocusControl = edtPRC_INI_Internalname ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
            }
            else
            {
               if ( StringUtil.StrCmp(Gx_mode, "UPD") == 0 )
               {
                  GX_msglist.addItem(context.GetMessage( "GXM_recdeleted"), 1, "PRC_NRO");
                  AnyError = 1 ;
               }
               else
               {
                  Gx_mode = "INS" ;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
                  /* Insert record */
                  Insert024( ) ;
                  GX_FocusControl = edtPRC_INI_Internalname ;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
               }
            }
         }
         AfterTrn( ) ;
      }

      protected void btn_delete( )
      {
         if ( A79PRC_NRO != Z79PRC_NRO )
         {
            GX_msglist.addItem(context.GetMessage( "GXM_getbeforedlt"), 1, "PRC_NRO");
            AnyError = 1 ;
         }
         else
         {
            delete( ) ;
            AfterTrn( ) ;
            GX_FocusControl = edtPRC_INI_Internalname ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
         }
         if ( AnyError != 0 )
         {
            Gx_mode = "UPD" ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
         }
         getByPrimaryKey( ) ;
         CloseOpenCursors();
      }

      protected void btn_get( )
      {
         nKeyPressed = 2 ;
         IsConfirmed = 0 ;
         getEqualNoModal( ) ;
         if ( RcdFound4 == 0 )
         {
            GX_msglist.addItem(context.GetMessage( "GXM_keynfound"), "PrimaryKeyNotFound", 1, "PRC_NRO");
            AnyError = 1 ;
         }
         GX_FocusControl = edtPRC_INI_Internalname ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
         standaloneNotModal( ) ;
         standaloneModal( ) ;
      }

      protected void btn_first( )
      {
         nKeyPressed = 2 ;
         IsConfirmed = 0 ;
         ScanStart024( ) ;
         if ( RcdFound4 == 0 )
         {
            GX_msglist.addItem(context.GetMessage( "GXM_norectobrow"), 0, "");
         }
         else
         {
            Gx_mode = "UPD" ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
         }
         GX_FocusControl = edtPRC_INI_Internalname ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
         ScanEnd024( ) ;
         getByPrimaryKey( ) ;
         standaloneNotModal( ) ;
         standaloneModal( ) ;
      }

      protected void btn_previous( )
      {
         nKeyPressed = 2 ;
         IsConfirmed = 0 ;
         move_previous( ) ;
         if ( RcdFound4 == 0 )
         {
            GX_msglist.addItem(context.GetMessage( "GXM_norectobrow"), 0, "");
         }
         else
         {
            Gx_mode = "UPD" ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
         }
         GX_FocusControl = edtPRC_INI_Internalname ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
         getByPrimaryKey( ) ;
         standaloneNotModal( ) ;
         standaloneModal( ) ;
      }

      protected void btn_next( )
      {
         nKeyPressed = 2 ;
         IsConfirmed = 0 ;
         move_next( ) ;
         if ( RcdFound4 == 0 )
         {
            GX_msglist.addItem(context.GetMessage( "GXM_norectobrow"), 0, "");
         }
         else
         {
            Gx_mode = "UPD" ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
         }
         GX_FocusControl = edtPRC_INI_Internalname ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
         getByPrimaryKey( ) ;
         standaloneNotModal( ) ;
         standaloneModal( ) ;
      }

      protected void btn_last( )
      {
         nKeyPressed = 2 ;
         IsConfirmed = 0 ;
         ScanStart024( ) ;
         if ( RcdFound4 == 0 )
         {
            GX_msglist.addItem(context.GetMessage( "GXM_norectobrow"), 0, "");
         }
         else
         {
            while ( RcdFound4 != 0 )
            {
               ScanNext024( ) ;
            }
            Gx_mode = "UPD" ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
         }
         GX_FocusControl = edtPRC_INI_Internalname ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
         ScanEnd024( ) ;
         getByPrimaryKey( ) ;
         standaloneNotModal( ) ;
         standaloneModal( ) ;
      }

      protected void btn_select( )
      {
         getEqualNoModal( ) ;
      }

      protected void CheckOptimisticConcurrency024( )
      {
         if ( StringUtil.StrCmp(Gx_mode, "INS") != 0 )
         {
            /* Using cursor T00028 */
            pr_default.execute(6, new Object[] {A79PRC_NRO});
            if ( (pr_default.getStatus(6) == 103) )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_lock", new   object[]  {"COL000"}), "RecordIsLocked", 1, "");
               AnyError = 1 ;
               return  ;
            }
            Gx_longc = false ;
            if ( (pr_default.getStatus(6) == 101) || ( Z92PRC_ING != T00028_A92PRC_ING[0] ) || ( Z96PRC_INI != T00028_A96PRC_INI[0] ) || ( Z157PRC_FIN != T00028_A157PRC_FIN[0] ) || ( StringUtil.StrCmp(Z93PRC_NOM, T00028_A93PRC_NOM[0]) != 0 ) || ( StringUtil.StrCmp(Z95PRC_DES, T00028_A95PRC_DES[0]) != 0 ) )
            {
               Gx_longc = true ;
            }
            if ( Gx_longc || ( StringUtil.StrCmp(Z160PRC_INV, T00028_A160PRC_INV[0]) != 0 ) || ( StringUtil.StrCmp(Z80PRC_PAR, T00028_A80PRC_PAR[0]) != 0 ) || ( Z158PRC_EST != T00028_A158PRC_EST[0] ) || ( StringUtil.StrCmp(Z94PRC_USR, T00028_A94PRC_USR[0]) != 0 ) || ( StringUtil.StrCmp(Z159PRC_SAL, T00028_A159PRC_SAL[0]) != 0 ) )
            {
               Gx_longc = true ;
            }
            if ( Gx_longc || ( StringUtil.StrCmp(Z162PRC_PRS, T00028_A162PRC_PRS[0]) != 0 ) || ( StringUtil.StrCmp(Z161PRC_MSG, T00028_A161PRC_MSG[0]) != 0 ) || ( Z97PRC_EML != T00028_A97PRC_EML[0] ) || ( StringUtil.StrCmp(Z163PRC_SRV, T00028_A163PRC_SRV[0]) != 0 ) || ( StringUtil.StrCmp(Z98PRC_VER, T00028_A98PRC_VER[0]) != 0 ) )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_waschg", new   object[]  {"COL000"}), "RecordWasChanged", 1, "");
               AnyError = 1 ;
               return  ;
            }
         }
      }

      protected void Insert024( )
      {
         BeforeValidate024( ) ;
         if ( AnyError == 0 )
         {
            CheckExtendedTable024( ) ;
         }
         if ( AnyError == 0 )
         {
            ZM024( 0) ;
            CheckOptimisticConcurrency024( ) ;
            if ( AnyError == 0 )
            {
               AfterConfirm024( ) ;
               if ( AnyError == 0 )
               {
                  BeforeInsert024( ) ;
                  if ( AnyError == 0 )
                  {
                     /* Using cursor T00029 */
                     pr_default.execute(7, new Object[] {A79PRC_NRO, A92PRC_ING, A96PRC_INI, A157PRC_FIN, A93PRC_NOM, A95PRC_DES, A160PRC_INV, A80PRC_PAR, A158PRC_EST, A94PRC_USR, A159PRC_SAL, A162PRC_PRS, A161PRC_MSG, A97PRC_EML, A163PRC_SRV, A98PRC_VER});
                     pr_default.close(7);
                     if ( (pr_default.getStatus(7) == 1) )
                     {
                        GX_msglist.addItem(context.GetMessage( "GXM_noupdate"), "DuplicatePrimaryKey", 1, "");
                        AnyError = 1 ;
                     }
                     if ( AnyError == 0 )
                     {
                        /* Start of After( Insert) rules */
                        /* End of After( Insert) rules */
                        if ( AnyError == 0 )
                        {
                           /* Save values for previous() function. */
                           GX_msglist.addItem(context.GetMessage( "GXM_sucadded"), 0, "");
                           ResetCaption020( ) ;
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
               Load024( ) ;
            }
            EndLevel024( ) ;
         }
         CloseExtendedTableCursors024( ) ;
      }

      protected void Update024( )
      {
         BeforeValidate024( ) ;
         if ( AnyError == 0 )
         {
            CheckExtendedTable024( ) ;
         }
         if ( AnyError == 0 )
         {
            CheckOptimisticConcurrency024( ) ;
            if ( AnyError == 0 )
            {
               AfterConfirm024( ) ;
               if ( AnyError == 0 )
               {
                  BeforeUpdate024( ) ;
                  if ( AnyError == 0 )
                  {
                     /* Using cursor T000210 */
                     pr_default.execute(8, new Object[] {A92PRC_ING, A96PRC_INI, A157PRC_FIN, A93PRC_NOM, A95PRC_DES, A160PRC_INV, A80PRC_PAR, A158PRC_EST, A94PRC_USR, A159PRC_SAL, A162PRC_PRS, A161PRC_MSG, A97PRC_EML, A163PRC_SRV, A98PRC_VER, A79PRC_NRO});
                     pr_default.close(8);
                     if ( (pr_default.getStatus(8) == 103) )
                     {
                        GX_msglist.addItem(context.GetMessage( "GXM_lock", new   object[]  {"COL000"}), "RecordIsLocked", 1, "");
                        AnyError = 1 ;
                     }
                     DeferredUpdate024( ) ;
                     if ( AnyError == 0 )
                     {
                        /* Start of After( update) rules */
                        /* End of After( update) rules */
                        if ( AnyError == 0 )
                        {
                           getByPrimaryKey( ) ;
                           GX_msglist.addItem(context.GetMessage( "GXM_sucupdated"), 0, "");
                           ResetCaption020( ) ;
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
            EndLevel024( ) ;
         }
         CloseExtendedTableCursors024( ) ;
      }

      protected void DeferredUpdate024( )
      {
      }

      protected void delete( )
      {
         Gx_mode = "DLT" ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
         BeforeValidate024( ) ;
         if ( AnyError == 0 )
         {
            CheckOptimisticConcurrency024( ) ;
         }
         if ( AnyError == 0 )
         {
            OnDeleteControls024( ) ;
            AfterConfirm024( ) ;
            if ( AnyError == 0 )
            {
               BeforeDelete024( ) ;
               if ( AnyError == 0 )
               {
                  /* No cascading delete specified. */
                  /* Using cursor T000211 */
                  pr_default.execute(9, new Object[] {A79PRC_NRO});
                  pr_default.close(9);
                  if ( AnyError == 0 )
                  {
                     /* Start of After( delete) rules */
                     /* End of After( delete) rules */
                     if ( AnyError == 0 )
                     {
                        move_next( ) ;
                        if ( RcdFound4 == 0 )
                        {
                           InitAll024( ) ;
                           Gx_mode = "INS" ;
                           context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
                        }
                        else
                        {
                           getByPrimaryKey( ) ;
                           Gx_mode = "UPD" ;
                           context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
                        }
                        GX_msglist.addItem(context.GetMessage( "GXM_sucdeleted"), 0, "");
                        ResetCaption020( ) ;
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
         sMode4 = Gx_mode ;
         Gx_mode = "DLT" ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
         EndLevel024( ) ;
         Gx_mode = sMode4 ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
      }

      protected void OnDeleteControls024( )
      {
         standaloneModal( ) ;
         /* No delete mode formulas found. */
      }

      protected void EndLevel024( )
      {
         if ( StringUtil.StrCmp(Gx_mode, "INS") != 0 )
         {
            pr_default.close(6);
         }
         if ( AnyError == 0 )
         {
            BeforeComplete024( ) ;
         }
         if ( AnyError == 0 )
         {
            pr_default.close(5);
            pr_default.close(4);
            context.CommitDataStores("TCOL000");
            if ( AnyError == 0 )
            {
               ConfirmValues020( ) ;
            }
            /* After transaction rules */
            /* Execute 'After Trn' event if defined. */
            trnEnded = 1 ;
         }
         else
         {
            pr_default.close(5);
            pr_default.close(4);
            context.RollbackDataStores("TCOL000");
         }
         IsModified = 0 ;
         if ( AnyError != 0 )
         {
            context.wjLoc = "" ;
            context.nUserReturn = 0 ;
         }
      }

      protected void ScanStart024( )
      {
         /* Using cursor T000212 */
         pr_default.execute(10, new Object[] {A79PRC_NRO});
         RcdFound4 = 0 ;
         if ( (pr_default.getStatus(10) != 101) )
         {
            RcdFound4 = 1 ;
         }
         /* Load Subordinate Levels */
      }

      protected void ScanNext024( )
      {
         pr_default.readNext(10);
         RcdFound4 = 0 ;
         if ( (pr_default.getStatus(10) != 101) )
         {
            RcdFound4 = 1 ;
         }
      }

      protected void ScanEnd024( )
      {
      }

      protected void AfterConfirm024( )
      {
         /* After Confirm Rules */
      }

      protected void BeforeInsert024( )
      {
         /* Before Insert Rules */
      }

      protected void BeforeUpdate024( )
      {
         /* Before Update Rules */
      }

      protected void BeforeDelete024( )
      {
         /* Before Delete Rules */
      }

      protected void BeforeComplete024( )
      {
         /* Before Complete Rules */
      }

      protected void BeforeValidate024( )
      {
         /* Before Validate Rules */
      }

      protected void assign_properties_default( )
      {
      }

      protected void ConfirmValues020( )
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
         context.WriteHtmlTextNl( "<form id=\"MAINFORM\" onsubmit=\"try{return gx.csv.validForm()}catch(e){return true;}\" name=\"MAINFORM\" method=\"post\" action=\""+formatLink("tcol000.aspx") + "?" + UrlEncode("" +A79PRC_NRO)+"\" class=\""+"Form"+"\">") ;
         GxWebStd.gx_hidden_field( context, "_EventName", "");
         GxWebStd.gx_hidden_field( context, "_EventGridId", "");
         GxWebStd.gx_hidden_field( context, "_EventRowId", "");
      }

      public override void RenderHtmlCloseForm( )
      {
         /* Send hidden variables. */
         /* Send saved values. */
         GxWebStd.gx_hidden_field( context, "Z79PRC_NRO", StringUtil.LTrim( StringUtil.NToC( (decimal)(Z79PRC_NRO), 10, 0, ",", "")));
         GxWebStd.gx_hidden_field( context, "Z92PRC_ING", context.localUtil.TToC( Z92PRC_ING, 10, 8, 0, 3, "/", ":", " "));
         GxWebStd.gx_hidden_field( context, "Z96PRC_INI", context.localUtil.TToC( Z96PRC_INI, 10, 8, 0, 3, "/", ":", " "));
         GxWebStd.gx_hidden_field( context, "Z157PRC_FIN", context.localUtil.TToC( Z157PRC_FIN, 10, 8, 0, 3, "/", ":", " "));
         GxWebStd.gx_hidden_field( context, "Z93PRC_NOM", StringUtil.RTrim( Z93PRC_NOM));
         GxWebStd.gx_hidden_field( context, "Z95PRC_DES", StringUtil.RTrim( Z95PRC_DES));
         GxWebStd.gx_hidden_field( context, "Z160PRC_INV", StringUtil.RTrim( Z160PRC_INV));
         GxWebStd.gx_hidden_field( context, "Z80PRC_PAR", StringUtil.RTrim( Z80PRC_PAR));
         GxWebStd.gx_hidden_field( context, "Z158PRC_EST", StringUtil.LTrim( StringUtil.NToC( (decimal)(Z158PRC_EST), 1, 0, ",", "")));
         GxWebStd.gx_hidden_field( context, "Z94PRC_USR", StringUtil.RTrim( Z94PRC_USR));
         GxWebStd.gx_hidden_field( context, "Z159PRC_SAL", StringUtil.RTrim( Z159PRC_SAL));
         GxWebStd.gx_hidden_field( context, "Z162PRC_PRS", StringUtil.RTrim( Z162PRC_PRS));
         GxWebStd.gx_hidden_field( context, "Z161PRC_MSG", StringUtil.RTrim( Z161PRC_MSG));
         GxWebStd.gx_hidden_field( context, "Z97PRC_EML", context.localUtil.TToC( Z97PRC_EML, 10, 8, 0, 3, "/", ":", " "));
         GxWebStd.gx_hidden_field( context, "Z163PRC_SRV", StringUtil.RTrim( Z163PRC_SRV));
         GxWebStd.gx_hidden_field( context, "Z98PRC_VER", StringUtil.RTrim( Z98PRC_VER));
         GxWebStd.gx_hidden_field( context, "IsConfirmed", StringUtil.LTrim( StringUtil.NToC( (decimal)(IsConfirmed), 4, 0, ",", "")));
         GxWebStd.gx_hidden_field( context, "IsModified", StringUtil.LTrim( StringUtil.NToC( (decimal)(IsModified), 4, 0, ",", "")));
         GxWebStd.gx_hidden_field( context, "Mode", StringUtil.RTrim( Gx_mode));
         GxWebStd.gx_hidden_field( context, "PRC_FIN", context.localUtil.TToC( A157PRC_FIN, 10, 8, 0, 3, "/", ":", " "));
         GxWebStd.gx_hidden_field( context, "PRC_NOM", StringUtil.RTrim( A93PRC_NOM));
         GxWebStd.gx_hidden_field( context, "PRC_INV", StringUtil.RTrim( A160PRC_INV));
         GxWebStd.gx_hidden_field( context, "PRC_PAR", StringUtil.RTrim( A80PRC_PAR));
         GxWebStd.gx_hidden_field( context, "PRC_EST", StringUtil.LTrim( StringUtil.NToC( (decimal)(A158PRC_EST), 1, 0, ",", "")));
         GxWebStd.gx_hidden_field( context, "PRC_SAL", StringUtil.RTrim( A159PRC_SAL));
         GxWebStd.gx_hidden_field( context, "PRC_PRS", StringUtil.RTrim( A162PRC_PRS));
         GxWebStd.gx_hidden_field( context, "PRC_MSG", StringUtil.RTrim( A161PRC_MSG));
         GxWebStd.gx_hidden_field( context, "PRC_EML", context.localUtil.TToC( A97PRC_EML, 10, 8, 0, 3, "/", ":", " "));
         GxWebStd.gx_hidden_field( context, "PRC_SRV", StringUtil.RTrim( A163PRC_SRV));
         GxWebStd.gx_hidden_field( context, "PRC_VER", StringUtil.RTrim( A98PRC_VER));
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
         return "TCOL000" ;
      }

      public override String GetPgmdesc( )
      {
         return "COLA DE PROCESOS BATCH" ;
      }

      public override GXWebForm GetForm( )
      {
         return Form ;
      }

      public override String GetSelfLink( )
      {
         return formatLink("tcol000.aspx") + "?" + UrlEncode("" +A79PRC_NRO) ;
      }

      protected void InitializeNonKey024( )
      {
         A92PRC_ING = (DateTime)(DateTime.MinValue) ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A92PRC_ING", context.localUtil.TToC( A92PRC_ING, 8, 5, 0, 3, "/", ":", " "));
         A96PRC_INI = (DateTime)(DateTime.MinValue) ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A96PRC_INI", context.localUtil.TToC( A96PRC_INI, 8, 5, 0, 3, "/", ":", " "));
         A157PRC_FIN = (DateTime)(DateTime.MinValue) ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A157PRC_FIN", context.localUtil.TToC( A157PRC_FIN, 8, 5, 0, 3, "/", ":", " "));
         A93PRC_NOM = "" ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A93PRC_NOM", A93PRC_NOM);
         A95PRC_DES = "" ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A95PRC_DES", A95PRC_DES);
         A160PRC_INV = "" ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A160PRC_INV", A160PRC_INV);
         A80PRC_PAR = "" ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A80PRC_PAR", A80PRC_PAR);
         A158PRC_EST = 0 ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A158PRC_EST", StringUtil.Str( (decimal)(A158PRC_EST), 1, 0));
         A94PRC_USR = "" ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A94PRC_USR", A94PRC_USR);
         A159PRC_SAL = "" ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A159PRC_SAL", A159PRC_SAL);
         A162PRC_PRS = "" ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A162PRC_PRS", A162PRC_PRS);
         A161PRC_MSG = "" ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A161PRC_MSG", A161PRC_MSG);
         A97PRC_EML = (DateTime)(DateTime.MinValue) ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A97PRC_EML", context.localUtil.TToC( A97PRC_EML, 8, 5, 0, 3, "/", ":", " "));
         A163PRC_SRV = "" ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A163PRC_SRV", A163PRC_SRV);
         A98PRC_VER = "" ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A98PRC_VER", A98PRC_VER);
      }

      protected void InitAll024( )
      {
         InitializeNonKey024( ) ;
      }

      protected void StandaloneModalInsert( )
      {
      }

      protected void define_styles( )
      {
         AddStyleSheetFile("calendar-system.css", "?84120");
         AddThemeStyleSheetFile("", "Modern.css", "?19542497");
         idxLst = 1 ;
         while ( idxLst <= Form.Jscriptsrc.Count )
         {
            context.AddJavascriptSource(StringUtil.RTrim( Form.Jscriptsrc.Item(idxLst)), "?11192754");
            idxLst = (int)(idxLst+1) ;
         }
         /* End function define_styles */
      }

      protected void include_jscripts( )
      {
         context.AddJavascriptSource("messages.spa.js", "?42940");
         context.AddJavascriptSource("tcol000.js", "?11192755");
         /* End function include_jscripts */
      }

      protected void init_default_properties( )
      {
         lblTextblock1_Internalname = "TEXTBLOCK1" ;
         edtPRC_NRO_Internalname = "PRC_NRO" ;
         lblTextblock2_Internalname = "TEXTBLOCK2" ;
         edtPRC_ING_Internalname = "PRC_ING" ;
         lblTextblock10_Internalname = "TEXTBLOCK10" ;
         edtPRC_USR_Internalname = "PRC_USR" ;
         lblTextblock6_Internalname = "TEXTBLOCK6" ;
         edtPRC_DES_Internalname = "PRC_DES" ;
         lblTextblock3_Internalname = "TEXTBLOCK3" ;
         edtPRC_INI_Internalname = "PRC_INI" ;
         tblTable2_Internalname = "TABLE2" ;
         bttBtn_enter_Internalname = "BTN_ENTER" ;
         bttBtn_cancel_Internalname = "BTN_CANCEL" ;
         tblTable1_Internalname = "TABLE1" ;
         Form.Internalname = "FORM" ;
      }

      public override void initialize_properties( )
      {
         init_default_properties( ) ;
         Form.Headerrawhtml = "" ;
         Form.Background = "" ;
         Form.Backcolor = (int)(0xFFFFFF) ;
         Form.Caption = "COLA DE PROCESOS BATCH" ;
         edtPRC_INI_Jsonclick = "" ;
         edtPRC_INI_Enabled = 1 ;
         edtPRC_DES_Jsonclick = "" ;
         edtPRC_DES_Enabled = 0 ;
         edtPRC_USR_Jsonclick = "" ;
         edtPRC_USR_Enabled = 0 ;
         edtPRC_ING_Jsonclick = "" ;
         edtPRC_ING_Enabled = 0 ;
         edtPRC_NRO_Jsonclick = "" ;
         edtPRC_NRO_Enabled = 0 ;
         bttBtn_cancel_Visible = 1 ;
         bttBtn_enter_Enabled = 1 ;
         bttBtn_enter_Visible = 1 ;
         context.GX_msglist.DisplayMode = 1 ;
      }

      protected void dynload_actions( )
      {
         /* End function dynload_actions */
      }

      protected void AfterKeyLoadScreen( )
      {
         IsConfirmed = 0 ;
         getEqualNoModal( ) ;
         GX_FocusControl = edtPRC_INI_Internalname ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
         standaloneNotModal( ) ;
         standaloneModal( ) ;
         /* End function AfterKeyLoadScreen */
      }

      public void Valid_Prc_nro( long GX_Parm1 ,
                                 DateTime GX_Parm2 ,
                                 DateTime GX_Parm3 ,
                                 DateTime GX_Parm4 ,
                                 String GX_Parm5 ,
                                 String GX_Parm6 ,
                                 String GX_Parm7 ,
                                 String GX_Parm8 ,
                                 short GX_Parm9 ,
                                 String GX_Parm10 ,
                                 String GX_Parm11 ,
                                 String GX_Parm12 ,
                                 String GX_Parm13 ,
                                 DateTime GX_Parm14 ,
                                 String GX_Parm15 ,
                                 String GX_Parm16 )
      {
         A79PRC_NRO = GX_Parm1 ;
         A92PRC_ING = GX_Parm2 ;
         A96PRC_INI = GX_Parm3 ;
         A157PRC_FIN = GX_Parm4 ;
         A93PRC_NOM = GX_Parm5 ;
         A95PRC_DES = GX_Parm6 ;
         A160PRC_INV = GX_Parm7 ;
         A80PRC_PAR = GX_Parm8 ;
         A158PRC_EST = GX_Parm9 ;
         A94PRC_USR = GX_Parm10 ;
         A159PRC_SAL = GX_Parm11 ;
         A162PRC_PRS = GX_Parm12 ;
         A161PRC_MSG = GX_Parm13 ;
         A97PRC_EML = GX_Parm14 ;
         A163PRC_SRV = GX_Parm15 ;
         A98PRC_VER = GX_Parm16 ;
         context.wbHandled = 1 ;
         AfterKeyLoadScreen( ) ;
         Draw( ) ;
         dynload_actions( ) ;
         if ( AnyError == 1 )
         {
         }
         isValidOutput.Add((Object)(context.localUtil.Format(A92PRC_ING, "99/99/99 99:99")));
         isValidOutput.Add((Object)(context.localUtil.Format(A96PRC_INI, "99/99/99 99:99")));
         isValidOutput.Add((Object)(context.localUtil.Format(A157PRC_FIN, "99/99/99 99:99")));
         isValidOutput.Add((Object)(StringUtil.RTrim( A93PRC_NOM)));
         isValidOutput.Add((Object)(StringUtil.RTrim( A95PRC_DES)));
         isValidOutput.Add((Object)(StringUtil.RTrim( A160PRC_INV)));
         isValidOutput.Add((Object)(StringUtil.RTrim( A80PRC_PAR)));
         isValidOutput.Add((Object)(StringUtil.LTrim( StringUtil.NToC( (decimal)(A158PRC_EST), 1, 0, ".", ""))));
         isValidOutput.Add((Object)(StringUtil.RTrim( A94PRC_USR)));
         isValidOutput.Add((Object)(StringUtil.RTrim( A159PRC_SAL)));
         isValidOutput.Add((Object)(StringUtil.RTrim( A162PRC_PRS)));
         isValidOutput.Add((Object)(StringUtil.RTrim( A161PRC_MSG)));
         isValidOutput.Add((Object)(context.localUtil.Format(A97PRC_EML, "99/99/99 99:99")));
         isValidOutput.Add((Object)(StringUtil.RTrim( A163PRC_SRV)));
         isValidOutput.Add((Object)(StringUtil.RTrim( A98PRC_VER)));
         isValidOutput.Add((Object)(StringUtil.RTrim( Gx_mode)));
         isValidOutput.Add((Object)(StringUtil.LTrim( StringUtil.NToC( (decimal)(Z79PRC_NRO), 10, 0, ",", ""))));
         isValidOutput.Add((Object)(context.localUtil.TToC( Z92PRC_ING, 10, 8, 0, 3, "/", ":", " ")));
         isValidOutput.Add((Object)(context.localUtil.TToC( Z96PRC_INI, 10, 8, 0, 3, "/", ":", " ")));
         isValidOutput.Add((Object)(context.localUtil.TToC( Z157PRC_FIN, 10, 8, 0, 3, "/", ":", " ")));
         isValidOutput.Add((Object)(StringUtil.RTrim( Z93PRC_NOM)));
         isValidOutput.Add((Object)(StringUtil.RTrim( Z95PRC_DES)));
         isValidOutput.Add((Object)(StringUtil.RTrim( Z160PRC_INV)));
         isValidOutput.Add((Object)(StringUtil.RTrim( Z80PRC_PAR)));
         isValidOutput.Add((Object)(StringUtil.LTrim( StringUtil.NToC( (decimal)(Z158PRC_EST), 1, 0, ",", ""))));
         isValidOutput.Add((Object)(StringUtil.RTrim( Z94PRC_USR)));
         isValidOutput.Add((Object)(StringUtil.RTrim( Z159PRC_SAL)));
         isValidOutput.Add((Object)(StringUtil.RTrim( Z162PRC_PRS)));
         isValidOutput.Add((Object)(StringUtil.RTrim( Z161PRC_MSG)));
         isValidOutput.Add((Object)(context.localUtil.TToC( Z97PRC_EML, 10, 8, 0, 3, "/", ":", " ")));
         isValidOutput.Add((Object)(StringUtil.RTrim( Z163PRC_SRV)));
         isValidOutput.Add((Object)(StringUtil.RTrim( Z98PRC_VER)));
         isValidOutput.Add((Object)(bttBtn_enter_Enabled));
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
         pr_default.close(10);
         pr_default.close(5);
         pr_default.close(4);
      }

      public override void initialize( )
      {
         sPrefix = "" ;
         scmdbuf = "" ;
         gxfirstwebparm = "" ;
         gxfirstwebparm_bkp = "" ;
         PreviousTooltip = "" ;
         PreviousCaption = "" ;
         Form = new GXWebForm();
         GX_FocusControl = "" ;
         sStyleString = "" ;
         ClassString = "" ;
         StyleString = "" ;
         TempTags = "" ;
         bttBtn_enter_Jsonclick = "" ;
         bttBtn_cancel_Jsonclick = "" ;
         lblTextblock1_Jsonclick = "" ;
         lblTextblock2_Jsonclick = "" ;
         A92PRC_ING = (DateTime)(DateTime.MinValue) ;
         lblTextblock10_Jsonclick = "" ;
         A94PRC_USR = "" ;
         lblTextblock6_Jsonclick = "" ;
         A95PRC_DES = "" ;
         lblTextblock3_Jsonclick = "" ;
         A96PRC_INI = (DateTime)(DateTime.MinValue) ;
         Z92PRC_ING = (DateTime)(DateTime.MinValue) ;
         Z96PRC_INI = (DateTime)(DateTime.MinValue) ;
         Z157PRC_FIN = (DateTime)(DateTime.MinValue) ;
         Z93PRC_NOM = "" ;
         Z95PRC_DES = "" ;
         Z160PRC_INV = "" ;
         Z80PRC_PAR = "" ;
         Z94PRC_USR = "" ;
         Z159PRC_SAL = "" ;
         Z162PRC_PRS = "" ;
         Z161PRC_MSG = "" ;
         Z97PRC_EML = (DateTime)(DateTime.MinValue) ;
         Z163PRC_SRV = "" ;
         Z98PRC_VER = "" ;
         A157PRC_FIN = (DateTime)(DateTime.MinValue) ;
         A93PRC_NOM = "" ;
         A160PRC_INV = "" ;
         A80PRC_PAR = "" ;
         A159PRC_SAL = "" ;
         A162PRC_PRS = "" ;
         A161PRC_MSG = "" ;
         A97PRC_EML = (DateTime)(DateTime.MinValue) ;
         A163PRC_SRV = "" ;
         A98PRC_VER = "" ;
         Gx_mode = "" ;
         sEvt = "" ;
         EvtGridId = "" ;
         EvtRowId = "" ;
         sEvtType = "" ;
         T00024_A79PRC_NRO = new long[1] ;
         T00024_A92PRC_ING = new DateTime[] {DateTime.MinValue} ;
         T00024_A96PRC_INI = new DateTime[] {DateTime.MinValue} ;
         T00024_A157PRC_FIN = new DateTime[] {DateTime.MinValue} ;
         T00024_A93PRC_NOM = new String[] {""} ;
         T00024_A95PRC_DES = new String[] {""} ;
         T00024_A160PRC_INV = new String[] {""} ;
         T00024_A80PRC_PAR = new String[] {""} ;
         T00024_A158PRC_EST = new short[1] ;
         T00024_A94PRC_USR = new String[] {""} ;
         T00024_A159PRC_SAL = new String[] {""} ;
         T00024_A162PRC_PRS = new String[] {""} ;
         T00024_A161PRC_MSG = new String[] {""} ;
         T00024_A97PRC_EML = new DateTime[] {DateTime.MinValue} ;
         T00024_A163PRC_SRV = new String[] {""} ;
         T00024_A98PRC_VER = new String[] {""} ;
         T00025_A79PRC_NRO = new long[1] ;
         T00023_A79PRC_NRO = new long[1] ;
         T00023_A92PRC_ING = new DateTime[] {DateTime.MinValue} ;
         T00023_A96PRC_INI = new DateTime[] {DateTime.MinValue} ;
         T00023_A157PRC_FIN = new DateTime[] {DateTime.MinValue} ;
         T00023_A93PRC_NOM = new String[] {""} ;
         T00023_A95PRC_DES = new String[] {""} ;
         T00023_A160PRC_INV = new String[] {""} ;
         T00023_A80PRC_PAR = new String[] {""} ;
         T00023_A158PRC_EST = new short[1] ;
         T00023_A94PRC_USR = new String[] {""} ;
         T00023_A159PRC_SAL = new String[] {""} ;
         T00023_A162PRC_PRS = new String[] {""} ;
         T00023_A161PRC_MSG = new String[] {""} ;
         T00023_A97PRC_EML = new DateTime[] {DateTime.MinValue} ;
         T00023_A163PRC_SRV = new String[] {""} ;
         T00023_A98PRC_VER = new String[] {""} ;
         sMode4 = "" ;
         T00026_A79PRC_NRO = new long[1] ;
         T00027_A79PRC_NRO = new long[1] ;
         T00028_A79PRC_NRO = new long[1] ;
         T00028_A92PRC_ING = new DateTime[] {DateTime.MinValue} ;
         T00028_A96PRC_INI = new DateTime[] {DateTime.MinValue} ;
         T00028_A157PRC_FIN = new DateTime[] {DateTime.MinValue} ;
         T00028_A93PRC_NOM = new String[] {""} ;
         T00028_A95PRC_DES = new String[] {""} ;
         T00028_A160PRC_INV = new String[] {""} ;
         T00028_A80PRC_PAR = new String[] {""} ;
         T00028_A158PRC_EST = new short[1] ;
         T00028_A94PRC_USR = new String[] {""} ;
         T00028_A159PRC_SAL = new String[] {""} ;
         T00028_A162PRC_PRS = new String[] {""} ;
         T00028_A161PRC_MSG = new String[] {""} ;
         T00028_A97PRC_EML = new DateTime[] {DateTime.MinValue} ;
         T00028_A163PRC_SRV = new String[] {""} ;
         T00028_A98PRC_VER = new String[] {""} ;
         T000212_A79PRC_NRO = new long[1] ;
         sDynURL = "" ;
         FormProcess = "" ;
         GXt_char3 = "" ;
         GXt_char2 = "" ;
         GXt_char1 = "" ;
         isValidOutput = new GxUnknownObjectCollection();
         pr_default = new DataStoreProvider(context, new GeneXus.Programs.tcol000__default(),
            new Object[][] {
                new Object[] {
               T00022_A79PRC_NRO, T00022_A92PRC_ING, T00022_A96PRC_INI, T00022_A157PRC_FIN, T00022_A93PRC_NOM, T00022_A95PRC_DES, T00022_A160PRC_INV, T00022_A80PRC_PAR, T00022_A158PRC_EST, T00022_A94PRC_USR,
               T00022_A159PRC_SAL, T00022_A162PRC_PRS, T00022_A161PRC_MSG, T00022_A97PRC_EML, T00022_A163PRC_SRV, T00022_A98PRC_VER
               }
               , new Object[] {
               T00023_A79PRC_NRO, T00023_A92PRC_ING, T00023_A96PRC_INI, T00023_A157PRC_FIN, T00023_A93PRC_NOM, T00023_A95PRC_DES, T00023_A160PRC_INV, T00023_A80PRC_PAR, T00023_A158PRC_EST, T00023_A94PRC_USR,
               T00023_A159PRC_SAL, T00023_A162PRC_PRS, T00023_A161PRC_MSG, T00023_A97PRC_EML, T00023_A163PRC_SRV, T00023_A98PRC_VER
               }
               , new Object[] {
               T00024_A79PRC_NRO, T00024_A92PRC_ING, T00024_A96PRC_INI, T00024_A157PRC_FIN, T00024_A93PRC_NOM, T00024_A95PRC_DES, T00024_A160PRC_INV, T00024_A80PRC_PAR, T00024_A158PRC_EST, T00024_A94PRC_USR,
               T00024_A159PRC_SAL, T00024_A162PRC_PRS, T00024_A161PRC_MSG, T00024_A97PRC_EML, T00024_A163PRC_SRV, T00024_A98PRC_VER
               }
               , new Object[] {
               T00025_A79PRC_NRO
               }
               , new Object[] {
               T00026_A79PRC_NRO
               }
               , new Object[] {
               T00027_A79PRC_NRO
               }
               , new Object[] {
               T00028_A79PRC_NRO, T00028_A92PRC_ING, T00028_A96PRC_INI, T00028_A157PRC_FIN, T00028_A93PRC_NOM, T00028_A95PRC_DES, T00028_A160PRC_INV, T00028_A80PRC_PAR, T00028_A158PRC_EST, T00028_A94PRC_USR,
               T00028_A159PRC_SAL, T00028_A162PRC_PRS, T00028_A161PRC_MSG, T00028_A97PRC_EML, T00028_A163PRC_SRV, T00028_A98PRC_VER
               }
               , new Object[] {
               }
               , new Object[] {
               }
               , new Object[] {
               }
               , new Object[] {
               T000212_A79PRC_NRO
               }
            }
         );
         Z79PRC_NRO = 0 ;
      }

      private short GxWebError ;
      private short IsConfirmed ;
      private short IsModified ;
      private short AnyError ;
      private short nKeyPressed ;
      private short initialized ;
      private short Z158PRC_EST ;
      private short A158PRC_EST ;
      private short GX_JID ;
      private short RcdFound4 ;
      private short Gx_BScreen ;
      private short gxajaxcallmode ;
      private int trnEnded ;
      private int bttBtn_enter_Visible ;
      private int bttBtn_enter_Enabled ;
      private int bttBtn_cancel_Visible ;
      private int edtPRC_NRO_Enabled ;
      private int edtPRC_ING_Enabled ;
      private int edtPRC_USR_Enabled ;
      private int edtPRC_DES_Enabled ;
      private int edtPRC_INI_Enabled ;
      private int idxLst ;
      private long wcpOA79PRC_NRO ;
      private long A79PRC_NRO ;
      private long Z79PRC_NRO ;
      private String sPrefix ;
      private String scmdbuf ;
      private String gxfirstwebparm ;
      private String gxfirstwebparm_bkp ;
      private String PreviousTooltip ;
      private String PreviousCaption ;
      private String GX_FocusControl ;
      private String edtPRC_INI_Internalname ;
      private String sStyleString ;
      private String tblTable1_Internalname ;
      private String ClassString ;
      private String StyleString ;
      private String TempTags ;
      private String bttBtn_enter_Internalname ;
      private String bttBtn_enter_Jsonclick ;
      private String bttBtn_cancel_Internalname ;
      private String bttBtn_cancel_Jsonclick ;
      private String tblTable2_Internalname ;
      private String lblTextblock1_Internalname ;
      private String lblTextblock1_Jsonclick ;
      private String edtPRC_NRO_Internalname ;
      private String edtPRC_NRO_Jsonclick ;
      private String lblTextblock2_Internalname ;
      private String lblTextblock2_Jsonclick ;
      private String edtPRC_ING_Internalname ;
      private String edtPRC_ING_Jsonclick ;
      private String lblTextblock10_Internalname ;
      private String lblTextblock10_Jsonclick ;
      private String edtPRC_USR_Internalname ;
      private String A94PRC_USR ;
      private String edtPRC_USR_Jsonclick ;
      private String lblTextblock6_Internalname ;
      private String lblTextblock6_Jsonclick ;
      private String edtPRC_DES_Internalname ;
      private String A95PRC_DES ;
      private String edtPRC_DES_Jsonclick ;
      private String lblTextblock3_Internalname ;
      private String lblTextblock3_Jsonclick ;
      private String edtPRC_INI_Jsonclick ;
      private String Z93PRC_NOM ;
      private String Z95PRC_DES ;
      private String Z160PRC_INV ;
      private String Z80PRC_PAR ;
      private String Z94PRC_USR ;
      private String Z159PRC_SAL ;
      private String Z162PRC_PRS ;
      private String Z161PRC_MSG ;
      private String Z163PRC_SRV ;
      private String Z98PRC_VER ;
      private String A93PRC_NOM ;
      private String A160PRC_INV ;
      private String A80PRC_PAR ;
      private String A159PRC_SAL ;
      private String A162PRC_PRS ;
      private String A161PRC_MSG ;
      private String A163PRC_SRV ;
      private String A98PRC_VER ;
      private String Gx_mode ;
      private String sEvt ;
      private String EvtGridId ;
      private String EvtRowId ;
      private String sEvtType ;
      private String sMode4 ;
      private String sDynURL ;
      private String FormProcess ;
      private String GXt_char3 ;
      private String GXt_char2 ;
      private String GXt_char1 ;
      private DateTime A92PRC_ING ;
      private DateTime A96PRC_INI ;
      private DateTime Z92PRC_ING ;
      private DateTime Z96PRC_INI ;
      private DateTime Z157PRC_FIN ;
      private DateTime Z97PRC_EML ;
      private DateTime A157PRC_FIN ;
      private DateTime A97PRC_EML ;
      private bool entryPointCalled ;
      private bool wbErr ;
      private bool returnInSub ;
      private bool Gx_longc ;
      private GxUnknownObjectCollection isValidOutput ;
      private GXMasterPage MasterPageObj ;
      private IGxDataStore dsDESARROLLO ;
      private IGxDataStore dssoporte_notebook ;
      private IGxDataStore dsDefault ;
      private long aP0_PRC_NRO ;
      private IDataStoreProvider pr_default ;
      private long[] T00024_A79PRC_NRO ;
      private DateTime[] T00024_A92PRC_ING ;
      private DateTime[] T00024_A96PRC_INI ;
      private DateTime[] T00024_A157PRC_FIN ;
      private String[] T00024_A93PRC_NOM ;
      private String[] T00024_A95PRC_DES ;
      private String[] T00024_A160PRC_INV ;
      private String[] T00024_A80PRC_PAR ;
      private short[] T00024_A158PRC_EST ;
      private String[] T00024_A94PRC_USR ;
      private String[] T00024_A159PRC_SAL ;
      private String[] T00024_A162PRC_PRS ;
      private String[] T00024_A161PRC_MSG ;
      private DateTime[] T00024_A97PRC_EML ;
      private String[] T00024_A163PRC_SRV ;
      private String[] T00024_A98PRC_VER ;
      private long[] T00025_A79PRC_NRO ;
      private long[] T00023_A79PRC_NRO ;
      private DateTime[] T00023_A92PRC_ING ;
      private DateTime[] T00023_A96PRC_INI ;
      private DateTime[] T00023_A157PRC_FIN ;
      private String[] T00023_A93PRC_NOM ;
      private String[] T00023_A95PRC_DES ;
      private String[] T00023_A160PRC_INV ;
      private String[] T00023_A80PRC_PAR ;
      private short[] T00023_A158PRC_EST ;
      private String[] T00023_A94PRC_USR ;
      private String[] T00023_A159PRC_SAL ;
      private String[] T00023_A162PRC_PRS ;
      private String[] T00023_A161PRC_MSG ;
      private DateTime[] T00023_A97PRC_EML ;
      private String[] T00023_A163PRC_SRV ;
      private String[] T00023_A98PRC_VER ;
      private long[] T00026_A79PRC_NRO ;
      private long[] T00027_A79PRC_NRO ;
      private long[] T00028_A79PRC_NRO ;
      private DateTime[] T00028_A92PRC_ING ;
      private DateTime[] T00028_A96PRC_INI ;
      private DateTime[] T00028_A157PRC_FIN ;
      private String[] T00028_A93PRC_NOM ;
      private String[] T00028_A95PRC_DES ;
      private String[] T00028_A160PRC_INV ;
      private String[] T00028_A80PRC_PAR ;
      private short[] T00028_A158PRC_EST ;
      private String[] T00028_A94PRC_USR ;
      private String[] T00028_A159PRC_SAL ;
      private String[] T00028_A162PRC_PRS ;
      private String[] T00028_A161PRC_MSG ;
      private DateTime[] T00028_A97PRC_EML ;
      private String[] T00028_A163PRC_SRV ;
      private String[] T00028_A98PRC_VER ;
      private long[] T000212_A79PRC_NRO ;
      private long[] T00022_A79PRC_NRO ;
      private DateTime[] T00022_A92PRC_ING ;
      private DateTime[] T00022_A96PRC_INI ;
      private DateTime[] T00022_A157PRC_FIN ;
      private String[] T00022_A93PRC_NOM ;
      private String[] T00022_A95PRC_DES ;
      private String[] T00022_A160PRC_INV ;
      private String[] T00022_A80PRC_PAR ;
      private short[] T00022_A158PRC_EST ;
      private String[] T00022_A94PRC_USR ;
      private String[] T00022_A159PRC_SAL ;
      private String[] T00022_A162PRC_PRS ;
      private String[] T00022_A161PRC_MSG ;
      private DateTime[] T00022_A97PRC_EML ;
      private String[] T00022_A163PRC_SRV ;
      private String[] T00022_A98PRC_VER ;
      private GXWebForm Form ;
   }

   public class tcol000__default : DataStoreHelperBase, IDataStoreHelper
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
         ,new UpdateCursor(def[8])
         ,new UpdateCursor(def[9])
         ,new ForEachCursor(def[10])
       };
    }

    private static CursorDef[] def;
    private void cursorDefinitions( )
    {
       if ( def == null )
       {
          Object[] prmT00022 ;
          prmT00022 = new Object[] {
          new Object[] {"@PRC_NRO",SqlDbType.Decimal,10,0}
          } ;
          Object[] prmT00024 ;
          prmT00024 = new Object[] {
          new Object[] {"@PRC_NRO",SqlDbType.Decimal,10,0}
          } ;
          Object[] prmT00025 ;
          prmT00025 = new Object[] {
          new Object[] {"@PRC_NRO",SqlDbType.Decimal,10,0}
          } ;
          Object[] prmT00023 ;
          prmT00023 = new Object[] {
          new Object[] {"@PRC_NRO",SqlDbType.Decimal,10,0}
          } ;
          Object[] prmT00026 ;
          prmT00026 = new Object[] {
          new Object[] {"@PRC_NRO",SqlDbType.Decimal,10,0}
          } ;
          Object[] prmT00027 ;
          prmT00027 = new Object[] {
          new Object[] {"@PRC_NRO",SqlDbType.Decimal,10,0}
          } ;
          Object[] prmT00028 ;
          prmT00028 = new Object[] {
          new Object[] {"@PRC_NRO",SqlDbType.Decimal,10,0}
          } ;
          Object[] prmT00029 ;
          prmT00029 = new Object[] {
          new Object[] {"@PRC_NRO",SqlDbType.Decimal,10,0} ,
          new Object[] {"@PRC_ING",SqlDbType.DateTime,8,5} ,
          new Object[] {"@PRC_INI",SqlDbType.DateTime,8,5} ,
          new Object[] {"@PRC_FIN",SqlDbType.DateTime,8,5} ,
          new Object[] {"@PRC_NOM",SqlDbType.Char,30,0} ,
          new Object[] {"@PRC_DES",SqlDbType.Char,50,0} ,
          new Object[] {"@PRC_INV",SqlDbType.Char,1,0} ,
          new Object[] {"@PRC_PAR",SqlDbType.Char,100,0} ,
          new Object[] {"@PRC_EST",SqlDbType.SmallInt,1,0} ,
          new Object[] {"@PRC_USR",SqlDbType.Char,16,0} ,
          new Object[] {"@PRC_SAL",SqlDbType.Char,100,0} ,
          new Object[] {"@PRC_PRS",SqlDbType.Char,100,0} ,
          new Object[] {"@PRC_MSG",SqlDbType.Char,75,0} ,
          new Object[] {"@PRC_EML",SqlDbType.DateTime,8,5} ,
          new Object[] {"@PRC_SRV",SqlDbType.Char,256,0} ,
          new Object[] {"@PRC_VER",SqlDbType.Char,1,0}
          } ;
          Object[] prmT000210 ;
          prmT000210 = new Object[] {
          new Object[] {"@PRC_ING",SqlDbType.DateTime,8,5} ,
          new Object[] {"@PRC_INI",SqlDbType.DateTime,8,5} ,
          new Object[] {"@PRC_FIN",SqlDbType.DateTime,8,5} ,
          new Object[] {"@PRC_NOM",SqlDbType.Char,30,0} ,
          new Object[] {"@PRC_DES",SqlDbType.Char,50,0} ,
          new Object[] {"@PRC_INV",SqlDbType.Char,1,0} ,
          new Object[] {"@PRC_PAR",SqlDbType.Char,100,0} ,
          new Object[] {"@PRC_EST",SqlDbType.SmallInt,1,0} ,
          new Object[] {"@PRC_USR",SqlDbType.Char,16,0} ,
          new Object[] {"@PRC_SAL",SqlDbType.Char,100,0} ,
          new Object[] {"@PRC_PRS",SqlDbType.Char,100,0} ,
          new Object[] {"@PRC_MSG",SqlDbType.Char,75,0} ,
          new Object[] {"@PRC_EML",SqlDbType.DateTime,8,5} ,
          new Object[] {"@PRC_SRV",SqlDbType.Char,256,0} ,
          new Object[] {"@PRC_VER",SqlDbType.Char,1,0} ,
          new Object[] {"@PRC_NRO",SqlDbType.Decimal,10,0}
          } ;
          Object[] prmT000211 ;
          prmT000211 = new Object[] {
          new Object[] {"@PRC_NRO",SqlDbType.Decimal,10,0}
          } ;
          Object[] prmT000212 ;
          prmT000212 = new Object[] {
          new Object[] {"@PRC_NRO",SqlDbType.Decimal,10,0}
          } ;
          def= new CursorDef[] {
              new CursorDef("T00022", "SELECT [PRC_NRO], [PRC_ING], [PRC_INI], [PRC_FIN], [PRC_NOM], [PRC_DES], [PRC_INV], [PRC_PAR], [PRC_EST], [PRC_USR], [PRC_SAL], [PRC_PRS], [PRC_MSG], [PRC_EML], [PRC_SRV], [PRC_VER] FROM [COL000] WITH (UPDLOCK) WHERE [PRC_NRO] = @PRC_NRO ",true, GxErrorMask.GX_NOMASK, false, this,prmT00022,1,0,true,true )
             ,new CursorDef("T00023", "SELECT [PRC_NRO], [PRC_ING], [PRC_INI], [PRC_FIN], [PRC_NOM], [PRC_DES], [PRC_INV], [PRC_PAR], [PRC_EST], [PRC_USR], [PRC_SAL], [PRC_PRS], [PRC_MSG], [PRC_EML], [PRC_SRV], [PRC_VER] FROM [COL000] WITH (NOLOCK) WHERE [PRC_NRO] = @PRC_NRO ",true, GxErrorMask.GX_NOMASK, false, this,prmT00023,1,0,true,true )
             ,new CursorDef("T00024", "SELECT TM1.[PRC_NRO], TM1.[PRC_ING], TM1.[PRC_INI], TM1.[PRC_FIN], TM1.[PRC_NOM], TM1.[PRC_DES], TM1.[PRC_INV], TM1.[PRC_PAR], TM1.[PRC_EST], TM1.[PRC_USR], TM1.[PRC_SAL], TM1.[PRC_PRS], TM1.[PRC_MSG], TM1.[PRC_EML], TM1.[PRC_SRV], TM1.[PRC_VER] FROM [COL000] TM1 WITH (NOLOCK) WHERE TM1.[PRC_NRO] = @PRC_NRO ORDER BY TM1.[PRC_NRO]  OPTION (FAST 1)",true, GxErrorMask.GX_NOMASK, false, this,prmT00024,1,0,true,true )
             ,new CursorDef("T00025", "SELECT [PRC_NRO] FROM [COL000] WITH (NOLOCK) WHERE [PRC_NRO] = @PRC_NRO  OPTION (FAST 1)",true, GxErrorMask.GX_NOMASK, false, this,prmT00025,1,0,true,true )
             ,new CursorDef("T00026", "SELECT TOP 1 [PRC_NRO] FROM [COL000] WITH (NOLOCK) WHERE [PRC_NRO] = @PRC_NRO ORDER BY [PRC_NRO]  OPTION (FAST 1)",true, GxErrorMask.GX_NOMASK, false, this,prmT00026,1,0,true,true )
             ,new CursorDef("T00027", "SELECT TOP 1 [PRC_NRO] FROM [COL000] WITH (NOLOCK) WHERE [PRC_NRO] = @PRC_NRO ORDER BY [PRC_NRO] DESC  OPTION (FAST 1)",true, GxErrorMask.GX_NOMASK, false, this,prmT00027,1,0,true,true )
             ,new CursorDef("T00028", "SELECT [PRC_NRO], [PRC_ING], [PRC_INI], [PRC_FIN], [PRC_NOM], [PRC_DES], [PRC_INV], [PRC_PAR], [PRC_EST], [PRC_USR], [PRC_SAL], [PRC_PRS], [PRC_MSG], [PRC_EML], [PRC_SRV], [PRC_VER] FROM [COL000] WITH (UPDLOCK) WHERE [PRC_NRO] = @PRC_NRO ",true, GxErrorMask.GX_NOMASK, false, this,prmT00028,1,0,true,true )
             ,new CursorDef("T00029", "INSERT INTO [COL000] ([PRC_NRO], [PRC_ING], [PRC_INI], [PRC_FIN], [PRC_NOM], [PRC_DES], [PRC_INV], [PRC_PAR], [PRC_EST], [PRC_USR], [PRC_SAL], [PRC_PRS], [PRC_MSG], [PRC_EML], [PRC_SRV], [PRC_VER]) VALUES (@PRC_NRO, @PRC_ING, @PRC_INI, @PRC_FIN, @PRC_NOM, @PRC_DES, @PRC_INV, @PRC_PAR, @PRC_EST, @PRC_USR, @PRC_SAL, @PRC_PRS, @PRC_MSG, @PRC_EML, @PRC_SRV, @PRC_VER)", GxErrorMask.GX_NOMASK,prmT00029)
             ,new CursorDef("T000210", "UPDATE [COL000] SET [PRC_ING]=@PRC_ING, [PRC_INI]=@PRC_INI, [PRC_FIN]=@PRC_FIN, [PRC_NOM]=@PRC_NOM, [PRC_DES]=@PRC_DES, [PRC_INV]=@PRC_INV, [PRC_PAR]=@PRC_PAR, [PRC_EST]=@PRC_EST, [PRC_USR]=@PRC_USR, [PRC_SAL]=@PRC_SAL, [PRC_PRS]=@PRC_PRS, [PRC_MSG]=@PRC_MSG, [PRC_EML]=@PRC_EML, [PRC_SRV]=@PRC_SRV, [PRC_VER]=@PRC_VER  WHERE [PRC_NRO] = @PRC_NRO", GxErrorMask.GX_NOMASK,prmT000210)
             ,new CursorDef("T000211", "DELETE FROM [COL000]  WHERE [PRC_NRO] = @PRC_NRO", GxErrorMask.GX_NOMASK,prmT000211)
             ,new CursorDef("T000212", "SELECT [PRC_NRO] FROM [COL000] WITH (NOLOCK) WHERE [PRC_NRO] = @PRC_NRO ORDER BY [PRC_NRO]  OPTION (FAST 100)",true, GxErrorMask.GX_NOMASK, false, this,prmT000212,100,0,true,true )
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
                ((long[]) buf[0])[0] = rslt.getLong(1) ;
                ((DateTime[]) buf[1])[0] = rslt.getGXDateTime(2) ;
                ((DateTime[]) buf[2])[0] = rslt.getGXDateTime(3) ;
                ((DateTime[]) buf[3])[0] = rslt.getGXDateTime(4) ;
                ((String[]) buf[4])[0] = rslt.getString(5, 30) ;
                ((String[]) buf[5])[0] = rslt.getString(6, 50) ;
                ((String[]) buf[6])[0] = rslt.getString(7, 1) ;
                ((String[]) buf[7])[0] = rslt.getString(8, 100) ;
                ((short[]) buf[8])[0] = rslt.getShort(9) ;
                ((String[]) buf[9])[0] = rslt.getString(10, 16) ;
                ((String[]) buf[10])[0] = rslt.getString(11, 100) ;
                ((String[]) buf[11])[0] = rslt.getString(12, 100) ;
                ((String[]) buf[12])[0] = rslt.getString(13, 75) ;
                ((DateTime[]) buf[13])[0] = rslt.getGXDateTime(14) ;
                ((String[]) buf[14])[0] = rslt.getString(15, 256) ;
                ((String[]) buf[15])[0] = rslt.getString(16, 1) ;
                break;
             case 1 :
                ((long[]) buf[0])[0] = rslt.getLong(1) ;
                ((DateTime[]) buf[1])[0] = rslt.getGXDateTime(2) ;
                ((DateTime[]) buf[2])[0] = rslt.getGXDateTime(3) ;
                ((DateTime[]) buf[3])[0] = rslt.getGXDateTime(4) ;
                ((String[]) buf[4])[0] = rslt.getString(5, 30) ;
                ((String[]) buf[5])[0] = rslt.getString(6, 50) ;
                ((String[]) buf[6])[0] = rslt.getString(7, 1) ;
                ((String[]) buf[7])[0] = rslt.getString(8, 100) ;
                ((short[]) buf[8])[0] = rslt.getShort(9) ;
                ((String[]) buf[9])[0] = rslt.getString(10, 16) ;
                ((String[]) buf[10])[0] = rslt.getString(11, 100) ;
                ((String[]) buf[11])[0] = rslt.getString(12, 100) ;
                ((String[]) buf[12])[0] = rslt.getString(13, 75) ;
                ((DateTime[]) buf[13])[0] = rslt.getGXDateTime(14) ;
                ((String[]) buf[14])[0] = rslt.getString(15, 256) ;
                ((String[]) buf[15])[0] = rslt.getString(16, 1) ;
                break;
             case 2 :
                ((long[]) buf[0])[0] = rslt.getLong(1) ;
                ((DateTime[]) buf[1])[0] = rslt.getGXDateTime(2) ;
                ((DateTime[]) buf[2])[0] = rslt.getGXDateTime(3) ;
                ((DateTime[]) buf[3])[0] = rslt.getGXDateTime(4) ;
                ((String[]) buf[4])[0] = rslt.getString(5, 30) ;
                ((String[]) buf[5])[0] = rslt.getString(6, 50) ;
                ((String[]) buf[6])[0] = rslt.getString(7, 1) ;
                ((String[]) buf[7])[0] = rslt.getString(8, 100) ;
                ((short[]) buf[8])[0] = rslt.getShort(9) ;
                ((String[]) buf[9])[0] = rslt.getString(10, 16) ;
                ((String[]) buf[10])[0] = rslt.getString(11, 100) ;
                ((String[]) buf[11])[0] = rslt.getString(12, 100) ;
                ((String[]) buf[12])[0] = rslt.getString(13, 75) ;
                ((DateTime[]) buf[13])[0] = rslt.getGXDateTime(14) ;
                ((String[]) buf[14])[0] = rslt.getString(15, 256) ;
                ((String[]) buf[15])[0] = rslt.getString(16, 1) ;
                break;
             case 3 :
                ((long[]) buf[0])[0] = rslt.getLong(1) ;
                break;
             case 4 :
                ((long[]) buf[0])[0] = rslt.getLong(1) ;
                break;
             case 5 :
                ((long[]) buf[0])[0] = rslt.getLong(1) ;
                break;
             case 6 :
                ((long[]) buf[0])[0] = rslt.getLong(1) ;
                ((DateTime[]) buf[1])[0] = rslt.getGXDateTime(2) ;
                ((DateTime[]) buf[2])[0] = rslt.getGXDateTime(3) ;
                ((DateTime[]) buf[3])[0] = rslt.getGXDateTime(4) ;
                ((String[]) buf[4])[0] = rslt.getString(5, 30) ;
                ((String[]) buf[5])[0] = rslt.getString(6, 50) ;
                ((String[]) buf[6])[0] = rslt.getString(7, 1) ;
                ((String[]) buf[7])[0] = rslt.getString(8, 100) ;
                ((short[]) buf[8])[0] = rslt.getShort(9) ;
                ((String[]) buf[9])[0] = rslt.getString(10, 16) ;
                ((String[]) buf[10])[0] = rslt.getString(11, 100) ;
                ((String[]) buf[11])[0] = rslt.getString(12, 100) ;
                ((String[]) buf[12])[0] = rslt.getString(13, 75) ;
                ((DateTime[]) buf[13])[0] = rslt.getGXDateTime(14) ;
                ((String[]) buf[14])[0] = rslt.getString(15, 256) ;
                ((String[]) buf[15])[0] = rslt.getString(16, 1) ;
                break;
             case 10 :
                ((long[]) buf[0])[0] = rslt.getLong(1) ;
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
                stmt.SetParameter(1, (long)parms[0]);
                break;
             case 1 :
                stmt.SetParameter(1, (long)parms[0]);
                break;
             case 2 :
                stmt.SetParameter(1, (long)parms[0]);
                break;
             case 3 :
                stmt.SetParameter(1, (long)parms[0]);
                break;
             case 4 :
                stmt.SetParameter(1, (long)parms[0]);
                break;
             case 5 :
                stmt.SetParameter(1, (long)parms[0]);
                break;
             case 6 :
                stmt.SetParameter(1, (long)parms[0]);
                break;
             case 7 :
                stmt.SetParameter(1, (long)parms[0]);
                stmt.SetParameter(2, (DateTime)parms[1]);
                stmt.SetParameter(3, (DateTime)parms[2]);
                stmt.SetParameter(4, (DateTime)parms[3]);
                stmt.SetParameter(5, (String)parms[4]);
                stmt.SetParameter(6, (String)parms[5]);
                stmt.SetParameter(7, (String)parms[6]);
                stmt.SetParameter(8, (String)parms[7]);
                stmt.SetParameter(9, (short)parms[8]);
                stmt.SetParameter(10, (String)parms[9]);
                stmt.SetParameter(11, (String)parms[10]);
                stmt.SetParameter(12, (String)parms[11]);
                stmt.SetParameter(13, (String)parms[12]);
                stmt.SetParameter(14, (DateTime)parms[13]);
                stmt.SetParameter(15, (String)parms[14]);
                stmt.SetParameter(16, (String)parms[15]);
                break;
             case 8 :
                stmt.SetParameter(1, (DateTime)parms[0]);
                stmt.SetParameter(2, (DateTime)parms[1]);
                stmt.SetParameter(3, (DateTime)parms[2]);
                stmt.SetParameter(4, (String)parms[3]);
                stmt.SetParameter(5, (String)parms[4]);
                stmt.SetParameter(6, (String)parms[5]);
                stmt.SetParameter(7, (String)parms[6]);
                stmt.SetParameter(8, (short)parms[7]);
                stmt.SetParameter(9, (String)parms[8]);
                stmt.SetParameter(10, (String)parms[9]);
                stmt.SetParameter(11, (String)parms[10]);
                stmt.SetParameter(12, (String)parms[11]);
                stmt.SetParameter(13, (DateTime)parms[12]);
                stmt.SetParameter(14, (String)parms[13]);
                stmt.SetParameter(15, (String)parms[14]);
                stmt.SetParameter(16, (long)parms[15]);
                break;
             case 9 :
                stmt.SetParameter(1, (long)parms[0]);
                break;
             case 10 :
                stmt.SetParameter(1, (long)parms[0]);
                break;
       }
    }

 }

}
