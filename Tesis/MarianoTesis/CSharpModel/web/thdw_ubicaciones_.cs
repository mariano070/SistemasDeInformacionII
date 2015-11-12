/*
               File: THDW_UBICACIONES_
        Description: Ubicaciones Hardware
             Author: GeneXus C# Generator version 10_1_5-42940
       Generated on: 1/6/2014 11:19:36.36
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
   public class thdw_ubicaciones_ : GXDataArea, System.Web.SessionState.IRequiresSessionState
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
            AV8THDW_UBI_COD_ = (short)(NumberUtil.Val( gxfirstwebparm, ".")) ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV8THDW_UBI_COD_", StringUtil.LTrim( StringUtil.Str( (decimal)(AV8THDW_UBI_COD_), 4, 0)));
            if ( StringUtil.StrCmp(gxfirstwebparm, "viewer") != 0 )
            {
               Gx_mode = GetNextPar( ) ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
               AV7SISTEMA = GetNextPar( ) ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV7SISTEMA", AV7SISTEMA);
               AV9USUARIO = GetNextPar( ) ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV9USUARIO", AV9USUARIO);
            }
         }
         Form.Meta.addItem("Generator", "GeneXus C#", 0) ;
         Form.Meta.addItem("Version", "10_1_5-42940", 0) ;
         Form.Meta.addItem("Description", "Ubicaciones Hardware", 0) ;
         context.wjLoc = "" ;
         context.nUserReturn = 0 ;
         context.wbHandled = 0 ;
         if ( StringUtil.StrCmp(context.GetRequestMethod( ), "POST") == 0 )
         {
         }
         GX_FocusControl = edtTHDW_UBI_DESC__Internalname ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
         wbErr = false ;
         context.SetTheme("Modern");
      }

      public thdw_ubicaciones_( )
      {
         context = new GxContext(  );
         DataStoreUtil.LoadDataStores( context);
         dsDESARROLLO = context.GetDataStore("DESARROLLO") ;
         dssoporte_notebook = context.GetDataStore("soporte_notebook") ;
         dsDefault = context.GetDataStore("Default") ;
         IsMain = true;
         context.SetTheme("Modern");
      }

      public thdw_ubicaciones_( IGxContext context )
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

      public void execute( ref short aP0_THDW_UBI_COD_ ,
                           ref String aP1_Gx_mode ,
                           ref String aP2_SISTEMA ,
                           ref String aP3_USUARIO )
      {
         this.AV8THDW_UBI_COD_ = aP0_THDW_UBI_COD_;
         this.Gx_mode = aP1_Gx_mode;
         this.AV7SISTEMA = aP2_SISTEMA;
         this.AV9USUARIO = aP3_USUARIO;
         executePrivate();
         aP0_THDW_UBI_COD_=this.AV8THDW_UBI_COD_;
         aP1_Gx_mode=this.Gx_mode;
         aP2_SISTEMA=this.AV7SISTEMA;
         aP3_USUARIO=this.AV9USUARIO;
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
            wb_table1_2_0Q26( true) ;
         }
         return  ;
      }

      protected void wb_table1_2_0Q26e( bool wbgen )
      {
         if ( wbgen )
         {
         }
         /* Execute Exit event if defined. */
      }

      protected void wb_table1_2_0Q26( bool wbgen )
      {
         if ( wbgen )
         {
            /* Table start */
            sStyleString = "" ;
            GxWebStd.gx_table_start( context, tblTablemain_Internalname, tblTablemain_Internalname, "", "TableBorder100x100", 0, "", "", 1, 2, sStyleString, "", 0);
            context.WriteHtmlText( "<tbody>") ;
            context.WriteHtmlText( "<tr>") ;
            context.WriteHtmlText( "<td>") ;
            wb_table2_5_0Q26( true) ;
         }
         return  ;
      }

      protected void wb_table2_5_0Q26e( bool wbgen )
      {
         if ( wbgen )
         {
            /* Control Group */
            ClassString = "Group" ;
            StyleString = "" ;
            context.WriteHtmlText( "<fieldset id=\""+grpGroupdata_Internalname+"\""+" style=\"-moz-border-radius:3pt;\""+" class=\""+ClassString+"\">") ;
            context.WriteHtmlText( "<legend class=\""+ClassString+"Title"+"\">"+"Ubicaciones de Hardware"+"</legend>") ;
            wb_table3_11_0Q26( true) ;
         }
         return  ;
      }

      protected void wb_table3_11_0Q26e( bool wbgen )
      {
         if ( wbgen )
         {
            context.WriteHtmlText( "</fieldset>") ;
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "</tbody>") ;
            /* End of table */
            context.WriteHtmlText( "</table>") ;
            wb_table1_2_0Q26e( true) ;
         }
         else
         {
            wb_table1_2_0Q26e( false) ;
         }
      }

      protected void wb_table3_11_0Q26( bool wbgen )
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
            wb_table4_17_0Q26( true) ;
         }
         return  ;
      }

      protected void wb_table4_17_0Q26e( bool wbgen )
      {
         if ( wbgen )
         {
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "<tr>") ;
            context.WriteHtmlText( "<td>") ;
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 30,'',false,'',0)\"" ;
            ClassString = "BtnDelete" ;
            StyleString = "" ;
            GxWebStd.gx_button_ctrl( context, context.GetButtonType( ), bttBtn_delete_Internalname, "Eliminar", "Eliminar", "", StyleString, ClassString, bttBtn_delete_Visible, bttBtn_delete_Enabled, "rounded", 5, bttBtn_delete_Jsonclick, "EDELETE.", TempTags, "", "", "HLP_THDW_UBICACIONES_.htm");
            context.WriteHtmlText( "&nbsp; ") ;
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 31,'',false,'',0)\"" ;
            ClassString = "BtnCancel" ;
            StyleString = "" ;
            GxWebStd.gx_button_ctrl( context, context.GetButtonType( ), bttBtn_cancel_Internalname, "Cancelar", "Cancelar", "", StyleString, ClassString, bttBtn_cancel_Visible, 1, "rounded", 1, bttBtn_cancel_Jsonclick, "ECANCEL.", TempTags, "", "", "HLP_THDW_UBICACIONES_.htm");
            context.WriteHtmlText( "&nbsp; ") ;
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 32,'',false,'',0)\"" ;
            ClassString = "BtnEnter" ;
            StyleString = "" ;
            GxWebStd.gx_button_ctrl( context, context.GetButtonType( ), bttBtn_enter_Internalname, "Confirmar", "Confirmar", "", StyleString, ClassString, bttBtn_enter_Visible, bttBtn_enter_Enabled, "rounded", 5, bttBtn_enter_Jsonclick, "EENTER.", TempTags, "", "", "HLP_THDW_UBICACIONES_.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "</tbody>") ;
            /* End of table */
            context.WriteHtmlText( "</table>") ;
            wb_table3_11_0Q26e( true) ;
         }
         else
         {
            wb_table3_11_0Q26e( false) ;
         }
      }

      protected void wb_table4_17_0Q26( bool wbgen )
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
            GxWebStd.gx_label_ctrl( context, lblTextblockthdw_ubi_cod__Internalname, 1, 1, 0, "Cod.Ubicación", "", "", "", 0, lblTextblockthdw_ubi_cod__Jsonclick, "", StyleString, ClassString, "HLP_THDW_UBICACIONES_.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "<td>") ;
            /* Single line edit */
            ClassString = "Attribute" ;
            StyleString = "" ;
            GxWebStd.gx_single_line_edit( context, edtTHDW_UBI_COD__Internalname, StringUtil.LTrim( StringUtil.NToC( (decimal)(A306THDW_UBI_COD_), 10, 0, ",", "")), "", 10, "chr", 1, "row", 10, 1, edtTHDW_UBI_COD__Enabled, 0, 0, 0, "", "", StyleString, ClassString, "", context.localUtil.Format( (decimal)(A306THDW_UBI_COD_), "ZZZZZZZZZ9"), "", 0, edtTHDW_UBI_COD__Jsonclick, "", 0, 1, -1, true, "right", "HLP_THDW_UBICACIONES_.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "<tr>") ;
            context.WriteHtmlText( "<td valign=\"top\" class=\"td5\" >") ;
            /* Text block */
            ClassString = "TextBlock" ;
            StyleString = "" ;
            GxWebStd.gx_label_ctrl( context, lblTextblockthdw_ubi_desc__Internalname, 1, 1, 0, "Desc. Ubicación", "", "", "", 0, lblTextblockthdw_ubi_desc__Jsonclick, "", StyleString, ClassString, "HLP_THDW_UBICACIONES_.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "<td>") ;
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 27,'',false,'',0)\"" ;
            ClassString = "Attribute" ;
            StyleString = "" ;
            GxWebStd.gx_single_line_edit( context, edtTHDW_UBI_DESC__Internalname, StringUtil.RTrim( A307THDW_UBI_DESC_), "", 30, "chr", 1, "row", 30, 1, edtTHDW_UBI_DESC__Enabled, 0, 0, 0, "", "", StyleString, ClassString, "", StringUtil.RTrim( context.localUtil.Format( A307THDW_UBI_DESC_, "XXXXXXXXXXXXXXXXXXXXXXXXXXXXXX")), TempTags+" onchange=\"gx.evt.onchange(this)\" "+" onblur=\""+""+";gx.evt.onblur(27);\"", 0, edtTHDW_UBI_DESC__Jsonclick, "", 0, 1, -1, true, "left", "HLP_THDW_UBICACIONES_.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "</tbody>") ;
            /* End of table */
            context.WriteHtmlText( "</table>") ;
            wb_table4_17_0Q26e( true) ;
         }
         else
         {
            wb_table4_17_0Q26e( false) ;
         }
      }

      protected void wb_table2_5_0Q26( bool wbgen )
      {
         if ( wbgen )
         {
            /* Table start */
            sStyleString = "" ;
            GxWebStd.gx_table_start( context, tblTabletoolbar_Internalname, tblTabletoolbar_Internalname, "", "ViewTable", 0, "", "", 1, 2, sStyleString, "", 0);
            context.WriteHtmlText( "<tbody>") ;
            context.WriteHtmlText( "<tr>") ;
            context.WriteHtmlText( "<td>") ;
            context.WriteHtmlText( "<div style=\"WHITE-SPACE: nowrap\" class=\"ToolbarMain\"/>") ;
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "<tr>") ;
            context.WriteHtmlText( "<td>") ;
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "</tbody>") ;
            /* End of table */
            context.WriteHtmlText( "</table>") ;
            wb_table2_5_0Q26e( true) ;
         }
         else
         {
            wb_table2_5_0Q26e( false) ;
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
         /* Execute user event: E110Q2 */
         E110Q2 ();
         context.wbGlbDoneStart = 1 ;
         assign_properties_default( ) ;
         if ( AnyError == 0 )
         {
            if ( StringUtil.StrCmp(context.GetRequestMethod( ), "POST") == 0 )
            {
               /* Read saved SDTs. */
               /* Read variables values. */
               A306THDW_UBI_COD_ = (long)(context.localUtil.CToN( cgiGet( edtTHDW_UBI_COD__Internalname), ",", ".")) ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A306THDW_UBI_COD_", StringUtil.LTrim( StringUtil.Str( (decimal)(A306THDW_UBI_COD_), 10, 0)));
               A307THDW_UBI_DESC_ = cgiGet( edtTHDW_UBI_DESC__Internalname) ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A307THDW_UBI_DESC_", A307THDW_UBI_DESC_);
               /* Read saved values. */
               Z306THDW_UBI_COD_ = (long)(context.localUtil.CToN( cgiGet( "Z306THDW_UBI_COD_"), ",", ".")) ;
               Z307THDW_UBI_DESC_ = cgiGet( "Z307THDW_UBI_DESC_") ;
               IsConfirmed = (short)(context.localUtil.CToN( cgiGet( "IsConfirmed"), ",", ".")) ;
               IsModified = (short)(context.localUtil.CToN( cgiGet( "IsModified"), ",", ".")) ;
               Gx_mode = cgiGet( "Mode") ;
               AV7SISTEMA = cgiGet( "vSISTEMA") ;
               AV9USUARIO = cgiGet( "vUSUARIO") ;
               AV8THDW_UBI_COD_ = (short)(context.localUtil.CToN( cgiGet( "vTHDW_UBI_COD_"), ",", ".")) ;
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
                  A306THDW_UBI_COD_ = (long)(NumberUtil.Val( GetNextPar( ), ".")) ;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A306THDW_UBI_COD_", StringUtil.LTrim( StringUtil.Str( (decimal)(A306THDW_UBI_COD_), 10, 0)));
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
                     sMode26 = Gx_mode ;
                     Gx_mode = "UPD" ;
                     context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
                     Gx_mode = sMode26 ;
                     context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
                  }
                  standaloneModal( ) ;
                  if ( StringUtil.StrCmp(Gx_mode, "INS") != 0 )
                  {
                     getByPrimaryKey( ) ;
                     if ( RcdFound26 == 1 )
                     {
                        if ( StringUtil.StrCmp(Gx_mode, "DLT") == 0 )
                        {
                           /* Confirm record */
                           CONFIRM_0Q0( ) ;
                           if ( AnyError == 0 )
                           {
                              GX_FocusControl = bttBtn_enter_Internalname ;
                              context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
                           }
                        }
                     }
                     else
                     {
                        GX_msglist.addItem(context.GetMessage( "GXM_noinsert"), 1, "THDW_UBI_COD_");
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
                           /* Execute user event: E110Q2 */
                           E110Q2 ();
                        }
                        else if ( StringUtil.StrCmp(sEvt, "ENTER") == 0 )
                        {
                           context.wbHandled = 1 ;
                           btn_enter( ) ;
                           /* No code required for Cancel button. It is implemented as the Reset button. */
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
            trnEnded = 0 ;
            standaloneNotModal( ) ;
            standaloneModal( ) ;
            if ( ( StringUtil.StrCmp(Gx_mode, "INS") == 0 )  )
            {
               /* Clear variables for new insertion. */
               InitAll0Q26( ) ;
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
         if ( ( StringUtil.StrCmp(Gx_mode, "DSP") == 0 ) || ( StringUtil.StrCmp(Gx_mode, "DLT") == 0 ) )
         {
            bttBtn_delete_Visible = 0 ;
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, bttBtn_delete_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(bttBtn_delete_Visible), 5, 0)));
            if ( StringUtil.StrCmp(Gx_mode, "DSP") == 0 )
            {
               bttBtn_enter_Visible = 0 ;
               context.httpAjaxContext.ajax_rsp_assign_prop("", false, bttBtn_enter_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(bttBtn_enter_Visible), 5, 0)));
            }
            edtTHDW_UBI_COD__Enabled = 0 ;
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtTHDW_UBI_COD__Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtTHDW_UBI_COD__Enabled), 5, 0)));
            edtTHDW_UBI_DESC__Enabled = 0 ;
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtTHDW_UBI_DESC__Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtTHDW_UBI_DESC__Enabled), 5, 0)));
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

      protected void CONFIRM_0Q0( )
      {
         BeforeValidate0Q26( ) ;
         if ( AnyError == 0 )
         {
            if ( StringUtil.StrCmp(Gx_mode, "DLT") == 0 )
            {
               OnDeleteControls0Q26( ) ;
            }
            else
            {
               CheckExtendedTable0Q26( ) ;
               CloseExtendedTableCursors0Q26( ) ;
            }
         }
         if ( AnyError == 0 )
         {
            IsConfirmed = 1 ;
         }
      }

      protected void ResetCaption0Q0( )
      {
      }

      protected void E110Q2( )
      {
         /* Start Routine */
      }

      protected void ZM0Q26( short GX_JID )
      {
         if ( ( GX_JID == 4 ) || ( GX_JID == 0 ) )
         {
            if ( StringUtil.StrCmp(Gx_mode, "INS") != 0 )
            {
               Z307THDW_UBI_DESC_ = T000Q3_A307THDW_UBI_DESC_[0] ;
            }
            else
            {
               Z307THDW_UBI_DESC_ = A307THDW_UBI_DESC_ ;
            }
         }
         if ( GX_JID == -4 )
         {
            Z306THDW_UBI_COD_ = A306THDW_UBI_COD_ ;
            Z307THDW_UBI_DESC_ = A307THDW_UBI_DESC_ ;
         }
      }

      protected void standaloneNotModal( )
      {
         edtTHDW_UBI_COD__Enabled = 0 ;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtTHDW_UBI_COD__Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtTHDW_UBI_COD__Enabled), 5, 0)));
         edtTHDW_UBI_COD__Enabled = 0 ;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtTHDW_UBI_COD__Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtTHDW_UBI_COD__Enabled), 5, 0)));
         bttBtn_delete_Enabled = 0 ;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, bttBtn_delete_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(bttBtn_delete_Enabled), 5, 0)));
         if ( StringUtil.StrCmp(Gx_mode, "INS") != 0 )
         {
            A306THDW_UBI_COD_ = AV8THDW_UBI_COD_ ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A306THDW_UBI_COD_", StringUtil.LTrim( StringUtil.Str( (decimal)(A306THDW_UBI_COD_), 10, 0)));
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

      protected void Load0Q26( )
      {
         /* Using cursor T000Q4 */
         pr_default.execute(2, new Object[] {A306THDW_UBI_COD_});
         if ( (pr_default.getStatus(2) != 101) )
         {
            RcdFound26 = 1 ;
            A307THDW_UBI_DESC_ = T000Q4_A307THDW_UBI_DESC_[0] ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A307THDW_UBI_DESC_", A307THDW_UBI_DESC_);
            ZM0Q26( -4) ;
         }
         pr_default.close(2);
         OnLoadActions0Q26( ) ;
      }

      protected void OnLoadActions0Q26( )
      {
      }

      protected void CheckExtendedTable0Q26( )
      {
         Gx_BScreen = 1 ;
         standaloneModal( ) ;
         if ( ( StringUtil.StrCmp(StringUtil.Trim( A307THDW_UBI_DESC_), "") == 0 ) && true /* After */ )
         {
            GX_msglist.addItem("Debe ingresar una descripción.", 1, "");
            AnyError = 1 ;
         }
      }

      protected void CloseExtendedTableCursors0Q26( )
      {
      }

      protected void enableDisable( )
      {
      }

      protected void GetKey0Q26( )
      {
         /* Using cursor T000Q5 */
         pr_default.execute(3, new Object[] {A306THDW_UBI_COD_});
         if ( (pr_default.getStatus(3) != 101) )
         {
            RcdFound26 = 1 ;
         }
         else
         {
            RcdFound26 = 0 ;
         }
         pr_default.close(3);
      }

      protected void getByPrimaryKey( )
      {
         /* Using cursor T000Q3 */
         pr_default.execute(1, new Object[] {A306THDW_UBI_COD_});
         if ( (pr_default.getStatus(1) != 101) )
         {
            ZM0Q26( 4) ;
            RcdFound26 = 1 ;
            A306THDW_UBI_COD_ = T000Q3_A306THDW_UBI_COD_[0] ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A306THDW_UBI_COD_", StringUtil.LTrim( StringUtil.Str( (decimal)(A306THDW_UBI_COD_), 10, 0)));
            A307THDW_UBI_DESC_ = T000Q3_A307THDW_UBI_DESC_[0] ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A307THDW_UBI_DESC_", A307THDW_UBI_DESC_);
            Z306THDW_UBI_COD_ = A306THDW_UBI_COD_ ;
            sMode26 = Gx_mode ;
            Gx_mode = "DSP" ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
            Load0Q26( ) ;
            Gx_mode = sMode26 ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
         }
         else
         {
            RcdFound26 = 0 ;
            InitializeNonKey0Q26( ) ;
            sMode26 = Gx_mode ;
            Gx_mode = "DSP" ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
            standaloneModal( ) ;
            Gx_mode = sMode26 ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
         }
         pr_default.close(1);
      }

      protected void getEqualNoModal( )
      {
         GetKey0Q26( ) ;
         if ( RcdFound26 == 0 )
         {
         }
         else
         {
         }
         getByPrimaryKey( ) ;
      }

      protected void move_next( )
      {
         RcdFound26 = 0 ;
         /* Using cursor T000Q6 */
         pr_default.execute(4, new Object[] {A306THDW_UBI_COD_});
         if ( (pr_default.getStatus(4) != 101) )
         {
            while ( (pr_default.getStatus(4) != 101) && ( ( T000Q6_A306THDW_UBI_COD_[0] < A306THDW_UBI_COD_ ) ) )
            {
               pr_default.readNext(4);
            }
            if ( (pr_default.getStatus(4) != 101) && ( ( T000Q6_A306THDW_UBI_COD_[0] > A306THDW_UBI_COD_ ) ) )
            {
               A306THDW_UBI_COD_ = T000Q6_A306THDW_UBI_COD_[0] ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A306THDW_UBI_COD_", StringUtil.LTrim( StringUtil.Str( (decimal)(A306THDW_UBI_COD_), 10, 0)));
               RcdFound26 = 1 ;
            }
         }
         pr_default.close(1);
      }

      protected void move_previous( )
      {
         RcdFound26 = 0 ;
         /* Using cursor T000Q7 */
         pr_default.execute(5, new Object[] {A306THDW_UBI_COD_});
         if ( (pr_default.getStatus(5) != 101) )
         {
            while ( (pr_default.getStatus(5) != 101) && ( ( T000Q7_A306THDW_UBI_COD_[0] > A306THDW_UBI_COD_ ) ) )
            {
               pr_default.readNext(5);
            }
            if ( (pr_default.getStatus(5) != 101) && ( ( T000Q7_A306THDW_UBI_COD_[0] < A306THDW_UBI_COD_ ) ) )
            {
               A306THDW_UBI_COD_ = T000Q7_A306THDW_UBI_COD_[0] ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A306THDW_UBI_COD_", StringUtil.LTrim( StringUtil.Str( (decimal)(A306THDW_UBI_COD_), 10, 0)));
               RcdFound26 = 1 ;
            }
         }
         pr_default.close(0);
      }

      protected void btn_enter( )
      {
         nKeyPressed = 1 ;
         GetKey0Q26( ) ;
         if ( RcdFound26 == 1 )
         {
            if ( StringUtil.StrCmp(Gx_mode, "INS") == 0 )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_noupdate"), "DuplicatePrimaryKey", 1, "THDW_UBI_COD_");
               AnyError = 1 ;
            }
            else if ( A306THDW_UBI_COD_ != Z306THDW_UBI_COD_ )
            {
               A306THDW_UBI_COD_ = Z306THDW_UBI_COD_ ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A306THDW_UBI_COD_", StringUtil.LTrim( StringUtil.Str( (decimal)(A306THDW_UBI_COD_), 10, 0)));
               GX_msglist.addItem(context.GetMessage( "GXM_getbeforeupd"), "CandidateKeyNotFound", 1, "THDW_UBI_COD_");
               AnyError = 1 ;
            }
            else if ( StringUtil.StrCmp(Gx_mode, "DLT") == 0 )
            {
               delete( ) ;
               AfterTrn( ) ;
               GX_FocusControl = edtTHDW_UBI_DESC__Internalname ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
            }
            else
            {
               /* Update record */
               Update0Q26( ) ;
               GX_FocusControl = edtTHDW_UBI_DESC__Internalname ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
            }
         }
         else
         {
            if ( A306THDW_UBI_COD_ != Z306THDW_UBI_COD_ )
            {
               /* Insert record */
               Insert0Q26( ) ;
               GX_FocusControl = edtTHDW_UBI_DESC__Internalname ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
            }
            else
            {
               if ( StringUtil.StrCmp(Gx_mode, "UPD") == 0 )
               {
                  GX_msglist.addItem(context.GetMessage( "GXM_recdeleted"), 1, "THDW_UBI_COD_");
                  AnyError = 1 ;
               }
               else
               {
                  /* Insert record */
                  Insert0Q26( ) ;
                  GX_FocusControl = edtTHDW_UBI_DESC__Internalname ;
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
         if ( A306THDW_UBI_COD_ != Z306THDW_UBI_COD_ )
         {
            A306THDW_UBI_COD_ = Z306THDW_UBI_COD_ ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A306THDW_UBI_COD_", StringUtil.LTrim( StringUtil.Str( (decimal)(A306THDW_UBI_COD_), 10, 0)));
            GX_msglist.addItem(context.GetMessage( "GXM_getbeforedlt"), 1, "THDW_UBI_COD_");
            AnyError = 1 ;
         }
         else
         {
            delete( ) ;
            AfterTrn( ) ;
            GX_FocusControl = edtTHDW_UBI_DESC__Internalname ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
         }
         if ( AnyError != 0 )
         {
         }
      }

      protected void CheckOptimisticConcurrency0Q26( )
      {
         if ( StringUtil.StrCmp(Gx_mode, "INS") != 0 )
         {
            /* Using cursor T000Q8 */
            pr_default.execute(6, new Object[] {A306THDW_UBI_COD_});
            if ( (pr_default.getStatus(6) == 103) )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_lock", new   object[]  {"THDW_UBICACIONES_"}), "RecordIsLocked", 1, "");
               AnyError = 1 ;
               return  ;
            }
            if ( (pr_default.getStatus(6) == 101) || ( StringUtil.StrCmp(Z307THDW_UBI_DESC_, T000Q8_A307THDW_UBI_DESC_[0]) != 0 ) )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_waschg", new   object[]  {"THDW_UBICACIONES_"}), "RecordWasChanged", 1, "");
               AnyError = 1 ;
               return  ;
            }
         }
      }

      protected void Insert0Q26( )
      {
         BeforeValidate0Q26( ) ;
         if ( AnyError == 0 )
         {
            CheckExtendedTable0Q26( ) ;
         }
         if ( AnyError == 0 )
         {
            ZM0Q26( 0) ;
            CheckOptimisticConcurrency0Q26( ) ;
            if ( AnyError == 0 )
            {
               AfterConfirm0Q26( ) ;
               if ( AnyError == 0 )
               {
                  BeforeInsert0Q26( ) ;
                  if ( AnyError == 0 )
                  {
                     /* Using cursor T000Q9 */
                     pr_default.execute(7, new Object[] {A307THDW_UBI_DESC_});
                     pr_default.close(7);
                     /* Retrieving last key number assigned */
                     /* Using cursor T000Q10 */
                     pr_default.execute(8);
                     A306THDW_UBI_COD_ = T000Q10_A306THDW_UBI_COD_[0] ;
                     context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A306THDW_UBI_COD_", StringUtil.LTrim( StringUtil.Str( (decimal)(A306THDW_UBI_COD_), 10, 0)));
                     pr_default.close(8);
                     if ( AnyError == 0 )
                     {
                        /* Start of After( Insert) rules */
                        /* End of After( Insert) rules */
                        if ( AnyError == 0 )
                        {
                           /* Save values for previous() function. */
                           GX_msglist.addItem(context.GetMessage( "GXM_sucadded"), 0, "");
                           ResetCaption0Q0( ) ;
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
               Load0Q26( ) ;
            }
            EndLevel0Q26( ) ;
         }
         CloseExtendedTableCursors0Q26( ) ;
      }

      protected void Update0Q26( )
      {
         BeforeValidate0Q26( ) ;
         if ( AnyError == 0 )
         {
            CheckExtendedTable0Q26( ) ;
         }
         if ( AnyError == 0 )
         {
            CheckOptimisticConcurrency0Q26( ) ;
            if ( AnyError == 0 )
            {
               AfterConfirm0Q26( ) ;
               if ( AnyError == 0 )
               {
                  BeforeUpdate0Q26( ) ;
                  if ( AnyError == 0 )
                  {
                     /* Using cursor T000Q11 */
                     pr_default.execute(9, new Object[] {A307THDW_UBI_DESC_, A306THDW_UBI_COD_});
                     pr_default.close(9);
                     if ( (pr_default.getStatus(9) == 103) )
                     {
                        GX_msglist.addItem(context.GetMessage( "GXM_lock", new   object[]  {"THDW_UBICACIONES_"}), "RecordIsLocked", 1, "");
                        AnyError = 1 ;
                     }
                     DeferredUpdate0Q26( ) ;
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
            EndLevel0Q26( ) ;
         }
         CloseExtendedTableCursors0Q26( ) ;
      }

      protected void DeferredUpdate0Q26( )
      {
      }

      protected void delete( )
      {
         BeforeValidate0Q26( ) ;
         if ( AnyError == 0 )
         {
            CheckOptimisticConcurrency0Q26( ) ;
         }
         if ( AnyError == 0 )
         {
            OnDeleteControls0Q26( ) ;
            AfterConfirm0Q26( ) ;
            if ( AnyError == 0 )
            {
               BeforeDelete0Q26( ) ;
               if ( AnyError == 0 )
               {
                  /* No cascading delete specified. */
                  /* Using cursor T000Q12 */
                  pr_default.execute(10, new Object[] {A306THDW_UBI_COD_});
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
         sMode26 = Gx_mode ;
         Gx_mode = "DLT" ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
         EndLevel0Q26( ) ;
         Gx_mode = sMode26 ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
      }

      protected void OnDeleteControls0Q26( )
      {
         standaloneModal( ) ;
         /* No delete mode formulas found. */
         if ( AnyError == 0 )
         {
            /* Using cursor T000Q13 */
            pr_default.execute(11, new Object[] {A306THDW_UBI_COD_});
            if ( (pr_default.getStatus(11) != 101) )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_del", new   object[]  {"REDES"}), "CannotDeleteReferencedRecord", 1, "");
               AnyError = 1 ;
            }
            pr_default.close(11);
         }
      }

      protected void EndLevel0Q26( )
      {
         if ( StringUtil.StrCmp(Gx_mode, "INS") != 0 )
         {
            pr_default.close(6);
         }
         if ( AnyError == 0 )
         {
            BeforeComplete0Q26( ) ;
         }
         if ( AnyError == 0 )
         {
            pr_default.close(5);
            pr_default.close(4);
            context.CommitDataStores("THDW_UBICACIONES_");
            if ( AnyError == 0 )
            {
               ConfirmValues0Q0( ) ;
            }
            /* After transaction rules */
            /* Execute 'After Trn' event if defined. */
            trnEnded = 1 ;
         }
         else
         {
            pr_default.close(5);
            pr_default.close(4);
            context.RollbackDataStores("THDW_UBICACIONES_");
         }
         IsModified = 0 ;
         if ( AnyError != 0 )
         {
            context.wjLoc = "" ;
            context.nUserReturn = 0 ;
         }
      }

      protected void ScanStart0Q26( )
      {
         /* Using cursor T000Q14 */
         pr_default.execute(12);
         RcdFound26 = 0 ;
         if ( (pr_default.getStatus(12) != 101) )
         {
            RcdFound26 = 1 ;
            A306THDW_UBI_COD_ = T000Q14_A306THDW_UBI_COD_[0] ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A306THDW_UBI_COD_", StringUtil.LTrim( StringUtil.Str( (decimal)(A306THDW_UBI_COD_), 10, 0)));
         }
         /* Load Subordinate Levels */
      }

      protected void ScanNext0Q26( )
      {
         pr_default.readNext(12);
         RcdFound26 = 0 ;
         if ( (pr_default.getStatus(12) != 101) )
         {
            RcdFound26 = 1 ;
            A306THDW_UBI_COD_ = T000Q14_A306THDW_UBI_COD_[0] ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A306THDW_UBI_COD_", StringUtil.LTrim( StringUtil.Str( (decimal)(A306THDW_UBI_COD_), 10, 0)));
         }
      }

      protected void ScanEnd0Q26( )
      {
      }

      protected void AfterConfirm0Q26( )
      {
         /* After Confirm Rules */
      }

      protected void BeforeInsert0Q26( )
      {
         /* Before Insert Rules */
      }

      protected void BeforeUpdate0Q26( )
      {
         /* Before Update Rules */
      }

      protected void BeforeDelete0Q26( )
      {
         /* Before Delete Rules */
      }

      protected void BeforeComplete0Q26( )
      {
         /* Before Complete Rules */
      }

      protected void BeforeValidate0Q26( )
      {
         /* Before Validate Rules */
      }

      protected void assign_properties_default( )
      {
      }

      protected void ConfirmValues0Q0( )
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
         context.WriteHtmlTextNl( "<form id=\"MAINFORM\" onsubmit=\"try{return gx.csv.validForm()}catch(e){return true;}\" name=\"MAINFORM\" method=\"post\" action=\""+formatLink("thdw_ubicaciones_.aspx") + "?" + UrlEncode("" +AV8THDW_UBI_COD_) + "," + UrlEncode(StringUtil.RTrim(Gx_mode)) + "," + UrlEncode(StringUtil.RTrim(AV7SISTEMA)) + "," + UrlEncode(StringUtil.RTrim(AV9USUARIO))+"\" class=\""+"Form"+"\">") ;
         GxWebStd.gx_hidden_field( context, "_EventName", "");
         GxWebStd.gx_hidden_field( context, "_EventGridId", "");
         GxWebStd.gx_hidden_field( context, "_EventRowId", "");
      }

      public override void RenderHtmlCloseForm( )
      {
         /* Send hidden variables. */
         /* Send saved values. */
         GxWebStd.gx_hidden_field( context, "Z306THDW_UBI_COD_", StringUtil.LTrim( StringUtil.NToC( (decimal)(Z306THDW_UBI_COD_), 10, 0, ",", "")));
         GxWebStd.gx_hidden_field( context, "Z307THDW_UBI_DESC_", StringUtil.RTrim( Z307THDW_UBI_DESC_));
         GxWebStd.gx_hidden_field( context, "IsConfirmed", StringUtil.LTrim( StringUtil.NToC( (decimal)(IsConfirmed), 4, 0, ",", "")));
         GxWebStd.gx_hidden_field( context, "IsModified", StringUtil.LTrim( StringUtil.NToC( (decimal)(IsModified), 4, 0, ",", "")));
         GxWebStd.gx_hidden_field( context, "Mode", StringUtil.RTrim( Gx_mode));
         GxWebStd.gx_hidden_field( context, "vSISTEMA", StringUtil.RTrim( AV7SISTEMA));
         GxWebStd.gx_hidden_field( context, "vUSUARIO", StringUtil.RTrim( AV9USUARIO));
         GxWebStd.gx_hidden_field( context, "vTHDW_UBI_COD_", StringUtil.LTrim( StringUtil.NToC( (decimal)(AV8THDW_UBI_COD_), 4, 0, ",", "")));
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
         return "THDW_UBICACIONES_" ;
      }

      public override String GetPgmdesc( )
      {
         return "Ubicaciones Hardware" ;
      }

      public override GXWebForm GetForm( )
      {
         return Form ;
      }

      public override String GetSelfLink( )
      {
         return formatLink("thdw_ubicaciones_.aspx") + "?" + UrlEncode("" +AV8THDW_UBI_COD_) + "," + UrlEncode(StringUtil.RTrim(Gx_mode)) + "," + UrlEncode(StringUtil.RTrim(AV7SISTEMA)) + "," + UrlEncode(StringUtil.RTrim(AV9USUARIO)) ;
      }

      protected void InitializeNonKey0Q26( )
      {
         A307THDW_UBI_DESC_ = "" ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A307THDW_UBI_DESC_", A307THDW_UBI_DESC_);
      }

      protected void InitAll0Q26( )
      {
         A306THDW_UBI_COD_ = 0 ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A306THDW_UBI_COD_", StringUtil.LTrim( StringUtil.Str( (decimal)(A306THDW_UBI_COD_), 10, 0)));
         InitializeNonKey0Q26( ) ;
      }

      protected void StandaloneModalInsert( )
      {
      }

      protected void define_styles( )
      {
         AddThemeStyleSheetFile("", "Modern.css", "?19542497");
         idxLst = 1 ;
         while ( idxLst <= Form.Jscriptsrc.Count )
         {
            context.AddJavascriptSource(StringUtil.RTrim( Form.Jscriptsrc.Item(idxLst)), "?11193693");
            idxLst = (int)(idxLst+1) ;
         }
         /* End function define_styles */
      }

      protected void include_jscripts( )
      {
         context.AddJavascriptSource("messages.spa.js", "?42940");
         context.AddJavascriptSource("thdw_ubicaciones_.js", "?11193693");
         /* End function include_jscripts */
      }

      protected void init_default_properties( )
      {
         tblTabletoolbar_Internalname = "TABLETOOLBAR" ;
         lblTextblockthdw_ubi_cod__Internalname = "TEXTBLOCKTHDW_UBI_COD_" ;
         edtTHDW_UBI_COD__Internalname = "THDW_UBI_COD_" ;
         lblTextblockthdw_ubi_desc__Internalname = "TEXTBLOCKTHDW_UBI_DESC_" ;
         edtTHDW_UBI_DESC__Internalname = "THDW_UBI_DESC_" ;
         tblTable2_Internalname = "TABLE2" ;
         bttBtn_delete_Internalname = "BTN_DELETE" ;
         bttBtn_cancel_Internalname = "BTN_CANCEL" ;
         bttBtn_enter_Internalname = "BTN_ENTER" ;
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
         Form.Caption = "Ubicaciones Hardware" ;
         edtTHDW_UBI_DESC__Jsonclick = "" ;
         edtTHDW_UBI_DESC__Enabled = 1 ;
         edtTHDW_UBI_COD__Jsonclick = "" ;
         edtTHDW_UBI_COD__Enabled = 0 ;
         bttBtn_enter_Enabled = 1 ;
         bttBtn_enter_Visible = 1 ;
         bttBtn_cancel_Visible = 1 ;
         bttBtn_delete_Enabled = 0 ;
         bttBtn_delete_Visible = 1 ;
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
         wcpOGx_mode = "" ;
         wcpOAV7SISTEMA = "" ;
         wcpOAV9USUARIO = "" ;
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
         bttBtn_delete_Jsonclick = "" ;
         bttBtn_cancel_Jsonclick = "" ;
         bttBtn_enter_Jsonclick = "" ;
         lblTextblockthdw_ubi_cod__Jsonclick = "" ;
         lblTextblockthdw_ubi_desc__Jsonclick = "" ;
         A307THDW_UBI_DESC_ = "" ;
         Z307THDW_UBI_DESC_ = "" ;
         sMode26 = "" ;
         sEvt = "" ;
         EvtGridId = "" ;
         EvtRowId = "" ;
         sEvtType = "" ;
         T000Q4_A306THDW_UBI_COD_ = new long[1] ;
         T000Q4_A307THDW_UBI_DESC_ = new String[] {""} ;
         T000Q5_A306THDW_UBI_COD_ = new long[1] ;
         T000Q3_A306THDW_UBI_COD_ = new long[1] ;
         T000Q3_A307THDW_UBI_DESC_ = new String[] {""} ;
         T000Q6_A306THDW_UBI_COD_ = new long[1] ;
         T000Q7_A306THDW_UBI_COD_ = new long[1] ;
         T000Q8_A306THDW_UBI_COD_ = new long[1] ;
         T000Q8_A307THDW_UBI_DESC_ = new String[] {""} ;
         T000Q10_A306THDW_UBI_COD_ = new long[1] ;
         T000Q13_A306THDW_UBI_COD_ = new long[1] ;
         T000Q13_A300Red_Id = new long[1] ;
         T000Q14_A306THDW_UBI_COD_ = new long[1] ;
         sDynURL = "" ;
         FormProcess = "" ;
         GXt_char2 = "" ;
         GXt_char1 = "" ;
         GXt_char3 = "" ;
         pr_default = new DataStoreProvider(context, new GeneXus.Programs.thdw_ubicaciones___default(),
            new Object[][] {
                new Object[] {
               T000Q2_A306THDW_UBI_COD_, T000Q2_A307THDW_UBI_DESC_
               }
               , new Object[] {
               T000Q3_A306THDW_UBI_COD_, T000Q3_A307THDW_UBI_DESC_
               }
               , new Object[] {
               T000Q4_A306THDW_UBI_COD_, T000Q4_A307THDW_UBI_DESC_
               }
               , new Object[] {
               T000Q5_A306THDW_UBI_COD_
               }
               , new Object[] {
               T000Q6_A306THDW_UBI_COD_
               }
               , new Object[] {
               T000Q7_A306THDW_UBI_COD_
               }
               , new Object[] {
               T000Q8_A306THDW_UBI_COD_, T000Q8_A307THDW_UBI_DESC_
               }
               , new Object[] {
               }
               , new Object[] {
               T000Q10_A306THDW_UBI_COD_
               }
               , new Object[] {
               }
               , new Object[] {
               }
               , new Object[] {
               T000Q13_A306THDW_UBI_COD_, T000Q13_A300Red_Id
               }
               , new Object[] {
               T000Q14_A306THDW_UBI_COD_
               }
            }
         );
      }

      private short wcpOAV8THDW_UBI_COD_ ;
      private short GxWebError ;
      private short AV8THDW_UBI_COD_ ;
      private short IsConfirmed ;
      private short IsModified ;
      private short AnyError ;
      private short nKeyPressed ;
      private short initialized ;
      private short RcdFound26 ;
      private short GX_JID ;
      private short Gx_BScreen ;
      private short gxajaxcallmode ;
      private int trnEnded ;
      private int bttBtn_delete_Visible ;
      private int bttBtn_delete_Enabled ;
      private int bttBtn_cancel_Visible ;
      private int bttBtn_enter_Visible ;
      private int bttBtn_enter_Enabled ;
      private int edtTHDW_UBI_COD__Enabled ;
      private int edtTHDW_UBI_DESC__Enabled ;
      private int idxLst ;
      private long A306THDW_UBI_COD_ ;
      private long Z306THDW_UBI_COD_ ;
      private String sPrefix ;
      private String wcpOGx_mode ;
      private String wcpOAV7SISTEMA ;
      private String wcpOAV9USUARIO ;
      private String scmdbuf ;
      private String gxfirstwebparm ;
      private String gxfirstwebparm_bkp ;
      private String Gx_mode ;
      private String AV7SISTEMA ;
      private String AV9USUARIO ;
      private String PreviousTooltip ;
      private String PreviousCaption ;
      private String GX_FocusControl ;
      private String edtTHDW_UBI_DESC__Internalname ;
      private String sStyleString ;
      private String tblTablemain_Internalname ;
      private String ClassString ;
      private String StyleString ;
      private String grpGroupdata_Internalname ;
      private String tblTable1_Internalname ;
      private String TempTags ;
      private String bttBtn_delete_Internalname ;
      private String bttBtn_delete_Jsonclick ;
      private String bttBtn_cancel_Internalname ;
      private String bttBtn_cancel_Jsonclick ;
      private String bttBtn_enter_Internalname ;
      private String bttBtn_enter_Jsonclick ;
      private String tblTable2_Internalname ;
      private String lblTextblockthdw_ubi_cod__Internalname ;
      private String lblTextblockthdw_ubi_cod__Jsonclick ;
      private String edtTHDW_UBI_COD__Internalname ;
      private String edtTHDW_UBI_COD__Jsonclick ;
      private String lblTextblockthdw_ubi_desc__Internalname ;
      private String lblTextblockthdw_ubi_desc__Jsonclick ;
      private String A307THDW_UBI_DESC_ ;
      private String edtTHDW_UBI_DESC__Jsonclick ;
      private String tblTabletoolbar_Internalname ;
      private String Z307THDW_UBI_DESC_ ;
      private String sMode26 ;
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
      private GXMasterPage MasterPageObj ;
      private IGxDataStore dsDESARROLLO ;
      private IGxDataStore dssoporte_notebook ;
      private IGxDataStore dsDefault ;
      private short aP0_THDW_UBI_COD_ ;
      private String aP1_Gx_mode ;
      private String aP2_SISTEMA ;
      private String aP3_USUARIO ;
      private IDataStoreProvider pr_default ;
      private long[] T000Q4_A306THDW_UBI_COD_ ;
      private String[] T000Q4_A307THDW_UBI_DESC_ ;
      private long[] T000Q5_A306THDW_UBI_COD_ ;
      private long[] T000Q3_A306THDW_UBI_COD_ ;
      private String[] T000Q3_A307THDW_UBI_DESC_ ;
      private long[] T000Q6_A306THDW_UBI_COD_ ;
      private long[] T000Q7_A306THDW_UBI_COD_ ;
      private long[] T000Q8_A306THDW_UBI_COD_ ;
      private String[] T000Q8_A307THDW_UBI_DESC_ ;
      private long[] T000Q10_A306THDW_UBI_COD_ ;
      private long[] T000Q13_A306THDW_UBI_COD_ ;
      private long[] T000Q13_A300Red_Id ;
      private long[] T000Q14_A306THDW_UBI_COD_ ;
      private long[] T000Q2_A306THDW_UBI_COD_ ;
      private String[] T000Q2_A307THDW_UBI_DESC_ ;
      private GXWebForm Form ;
   }

   public class thdw_ubicaciones___default : DataStoreHelperBase, IDataStoreHelper
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
          Object[] prmT000Q2 ;
          prmT000Q2 = new Object[] {
          new Object[] {"@THDW_UBI_COD_",SqlDbType.Decimal,10,0}
          } ;
          Object[] prmT000Q4 ;
          prmT000Q4 = new Object[] {
          new Object[] {"@THDW_UBI_COD_",SqlDbType.Decimal,10,0}
          } ;
          Object[] prmT000Q5 ;
          prmT000Q5 = new Object[] {
          new Object[] {"@THDW_UBI_COD_",SqlDbType.Decimal,10,0}
          } ;
          Object[] prmT000Q3 ;
          prmT000Q3 = new Object[] {
          new Object[] {"@THDW_UBI_COD_",SqlDbType.Decimal,10,0}
          } ;
          Object[] prmT000Q6 ;
          prmT000Q6 = new Object[] {
          new Object[] {"@THDW_UBI_COD_",SqlDbType.Decimal,10,0}
          } ;
          Object[] prmT000Q7 ;
          prmT000Q7 = new Object[] {
          new Object[] {"@THDW_UBI_COD_",SqlDbType.Decimal,10,0}
          } ;
          Object[] prmT000Q8 ;
          prmT000Q8 = new Object[] {
          new Object[] {"@THDW_UBI_COD_",SqlDbType.Decimal,10,0}
          } ;
          Object[] prmT000Q9 ;
          prmT000Q9 = new Object[] {
          new Object[] {"@THDW_UBI_DESC_",SqlDbType.Char,30,0}
          } ;
          Object[] prmT000Q10 ;
          prmT000Q10 = new Object[] {
          } ;
          Object[] prmT000Q11 ;
          prmT000Q11 = new Object[] {
          new Object[] {"@THDW_UBI_DESC_",SqlDbType.Char,30,0} ,
          new Object[] {"@THDW_UBI_COD_",SqlDbType.Decimal,10,0}
          } ;
          Object[] prmT000Q12 ;
          prmT000Q12 = new Object[] {
          new Object[] {"@THDW_UBI_COD_",SqlDbType.Decimal,10,0}
          } ;
          Object[] prmT000Q13 ;
          prmT000Q13 = new Object[] {
          new Object[] {"@THDW_UBI_COD_",SqlDbType.Decimal,10,0}
          } ;
          Object[] prmT000Q14 ;
          prmT000Q14 = new Object[] {
          } ;
          def= new CursorDef[] {
              new CursorDef("T000Q2", "SELECT [THDW_UBI_COD_], [THDW_UBI_DESC_] FROM [THDW_UBICACIONES_] WITH (UPDLOCK) WHERE [THDW_UBI_COD_] = @THDW_UBI_COD_ ",true, GxErrorMask.GX_NOMASK, false, this,prmT000Q2,1,0,true,false )
             ,new CursorDef("T000Q3", "SELECT [THDW_UBI_COD_], [THDW_UBI_DESC_] FROM [THDW_UBICACIONES_] WITH (NOLOCK) WHERE [THDW_UBI_COD_] = @THDW_UBI_COD_ ",true, GxErrorMask.GX_NOMASK, false, this,prmT000Q3,1,0,true,false )
             ,new CursorDef("T000Q4", "SELECT TM1.[THDW_UBI_COD_], TM1.[THDW_UBI_DESC_] FROM [THDW_UBICACIONES_] TM1 WITH (NOLOCK) WHERE TM1.[THDW_UBI_COD_] = @THDW_UBI_COD_ ORDER BY TM1.[THDW_UBI_COD_]  OPTION (FAST 100)",true, GxErrorMask.GX_NOMASK, false, this,prmT000Q4,100,0,true,false )
             ,new CursorDef("T000Q5", "SELECT [THDW_UBI_COD_] FROM [THDW_UBICACIONES_] WITH (NOLOCK) WHERE [THDW_UBI_COD_] = @THDW_UBI_COD_  OPTION (FAST 1)",true, GxErrorMask.GX_NOMASK, false, this,prmT000Q5,1,0,true,false )
             ,new CursorDef("T000Q6", "SELECT TOP 1 [THDW_UBI_COD_] FROM [THDW_UBICACIONES_] WITH (NOLOCK) WHERE ( [THDW_UBI_COD_] > @THDW_UBI_COD_) ORDER BY [THDW_UBI_COD_]  OPTION (FAST 1)",true, GxErrorMask.GX_NOMASK, false, this,prmT000Q6,1,0,true,true )
             ,new CursorDef("T000Q7", "SELECT TOP 1 [THDW_UBI_COD_] FROM [THDW_UBICACIONES_] WITH (NOLOCK) WHERE ( [THDW_UBI_COD_] < @THDW_UBI_COD_) ORDER BY [THDW_UBI_COD_] DESC  OPTION (FAST 1)",true, GxErrorMask.GX_NOMASK, false, this,prmT000Q7,1,0,true,true )
             ,new CursorDef("T000Q8", "SELECT [THDW_UBI_COD_], [THDW_UBI_DESC_] FROM [THDW_UBICACIONES_] WITH (UPDLOCK) WHERE [THDW_UBI_COD_] = @THDW_UBI_COD_ ",true, GxErrorMask.GX_NOMASK, false, this,prmT000Q8,1,0,true,false )
             ,new CursorDef("T000Q9", "INSERT INTO [THDW_UBICACIONES_] ([THDW_UBI_DESC_]) VALUES (@THDW_UBI_DESC_)", GxErrorMask.GX_NOMASK,prmT000Q9)
             ,new CursorDef("T000Q10", "SELECT Ident_Current('[THDW_UBICACIONES_]') ",true, GxErrorMask.GX_NOMASK, false, this,prmT000Q10,1,0,true,false )
             ,new CursorDef("T000Q11", "UPDATE [THDW_UBICACIONES_] SET [THDW_UBI_DESC_]=@THDW_UBI_DESC_  WHERE [THDW_UBI_COD_] = @THDW_UBI_COD_", GxErrorMask.GX_NOMASK,prmT000Q11)
             ,new CursorDef("T000Q12", "DELETE FROM [THDW_UBICACIONES_]  WHERE [THDW_UBI_COD_] = @THDW_UBI_COD_", GxErrorMask.GX_NOMASK,prmT000Q12)
             ,new CursorDef("T000Q13", "SELECT TOP 1 [THDW_UBI_COD_], [Red_Id] FROM [THDW_REDES] WITH (NOLOCK) WHERE [THDW_UBI_COD_] = @THDW_UBI_COD_ ",true, GxErrorMask.GX_NOMASK, false, this,prmT000Q13,1,0,true,true )
             ,new CursorDef("T000Q14", "SELECT [THDW_UBI_COD_] FROM [THDW_UBICACIONES_] WITH (NOLOCK) ORDER BY [THDW_UBI_COD_]  OPTION (FAST 100)",true, GxErrorMask.GX_NOMASK, false, this,prmT000Q14,100,0,true,false )
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
                ((String[]) buf[1])[0] = rslt.getString(2, 30) ;
                break;
             case 1 :
                ((long[]) buf[0])[0] = rslt.getLong(1) ;
                ((String[]) buf[1])[0] = rslt.getString(2, 30) ;
                break;
             case 2 :
                ((long[]) buf[0])[0] = rslt.getLong(1) ;
                ((String[]) buf[1])[0] = rslt.getString(2, 30) ;
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
                ((String[]) buf[1])[0] = rslt.getString(2, 30) ;
                break;
             case 8 :
                ((long[]) buf[0])[0] = rslt.getLong(1) ;
                break;
             case 11 :
                ((long[]) buf[0])[0] = rslt.getLong(1) ;
                ((long[]) buf[1])[0] = rslt.getLong(2) ;
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
                stmt.SetParameter(1, (String)parms[0]);
                break;
             case 9 :
                stmt.SetParameter(1, (String)parms[0]);
                stmt.SetParameter(2, (long)parms[1]);
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
