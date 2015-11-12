/*
               File: TTBUS002_c
        Description: Cancelación de Envío de Bien de Uso
             Author: GeneXus C# Generator version 10_1_5-42940
       Generated on: 3/17/2014 13:22:17.86
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
   public class ttbus002_c : GXDataArea, System.Web.SessionState.IRequiresSessionState
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
            AV10TTBUS2_IdMovimiento = (long)(NumberUtil.Val( gxfirstwebparm, ".")) ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV10TTBUS2_IdMovimiento", StringUtil.LTrim( StringUtil.Str( (decimal)(AV10TTBUS2_IdMovimiento), 12, 0)));
            if ( StringUtil.StrCmp(gxfirstwebparm, "viewer") != 0 )
            {
               AV9TTBUS2_IdBien = (int)(NumberUtil.Val( GetNextPar( ), ".")) ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV9TTBUS2_IdBien", StringUtil.LTrim( StringUtil.Str( (decimal)(AV9TTBUS2_IdBien), 8, 0)));
               AV8TTBUS_Descripcion = GetNextPar( ) ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV8TTBUS_Descripcion", AV8TTBUS_Descripcion);
               Gx_mode = GetNextPar( ) ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
               AV7SISTEMA = GetNextPar( ) ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV7SISTEMA", AV7SISTEMA);
               AV11USUARIO = GetNextPar( ) ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV11USUARIO", AV11USUARIO);
            }
         }
         Form.Meta.addItem("Generator", "GeneXus C#", 0) ;
         Form.Meta.addItem("Version", "10_1_5-42940", 0) ;
         Form.Meta.addItem("Description", "Cancelación de Envío de Bien de Uso", 0) ;
         context.wjLoc = "" ;
         context.nUserReturn = 0 ;
         context.wbHandled = 0 ;
         if ( StringUtil.StrCmp(context.GetRequestMethod( ), "POST") == 0 )
         {
         }
         GX_FocusControl = edtTTBUS2_MotivoCancelacion_Internalname ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
         wbErr = false ;
         context.SetTheme("Modern");
      }

      public ttbus002_c( )
      {
         context = new GxContext(  );
         DataStoreUtil.LoadDataStores( context);
         dsDefault = context.GetDataStore("Default") ;
         IsMain = true;
         context.SetTheme("Modern");
      }

      public ttbus002_c( IGxContext context )
      {
         this.context = context;
         IsMain = false;
         dsDefault = context.GetDataStore("Default") ;
      }

      public void release( )
      {
      }

      public void execute( ref long aP0_TTBUS2_IdMovimiento ,
                           ref int aP1_TTBUS2_IdBien ,
                           ref String aP2_TTBUS_Descripcion ,
                           ref String aP3_Gx_mode ,
                           ref String aP4_SISTEMA ,
                           ref String aP5_USUARIO )
      {
         this.AV10TTBUS2_IdMovimiento = aP0_TTBUS2_IdMovimiento;
         this.AV9TTBUS2_IdBien = aP1_TTBUS2_IdBien;
         this.AV8TTBUS_Descripcion = aP2_TTBUS_Descripcion;
         this.Gx_mode = aP3_Gx_mode;
         this.AV7SISTEMA = aP4_SISTEMA;
         this.AV11USUARIO = aP5_USUARIO;
         executePrivate();
         aP0_TTBUS2_IdMovimiento=this.AV10TTBUS2_IdMovimiento;
         aP1_TTBUS2_IdBien=this.AV9TTBUS2_IdBien;
         aP2_TTBUS_Descripcion=this.AV8TTBUS_Descripcion;
         aP3_Gx_mode=this.Gx_mode;
         aP4_SISTEMA=this.AV7SISTEMA;
         aP5_USUARIO=this.AV11USUARIO;
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
            MasterPageObj = (GXMasterPage) ClassLoader.GetInstance("mptrazabilidad", "GeneXus.Programs.mptrazabilidad", new Object[] {new GxContext( context.handle, context.DataStores, context.HttpContext)});
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
            wb_table1_2_045( true) ;
         }
         return  ;
      }

      protected void wb_table1_2_045e( bool wbgen )
      {
         if ( wbgen )
         {
         }
         /* Execute Exit event if defined. */
      }

      protected void wb_table1_2_045( bool wbgen )
      {
         if ( wbgen )
         {
            /* Table start */
            sStyleString = "" ;
            GxWebStd.gx_table_start( context, tblTablemain_Internalname, tblTablemain_Internalname, "", "TableBorder100x100", 0, "", "", 1, 2, sStyleString, "", 0);
            context.WriteHtmlText( "<tbody>") ;
            context.WriteHtmlText( "<tr>") ;
            context.WriteHtmlText( "<td>") ;
            wb_table2_5_045( true) ;
         }
         return  ;
      }

      protected void wb_table2_5_045e( bool wbgen )
      {
         if ( wbgen )
         {
            /* Control Group */
            ClassString = "Group" ;
            StyleString = "" ;
            context.WriteHtmlText( "<fieldset id=\""+grpGroupdata_Internalname+"\""+" style=\"-moz-border-radius:3pt;\""+" class=\""+ClassString+"\">") ;
            context.WriteHtmlText( "<legend class=\""+ClassString+"Title"+"\">"+grpGroupdata_Caption+"</legend>") ;
            wb_table3_10_045( true) ;
         }
         return  ;
      }

      protected void wb_table3_10_045e( bool wbgen )
      {
         if ( wbgen )
         {
            context.WriteHtmlText( "</fieldset>") ;
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "</tbody>") ;
            /* End of table */
            context.WriteHtmlText( "</table>") ;
            wb_table1_2_045e( true) ;
         }
         else
         {
            wb_table1_2_045e( false) ;
         }
      }

      protected void wb_table3_10_045( bool wbgen )
      {
         if ( wbgen )
         {
            /* Table start */
            sStyleString = "" ;
            GxWebStd.gx_table_start( context, tblTable1_Internalname, tblTable1_Internalname, "", "Table", 0, "", "", 1, 2, sStyleString, "", 0);
            context.WriteHtmlText( "<tbody>") ;
            context.WriteHtmlText( "<tr>") ;
            context.WriteHtmlText( "<td>") ;
            ClassString = "ErrorViewer" ;
            StyleString = "" ;
            GxWebStd.gx_msg_list( context, "", context.GX_msglist.DisplayMode, StyleString, ClassString, "", "false");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "<tr>") ;
            context.WriteHtmlText( "<td>") ;
            wb_table4_16_045( true) ;
         }
         return  ;
      }

      protected void wb_table4_16_045e( bool wbgen )
      {
         if ( wbgen )
         {
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "<tr>") ;
            context.WriteHtmlText( "<td>") ;
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 24,'',false,'',0)\"" ;
            ClassString = "BtnEnter" ;
            StyleString = "" ;
            GxWebStd.gx_button_ctrl( context, context.GetButtonType( ), bttBtn_enter_Internalname, "Confirmar", "Confirmar", "", StyleString, ClassString, bttBtn_enter_Visible, bttBtn_enter_Enabled, "rounded", 5, bttBtn_enter_Jsonclick, "EENTER.", TempTags, "", "", "HLP_TTBUS002_c.htm");
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 25,'',false,'',0)\"" ;
            ClassString = "BtnCancel" ;
            StyleString = "" ;
            GxWebStd.gx_button_ctrl( context, context.GetButtonType( ), bttBtn_cancel_Internalname, "Cancelar", "Cancelar", "", StyleString, ClassString, bttBtn_cancel_Visible, 1, "rounded", 1, bttBtn_cancel_Jsonclick, "ECANCEL.", TempTags, "", "", "HLP_TTBUS002_c.htm");
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 26,'',false,'',0)\"" ;
            ClassString = "BtnDelete" ;
            StyleString = "" ;
            GxWebStd.gx_button_ctrl( context, context.GetButtonType( ), bttBtn_delete_Internalname, "Eliminar", "Eliminar", "", StyleString, ClassString, bttBtn_delete_Visible, bttBtn_delete_Enabled, "rounded", 5, bttBtn_delete_Jsonclick, "EDELETE.", TempTags, "", "", "HLP_TTBUS002_c.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "</tbody>") ;
            /* End of table */
            context.WriteHtmlText( "</table>") ;
            wb_table3_10_045e( true) ;
         }
         else
         {
            wb_table3_10_045e( false) ;
         }
      }

      protected void wb_table4_16_045( bool wbgen )
      {
         if ( wbgen )
         {
            /* Table start */
            sStyleString = "" ;
            GxWebStd.gx_table_start( context, tblTable2_Internalname, tblTable2_Internalname, "", "Table", 0, "", "", 1, 2, sStyleString, "", 0);
            context.WriteHtmlText( "<tbody>") ;
            context.WriteHtmlText( "<tr>") ;
            context.WriteHtmlText( "<td valign=\"top\" class=\"td5\" >") ;
            /* Text block */
            ClassString = "TextBlock" ;
            StyleString = "" ;
            GxWebStd.gx_label_ctrl( context, lblTextblockttbus2_motivocancelacion_Internalname, 1, 1, 0, "Motivo de Cancelación", "", "", "", 0, lblTextblockttbus2_motivocancelacion_Jsonclick, "", StyleString, ClassString, "HLP_TTBUS002_c.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "<td>") ;
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 21,'',false,'',0)\"" ;
            ClassString = "Attribute" ;
            StyleString = "" ;
            GxWebStd.gx_single_line_edit( context, edtTTBUS2_MotivoCancelacion_Internalname, StringUtil.RTrim( A50TTBUS2_MotivoCancelacion), "", 80, "chr", 1, "row", 100, 1, edtTTBUS2_MotivoCancelacion_Enabled, 0, 0, 0, "", "", StyleString, ClassString, "", StringUtil.RTrim( context.localUtil.Format( A50TTBUS2_MotivoCancelacion, "@!")), TempTags+" onchange=\"gx.evt.onchange(this)\" "+" onblur=\""+"this.value=this.value.toUpperCase();"+";gx.evt.onblur(21);\"", 0, edtTTBUS2_MotivoCancelacion_Jsonclick, "", 0, 1, -1, true, "left", "HLP_TTBUS002_c.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "</tbody>") ;
            /* End of table */
            context.WriteHtmlText( "</table>") ;
            wb_table4_16_045e( true) ;
         }
         else
         {
            wb_table4_16_045e( false) ;
         }
      }

      protected void wb_table2_5_045( bool wbgen )
      {
         if ( wbgen )
         {
            /* Table start */
            sStyleString = "" ;
            GxWebStd.gx_table_start( context, tblTabletoolbar_Internalname, tblTabletoolbar_Internalname, "", "ViewTable", 0, "", "", 1, 2, sStyleString, "", 0);
            context.WriteHtmlText( "<tbody>") ;
            context.WriteHtmlText( "<tr>") ;
            context.WriteHtmlText( "<td>") ;
            context.WriteHtmlText( "<div style=\"WHITE-SPACE: nowrap\" class=\"ToolbarMain\">") ;
            /* Active images/pictures */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 8,'',false,'',0)\"" ;
            ClassString = "ImageTop" ;
            StyleString = "" ;
            GxWebStd.gx_bitmap( context, imgBtn_first_separator_Internalname, "", context.GetImagePath( "ea7811ba-4fa2-42da-8591-e6cb10669f1f", "", "Modern"), "Modern", imgBtn_first_separator_Visible, 1, "", "", 0, 0, 0, "", 0, "", 0, 0, "", "", 5, imgBtn_first_separator_Jsonclick, "EFIRST.", StyleString, ClassString, "", ""+TempTags, "", "", "HLP_TTBUS002_c.htm");
            context.WriteHtmlText( "</div>") ;
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "</tbody>") ;
            /* End of table */
            context.WriteHtmlText( "</table>") ;
            wb_table2_5_045e( true) ;
         }
         else
         {
            wb_table2_5_045e( false) ;
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
         /* Execute user event: E11042 */
         E11042 ();
         context.wbGlbDoneStart = 1 ;
         assign_properties_default( ) ;
         if ( AnyError == 0 )
         {
            if ( StringUtil.StrCmp(context.GetRequestMethod( ), "POST") == 0 )
            {
               /* Read saved SDTs. */
               /* Read variables values. */
               A50TTBUS2_MotivoCancelacion = StringUtil.Upper( cgiGet( edtTTBUS2_MotivoCancelacion_Internalname)) ;
               n50TTBUS2_MotivoCancelacion = false ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A50TTBUS2_MotivoCancelacion", A50TTBUS2_MotivoCancelacion);
               n50TTBUS2_MotivoCancelacion = (String.IsNullOrEmpty(StringUtil.RTrim( A50TTBUS2_MotivoCancelacion)) ? true : false) ;
               /* Read saved values. */
               Z52TTBUS2_IdMovimiento = (long)(context.localUtil.CToN( cgiGet( "Z52TTBUS2_IdMovimiento"), ",", ".")) ;
               Z50TTBUS2_MotivoCancelacion = cgiGet( "Z50TTBUS2_MotivoCancelacion") ;
               IsConfirmed = (short)(context.localUtil.CToN( cgiGet( "IsConfirmed"), ",", ".")) ;
               IsModified = (short)(context.localUtil.CToN( cgiGet( "IsModified"), ",", ".")) ;
               Gx_mode = cgiGet( "Mode") ;
               AV9TTBUS2_IdBien = (int)(context.localUtil.CToN( cgiGet( "vTTBUS2_IDBIEN"), ",", ".")) ;
               AV8TTBUS_Descripcion = cgiGet( "vTTBUS_DESCRIPCION") ;
               AV7SISTEMA = cgiGet( "vSISTEMA") ;
               AV11USUARIO = cgiGet( "vUSUARIO") ;
               AV10TTBUS2_IdMovimiento = (long)(context.localUtil.CToN( cgiGet( "vTTBUS2_IDMOVIMIENTO"), ",", ".")) ;
               A52TTBUS2_IdMovimiento = (long)(context.localUtil.CToN( cgiGet( "TTBUS2_IDMOVIMIENTO"), ",", ".")) ;
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
                  A52TTBUS2_IdMovimiento = (long)(NumberUtil.Val( GetNextPar( ), ".")) ;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A52TTBUS2_IdMovimiento", StringUtil.LTrim( StringUtil.Str( (decimal)(A52TTBUS2_IdMovimiento), 12, 0)));
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
                     sMode5 = Gx_mode ;
                     Gx_mode = "UPD" ;
                     context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
                     Gx_mode = sMode5 ;
                     context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
                  }
                  standaloneModal( ) ;
                  if ( StringUtil.StrCmp(Gx_mode, "INS") != 0 )
                  {
                     getByPrimaryKey( ) ;
                     if ( RcdFound5 == 1 )
                     {
                        if ( StringUtil.StrCmp(Gx_mode, "DLT") == 0 )
                        {
                           /* Confirm record */
                           CONFIRM_040( ) ;
                           if ( AnyError == 0 )
                           {
                              GX_FocusControl = bttBtn_enter_Internalname ;
                              context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
                           }
                        }
                     }
                     else
                     {
                        GX_msglist.addItem(context.GetMessage( "GXM_noinsert"), 1, "");
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
                           /* Execute user event: E11042 */
                           E11042 ();
                        }
                        else if ( StringUtil.StrCmp(sEvt, "AFTER TRN") == 0 )
                        {
                           context.wbHandled = 1 ;
                           dynload_actions( ) ;
                           /* Execute user event: E12042 */
                           E12042 ();
                        }
                        else if ( StringUtil.StrCmp(sEvt, "ENTER") == 0 )
                        {
                           context.wbHandled = 1 ;
                           btn_enter( ) ;
                           /* No code required for Cancel button. It is implemented as the Reset button. */
                        }
                        else if ( StringUtil.StrCmp(sEvt, "FIRST") == 0 )
                        {
                           context.wbHandled = 1 ;
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
            /* Execute user event: E12042 */
            E12042 ();
            trnEnded = 0 ;
            standaloneNotModal( ) ;
            standaloneModal( ) ;
            if ( ( StringUtil.StrCmp(Gx_mode, "INS") == 0 )  )
            {
               /* Clear variables for new insertion. */
               InitAll045( ) ;
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
         imgBtn_first_separator_Visible = 0 ;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, imgBtn_first_separator_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(imgBtn_first_separator_Visible), 5, 0)));
         if ( ( StringUtil.StrCmp(Gx_mode, "DSP") == 0 ) || ( StringUtil.StrCmp(Gx_mode, "DLT") == 0 ) )
         {
            bttBtn_delete_Visible = 0 ;
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, bttBtn_delete_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(bttBtn_delete_Visible), 5, 0)));
            if ( StringUtil.StrCmp(Gx_mode, "DSP") == 0 )
            {
               bttBtn_enter_Visible = 0 ;
               context.httpAjaxContext.ajax_rsp_assign_prop("", false, bttBtn_enter_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(bttBtn_enter_Visible), 5, 0)));
            }
            edtTTBUS2_MotivoCancelacion_Enabled = 0 ;
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtTTBUS2_MotivoCancelacion_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtTTBUS2_MotivoCancelacion_Enabled), 5, 0)));
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

      protected void CONFIRM_040( )
      {
         BeforeValidate045( ) ;
         if ( AnyError == 0 )
         {
            if ( StringUtil.StrCmp(Gx_mode, "DLT") == 0 )
            {
               OnDeleteControls045( ) ;
            }
            else
            {
               CheckExtendedTable045( ) ;
               CloseExtendedTableCursors045( ) ;
            }
         }
         if ( AnyError == 0 )
         {
            IsConfirmed = 1 ;
         }
      }

      protected void ResetCaption040( )
      {
      }

      protected void E11042( )
      {
         /* Start Routine */
         grpGroupdata_Caption = "Cancelación de Envío de Bien de Uso Nº"+StringUtil.Trim( StringUtil.Str( (decimal)(AV9TTBUS2_IdBien), 8, 0))+": \""+StringUtil.Trim( AV8TTBUS_Descripcion)+"\"" ;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, grpGroupdata_Internalname, "Caption", grpGroupdata_Caption);
      }

      protected void E12042( )
      {
         /* After Trn Routine */
         new ptbus003(context ).execute( ref  A52TTBUS2_IdMovimiento, ref  AV9TTBUS2_IdBien, ref  AV11USUARIO) ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A52TTBUS2_IdMovimiento", StringUtil.LTrim( StringUtil.Str( (decimal)(A52TTBUS2_IdMovimiento), 12, 0)));
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV9TTBUS2_IdBien", StringUtil.LTrim( StringUtil.Str( (decimal)(AV9TTBUS2_IdBien), 8, 0)));
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV11USUARIO", AV11USUARIO);
      }

      protected void ZM045( short GX_JID )
      {
         if ( ( GX_JID == 3 ) || ( GX_JID == 0 ) )
         {
            if ( StringUtil.StrCmp(Gx_mode, "INS") != 0 )
            {
               Z50TTBUS2_MotivoCancelacion = T00043_A50TTBUS2_MotivoCancelacion[0] ;
            }
            else
            {
               Z50TTBUS2_MotivoCancelacion = A50TTBUS2_MotivoCancelacion ;
            }
         }
         if ( GX_JID == -3 )
         {
            Z52TTBUS2_IdMovimiento = A52TTBUS2_IdMovimiento ;
            Z50TTBUS2_MotivoCancelacion = A50TTBUS2_MotivoCancelacion ;
         }
      }

      protected void standaloneNotModal( )
      {
         bttBtn_delete_Enabled = 0 ;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, bttBtn_delete_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(bttBtn_delete_Enabled), 5, 0)));
         if ( StringUtil.StrCmp(Gx_mode, "INS") != 0 )
         {
            A52TTBUS2_IdMovimiento = AV10TTBUS2_IdMovimiento ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A52TTBUS2_IdMovimiento", StringUtil.LTrim( StringUtil.Str( (decimal)(A52TTBUS2_IdMovimiento), 12, 0)));
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
      }

      protected void Load045( )
      {
         /* Using cursor T00044 */
         pr_default.execute(2, new Object[] {A52TTBUS2_IdMovimiento});
         if ( (pr_default.getStatus(2) != 101) )
         {
            RcdFound5 = 1 ;
            A50TTBUS2_MotivoCancelacion = T00044_A50TTBUS2_MotivoCancelacion[0] ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A50TTBUS2_MotivoCancelacion", A50TTBUS2_MotivoCancelacion);
            n50TTBUS2_MotivoCancelacion = T00044_n50TTBUS2_MotivoCancelacion[0] ;
            ZM045( -3) ;
         }
         pr_default.close(2);
         OnLoadActions045( ) ;
      }

      protected void OnLoadActions045( )
      {
      }

      protected void CheckExtendedTable045( )
      {
         Gx_BScreen = 1 ;
         standaloneModal( ) ;
         if ( ( ( StringUtil.StrCmp(StringUtil.Trim( A50TTBUS2_MotivoCancelacion), "") == 0 ) ) && ( true /* After */ ) )
         {
            GX_msglist.addItem("DEBE INGRESAR UN MOTIVO DE CANCELACIÓN DE ENVÍO.", 1, "");
            AnyError = 1 ;
         }
      }

      protected void CloseExtendedTableCursors045( )
      {
      }

      protected void enableDisable( )
      {
      }

      protected void GetKey045( )
      {
         /* Using cursor T00045 */
         pr_default.execute(3, new Object[] {A52TTBUS2_IdMovimiento});
         if ( (pr_default.getStatus(3) != 101) )
         {
            RcdFound5 = 1 ;
         }
         else
         {
            RcdFound5 = 0 ;
         }
         pr_default.close(3);
      }

      protected void getByPrimaryKey( )
      {
         /* Using cursor T00043 */
         pr_default.execute(1, new Object[] {A52TTBUS2_IdMovimiento});
         if ( (pr_default.getStatus(1) != 101) )
         {
            ZM045( 3) ;
            RcdFound5 = 1 ;
            A52TTBUS2_IdMovimiento = T00043_A52TTBUS2_IdMovimiento[0] ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A52TTBUS2_IdMovimiento", StringUtil.LTrim( StringUtil.Str( (decimal)(A52TTBUS2_IdMovimiento), 12, 0)));
            A50TTBUS2_MotivoCancelacion = T00043_A50TTBUS2_MotivoCancelacion[0] ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A50TTBUS2_MotivoCancelacion", A50TTBUS2_MotivoCancelacion);
            n50TTBUS2_MotivoCancelacion = T00043_n50TTBUS2_MotivoCancelacion[0] ;
            Z52TTBUS2_IdMovimiento = A52TTBUS2_IdMovimiento ;
            sMode5 = Gx_mode ;
            Gx_mode = "DSP" ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
            Load045( ) ;
            Gx_mode = sMode5 ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
         }
         else
         {
            RcdFound5 = 0 ;
            InitializeNonKey045( ) ;
            sMode5 = Gx_mode ;
            Gx_mode = "DSP" ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
            standaloneModal( ) ;
            Gx_mode = sMode5 ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
         }
         pr_default.close(1);
      }

      protected void getEqualNoModal( )
      {
         GetKey045( ) ;
         if ( RcdFound5 == 0 )
         {
         }
         else
         {
         }
         getByPrimaryKey( ) ;
      }

      protected void move_next( )
      {
         RcdFound5 = 0 ;
         /* Using cursor T00046 */
         pr_default.execute(4, new Object[] {A52TTBUS2_IdMovimiento});
         if ( (pr_default.getStatus(4) != 101) )
         {
            while ( (pr_default.getStatus(4) != 101) && ( ( T00046_A52TTBUS2_IdMovimiento[0] < A52TTBUS2_IdMovimiento ) ) )
            {
               pr_default.readNext(4);
            }
            if ( (pr_default.getStatus(4) != 101) && ( ( T00046_A52TTBUS2_IdMovimiento[0] > A52TTBUS2_IdMovimiento ) ) )
            {
               A52TTBUS2_IdMovimiento = T00046_A52TTBUS2_IdMovimiento[0] ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A52TTBUS2_IdMovimiento", StringUtil.LTrim( StringUtil.Str( (decimal)(A52TTBUS2_IdMovimiento), 12, 0)));
               RcdFound5 = 1 ;
            }
         }
         pr_default.close(1);
      }

      protected void move_previous( )
      {
         RcdFound5 = 0 ;
         /* Using cursor T00047 */
         pr_default.execute(5, new Object[] {A52TTBUS2_IdMovimiento});
         if ( (pr_default.getStatus(5) != 101) )
         {
            while ( (pr_default.getStatus(5) != 101) && ( ( T00047_A52TTBUS2_IdMovimiento[0] > A52TTBUS2_IdMovimiento ) ) )
            {
               pr_default.readNext(5);
            }
            if ( (pr_default.getStatus(5) != 101) && ( ( T00047_A52TTBUS2_IdMovimiento[0] < A52TTBUS2_IdMovimiento ) ) )
            {
               A52TTBUS2_IdMovimiento = T00047_A52TTBUS2_IdMovimiento[0] ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A52TTBUS2_IdMovimiento", StringUtil.LTrim( StringUtil.Str( (decimal)(A52TTBUS2_IdMovimiento), 12, 0)));
               RcdFound5 = 1 ;
            }
         }
         pr_default.close(0);
      }

      protected void btn_enter( )
      {
         nKeyPressed = 1 ;
         GetKey045( ) ;
         if ( RcdFound5 == 1 )
         {
            if ( StringUtil.StrCmp(Gx_mode, "INS") == 0 )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_noupdate"), "DuplicatePrimaryKey", 1, "");
               AnyError = 1 ;
            }
            else if ( A52TTBUS2_IdMovimiento != Z52TTBUS2_IdMovimiento )
            {
               A52TTBUS2_IdMovimiento = Z52TTBUS2_IdMovimiento ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A52TTBUS2_IdMovimiento", StringUtil.LTrim( StringUtil.Str( (decimal)(A52TTBUS2_IdMovimiento), 12, 0)));
               GX_msglist.addItem(context.GetMessage( "GXM_getbeforeupd"), "CandidateKeyNotFound", 1, "");
               AnyError = 1 ;
            }
            else if ( StringUtil.StrCmp(Gx_mode, "DLT") == 0 )
            {
               delete( ) ;
               AfterTrn( ) ;
               GX_FocusControl = edtTTBUS2_MotivoCancelacion_Internalname ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
            }
            else
            {
               /* Update record */
               Update045( ) ;
               GX_FocusControl = edtTTBUS2_MotivoCancelacion_Internalname ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
            }
         }
         else
         {
            if ( A52TTBUS2_IdMovimiento != Z52TTBUS2_IdMovimiento )
            {
               /* Insert record */
               Insert045( ) ;
               GX_FocusControl = edtTTBUS2_MotivoCancelacion_Internalname ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
            }
            else
            {
               if ( StringUtil.StrCmp(Gx_mode, "UPD") == 0 )
               {
                  GX_msglist.addItem(context.GetMessage( "GXM_recdeleted"), 1, "");
                  AnyError = 1 ;
               }
               else
               {
                  /* Insert record */
                  Insert045( ) ;
                  GX_FocusControl = edtTTBUS2_MotivoCancelacion_Internalname ;
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
         if ( A52TTBUS2_IdMovimiento != Z52TTBUS2_IdMovimiento )
         {
            A52TTBUS2_IdMovimiento = Z52TTBUS2_IdMovimiento ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A52TTBUS2_IdMovimiento", StringUtil.LTrim( StringUtil.Str( (decimal)(A52TTBUS2_IdMovimiento), 12, 0)));
            GX_msglist.addItem(context.GetMessage( "GXM_getbeforedlt"), 1, "");
            AnyError = 1 ;
         }
         else
         {
            delete( ) ;
            AfterTrn( ) ;
            GX_FocusControl = edtTTBUS2_MotivoCancelacion_Internalname ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
         }
         if ( AnyError != 0 )
         {
         }
      }

      protected void CheckOptimisticConcurrency045( )
      {
         if ( StringUtil.StrCmp(Gx_mode, "INS") != 0 )
         {
            /* Using cursor T00048 */
            pr_default.execute(6, new Object[] {A52TTBUS2_IdMovimiento});
            if ( (pr_default.getStatus(6) == 103) )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_lock", new   object[]  {"TTBUS002"}), "RecordIsLocked", 1, "");
               AnyError = 1 ;
               return  ;
            }
            if ( (pr_default.getStatus(6) == 101) || ( StringUtil.StrCmp(Z50TTBUS2_MotivoCancelacion, T00048_A50TTBUS2_MotivoCancelacion[0]) != 0 ) )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_waschg", new   object[]  {"TTBUS002"}), "RecordWasChanged", 1, "");
               AnyError = 1 ;
               return  ;
            }
         }
      }

      protected void Insert045( )
      {
         BeforeValidate045( ) ;
         if ( AnyError == 0 )
         {
            CheckExtendedTable045( ) ;
         }
         if ( AnyError == 0 )
         {
            ZM045( 0) ;
            CheckOptimisticConcurrency045( ) ;
            if ( AnyError == 0 )
            {
               AfterConfirm045( ) ;
               if ( AnyError == 0 )
               {
                  BeforeInsert045( ) ;
                  if ( AnyError == 0 )
                  {
                     /* Using cursor T00049 */
                     pr_default.execute(7, new Object[] {n50TTBUS2_MotivoCancelacion, A50TTBUS2_MotivoCancelacion});
                     pr_default.close(7);
                     /* Retrieving last key number assigned */
                     /* Using cursor T000410 */
                     pr_default.execute(8);
                     A52TTBUS2_IdMovimiento = T000410_A52TTBUS2_IdMovimiento[0] ;
                     context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A52TTBUS2_IdMovimiento", StringUtil.LTrim( StringUtil.Str( (decimal)(A52TTBUS2_IdMovimiento), 12, 0)));
                     pr_default.close(8);
                     if ( AnyError == 0 )
                     {
                        /* Start of After( Insert) rules */
                        /* End of After( Insert) rules */
                        if ( AnyError == 0 )
                        {
                           /* Save values for previous() function. */
                           GX_msglist.addItem(context.GetMessage( "GXM_sucadded"), 0, "");
                           ResetCaption040( ) ;
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
               Load045( ) ;
            }
            EndLevel045( ) ;
         }
         CloseExtendedTableCursors045( ) ;
      }

      protected void Update045( )
      {
         BeforeValidate045( ) ;
         if ( AnyError == 0 )
         {
            CheckExtendedTable045( ) ;
         }
         if ( AnyError == 0 )
         {
            CheckOptimisticConcurrency045( ) ;
            if ( AnyError == 0 )
            {
               AfterConfirm045( ) ;
               if ( AnyError == 0 )
               {
                  BeforeUpdate045( ) ;
                  if ( AnyError == 0 )
                  {
                     /* Using cursor T000411 */
                     pr_default.execute(9, new Object[] {n50TTBUS2_MotivoCancelacion, A50TTBUS2_MotivoCancelacion, A52TTBUS2_IdMovimiento});
                     pr_default.close(9);
                     if ( (pr_default.getStatus(9) == 103) )
                     {
                        GX_msglist.addItem(context.GetMessage( "GXM_lock", new   object[]  {"TTBUS002"}), "RecordIsLocked", 1, "");
                        AnyError = 1 ;
                     }
                     DeferredUpdate045( ) ;
                     if ( AnyError == 0 )
                     {
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
            EndLevel045( ) ;
         }
         CloseExtendedTableCursors045( ) ;
      }

      protected void DeferredUpdate045( )
      {
      }

      protected void delete( )
      {
         BeforeValidate045( ) ;
         if ( AnyError == 0 )
         {
            CheckOptimisticConcurrency045( ) ;
         }
         if ( AnyError == 0 )
         {
            OnDeleteControls045( ) ;
            AfterConfirm045( ) ;
            if ( AnyError == 0 )
            {
               BeforeDelete045( ) ;
               if ( AnyError == 0 )
               {
                  /* No cascading delete specified. */
                  /* Using cursor T000412 */
                  pr_default.execute(10, new Object[] {A52TTBUS2_IdMovimiento});
                  pr_default.close(10);
                  if ( AnyError == 0 )
                  {
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
         sMode5 = Gx_mode ;
         Gx_mode = "DLT" ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
         EndLevel045( ) ;
         Gx_mode = sMode5 ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
      }

      protected void OnDeleteControls045( )
      {
         standaloneModal( ) ;
         /* No delete mode formulas found. */
         if ( AnyError == 0 )
         {
            /* Using cursor T000413 */
            pr_default.execute(11, new Object[] {A52TTBUS2_IdMovimiento});
            if ( (pr_default.getStatus(11) != 101) )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_del", new   object[]  {"Detalle de Movimientos de Bienes de Uso"}), "CannotDeleteReferencedRecord", 1, "");
               AnyError = 1 ;
            }
            pr_default.close(11);
         }
      }

      protected void EndLevel045( )
      {
         if ( StringUtil.StrCmp(Gx_mode, "INS") != 0 )
         {
            pr_default.close(6);
         }
         if ( AnyError == 0 )
         {
            BeforeComplete045( ) ;
         }
         if ( AnyError == 0 )
         {
            pr_default.close(5);
            pr_default.close(4);
            context.CommitDataStores("TTBUS002_c");
            if ( AnyError == 0 )
            {
               ConfirmValues040( ) ;
            }
            /* After transaction rules */
            /* Execute 'After Trn' event if defined. */
            trnEnded = 1 ;
         }
         else
         {
            pr_default.close(5);
            pr_default.close(4);
            context.RollbackDataStores("TTBUS002_c");
         }
         IsModified = 0 ;
         if ( AnyError != 0 )
         {
            context.wjLoc = "" ;
            context.nUserReturn = 0 ;
         }
      }

      protected void ScanStart045( )
      {
         /* Using cursor T000414 */
         pr_default.execute(12);
         RcdFound5 = 0 ;
         if ( (pr_default.getStatus(12) != 101) )
         {
            RcdFound5 = 1 ;
            A52TTBUS2_IdMovimiento = T000414_A52TTBUS2_IdMovimiento[0] ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A52TTBUS2_IdMovimiento", StringUtil.LTrim( StringUtil.Str( (decimal)(A52TTBUS2_IdMovimiento), 12, 0)));
         }
         /* Load Subordinate Levels */
      }

      protected void ScanNext045( )
      {
         pr_default.readNext(12);
         RcdFound5 = 0 ;
         if ( (pr_default.getStatus(12) != 101) )
         {
            RcdFound5 = 1 ;
            A52TTBUS2_IdMovimiento = T000414_A52TTBUS2_IdMovimiento[0] ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A52TTBUS2_IdMovimiento", StringUtil.LTrim( StringUtil.Str( (decimal)(A52TTBUS2_IdMovimiento), 12, 0)));
         }
      }

      protected void ScanEnd045( )
      {
      }

      protected void AfterConfirm045( )
      {
         /* After Confirm Rules */
      }

      protected void BeforeInsert045( )
      {
         /* Before Insert Rules */
      }

      protected void BeforeUpdate045( )
      {
         /* Before Update Rules */
      }

      protected void BeforeDelete045( )
      {
         /* Before Delete Rules */
      }

      protected void BeforeComplete045( )
      {
         /* Before Complete Rules */
      }

      protected void BeforeValidate045( )
      {
         /* Before Validate Rules */
      }

      protected void assign_properties_default( )
      {
      }

      protected void ConfirmValues040( )
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
         context.WriteHtmlTextNl( "<form id=\"MAINFORM\" onsubmit=\"try{return gx.csv.validForm()}catch(e){return true;}\" name=\"MAINFORM\" method=\"post\" action=\""+formatLink("ttbus002_c.aspx") + "?" + UrlEncode("" +AV10TTBUS2_IdMovimiento) + "," + UrlEncode("" +AV9TTBUS2_IdBien) + "," + UrlEncode(StringUtil.RTrim(AV8TTBUS_Descripcion)) + "," + UrlEncode(StringUtil.RTrim(Gx_mode)) + "," + UrlEncode(StringUtil.RTrim(AV7SISTEMA)) + "," + UrlEncode(StringUtil.RTrim(AV11USUARIO))+"\" class=\""+"Form"+"\">") ;
         GxWebStd.gx_hidden_field( context, "_EventName", "");
         GxWebStd.gx_hidden_field( context, "_EventGridId", "");
         GxWebStd.gx_hidden_field( context, "_EventRowId", "");
      }

      public override void RenderHtmlCloseForm( )
      {
         /* Send hidden variables. */
         /* Send saved values. */
         GxWebStd.gx_hidden_field( context, "Z52TTBUS2_IdMovimiento", StringUtil.LTrim( StringUtil.NToC( (decimal)(Z52TTBUS2_IdMovimiento), 12, 0, ",", "")));
         GxWebStd.gx_hidden_field( context, "Z50TTBUS2_MotivoCancelacion", StringUtil.RTrim( Z50TTBUS2_MotivoCancelacion));
         GxWebStd.gx_hidden_field( context, "IsConfirmed", StringUtil.LTrim( StringUtil.NToC( (decimal)(IsConfirmed), 4, 0, ",", "")));
         GxWebStd.gx_hidden_field( context, "IsModified", StringUtil.LTrim( StringUtil.NToC( (decimal)(IsModified), 4, 0, ",", "")));
         GxWebStd.gx_hidden_field( context, "Mode", StringUtil.RTrim( Gx_mode));
         GxWebStd.gx_hidden_field( context, "vTTBUS2_IDBIEN", StringUtil.LTrim( StringUtil.NToC( (decimal)(AV9TTBUS2_IdBien), 8, 0, ",", "")));
         GxWebStd.gx_hidden_field( context, "vTTBUS_DESCRIPCION", StringUtil.RTrim( AV8TTBUS_Descripcion));
         GxWebStd.gx_hidden_field( context, "vSISTEMA", StringUtil.RTrim( AV7SISTEMA));
         GxWebStd.gx_hidden_field( context, "vUSUARIO", StringUtil.RTrim( AV11USUARIO));
         GxWebStd.gx_hidden_field( context, "vTTBUS2_IDMOVIMIENTO", StringUtil.LTrim( StringUtil.NToC( (decimal)(AV10TTBUS2_IdMovimiento), 12, 0, ",", "")));
         GxWebStd.gx_hidden_field( context, "TTBUS2_IDMOVIMIENTO", StringUtil.LTrim( StringUtil.NToC( (decimal)(A52TTBUS2_IdMovimiento), 12, 0, ",", "")));
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
         return "TTBUS002_c" ;
      }

      public override String GetPgmdesc( )
      {
         return "Cancelación de Envío de Bien de Uso" ;
      }

      public override GXWebForm GetForm( )
      {
         return Form ;
      }

      public override String GetSelfLink( )
      {
         return formatLink("ttbus002_c.aspx") + "?" + UrlEncode("" +AV10TTBUS2_IdMovimiento) + "," + UrlEncode("" +AV9TTBUS2_IdBien) + "," + UrlEncode(StringUtil.RTrim(AV8TTBUS_Descripcion)) + "," + UrlEncode(StringUtil.RTrim(Gx_mode)) + "," + UrlEncode(StringUtil.RTrim(AV7SISTEMA)) + "," + UrlEncode(StringUtil.RTrim(AV11USUARIO)) ;
      }

      protected void InitializeNonKey045( )
      {
         A50TTBUS2_MotivoCancelacion = "" ;
         n50TTBUS2_MotivoCancelacion = false ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A50TTBUS2_MotivoCancelacion", A50TTBUS2_MotivoCancelacion);
         n50TTBUS2_MotivoCancelacion = (String.IsNullOrEmpty(StringUtil.RTrim( A50TTBUS2_MotivoCancelacion)) ? true : false) ;
      }

      protected void InitAll045( )
      {
         A52TTBUS2_IdMovimiento = 0 ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A52TTBUS2_IdMovimiento", StringUtil.LTrim( StringUtil.Str( (decimal)(A52TTBUS2_IdMovimiento), 12, 0)));
         InitializeNonKey045( ) ;
      }

      protected void StandaloneModalInsert( )
      {
      }

      protected void define_styles( )
      {
         AddThemeStyleSheetFile("", "Modern.css", "?2051812");
         idxLst = 1 ;
         while ( idxLst <= Form.Jscriptsrc.Count )
         {
            context.AddJavascriptSource(StringUtil.RTrim( Form.Jscriptsrc.Item(idxLst)), "?13221826");
            idxLst = (int)(idxLst+1) ;
         }
         /* End function define_styles */
      }

      protected void include_jscripts( )
      {
         context.AddJavascriptSource("messages.spa.js", "?42940");
         context.AddJavascriptSource("ttbus002_c.js", "?13221826");
         /* End function include_jscripts */
      }

      protected void init_default_properties( )
      {
         imgBtn_first_separator_Internalname = "BTN_FIRST_SEPARATOR" ;
         tblTabletoolbar_Internalname = "TABLETOOLBAR" ;
         lblTextblockttbus2_motivocancelacion_Internalname = "TEXTBLOCKTTBUS2_MOTIVOCANCELACION" ;
         edtTTBUS2_MotivoCancelacion_Internalname = "TTBUS2_MOTIVOCANCELACION" ;
         tblTable2_Internalname = "TABLE2" ;
         bttBtn_enter_Internalname = "BTN_ENTER" ;
         bttBtn_cancel_Internalname = "BTN_CANCEL" ;
         bttBtn_delete_Internalname = "BTN_DELETE" ;
         tblTable1_Internalname = "TABLE1" ;
         grpGroupdata_Internalname = "GROUPDATA" ;
         tblTablemain_Internalname = "TABLEMAIN" ;
         Form.Internalname = "FORM" ;
      }

      public override void initialize_properties( )
      {
         init_default_properties( ) ;
         Form.Headerrawhtml = "" ;
         Form.Background = "" ;
         Form.Backcolor = (int)(0xFFFFFF) ;
         Form.Caption = "Cancelación de Envío de Bien de Uso" ;
         imgBtn_first_separator_Visible = 1 ;
         edtTTBUS2_MotivoCancelacion_Jsonclick = "" ;
         edtTTBUS2_MotivoCancelacion_Enabled = 1 ;
         bttBtn_delete_Enabled = 0 ;
         bttBtn_delete_Visible = 1 ;
         bttBtn_cancel_Visible = 1 ;
         bttBtn_enter_Enabled = 1 ;
         bttBtn_enter_Visible = 1 ;
         grpGroupdata_Caption = "" ;
         context.GX_msglist.DisplayMode = 1 ;
      }

      protected void dynload_actions( )
      {
         /* End function dynload_actions */
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
         wcpOAV8TTBUS_Descripcion = "" ;
         wcpOGx_mode = "" ;
         wcpOAV7SISTEMA = "" ;
         wcpOAV11USUARIO = "" ;
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
         bttBtn_delete_Jsonclick = "" ;
         lblTextblockttbus2_motivocancelacion_Jsonclick = "" ;
         A50TTBUS2_MotivoCancelacion = "" ;
         imgBtn_first_separator_Jsonclick = "" ;
         Z50TTBUS2_MotivoCancelacion = "" ;
         sMode5 = "" ;
         sEvt = "" ;
         EvtGridId = "" ;
         EvtRowId = "" ;
         sEvtType = "" ;
         T00044_A52TTBUS2_IdMovimiento = new long[1] ;
         T00044_A50TTBUS2_MotivoCancelacion = new String[] {""} ;
         T00044_n50TTBUS2_MotivoCancelacion = new bool[] {false} ;
         T00045_A52TTBUS2_IdMovimiento = new long[1] ;
         T00043_A52TTBUS2_IdMovimiento = new long[1] ;
         T00043_A50TTBUS2_MotivoCancelacion = new String[] {""} ;
         T00043_n50TTBUS2_MotivoCancelacion = new bool[] {false} ;
         T00046_A52TTBUS2_IdMovimiento = new long[1] ;
         T00047_A52TTBUS2_IdMovimiento = new long[1] ;
         T00048_A52TTBUS2_IdMovimiento = new long[1] ;
         T00048_A50TTBUS2_MotivoCancelacion = new String[] {""} ;
         T00048_n50TTBUS2_MotivoCancelacion = new bool[] {false} ;
         T000410_A52TTBUS2_IdMovimiento = new long[1] ;
         T000413_A52TTBUS2_IdMovimiento = new long[1] ;
         T000413_A53TTBUS2_IdUsuario = new String[] {""} ;
         T000414_A52TTBUS2_IdMovimiento = new long[1] ;
         sDynURL = "" ;
         FormProcess = "" ;
         GXt_char2 = "" ;
         GXt_char1 = "" ;
         GXt_char3 = "" ;
         pr_default = new DataStoreProvider(context, new GeneXus.Programs.ttbus002_c__default(),
            new Object[][] {
                new Object[] {
               T00042_A52TTBUS2_IdMovimiento, T00042_A50TTBUS2_MotivoCancelacion, T00042_n50TTBUS2_MotivoCancelacion
               }
               , new Object[] {
               T00043_A52TTBUS2_IdMovimiento, T00043_A50TTBUS2_MotivoCancelacion, T00043_n50TTBUS2_MotivoCancelacion
               }
               , new Object[] {
               T00044_A52TTBUS2_IdMovimiento, T00044_A50TTBUS2_MotivoCancelacion, T00044_n50TTBUS2_MotivoCancelacion
               }
               , new Object[] {
               T00045_A52TTBUS2_IdMovimiento
               }
               , new Object[] {
               T00046_A52TTBUS2_IdMovimiento
               }
               , new Object[] {
               T00047_A52TTBUS2_IdMovimiento
               }
               , new Object[] {
               T00048_A52TTBUS2_IdMovimiento, T00048_A50TTBUS2_MotivoCancelacion, T00048_n50TTBUS2_MotivoCancelacion
               }
               , new Object[] {
               }
               , new Object[] {
               T000410_A52TTBUS2_IdMovimiento
               }
               , new Object[] {
               }
               , new Object[] {
               }
               , new Object[] {
               T000413_A52TTBUS2_IdMovimiento, T000413_A53TTBUS2_IdUsuario
               }
               , new Object[] {
               T000414_A52TTBUS2_IdMovimiento
               }
            }
         );
      }

      private short GxWebError ;
      private short IsConfirmed ;
      private short IsModified ;
      private short AnyError ;
      private short nKeyPressed ;
      private short initialized ;
      private short RcdFound5 ;
      private short GX_JID ;
      private short Gx_BScreen ;
      private short gxajaxcallmode ;
      private int wcpOAV9TTBUS2_IdBien ;
      private int AV9TTBUS2_IdBien ;
      private int trnEnded ;
      private int bttBtn_enter_Visible ;
      private int bttBtn_enter_Enabled ;
      private int bttBtn_cancel_Visible ;
      private int bttBtn_delete_Visible ;
      private int bttBtn_delete_Enabled ;
      private int edtTTBUS2_MotivoCancelacion_Enabled ;
      private int imgBtn_first_separator_Visible ;
      private int idxLst ;
      private long wcpOAV10TTBUS2_IdMovimiento ;
      private long AV10TTBUS2_IdMovimiento ;
      private long Z52TTBUS2_IdMovimiento ;
      private long A52TTBUS2_IdMovimiento ;
      private String sPrefix ;
      private String wcpOGx_mode ;
      private String wcpOAV7SISTEMA ;
      private String wcpOAV11USUARIO ;
      private String scmdbuf ;
      private String gxfirstwebparm ;
      private String gxfirstwebparm_bkp ;
      private String Gx_mode ;
      private String AV7SISTEMA ;
      private String AV11USUARIO ;
      private String PreviousTooltip ;
      private String PreviousCaption ;
      private String GX_FocusControl ;
      private String edtTTBUS2_MotivoCancelacion_Internalname ;
      private String sStyleString ;
      private String tblTablemain_Internalname ;
      private String ClassString ;
      private String StyleString ;
      private String grpGroupdata_Internalname ;
      private String grpGroupdata_Caption ;
      private String tblTable1_Internalname ;
      private String TempTags ;
      private String bttBtn_enter_Internalname ;
      private String bttBtn_enter_Jsonclick ;
      private String bttBtn_cancel_Internalname ;
      private String bttBtn_cancel_Jsonclick ;
      private String bttBtn_delete_Internalname ;
      private String bttBtn_delete_Jsonclick ;
      private String tblTable2_Internalname ;
      private String lblTextblockttbus2_motivocancelacion_Internalname ;
      private String lblTextblockttbus2_motivocancelacion_Jsonclick ;
      private String edtTTBUS2_MotivoCancelacion_Jsonclick ;
      private String tblTabletoolbar_Internalname ;
      private String imgBtn_first_separator_Internalname ;
      private String imgBtn_first_separator_Jsonclick ;
      private String sMode5 ;
      private String sEvt ;
      private String EvtGridId ;
      private String EvtRowId ;
      private String sEvtType ;
      private String sDynURL ;
      private String FormProcess ;
      private String GXt_char2 ;
      private String GXt_char1 ;
      private String GXt_char3 ;
      private bool entryPointCalled ;
      private bool wbErr ;
      private bool n50TTBUS2_MotivoCancelacion ;
      private String wcpOAV8TTBUS_Descripcion ;
      private String AV8TTBUS_Descripcion ;
      private String A50TTBUS2_MotivoCancelacion ;
      private String Z50TTBUS2_MotivoCancelacion ;
      private GXMasterPage MasterPageObj ;
      private IGxDataStore dsDefault ;
      private long aP0_TTBUS2_IdMovimiento ;
      private int aP1_TTBUS2_IdBien ;
      private String aP2_TTBUS_Descripcion ;
      private String aP3_Gx_mode ;
      private String aP4_SISTEMA ;
      private String aP5_USUARIO ;
      private IDataStoreProvider pr_default ;
      private long[] T00044_A52TTBUS2_IdMovimiento ;
      private String[] T00044_A50TTBUS2_MotivoCancelacion ;
      private bool[] T00044_n50TTBUS2_MotivoCancelacion ;
      private long[] T00045_A52TTBUS2_IdMovimiento ;
      private long[] T00043_A52TTBUS2_IdMovimiento ;
      private String[] T00043_A50TTBUS2_MotivoCancelacion ;
      private bool[] T00043_n50TTBUS2_MotivoCancelacion ;
      private long[] T00046_A52TTBUS2_IdMovimiento ;
      private long[] T00047_A52TTBUS2_IdMovimiento ;
      private long[] T00048_A52TTBUS2_IdMovimiento ;
      private String[] T00048_A50TTBUS2_MotivoCancelacion ;
      private bool[] T00048_n50TTBUS2_MotivoCancelacion ;
      private long[] T000410_A52TTBUS2_IdMovimiento ;
      private long[] T000413_A52TTBUS2_IdMovimiento ;
      private String[] T000413_A53TTBUS2_IdUsuario ;
      private long[] T000414_A52TTBUS2_IdMovimiento ;
      private long[] T00042_A52TTBUS2_IdMovimiento ;
      private String[] T00042_A50TTBUS2_MotivoCancelacion ;
      private bool[] T00042_n50TTBUS2_MotivoCancelacion ;
      private GXWebForm Form ;
   }

   public class ttbus002_c__default : DataStoreHelperBase, IDataStoreHelper
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
       };
    }

    private static CursorDef[] def;
    private void cursorDefinitions( )
    {
       if ( def == null )
       {
          Object[] prmT00042 ;
          prmT00042 = new Object[] {
          new Object[] {"@TTBUS2_IdMovimiento",SqlDbType.Decimal,12,0}
          } ;
          Object[] prmT00044 ;
          prmT00044 = new Object[] {
          new Object[] {"@TTBUS2_IdMovimiento",SqlDbType.Decimal,12,0}
          } ;
          Object[] prmT00045 ;
          prmT00045 = new Object[] {
          new Object[] {"@TTBUS2_IdMovimiento",SqlDbType.Decimal,12,0}
          } ;
          Object[] prmT00043 ;
          prmT00043 = new Object[] {
          new Object[] {"@TTBUS2_IdMovimiento",SqlDbType.Decimal,12,0}
          } ;
          Object[] prmT00046 ;
          prmT00046 = new Object[] {
          new Object[] {"@TTBUS2_IdMovimiento",SqlDbType.Decimal,12,0}
          } ;
          Object[] prmT00047 ;
          prmT00047 = new Object[] {
          new Object[] {"@TTBUS2_IdMovimiento",SqlDbType.Decimal,12,0}
          } ;
          Object[] prmT00048 ;
          prmT00048 = new Object[] {
          new Object[] {"@TTBUS2_IdMovimiento",SqlDbType.Decimal,12,0}
          } ;
          Object[] prmT00049 ;
          prmT00049 = new Object[] {
          new Object[] {"@TTBUS2_MotivoCancelacion",SqlDbType.VarChar,100,0}
          } ;
          Object[] prmT000410 ;
          prmT000410 = new Object[] {
          } ;
          Object[] prmT000411 ;
          prmT000411 = new Object[] {
          new Object[] {"@TTBUS2_MotivoCancelacion",SqlDbType.VarChar,100,0} ,
          new Object[] {"@TTBUS2_IdMovimiento",SqlDbType.Decimal,12,0}
          } ;
          Object[] prmT000412 ;
          prmT000412 = new Object[] {
          new Object[] {"@TTBUS2_IdMovimiento",SqlDbType.Decimal,12,0}
          } ;
          Object[] prmT000413 ;
          prmT000413 = new Object[] {
          new Object[] {"@TTBUS2_IdMovimiento",SqlDbType.Decimal,12,0}
          } ;
          Object[] prmT000414 ;
          prmT000414 = new Object[] {
          } ;
          def= new CursorDef[] {
              new CursorDef("T00042", "SELECT [TTBUS2_IdMovimiento], [TTBUS2_MotivoCancelacion] FROM [TTBUS002] WITH (UPDLOCK) WHERE [TTBUS2_IdMovimiento] = @TTBUS2_IdMovimiento ",true, GxErrorMask.GX_NOMASK, false, this,prmT00042,1,0,true,false )
             ,new CursorDef("T00043", "SELECT [TTBUS2_IdMovimiento], [TTBUS2_MotivoCancelacion] FROM [TTBUS002] WITH (NOLOCK) WHERE [TTBUS2_IdMovimiento] = @TTBUS2_IdMovimiento ",true, GxErrorMask.GX_NOMASK, false, this,prmT00043,1,0,true,false )
             ,new CursorDef("T00044", "SELECT TM1.[TTBUS2_IdMovimiento], TM1.[TTBUS2_MotivoCancelacion] FROM [TTBUS002] TM1 WITH (NOLOCK) WHERE TM1.[TTBUS2_IdMovimiento] = @TTBUS2_IdMovimiento ORDER BY TM1.[TTBUS2_IdMovimiento]  OPTION (FAST 100)",true, GxErrorMask.GX_NOMASK, false, this,prmT00044,100,0,true,false )
             ,new CursorDef("T00045", "SELECT [TTBUS2_IdMovimiento] FROM [TTBUS002] WITH (NOLOCK) WHERE [TTBUS2_IdMovimiento] = @TTBUS2_IdMovimiento  OPTION (FAST 1)",true, GxErrorMask.GX_NOMASK, false, this,prmT00045,1,0,true,false )
             ,new CursorDef("T00046", "SELECT TOP 1 [TTBUS2_IdMovimiento] FROM [TTBUS002] WITH (NOLOCK) WHERE ( [TTBUS2_IdMovimiento] > @TTBUS2_IdMovimiento) ORDER BY [TTBUS2_IdMovimiento]  OPTION (FAST 1)",true, GxErrorMask.GX_NOMASK, false, this,prmT00046,1,0,true,true )
             ,new CursorDef("T00047", "SELECT TOP 1 [TTBUS2_IdMovimiento] FROM [TTBUS002] WITH (NOLOCK) WHERE ( [TTBUS2_IdMovimiento] < @TTBUS2_IdMovimiento) ORDER BY [TTBUS2_IdMovimiento] DESC  OPTION (FAST 1)",true, GxErrorMask.GX_NOMASK, false, this,prmT00047,1,0,true,true )
             ,new CursorDef("T00048", "SELECT [TTBUS2_IdMovimiento], [TTBUS2_MotivoCancelacion] FROM [TTBUS002] WITH (UPDLOCK) WHERE [TTBUS2_IdMovimiento] = @TTBUS2_IdMovimiento ",true, GxErrorMask.GX_NOMASK, false, this,prmT00048,1,0,true,false )
             ,new CursorDef("T00049", "INSERT INTO [TTBUS002] ([TTBUS2_MotivoCancelacion], [TTBUS2_IdBien], [TTBUS2_CodPosDesde], [TTBUS2_RespDesde], [TTBUS2_FechaEnvio], [TTBUS2_CodPosHacia], [TTBUS2_RespHacia], [TTBUS2_FechaRecepcion], [TTBUS2_EstadoEnvio], [TTBUS2_MotivoEnvio], [TTBUS2_Observaciones], [TTBUS2_PlazoRecepcion]) VALUES (@TTBUS2_MotivoCancelacion, convert(int, 0), convert(int, 0), '', convert( DATETIME, '17530101', 112 ), convert(int, 0), '', convert( DATETIME, '17530101', 112 ), convert(int, 0), '', '', convert( DATETIME, '17530101', 112 ))", GxErrorMask.GX_NOMASK,prmT00049)
             ,new CursorDef("T000410", "SELECT Ident_Current('[TTBUS002]') ",true, GxErrorMask.GX_NOMASK, false, this,prmT000410,1,0,true,false )
             ,new CursorDef("T000411", "UPDATE [TTBUS002] SET [TTBUS2_MotivoCancelacion]=@TTBUS2_MotivoCancelacion  WHERE [TTBUS2_IdMovimiento] = @TTBUS2_IdMovimiento", GxErrorMask.GX_NOMASK,prmT000411)
             ,new CursorDef("T000412", "DELETE FROM [TTBUS002]  WHERE [TTBUS2_IdMovimiento] = @TTBUS2_IdMovimiento", GxErrorMask.GX_NOMASK,prmT000412)
             ,new CursorDef("T000413", "SELECT TOP 1 [TTBUS2_IdMovimiento], [TTBUS2_IdUsuario] FROM [TTBUS002_Det] WITH (NOLOCK) WHERE [TTBUS2_IdMovimiento] = @TTBUS2_IdMovimiento ",true, GxErrorMask.GX_NOMASK, false, this,prmT000413,1,0,true,true )
             ,new CursorDef("T000414", "SELECT [TTBUS2_IdMovimiento] FROM [TTBUS002] WITH (NOLOCK) ORDER BY [TTBUS2_IdMovimiento]  OPTION (FAST 100)",true, GxErrorMask.GX_NOMASK, false, this,prmT000414,100,0,true,false )
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
                ((String[]) buf[1])[0] = rslt.getVarchar(2) ;
                ((bool[]) buf[2])[0] = rslt.wasNull(2);
                break;
             case 1 :
                ((long[]) buf[0])[0] = rslt.getLong(1) ;
                ((String[]) buf[1])[0] = rslt.getVarchar(2) ;
                ((bool[]) buf[2])[0] = rslt.wasNull(2);
                break;
             case 2 :
                ((long[]) buf[0])[0] = rslt.getLong(1) ;
                ((String[]) buf[1])[0] = rslt.getVarchar(2) ;
                ((bool[]) buf[2])[0] = rslt.wasNull(2);
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
                ((String[]) buf[1])[0] = rslt.getVarchar(2) ;
                ((bool[]) buf[2])[0] = rslt.wasNull(2);
                break;
             case 8 :
                ((long[]) buf[0])[0] = rslt.getLong(1) ;
                break;
             case 11 :
                ((long[]) buf[0])[0] = rslt.getLong(1) ;
                ((String[]) buf[1])[0] = rslt.getString(2, 16) ;
                break;
             case 12 :
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
                if ( (bool)parms[0] )
                {
                   stmt.setNull( 1 , SqlDbType.VarChar );
                }
                else
                {
                   stmt.SetParameter(1, (String)parms[1]);
                }
                break;
             case 9 :
                if ( (bool)parms[0] )
                {
                   stmt.setNull( 1 , SqlDbType.VarChar );
                }
                else
                {
                   stmt.SetParameter(1, (String)parms[1]);
                }
                stmt.SetParameter(2, (long)parms[2]);
                break;
             case 10 :
                stmt.SetParameter(1, (long)parms[0]);
                break;
             case 11 :
                stmt.SetParameter(1, (long)parms[0]);
                break;
       }
    }

 }

}
