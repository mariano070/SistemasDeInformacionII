/*
               File: Gx00I0
        Description: Selection List Gestores por Grupo
             Author: GeneXus C# Generator version 10_1_5-42940
       Generated on: 1/2/2014 19:17:30.31
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
   public class gx00i0 : GXDataArea, System.Web.SessionState.IRequiresSessionState
   {
      public gx00i0( )
      {
         context = new GxContext(  );
         DataStoreUtil.LoadDataStores( context);
         dsDESARROLLO = context.GetDataStore("DESARROLLO") ;
         dssoporte_notebook = context.GetDataStore("soporte_notebook") ;
         dsDefault = context.GetDataStore("Default") ;
         IsMain = true;
         context.SetTheme("Modern");
      }

      public gx00i0( IGxContext context )
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

      public void execute( out short aP0_pGrupo_Cod ,
                           out String aP1_pGes_Cod )
      {
         this.AV10pGrupo_Cod = 0 ;
         this.AV11pGes_Cod = "" ;
         executePrivate();
         aP0_pGrupo_Cod=this.AV10pGrupo_Cod;
         aP1_pGes_Cod=this.AV11pGes_Cod;
      }

      void executePrivate( )
      {
         isStatic = false;
         webExecute();
      }

      protected override void createObjects( )
      {
      }

      protected void INITWEB( )
      {
         initialize_properties( ) ;
         if ( nGotPars == 0 )
         {
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
            else if ( StringUtil.StrCmp(gxfirstwebparm, "gxajaxNewRow_"+"Grid1") == 0 )
            {
               nRC_Grid1 = (short)(NumberUtil.Val( GetNextPar( ), ".")) ;
               nGXsfl_36_idx = (short)(NumberUtil.Val( GetNextPar( ), ".")) ;
               sGXsfl_36_idx = GetNextPar( ) ;
               setAjaxCallMode();
               if ( ! IsValidAjaxCall( true) )
               {
                  GxWebError = 1 ;
                  return  ;
               }
               gxnrGrid1_newrow( nRC_Grid1, nGXsfl_36_idx, sGXsfl_36_idx) ;
               return  ;
            }
            else if ( StringUtil.StrCmp(gxfirstwebparm, "gxajaxGridRefresh_"+"Grid1") == 0 )
            {
               /* GeneXus formulas. */
               context.Gx_err = 0 ;
               Grid1_PageSize36 = (int)(NumberUtil.Val( GetNextPar( ), ".")) ;
               AV6cGrupo_Cod = (short)(NumberUtil.Val( GetNextPar( ), ".")) ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV6cGrupo_Cod", StringUtil.LTrim( StringUtil.Str( (decimal)(AV6cGrupo_Cod), 4, 0)));
               AV7cGes_Cod = GetNextPar( ) ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV7cGes_Cod", AV7cGes_Cod);
               AV8cGrupo_Des = GetNextPar( ) ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV8cGrupo_Des", AV8cGrupo_Des);
               AV9cGrupo_Tip = GetNextPar( ) ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV9cGrupo_Tip", AV9cGrupo_Tip);
               setAjaxCallMode();
               if ( ! IsValidAjaxCall( true) )
               {
                  GxWebError = 1 ;
                  return  ;
               }
               gxgrGrid1_refresh( Grid1_PageSize36, AV6cGrupo_Cod, AV7cGes_Cod, AV8cGrupo_Des, AV9cGrupo_Tip) ;
               return  ;
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
               AV10pGrupo_Cod = (short)(NumberUtil.Val( gxfirstwebparm, ".")) ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV10pGrupo_Cod", StringUtil.LTrim( StringUtil.Str( (decimal)(AV10pGrupo_Cod), 4, 0)));
               if ( StringUtil.StrCmp(gxfirstwebparm, "viewer") != 0 )
               {
                  AV11pGes_Cod = GetNextPar( ) ;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV11pGes_Cod", AV11pGes_Cod);
               }
            }
         }
         context.SetTheme("Modern");
      }

      public override void webExecute( )
      {
         if ( initialized == 0 )
         {
            createObjects();
            initialize();
         }
         INITWEB( ) ;
         if ( ! isAjaxCallMode( ) )
         {
            MasterPageObj = (GXMasterPage) ClassLoader.GetInstance("promptmasterpage", "GeneXus.Programs.promptmasterpage", new Object[] {new GxContext( context.handle, context.DataStores, context.HttpContext)});
            MasterPageObj.setDataArea(this,true);
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

      public override short ExecuteStartEvent( )
      {
         PA2M2( ) ;
         gxajaxcallmode = (short)((isAjaxCallMode( ) ? 1 : 0)) ;
         if ( ( gxajaxcallmode == 0 ) && ( GxWebError == 0 ) )
         {
            START2M2( ) ;
         }
         return gxajaxcallmode ;
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
         if ( nGXWrapped != 1 )
         {
            MasterPageObj.master_styles();
         }
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
         context.WriteHtmlTextNl( "<form id=\"MAINFORM\" onsubmit=\"try{return gx.csv.validForm()}catch(e){return true;}\" name=\"MAINFORM\" method=\"post\" action=\""+formatLink("gx00i0.aspx") + "?" + UrlEncode("" +AV10pGrupo_Cod) + "," + UrlEncode(StringUtil.RTrim(AV11pGes_Cod))+"\" class=\""+"Form"+"\">") ;
         GxWebStd.gx_hidden_field( context, "_EventName", "");
         GxWebStd.gx_hidden_field( context, "_EventGridId", "");
         GxWebStd.gx_hidden_field( context, "_EventRowId", "");
      }

      public override void RenderHtmlCloseForm( )
      {
         /* Send hidden variables. */
         GxWebStd.gx_hidden_field( context, "GXH_vCGRUPO_COD", StringUtil.LTrim( StringUtil.NToC( (decimal)(AV6cGrupo_Cod), 4, 0, ",", "")));
         GxWebStd.gx_hidden_field( context, "GXH_vCGES_COD", StringUtil.RTrim( AV7cGes_Cod));
         GxWebStd.gx_hidden_field( context, "GXH_vCGRUPO_DES", StringUtil.RTrim( AV8cGrupo_Des));
         GxWebStd.gx_hidden_field( context, "GXH_vCGRUPO_TIP", StringUtil.RTrim( AV9cGrupo_Tip));
         /* Send saved values. */
         GxWebStd.gx_hidden_field( context, "nRC_Grid1", StringUtil.LTrim( StringUtil.NToC( (decimal)(nRC_Grid1), 4, 0, ",", "")));
         GxWebStd.gx_hidden_field( context, "vPGRUPO_COD", StringUtil.LTrim( StringUtil.NToC( (decimal)(AV10pGrupo_Cod), 4, 0, ",", "")));
         GxWebStd.gx_hidden_field( context, "vPGES_COD", StringUtil.RTrim( AV11pGes_Cod));
         GxWebStd.gx_hidden_field( context, "GRID1_nFirstRecordOnPage", StringUtil.LTrim( StringUtil.NToC( (decimal)(GRID1_nFirstRecordOnPage), 6, 0, ",", "")));
         GxWebStd.gx_hidden_field( context, "GRID1_nEOF", StringUtil.LTrim( StringUtil.NToC( (decimal)(GRID1_nEOF), 1, 0, ",", "")));
         GxWebStd.gx_hidden_field( context, "GX_FocusControl", GX_FocusControl);
         SendAjaxEncryptionKey();
         SendComponentObjects();
         SendServerCommands();
         SendState();
         context.WriteHtmlTextNl( "</form>") ;
         include_jscripts( ) ;
      }

      public override void RenderHtmlContent( )
      {
         gxajaxcallmode = (short)((isAjaxCallMode( ) ? 1 : 0)) ;
         if ( ( gxajaxcallmode == 0 ) && ( GxWebError == 0 ) )
         {
            WE2M2( ) ;
         }
      }

      public override void DispatchEvents( )
      {
         EVT2M2( ) ;
      }

      public override bool HasEnterEvent( )
      {
         return true ;
      }

      public override String GetPgmname( )
      {
         return "Gx00I0" ;
      }

      public override String GetPgmdesc( )
      {
         return "Selection List Gestores por Grupo" ;
      }

      public override GXWebForm GetForm( )
      {
         return Form ;
      }

      public override String GetSelfLink( )
      {
         return formatLink("gx00i0.aspx") + "?" + UrlEncode("" +AV10pGrupo_Cod) + "," + UrlEncode(StringUtil.RTrim(AV11pGes_Cod)) ;
      }

      protected void WB2M0( )
      {
         if ( context.isAjaxRequest( ) )
         {
            disableOutput();
         }
         if ( ! wbLoad )
         {
            if ( nGXWrapped == 1 )
            {
               RenderHtmlHeaders( ) ;
               RenderHtmlOpenForm( ) ;
            }
            wb_table1_2_2M2( true) ;
         }
         else
         {
            wb_table1_2_2M2( false) ;
         }
         return  ;
      }

      protected void wb_table1_2_2M2e( bool wbgen )
      {
         if ( wbgen )
         {
         }
         wbLoad = true ;
      }

      protected void START2M2( )
      {
         wbLoad = false ;
         wbEnd = 0 ;
         wbStart = 0 ;
         Form.Meta.addItem("Generator", "GeneXus C#", 0) ;
         Form.Meta.addItem("Version", "10_1_5-42940", 0) ;
         Form.Meta.addItem("Description", "Selection List Gestores por Grupo", 0) ;
         context.wjLoc = "" ;
         context.nUserReturn = 0 ;
         context.wbHandled = 0 ;
         if ( StringUtil.StrCmp(context.GetRequestMethod( ), "POST") == 0 )
         {
         }
         wbErr = false ;
         STRUP2M0( ) ;
      }

      protected void WS2M2( )
      {
         START2M2( ) ;
         EVT2M2( ) ;
      }

      protected void EVT2M2( )
      {
         if ( StringUtil.StrCmp(context.GetRequestMethod( ), "POST") == 0 )
         {
            if ( String.IsNullOrEmpty(StringUtil.RTrim( context.wjLoc)) && ( context.nUserReturn != 1 ) && ! wbErr )
            {
               /* Read Web Panel buttons. */
               sEvt = cgiGet( "_EventName") ;
               EvtGridId = cgiGet( "_EventGridId") ;
               EvtRowId = cgiGet( "_EventRowId") ;
               if ( StringUtil.Len( sEvt) > 0 )
               {
                  sEvtType = StringUtil.Left( sEvt, 1) ;
                  sEvt = StringUtil.Right( sEvt, (short)(StringUtil.Len( sEvt)-1)) ;
                  /* Check if conditions changed and reset current page numbers */
                  if ( ( context.localUtil.CToN( cgiGet( "GXH_vCGRUPO_COD"), ",", ".") != Convert.ToDecimal( AV6cGrupo_Cod )) )
                  {
                     GRID1_nFirstRecordOnPage = 0 ;
                  }
                  if ( StringUtil.StrCmp(cgiGet( "GXH_vCGES_COD"), AV7cGes_Cod) != 0 )
                  {
                     GRID1_nFirstRecordOnPage = 0 ;
                  }
                  if ( StringUtil.StrCmp(cgiGet( "GXH_vCGRUPO_DES"), AV8cGrupo_Des) != 0 )
                  {
                     GRID1_nFirstRecordOnPage = 0 ;
                  }
                  if ( StringUtil.StrCmp(cgiGet( "GXH_vCGRUPO_TIP"), AV9cGrupo_Tip) != 0 )
                  {
                     GRID1_nFirstRecordOnPage = 0 ;
                  }
                  if ( StringUtil.StrCmp(sEvtType, "M") != 0 )
                  {
                     if ( StringUtil.StrCmp(sEvtType, "E") == 0 )
                     {
                        sEvtType = StringUtil.Right( sEvt, 1) ;
                        if ( StringUtil.StrCmp(sEvtType, ".") == 0 )
                        {
                           sEvt = StringUtil.Left( sEvt, (short)(StringUtil.Len( sEvt)-1)) ;
                           if ( StringUtil.StrCmp(sEvt, "RFR") == 0 )
                           {
                              context.wbHandled = 1 ;
                              dynload_actions( ) ;
                           }
                           else if ( StringUtil.StrCmp(sEvt, "LSCR") == 0 )
                           {
                              context.wbHandled = 1 ;
                              dynload_actions( ) ;
                           }
                           else if ( StringUtil.StrCmp(sEvt, "GRID1PAGING") == 0 )
                           {
                              context.wbHandled = 1 ;
                              sEvt = cgiGet( "GRID1PAGING") ;
                              if ( StringUtil.StrCmp(sEvt, "FIRST") == 0 )
                              {
                                 subgrid1_firstpage( ) ;
                              }
                              else if ( StringUtil.StrCmp(sEvt, "PREV") == 0 )
                              {
                                 subgrid1_previouspage( ) ;
                              }
                              else if ( StringUtil.StrCmp(sEvt, "NEXT") == 0 )
                              {
                                 subgrid1_nextpage( ) ;
                              }
                              else if ( StringUtil.StrCmp(sEvt, "LAST") == 0 )
                              {
                                 subgrid1_lastpage( ) ;
                              }
                           }
                        }
                        else
                        {
                           sEvtType = StringUtil.Right( sEvt, 4) ;
                           sEvt = StringUtil.Left( sEvt, (short)(StringUtil.Len( sEvt)-4)) ;
                           if ( ( StringUtil.StrCmp(StringUtil.Left( sEvt, 5), "START") == 0 ) || ( StringUtil.StrCmp(StringUtil.Left( sEvt, 4), "LOAD") == 0 ) || ( StringUtil.StrCmp(StringUtil.Left( sEvt, 5), "ENTER") == 0 ) || ( StringUtil.StrCmp(StringUtil.Left( sEvt, 6), "CANCEL") == 0 ) )
                           {
                              nGXsfl_36_idx = (short)(NumberUtil.Val( sEvtType, ".")) ;
                              sGXsfl_36_idx = StringUtil.PadL( StringUtil.LTrim( StringUtil.Str( (decimal)(nGXsfl_36_idx), 4, 0)), 4, "0") ;
                              edtavLinkselection_Internalname = "vLINKSELECTION_"+sGXsfl_36_idx ;
                              edtGrupo_Cod_Internalname = "GRUPO_COD_"+sGXsfl_36_idx ;
                              edtGes_Cod_Internalname = "GES_COD_"+sGXsfl_36_idx ;
                              edtGrupo_Des_Internalname = "GRUPO_DES_"+sGXsfl_36_idx ;
                              edtGrupo_Tip_Internalname = "GRUPO_TIP_"+sGXsfl_36_idx ;
                              AV5LinkSelection = cgiGet( "GXimg"+edtavLinkselection_Internalname) ;
                              context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavLinkselection_Internalname, "Bitmap", context.convertURL( AV5LinkSelection));
                              A271Grupo_Cod = (short)(context.localUtil.CToN( cgiGet( edtGrupo_Cod_Internalname), ",", ".")) ;
                              context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A271Grupo_Cod", StringUtil.LTrim( StringUtil.Str( (decimal)(A271Grupo_Cod), 4, 0)));
                              A270Ges_Cod = StringUtil.Upper( cgiGet( edtGes_Cod_Internalname)) ;
                              context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A270Ges_Cod", A270Ges_Cod);
                              A273Grupo_Des = cgiGet( edtGrupo_Des_Internalname) ;
                              context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A273Grupo_Des", A273Grupo_Des);
                              A275Grupo_Tip = cgiGet( edtGrupo_Tip_Internalname) ;
                              context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A275Grupo_Tip", A275Grupo_Tip);
                              sEvtType = StringUtil.Right( sEvt, 1) ;
                              if ( StringUtil.StrCmp(sEvtType, ".") == 0 )
                              {
                                 sEvt = StringUtil.Left( sEvt, (short)(StringUtil.Len( sEvt)-1)) ;
                                 if ( StringUtil.StrCmp(sEvt, "START") == 0 )
                                 {
                                    context.wbHandled = 1 ;
                                    dynload_actions( ) ;
                                    /* Execute user event: E112M2 */
                                    E112M2 ();
                                 }
                                 else if ( StringUtil.StrCmp(sEvt, "LOAD") == 0 )
                                 {
                                    context.wbHandled = 1 ;
                                    dynload_actions( ) ;
                                    /* Execute user event: E122M2 */
                                    E122M2 ();
                                 }
                                 else if ( StringUtil.StrCmp(sEvt, "ENTER") == 0 )
                                 {
                                    context.wbHandled = 1 ;
                                    if ( ! wbErr )
                                    {
                                       Rfr0gs = false ;
                                       /* Set Refresh If Cgrupo_cod Changed */
                                       if ( ( context.localUtil.CToN( cgiGet( "GXH_vCGRUPO_COD"), ",", ".") != Convert.ToDecimal( AV6cGrupo_Cod )) )
                                       {
                                          Rfr0gs = true ;
                                       }
                                       /* Set Refresh If Cges_cod Changed */
                                       if ( StringUtil.StrCmp(cgiGet( "GXH_vCGES_COD"), AV7cGes_Cod) != 0 )
                                       {
                                          Rfr0gs = true ;
                                       }
                                       /* Set Refresh If Cgrupo_des Changed */
                                       if ( StringUtil.StrCmp(cgiGet( "GXH_vCGRUPO_DES"), AV8cGrupo_Des) != 0 )
                                       {
                                          Rfr0gs = true ;
                                       }
                                       /* Set Refresh If Cgrupo_tip Changed */
                                       if ( StringUtil.StrCmp(cgiGet( "GXH_vCGRUPO_TIP"), AV9cGrupo_Tip) != 0 )
                                       {
                                          Rfr0gs = true ;
                                       }
                                       if ( ! Rfr0gs )
                                       {
                                          /* Execute user event: E132M2 */
                                          E132M2 ();
                                       }
                                       dynload_actions( ) ;
                                    }
                                 }
                                 else if ( StringUtil.StrCmp(sEvt, "CANCEL") == 0 )
                                 {
                                    context.wbHandled = 1 ;
                                    dynload_actions( ) ;
                                 }
                                 else if ( StringUtil.StrCmp(sEvt, "LSCR") == 0 )
                                 {
                                    context.wbHandled = 1 ;
                                    dynload_actions( ) ;
                                 }
                              }
                              else
                              {
                              }
                           }
                        }
                     }
                     context.wbHandled = 1 ;
                  }
               }
            }
         }
      }

      protected void WE2M2( )
      {
         if ( ! GxWebStd.gx_redirect( context) )
         {
            Rfr0gs = true ;
            Refresh( ) ;
            if ( ! GxWebStd.gx_redirect( context) )
            {
               if ( nGXWrapped == 1 )
               {
                  RenderHtmlCloseForm( ) ;
               }
            }
         }
      }

      protected void PA2M2( )
      {
         if ( nDonePA == 0 )
         {
            GX_FocusControl = edtavCgrupo_cod_Internalname ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
            nDonePA = 1 ;
         }
      }

      protected void dynload_actions( )
      {
         /* End function dynload_actions */
      }

      protected void gxnrGrid1_newrow( short nRC_Grid1 ,
                                       short nGXsfl_36_idx ,
                                       String sGXsfl_36_idx )
      {
         GxWebStd.set_html_headers( context, 0, "", "");
         edtavLinkselection_Internalname = "vLINKSELECTION_"+sGXsfl_36_idx ;
         edtGrupo_Cod_Internalname = "GRUPO_COD_"+sGXsfl_36_idx ;
         edtGes_Cod_Internalname = "GES_COD_"+sGXsfl_36_idx ;
         edtGrupo_Des_Internalname = "GRUPO_DES_"+sGXsfl_36_idx ;
         edtGrupo_Tip_Internalname = "GRUPO_TIP_"+sGXsfl_36_idx ;
         while ( nGXsfl_36_idx <= nRC_Grid1 )
         {
            sendrow_362( ) ;
            nGXsfl_36_idx = (short)(((subGrid1_Islastpage==1)&&(nGXsfl_36_idx+1>subGrid1_Recordsperpage( )) ? 1 : nGXsfl_36_idx+1)) ;
            sGXsfl_36_idx = StringUtil.PadL( StringUtil.LTrim( StringUtil.Str( (decimal)(nGXsfl_36_idx), 4, 0)), 4, "0") ;
            edtavLinkselection_Internalname = "vLINKSELECTION_"+sGXsfl_36_idx ;
            edtGrupo_Cod_Internalname = "GRUPO_COD_"+sGXsfl_36_idx ;
            edtGes_Cod_Internalname = "GES_COD_"+sGXsfl_36_idx ;
            edtGrupo_Des_Internalname = "GRUPO_DES_"+sGXsfl_36_idx ;
            edtGrupo_Tip_Internalname = "GRUPO_TIP_"+sGXsfl_36_idx ;
         }
         context.GX_webresponse.AddString(Grid1Container.ToJavascriptSource());
         /* End function gxnrGrid1_newrow */
      }

      protected void gxgrGrid1_refresh( int Grid1_PageSize36 ,
                                        short AV6cGrupo_Cod ,
                                        String AV7cGes_Cod ,
                                        String AV8cGrupo_Des ,
                                        String AV9cGrupo_Tip )
      {
         GxWebStd.set_html_headers( context, 0, "", "");
         disableOutput();
         subGrid1_Rows = (short)(Grid1_PageSize36) ;
         RF2M2( ) ;
         enableOutput();
         context.GX_webresponse.AddString(Grid1Container.ToJavascriptSource());
         /* End function gxgrGrid1_refresh */
      }

      protected void Refresh( )
      {
         RF2M2( ) ;
         /* End function Refresh */
      }

      protected void RF2M2( )
      {
         Grid1Container.PageSize = subGrid1_Recordsperpage( ) ;
         wbStart = 36 ;
         nGXsfl_36_idx = 1 ;
         sGXsfl_36_idx = StringUtil.PadL( StringUtil.LTrim( StringUtil.Str( (decimal)(nGXsfl_36_idx), 4, 0)), 4, "0") ;
         edtavLinkselection_Internalname = "vLINKSELECTION_"+sGXsfl_36_idx ;
         edtGrupo_Cod_Internalname = "GRUPO_COD_"+sGXsfl_36_idx ;
         edtGes_Cod_Internalname = "GES_COD_"+sGXsfl_36_idx ;
         edtGrupo_Des_Internalname = "GRUPO_DES_"+sGXsfl_36_idx ;
         edtGrupo_Tip_Internalname = "GRUPO_TIP_"+sGXsfl_36_idx ;
         if ( String.IsNullOrEmpty(StringUtil.RTrim( context.wjLoc)) && ( context.nUserReturn != 1 ) )
         {
            edtavLinkselection_Internalname = "vLINKSELECTION_"+sGXsfl_36_idx ;
            edtGrupo_Cod_Internalname = "GRUPO_COD_"+sGXsfl_36_idx ;
            edtGes_Cod_Internalname = "GES_COD_"+sGXsfl_36_idx ;
            edtGrupo_Des_Internalname = "GRUPO_DES_"+sGXsfl_36_idx ;
            edtGrupo_Tip_Internalname = "GRUPO_TIP_"+sGXsfl_36_idx ;
            lV7cGes_Cod = StringUtil.PadR( StringUtil.RTrim( AV7cGes_Cod), 15, "%") ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV7cGes_Cod", AV7cGes_Cod);
            lV8cGrupo_Des = StringUtil.PadR( StringUtil.RTrim( AV8cGrupo_Des), 20, "%") ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV8cGrupo_Des", AV8cGrupo_Des);
            lV9cGrupo_Tip = StringUtil.PadR( StringUtil.RTrim( AV9cGrupo_Tip), 1, "%") ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV9cGrupo_Tip", AV9cGrupo_Tip);
            /* Using cursor H002M2 */
            pr_default.execute(0, new Object[] {AV6cGrupo_Cod, lV7cGes_Cod, lV8cGrupo_Des, lV9cGrupo_Tip});
            nGXsfl_36_idx = 1 ;
            GRID1_nEOF = 0 ;
            while ( ( (pr_default.getStatus(0) != 101) ) && ( ( ( 10 == 0 ) || ( GRID1_nCurrentRecord < GRID1_nFirstRecordOnPage + subGrid1_Recordsperpage( ) ) ) ) )
            {
               A275Grupo_Tip = H002M2_A275Grupo_Tip[0] ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A275Grupo_Tip", A275Grupo_Tip);
               A273Grupo_Des = H002M2_A273Grupo_Des[0] ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A273Grupo_Des", A273Grupo_Des);
               A270Ges_Cod = H002M2_A270Ges_Cod[0] ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A270Ges_Cod", A270Ges_Cod);
               A271Grupo_Cod = H002M2_A271Grupo_Cod[0] ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A271Grupo_Cod", StringUtil.LTrim( StringUtil.Str( (decimal)(A271Grupo_Cod), 4, 0)));
               /* Execute user event: E122M2 */
               E122M2 ();
               pr_default.readNext(0);
            }
            GRID1_nEOF = (short)(((pr_default.getStatus(0) == 101) ? 1 : 0)) ;
            pr_default.close(0);
            wbEnd = 36 ;
            WB2M0( ) ;
         }
      }

      protected int subGrid1_Pagecount( )
      {
         GRID1_nRecordCount = subGrid1_Recordcount( ) ;
         if ( ((int)(GRID1_nRecordCount) % (subGrid1_Recordsperpage( ))) == 0 )
         {
            return (int)(NumberUtil.Int( (long)(GRID1_nRecordCount/ (decimal)(subGrid1_Recordsperpage( ))))) ;
         }
         return (int)(NumberUtil.Int( (long)(GRID1_nRecordCount/ (decimal)(subGrid1_Recordsperpage( ))))+1) ;
      }

      protected int subGrid1_Recordcount( )
      {
         lV7cGes_Cod = StringUtil.PadR( StringUtil.RTrim( AV7cGes_Cod), 15, "%") ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV7cGes_Cod", AV7cGes_Cod);
         lV8cGrupo_Des = StringUtil.PadR( StringUtil.RTrim( AV8cGrupo_Des), 20, "%") ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV8cGrupo_Des", AV8cGrupo_Des);
         lV9cGrupo_Tip = StringUtil.PadR( StringUtil.RTrim( AV9cGrupo_Tip), 1, "%") ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV9cGrupo_Tip", AV9cGrupo_Tip);
         /* Using cursor H002M3 */
         pr_default.execute(1, new Object[] {AV6cGrupo_Cod, lV7cGes_Cod, lV8cGrupo_Des, lV9cGrupo_Tip});
         GRID1_nRecordCount = H002M3_AGRID1_nRecordCount[0] ;
         pr_default.close(1);
         return GRID1_nRecordCount ;
      }

      protected int subGrid1_Recordsperpage( )
      {
         if ( 10 > 0 )
         {
            if ( 1 > 0 )
            {
               return (int)(10*1) ;
            }
            else
            {
               return (int)(10) ;
            }
         }
         return (int)(-1) ;
      }

      protected int subGrid1_Currentpage( )
      {
         return (int)(NumberUtil.Int( (long)(GRID1_nFirstRecordOnPage/ (decimal)(subGrid1_Recordsperpage( ))))+1) ;
      }

      protected short subgrid1_firstpage( )
      {
         GRID1_nFirstRecordOnPage = 0 ;
         return 0 ;
      }

      protected short subgrid1_nextpage( )
      {
         GRID1_nRecordCount = subGrid1_Recordcount( ) ;
         if ( ( GRID1_nRecordCount >= subGrid1_Recordsperpage( ) ) && ( GRID1_nEOF == 0 ) )
         {
            GRID1_nFirstRecordOnPage = (int)(GRID1_nFirstRecordOnPage+subGrid1_Recordsperpage( )) ;
         }
         else
         {
            return 2 ;
         }
         return 0 ;
      }

      protected short subgrid1_previouspage( )
      {
         if ( GRID1_nFirstRecordOnPage >= subGrid1_Recordsperpage( ) )
         {
            GRID1_nFirstRecordOnPage = (int)(GRID1_nFirstRecordOnPage-subGrid1_Recordsperpage( )) ;
         }
         else
         {
            return 2 ;
         }
         return 0 ;
      }

      protected short subgrid1_lastpage( )
      {
         GRID1_nRecordCount = subGrid1_Recordcount( ) ;
         if ( GRID1_nRecordCount > subGrid1_Recordsperpage( ) )
         {
            if ( ((int)(GRID1_nRecordCount) % (subGrid1_Recordsperpage( ))) == 0 )
            {
               GRID1_nFirstRecordOnPage = (int)(GRID1_nRecordCount-subGrid1_Recordsperpage( )) ;
            }
            else
            {
               GRID1_nFirstRecordOnPage = (int)(GRID1_nRecordCount-((int)(GRID1_nRecordCount) % (subGrid1_Recordsperpage( )))) ;
            }
         }
         else
         {
            GRID1_nFirstRecordOnPage = 0 ;
         }
         return 0 ;
      }

      protected int subgrid1_gotopage( int nPageNo )
      {
         if ( nPageNo > 0 )
         {
            int gx_pageCount = subGrid1_Pagecount( ) ;
            if ( ( nPageNo <= gx_pageCount ) || ( gx_pageCount == -1 ) )
            {
               GRID1_nFirstRecordOnPage = (int)(subGrid1_Recordsperpage( )*(nPageNo-1)) ;
            }
            else
            {
               GRID1_nFirstRecordOnPage = (int)(subGrid1_Recordsperpage( )*(gx_pageCount-1)) ;
            }
         }
         else
         {
            GRID1_nFirstRecordOnPage = 0 ;
         }
         return (int)(0) ;
      }

      protected void STRUP2M0( )
      {
         /* Before Start, stand alone formulas. */
         context.Gx_err = 0 ;
         /* Execute Start event if defined. */
         context.wbGlbDoneStart = 0 ;
         /* Execute user event: E112M2 */
         E112M2 ();
         context.wbGlbDoneStart = 1 ;
         /* After Start, stand alone formulas. */
         if ( StringUtil.StrCmp(context.GetRequestMethod( ), "POST") == 0 )
         {
            /* Read saved SDTs. */
            /* Read variables values. */
            if ( ! context.localUtil.VCNumber( cgiGet( edtavCgrupo_cod_Internalname), "ZZZ9") || ( context.localUtil.CToN( cgiGet( edtavCgrupo_cod_Internalname), ",", ".") < Convert.ToDecimal( 0 )) || ( ( context.localUtil.CToN( cgiGet( edtavCgrupo_cod_Internalname), ",", ".") > Convert.ToDecimal( 9999 )) ) )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_badnum"), 1, "vCGRUPO_COD");
               GX_FocusControl = edtavCgrupo_cod_Internalname ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
               wbErr = true ;
               AV6cGrupo_Cod = 0 ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV6cGrupo_Cod", StringUtil.LTrim( StringUtil.Str( (decimal)(AV6cGrupo_Cod), 4, 0)));
            }
            else
            {
               AV6cGrupo_Cod = (short)(context.localUtil.CToN( cgiGet( edtavCgrupo_cod_Internalname), ",", ".")) ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV6cGrupo_Cod", StringUtil.LTrim( StringUtil.Str( (decimal)(AV6cGrupo_Cod), 4, 0)));
            }
            AV7cGes_Cod = StringUtil.Upper( cgiGet( edtavCges_cod_Internalname)) ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV7cGes_Cod", AV7cGes_Cod);
            AV8cGrupo_Des = cgiGet( edtavCgrupo_des_Internalname) ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV8cGrupo_Des", AV8cGrupo_Des);
            AV9cGrupo_Tip = cgiGet( edtavCgrupo_tip_Internalname) ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV9cGrupo_Tip", AV9cGrupo_Tip);
            /* Read saved values. */
            nRC_Grid1 = (short)(context.localUtil.CToN( cgiGet( "nRC_Grid1"), ",", ".")) ;
            AV10pGrupo_Cod = (short)(context.localUtil.CToN( cgiGet( "vPGRUPO_COD"), ",", ".")) ;
            AV11pGes_Cod = cgiGet( "vPGES_COD") ;
            GRID1_nFirstRecordOnPage = (int)(context.localUtil.CToN( cgiGet( "GRID1_nFirstRecordOnPage"), ",", ".")) ;
            GRID1_nEOF = (short)(context.localUtil.CToN( cgiGet( "GRID1_nEOF"), ",", ".")) ;
            /* Read subfile selected row values. */
            /* Read hidden variables. */
         }
         else
         {
            dynload_actions( ) ;
         }
      }

      protected void GXStart( )
      {
         /* Execute user event: E112M2 */
         E112M2 ();
         if ( returnInSub )
         {
            returnInSub = true;
            if (true) return;
         }
      }

      protected void E112M2( )
      {
         /* Start Routine */
         Form.Caption = StringUtil.Format( "Lista de Selección %1", "Gestores por Grupo", "", "", "", "", "", "", "", "") ;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, "FORM", "Caption", Form.Caption);
      }

      private void E122M2( )
      {
         /* Load Routine */
         AV5LinkSelection = context.GetImagePath( "3914535b-0c03-44c5-9538-906a99cdd2bc", "", "Modern") ;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavLinkselection_Internalname, "Bitmap", context.convertURL( AV5LinkSelection));
         if ( ( subGrid1_Islastpage == 1 ) || ( 10 == 0 ) || ( ( GRID1_nCurrentRecord >= GRID1_nFirstRecordOnPage ) && ( GRID1_nCurrentRecord < GRID1_nFirstRecordOnPage + subGrid1_Recordsperpage( ) ) ) )
         {
            sendrow_362( ) ;
         }
         GRID1_nCurrentRecord = (int)(GRID1_nCurrentRecord+1) ;
      }

      public void GXEnter( )
      {
         /* Execute user event: E132M2 */
         E132M2 ();
         if ( returnInSub )
         {
            returnInSub = true;
            if (true) return;
         }
      }

      protected void E132M2( )
      {
         /* Enter Routine */
         AV10pGrupo_Cod = A271Grupo_Cod ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV10pGrupo_Cod", StringUtil.LTrim( StringUtil.Str( (decimal)(AV10pGrupo_Cod), 4, 0)));
         AV11pGes_Cod = A270Ges_Cod ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV11pGes_Cod", AV11pGes_Cod);
         context.setWebReturnParms(new Object[] {(short)AV10pGrupo_Cod,(String)AV11pGes_Cod});
         context.nUserReturn = 1 ;
         returnInSub = true;
         if (true) return;
      }

      protected void wb_table1_2_2M2( bool wbgen )
      {
         if ( wbgen )
         {
            /* Table start */
            sStyleString = "" ;
            GxWebStd.gx_table_start( context, tblTable1_Internalname, tblTable1_Internalname, "", "Table", 0, "", "", 1, 2, sStyleString, "", 0);
            context.WriteHtmlText( "<tbody>") ;
            context.WriteHtmlText( "<tr>") ;
            context.WriteHtmlText( "<td style=\"text-align:"+context.GetCssProperty( "Align", "center")+"\">") ;
            ClassString = "ErrorViewer" ;
            StyleString = "" ;
            GxWebStd.gx_msg_list( context, "", context.GX_msglist.DisplayMode, StyleString, ClassString, "", "false");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "<tr>") ;
            context.WriteHtmlText( "<td>") ;
            /* Control Group */
            ClassString = "FieldSet" ;
            StyleString = "" ;
            context.WriteHtmlText( "<fieldset id=\""+grpGroup1_Internalname+"\""+" style=\"-moz-border-radius:3pt;\""+" class=\""+ClassString+"\">") ;
            context.WriteHtmlText( "<legend class=\""+ClassString+"Title"+"\">"+"Filters"+"</legend>") ;
            wb_table2_9_2M2( true) ;
         }
         else
         {
            wb_table2_9_2M2( false) ;
         }
         return  ;
      }

      protected void wb_table2_9_2M2e( bool wbgen )
      {
         if ( wbgen )
         {
            context.WriteHtmlText( "</fieldset>") ;
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "<tr>") ;
            context.WriteHtmlText( "<td>") ;
            /* Control Group */
            ClassString = "FieldSet" ;
            StyleString = "" ;
            context.WriteHtmlText( "<fieldset id=\""+grpGroup2_Internalname+"\""+" style=\"-moz-border-radius:3pt;\""+" class=\""+ClassString+"\">") ;
            context.WriteHtmlText( "<legend class=\""+ClassString+"Title"+"\">"+"Lista de Selección"+"</legend>") ;
            wb_table3_33_2M2( true) ;
         }
         else
         {
            wb_table3_33_2M2( false) ;
         }
         return  ;
      }

      protected void wb_table3_33_2M2e( bool wbgen )
      {
         if ( wbgen )
         {
            context.WriteHtmlText( "</fieldset>") ;
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "</tbody>") ;
            /* End of table */
            context.WriteHtmlText( "</table>") ;
            wb_table1_2_2M2e( true) ;
         }
         else
         {
            wb_table1_2_2M2e( false) ;
         }
      }

      protected void wb_table3_33_2M2( bool wbgen )
      {
         if ( wbgen )
         {
            /* Table start */
            sStyleString = "" ;
            GxWebStd.gx_table_start( context, tblTable3_Internalname, tblTable3_Internalname, "", "Table", 0, "", "", 1, 2, sStyleString, "", 0);
            context.WriteHtmlText( "<tbody>") ;
            context.WriteHtmlText( "<tr>") ;
            context.WriteHtmlText( "<td colspan=\"3\" >") ;
            /*  Grid Control  */
            Grid1Container.SetWrapped(nGXWrapped);
            if ( Grid1Container.GetWrapped() == 1 )
            {
               sStyleString = "" ;
               GxWebStd.gx_table_start( context, subGrid1_Internalname, subGrid1_Internalname, "", "Grid", 0, "", "", 1, 0, sStyleString, "", 0);
               /* Subfile titles */
               context.WriteHtmlText( "<tr") ;
               context.WriteHtmlTextNl( ">") ;
               if ( subGrid1_Backcolorstyle == 0 )
               {
                  subGrid1_Titlebackstyle = 0 ;
                  if ( StringUtil.Len( subGrid1_Class) > 0 )
                  {
                     subGrid1_Linesclass = subGrid1_Class+"Title" ;
                  }
               }
               else
               {
                  subGrid1_Titlebackstyle = 1 ;
                  if ( subGrid1_Backcolorstyle == 1 )
                  {
                     subGrid1_Titlebackcolor = subGrid1_Allbackcolor ;
                     if ( StringUtil.Len( subGrid1_Class) > 0 )
                     {
                        subGrid1_Linesclass = subGrid1_Class+"UniformTitle" ;
                     }
                  }
                  else
                  {
                     if ( StringUtil.Len( subGrid1_Class) > 0 )
                     {
                        subGrid1_Linesclass = subGrid1_Class+"Title" ;
                     }
                  }
               }
               context.WriteHtmlText( "<th align=\""+""+"\" "+" nowrap=\"nowrap\" "+" class=\""+subGrid1_Linesclass+"\" "+" style=\""+((-1==0) ? "display:none;" : "")+""+"\" "+">") ;
               context.SendWebValue( "") ;
               context.WriteHtmlTextNl( "</th>") ;
               context.WriteHtmlText( "<th align=\""+"right"+"\" "+" nowrap=\"nowrap\" "+" class=\""+subGrid1_Linesclass+"\" "+" style=\""+((-1==0) ? "display:none;" : "")+""+"\" "+">") ;
               context.SendWebValue( "Cod") ;
               context.WriteHtmlTextNl( "</th>") ;
               context.WriteHtmlText( "<th align=\""+"left"+"\" "+" nowrap=\"nowrap\" "+" class=\""+subGrid1_Linesclass+"\" "+" style=\""+((-1==0) ? "display:none;" : "")+""+"\" "+">") ;
               context.SendWebValue( "Ges_ Cod") ;
               context.WriteHtmlTextNl( "</th>") ;
               context.WriteHtmlText( "<th align=\""+"left"+"\" "+" nowrap=\"nowrap\" "+" class=\""+subGrid1_Linesclass+"\" "+" style=\""+((-1==0) ? "display:none;" : "")+""+"\" "+">") ;
               context.SendWebValue( "Des") ;
               context.WriteHtmlTextNl( "</th>") ;
               context.WriteHtmlText( "<th align=\""+"left"+"\" "+" nowrap=\"nowrap\" "+" class=\""+subGrid1_Linesclass+"\" "+" style=\""+((-1==0) ? "display:none;" : "")+""+"\" "+">") ;
               context.SendWebValue( "Tip") ;
               context.WriteHtmlTextNl( "</th>") ;
               context.WriteHtmlTextNl( "</tr>") ;
            }
            else
            {
               Grid1Container.Clear();
               Grid1Container.SetWrapped(nGXWrapped);
               Grid1Container.AddObjectProperty("GridName", "Grid1");
               Grid1Container.AddObjectProperty("Class", "Grid");
               Grid1Container.AddObjectProperty("Cellpadding", StringUtil.LTrim( StringUtil.NToC( (decimal)(1), 4, 0, ".", "")));
               Grid1Container.AddObjectProperty("Cellspacing", StringUtil.LTrim( StringUtil.NToC( (decimal)(0), 4, 0, ".", "")));
               Grid1Container.AddObjectProperty("Backcolorstyle", StringUtil.LTrim( StringUtil.NToC( (decimal)(subGrid1_Backcolorstyle), 1, 0, ".", "")));
               Grid1Container.AddObjectProperty("CmpContext", "");
               Grid1Container.AddObjectProperty("InMasterPage", "false");
               Grid1Column = GXWebColumn.GetNew(isAjaxCallMode( )) ;
               Grid1Column.AddObjectProperty("Value", context.convertURL( AV5LinkSelection));
               Grid1Column.AddObjectProperty("Link", StringUtil.RTrim( edtavLinkselection_Link));
               Grid1Container.AddColumnProperties(Grid1Column);
               Grid1Column = GXWebColumn.GetNew(isAjaxCallMode( )) ;
               Grid1Column.AddObjectProperty("Value", StringUtil.LTrim( StringUtil.NToC( (decimal)(A271Grupo_Cod), 4, 0, ".", "")));
               Grid1Container.AddColumnProperties(Grid1Column);
               Grid1Column = GXWebColumn.GetNew(isAjaxCallMode( )) ;
               Grid1Column.AddObjectProperty("Value", StringUtil.RTrim( A270Ges_Cod));
               Grid1Container.AddColumnProperties(Grid1Column);
               Grid1Column = GXWebColumn.GetNew(isAjaxCallMode( )) ;
               Grid1Column.AddObjectProperty("Value", StringUtil.RTrim( A273Grupo_Des));
               Grid1Column.AddObjectProperty("Link", StringUtil.RTrim( edtGrupo_Des_Link));
               Grid1Container.AddColumnProperties(Grid1Column);
               Grid1Column = GXWebColumn.GetNew(isAjaxCallMode( )) ;
               Grid1Column.AddObjectProperty("Value", StringUtil.RTrim( A275Grupo_Tip));
               Grid1Container.AddColumnProperties(Grid1Column);
               Grid1Container.AddObjectProperty("Allowselection", "false");
               Grid1Container.AddObjectProperty("Allowcollapsing", "false");
               Grid1Container.AddObjectProperty("Collapsed", StringUtil.LTrim( StringUtil.NToC( (decimal)(subGrid1_Collapsed), 9, 0, ".", "")));
            }
         }
         if ( wbEnd == 36 )
         {
            wbEnd = 0 ;
            nRC_Grid1 = (short)(nGXsfl_36_idx-1) ;
            if ( Grid1Container.GetWrapped() == 1 )
            {
               context.WriteHtmlText( "</table>") ;
            }
            else
            {
               Grid1Container.AddObjectProperty("GRID1_nEOF", GRID1_nEOF);
               Grid1Container.AddObjectProperty("GRID1_nFirstRecordOnPage", GRID1_nFirstRecordOnPage);
               sStyleString = " style=\"display:none;\"" ;
               sStyleString = "" ;
               context.WriteHtmlText( "<div id=\""+"Grid1Container"+"Div\" "+sStyleString+">"+"</div>") ;
               context.httpAjaxContext.ajax_rsp_assign_grid("_"+"Grid1", (Object)(Grid1Container));
               GxWebStd.gx_hidden_field( context, "Grid1ContainerData", Grid1Container.ToJavascriptSource());
               if ( context.isAjaxRequest( ) )
               {
                  GxWebStd.gx_hidden_field( context, "Grid1ContainerData"+"V", Grid1Container.GridValuesHidden());
               }
               else
               {
                  context.WriteHtmlText( "<input type=\"hidden\" "+"name=\""+"Grid1ContainerData"+"V"+"\" value='"+Grid1Container.GridValuesHidden()+"'>") ;
               }
            }
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "<tr>") ;
            context.WriteHtmlText( "<td style=\"text-align:"+context.GetCssProperty( "Align", "right")+"\">") ;
            wb_table4_44_2M2( true) ;
         }
         else
         {
            wb_table4_44_2M2( false) ;
         }
         return  ;
      }

      protected void wb_table4_44_2M2e( bool wbgen )
      {
         if ( wbgen )
         {
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "</tbody>") ;
            /* End of table */
            context.WriteHtmlText( "</table>") ;
            wb_table3_33_2M2e( true) ;
         }
         else
         {
            wb_table3_33_2M2e( false) ;
         }
      }

      protected void wb_table4_44_2M2( bool wbgen )
      {
         if ( wbgen )
         {
            /* Table start */
            sStyleString = "" ;
            GxWebStd.gx_table_start( context, tblTable4_Internalname, tblTable4_Internalname, "", "Table", 0, "", "", 1, 2, sStyleString, "", 0);
            context.WriteHtmlText( "<tbody>") ;
            context.WriteHtmlText( "<tr>") ;
            context.WriteHtmlText( "<td>") ;
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 47,'',false,'',0)\"" ;
            ClassString = "BtnCancel" ;
            StyleString = "" ;
            GxWebStd.gx_button_ctrl( context, context.GetButtonType( ), bttBtn_cancel_Internalname, "Cancelar", "Cancelar", "", StyleString, ClassString, 1, 1, "rounded", 1, bttBtn_cancel_Jsonclick, "ECANCEL.", TempTags, "gx.evt.setGridEvt("+StringUtil.Str( (decimal)(36), 3, 0)+","+"null"+");", "", "HLP_Gx00I0.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "</tbody>") ;
            /* End of table */
            context.WriteHtmlText( "</table>") ;
            wb_table4_44_2M2e( true) ;
         }
         else
         {
            wb_table4_44_2M2e( false) ;
         }
      }

      protected void wb_table2_9_2M2( bool wbgen )
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
            GxWebStd.gx_label_ctrl( context, lblTextblockgrupo_cod_Internalname, 1, 1, 0, "Grupo_ Cod", "", "", "", 0, lblTextblockgrupo_cod_Jsonclick, "", StyleString, ClassString, "HLP_Gx00I0.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "<td>") ;
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 14,'',false,'" + sGXsfl_36_idx + "',0)\"" ;
            ClassString = "Attribute" ;
            StyleString = "" ;
            GxWebStd.gx_single_line_edit( context, edtavCgrupo_cod_Internalname, StringUtil.LTrim( StringUtil.NToC( (decimal)(AV6cGrupo_Cod), 4, 0, ",", "")), "", 4, "chr", 1, "row", 4, 1, 1, 0, 0, 0, "", "", StyleString, ClassString, "", context.localUtil.Format( (decimal)(AV6cGrupo_Cod), "ZZZ9"), TempTags+" onchange=\"gx.evt.onchange(this)\" "+" onblur=\""+"gx.num.valid_integer( this,'.');"+";gx.evt.onblur(14);\"", 0, edtavCgrupo_cod_Jsonclick, "", 0, 1, -1, true, "right", "HLP_Gx00I0.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "<tr>") ;
            context.WriteHtmlText( "<td>") ;
            /* Text block */
            ClassString = "TextBlock" ;
            StyleString = "" ;
            GxWebStd.gx_label_ctrl( context, lblTextblockges_cod_Internalname, 1, 1, 0, "Ges_ Cod", "", "", "", 0, lblTextblockges_cod_Jsonclick, "", StyleString, ClassString, "HLP_Gx00I0.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "<td>") ;
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 19,'',false,'" + sGXsfl_36_idx + "',0)\"" ;
            ClassString = "Attribute" ;
            StyleString = "" ;
            GxWebStd.gx_single_line_edit( context, edtavCges_cod_Internalname, StringUtil.RTrim( AV7cGes_Cod), "", 15, "chr", 1, "row", 15, 1, 1, 0, 0, 0, "", "", StyleString, ClassString, "", StringUtil.RTrim( context.localUtil.Format( AV7cGes_Cod, "@!")), TempTags+" onchange=\"gx.evt.onchange(this)\" "+" onblur=\""+"this.value=this.value.toUpperCase();"+";gx.evt.onblur(19);\"", 0, edtavCges_cod_Jsonclick, "", 0, 1, -1, true, "left", "HLP_Gx00I0.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "<tr>") ;
            context.WriteHtmlText( "<td>") ;
            /* Text block */
            ClassString = "TextBlock" ;
            StyleString = "" ;
            GxWebStd.gx_label_ctrl( context, lblTextblockgrupo_des_Internalname, 1, 1, 0, "Grupo_ Des", "", "", "", 0, lblTextblockgrupo_des_Jsonclick, "", StyleString, ClassString, "HLP_Gx00I0.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "<td>") ;
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 24,'',false,'" + sGXsfl_36_idx + "',0)\"" ;
            ClassString = "Attribute" ;
            StyleString = "" ;
            GxWebStd.gx_single_line_edit( context, edtavCgrupo_des_Internalname, StringUtil.RTrim( AV8cGrupo_Des), "", 20, "chr", 1, "row", 20, 1, 1, 0, 0, 0, "", "", StyleString, ClassString, "", StringUtil.RTrim( context.localUtil.Format( AV8cGrupo_Des, "XXXXXXXXXXXXXXXXXXXX")), TempTags+" onchange=\"gx.evt.onchange(this)\" "+" onblur=\""+""+";gx.evt.onblur(24);\"", 0, edtavCgrupo_des_Jsonclick, "", 0, 1, -1, true, "left", "HLP_Gx00I0.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "<tr>") ;
            context.WriteHtmlText( "<td>") ;
            /* Text block */
            ClassString = "TextBlock" ;
            StyleString = "" ;
            GxWebStd.gx_label_ctrl( context, lblTextblockgrupo_tip_Internalname, 1, 1, 0, "Grupo_ Tip", "", "", "", 0, lblTextblockgrupo_tip_Jsonclick, "", StyleString, ClassString, "HLP_Gx00I0.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "<td>") ;
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 29,'',false,'" + sGXsfl_36_idx + "',0)\"" ;
            ClassString = "Attribute" ;
            StyleString = "" ;
            GxWebStd.gx_single_line_edit( context, edtavCgrupo_tip_Internalname, StringUtil.RTrim( AV9cGrupo_Tip), "", 1, "chr", 1, "row", 1, 1, 1, 0, 0, 0, "", "", StyleString, ClassString, "", StringUtil.RTrim( context.localUtil.Format( AV9cGrupo_Tip, "X")), TempTags+" onchange=\"gx.evt.onchange(this)\" "+" onblur=\""+""+";gx.evt.onblur(29);\"", 0, edtavCgrupo_tip_Jsonclick, "", 0, 1, -1, true, "left", "HLP_Gx00I0.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "</tbody>") ;
            /* End of table */
            context.WriteHtmlText( "</table>") ;
            wb_table2_9_2M2e( true) ;
         }
         else
         {
            wb_table2_9_2M2e( false) ;
         }
      }

      public override void setparameters( Object[] obj )
      {
         createObjects();
         initialize();
         AV10pGrupo_Cod = Convert.ToInt16(getParm(obj,0)) ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV10pGrupo_Cod", StringUtil.LTrim( StringUtil.Str( (decimal)(AV10pGrupo_Cod), 4, 0)));
         AV11pGes_Cod = (String)getParm(obj,1) ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV11pGes_Cod", AV11pGes_Cod);
      }

      public override String getresponse( String sGXDynURL )
      {
         initialize_properties( ) ;
         BackMsgLst = context.GX_msglist ;
         context.GX_msglist = LclMsgLst ;
         sDynURL = sGXDynURL ;
         nGotPars = (short)(1) ;
         nGXWrapped = (short)(1) ;
         context.SetWrapped(true);
         PA2M2( ) ;
         WS2M2( ) ;
         WE2M2( ) ;
         this.cleanup();
         context.SetWrapped(false);
         context.GX_msglist = BackMsgLst ;
         return "";
      }

      public void responsestatic( String sGXDynURL )
      {
      }

      protected void define_styles( )
      {
         AddThemeStyleSheetFile("", "Modern.css", "?1915234");
         idxLst = 1 ;
         while ( idxLst <= Form.Jscriptsrc.Count )
         {
            context.AddJavascriptSource(StringUtil.RTrim( Form.Jscriptsrc.Item(idxLst)), "?19173086");
            idxLst = (int)(idxLst+1) ;
         }
         /* End function define_styles */
      }

      protected void include_jscripts( )
      {
         context.AddJavascriptSource("messages.spa.js", "?42940");
         context.AddJavascriptSource("gx00i0.js", "?19173086");
         /* End function include_jscripts */
      }

      protected void sendrow_362( )
      {
         WB2M0( ) ;
         if ( ( 10 * 1 == 0 ) || ( nGXsfl_36_idx <= subGrid1_Recordsperpage( ) * 1 ) )
         {
            Grid1Row = GXWebRow.GetNew(context,Grid1Container) ;
            if ( subGrid1_Backcolorstyle == 0 )
            {
               /* None style subfile background logic. */
               subGrid1_Backstyle = 0 ;
               if ( StringUtil.StrCmp(subGrid1_Class, "") != 0 )
               {
                  subGrid1_Linesclass = subGrid1_Class+"Odd" ;
               }
            }
            else if ( subGrid1_Backcolorstyle == 1 )
            {
               /* Uniform style subfile background logic. */
               subGrid1_Backstyle = 0 ;
               subGrid1_Backcolor = subGrid1_Allbackcolor ;
               context.httpAjaxContext.ajax_rsp_assign_prop("", false, "Grid1ContainerDiv", "Backcolor", StringUtil.LTrim( StringUtil.Str( (decimal)(subGrid1_Backcolor), 9, 0)));
               if ( StringUtil.StrCmp(subGrid1_Class, "") != 0 )
               {
                  subGrid1_Linesclass = subGrid1_Class+"Uniform" ;
               }
            }
            else if ( subGrid1_Backcolorstyle == 2 )
            {
               /* Header style subfile background logic. */
               subGrid1_Backstyle = 1 ;
               if ( StringUtil.StrCmp(subGrid1_Class, "") != 0 )
               {
                  subGrid1_Linesclass = subGrid1_Class+"Odd" ;
               }
               subGrid1_Backcolor = (int)(0xF0F0F0) ;
               context.httpAjaxContext.ajax_rsp_assign_prop("", false, "Grid1ContainerDiv", "Backcolor", StringUtil.LTrim( StringUtil.Str( (decimal)(subGrid1_Backcolor), 9, 0)));
            }
            else if ( subGrid1_Backcolorstyle == 3 )
            {
               /* Report style subfile background logic. */
               subGrid1_Backstyle = 1 ;
               if ( ((int)(nGXsfl_36_idx) % (2)) == 0 )
               {
                  subGrid1_Backcolor = (int)(0x0) ;
                  context.httpAjaxContext.ajax_rsp_assign_prop("", false, "Grid1ContainerDiv", "Backcolor", StringUtil.LTrim( StringUtil.Str( (decimal)(subGrid1_Backcolor), 9, 0)));
                  if ( StringUtil.StrCmp(subGrid1_Class, "") != 0 )
                  {
                     subGrid1_Linesclass = subGrid1_Class+"Even" ;
                  }
               }
               else
               {
                  subGrid1_Backcolor = (int)(0xF0F0F0) ;
                  context.httpAjaxContext.ajax_rsp_assign_prop("", false, "Grid1ContainerDiv", "Backcolor", StringUtil.LTrim( StringUtil.Str( (decimal)(subGrid1_Backcolor), 9, 0)));
                  if ( StringUtil.StrCmp(subGrid1_Class, "") != 0 )
                  {
                     subGrid1_Linesclass = subGrid1_Class+"Odd" ;
                  }
               }
            }
            if ( Grid1Container.GetWrapped() == 1 )
            {
               context.WriteHtmlText( "<tr ") ;
               context.WriteHtmlText( " class=\""+subGrid1_Linesclass+"\" style=\""+""+"\"") ;
               context.WriteHtmlText( ">") ;
            }
            /* Subfile cell */
            if ( Grid1Container.GetWrapped() == 1 )
            {
               context.WriteHtmlText( "<td valign=\"middle\" align=\""+""+"\""+" style=\""+((-1==0) ? "display:none;" : "")+"\">") ;
            }
            /* Static Bitmap Variable */
            edtavLinkselection_Link = "javascript:gx.popup.gxReturn(["+"'"+GXUtil.EncodeJSConstant( StringUtil.LTrim( StringUtil.NToC( (decimal)(A271Grupo_Cod), 4, 0, ",", "")))+"'"+", "+"'"+GXUtil.EncodeJSConstant( StringUtil.RTrim( A270Ges_Cod))+"'"+"]);" ;
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavLinkselection_Internalname, "Link", edtavLinkselection_Link);
            ClassString = "Image" ;
            StyleString = "" ;
            Grid1Row.AddColumnProperties("bitmap", 2, isAjaxCallMode( ), new Object[] {(String)edtavLinkselection_Internalname,(String)"",(String)AV5LinkSelection,(String)"Modern",(short)-1,(short)1,(String)"",(String)"Seleccionar",(short)0,(short)-1,(short)0,(String)"px",(short)0,(String)"",(short)0,(short)0,(String)edtavLinkselection_Link,(String)"",(short)0,(String)"",(String)"",(String)StyleString,(String)ClassString,(String)"",(String)"",(String)"''",(String)""});
            /* Subfile cell */
            if ( Grid1Container.GetWrapped() == 1 )
            {
               context.WriteHtmlText( "<td valign=\"middle\" align=\""+"right"+"\""+" style=\""+((-1==0) ? "display:none;" : "")+"\">") ;
            }
            /* Single line edit */
            ClassString = "Attribute" ;
            StyleString = "" ;
            ROClassString = ClassString ;
            Grid1Row.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edtGrupo_Cod_Internalname,StringUtil.LTrim( StringUtil.NToC( (decimal)(A271Grupo_Cod), 4, 0, ",", "")),(String)"",(short)0,(String)"px",(short)17,(String)"",(short)4,(short)-1,(short)0,(short)0,(short)0,(short)0,(String)"",(String)"",(String)StyleString,(String)ClassString,(String)ROClassString,context.localUtil.Format( (decimal)(A271Grupo_Cod), "ZZZ9"),(String)"",(short)0,(String)edtGrupo_Cod_Jsonclick,(String)"",(short)36,(short)1,(short)1,(bool)true,(String)"right"});
            /* Subfile cell */
            if ( Grid1Container.GetWrapped() == 1 )
            {
               context.WriteHtmlText( "<td valign=\"middle\" align=\""+"left"+"\""+" style=\""+((-1==0) ? "display:none;" : "")+"\">") ;
            }
            /* Single line edit */
            ClassString = "Attribute" ;
            StyleString = "" ;
            ROClassString = ClassString ;
            Grid1Row.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edtGes_Cod_Internalname,StringUtil.RTrim( A270Ges_Cod),(String)"",(short)0,(String)"px",(short)17,(String)"",(short)15,(short)-1,(short)0,(short)0,(short)0,(short)0,(String)"",(String)"",(String)StyleString,(String)ClassString,(String)ROClassString,StringUtil.RTrim( context.localUtil.Format( A270Ges_Cod, "@!")),(String)"",(short)0,(String)edtGes_Cod_Jsonclick,(String)"",(short)36,(short)1,(short)1,(bool)true,(String)"left"});
            /* Subfile cell */
            if ( Grid1Container.GetWrapped() == 1 )
            {
               context.WriteHtmlText( "<td valign=\"middle\" align=\""+"left"+"\""+" style=\""+((-1==0) ? "display:none;" : "")+"\">") ;
            }
            /* Single line edit */
            ClassString = "Attribute" ;
            StyleString = "" ;
            ROClassString = ClassString ;
            edtGrupo_Des_Link = "javascript:gx.popup.gxReturn(["+"'"+GXUtil.EncodeJSConstant( StringUtil.LTrim( StringUtil.NToC( (decimal)(A271Grupo_Cod), 4, 0, ",", "")))+"'"+", "+"'"+GXUtil.EncodeJSConstant( StringUtil.RTrim( A270Ges_Cod))+"'"+"]);" ;
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtGrupo_Des_Internalname, "Link", edtGrupo_Des_Link);
            Grid1Row.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edtGrupo_Des_Internalname,StringUtil.RTrim( A273Grupo_Des),(String)"Seleccionar",(short)0,(String)"px",(short)17,(String)"",(short)20,(short)-1,(short)0,(short)0,(short)0,(short)0,(String)edtGrupo_Des_Link,(String)"",(String)StyleString,(String)ClassString,(String)ROClassString,StringUtil.RTrim( context.localUtil.Format( A273Grupo_Des, "XXXXXXXXXXXXXXXXXXXX")),(String)"",(short)0,(String)edtGrupo_Des_Jsonclick,(String)"",(short)36,(short)1,(short)1,(bool)true,(String)"left"});
            /* Subfile cell */
            if ( Grid1Container.GetWrapped() == 1 )
            {
               context.WriteHtmlText( "<td valign=\"middle\" align=\""+"left"+"\""+" style=\""+((-1==0) ? "display:none;" : "")+"\">") ;
            }
            /* Single line edit */
            ClassString = "Attribute" ;
            StyleString = "" ;
            ROClassString = ClassString ;
            Grid1Row.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edtGrupo_Tip_Internalname,StringUtil.RTrim( A275Grupo_Tip),(String)"",(short)0,(String)"px",(short)17,(String)"",(short)1,(short)-1,(short)0,(short)0,(short)0,(short)0,(String)"",(String)"",(String)StyleString,(String)ClassString,(String)ROClassString,StringUtil.RTrim( context.localUtil.Format( A275Grupo_Tip, "X")),(String)"",(short)0,(String)edtGrupo_Tip_Jsonclick,(String)"",(short)36,(short)1,(short)1,(bool)true,(String)"left"});
            Grid1Container.AddRow(Grid1Row);
            nGXsfl_36_idx = (short)(((subGrid1_Islastpage==1)&&(nGXsfl_36_idx+1>subGrid1_Recordsperpage( )) ? 1 : nGXsfl_36_idx+1)) ;
            sGXsfl_36_idx = StringUtil.PadL( StringUtil.LTrim( StringUtil.Str( (decimal)(nGXsfl_36_idx), 4, 0)), 4, "0") ;
            edtavLinkselection_Internalname = "vLINKSELECTION_"+sGXsfl_36_idx ;
            edtGrupo_Cod_Internalname = "GRUPO_COD_"+sGXsfl_36_idx ;
            edtGes_Cod_Internalname = "GES_COD_"+sGXsfl_36_idx ;
            edtGrupo_Des_Internalname = "GRUPO_DES_"+sGXsfl_36_idx ;
            edtGrupo_Tip_Internalname = "GRUPO_TIP_"+sGXsfl_36_idx ;
         }
         /* End function sendrow_362 */
      }

      protected void init_default_properties( )
      {
         lblTextblockgrupo_cod_Internalname = "TEXTBLOCKGRUPO_COD" ;
         edtavCgrupo_cod_Internalname = "vCGRUPO_COD" ;
         lblTextblockges_cod_Internalname = "TEXTBLOCKGES_COD" ;
         edtavCges_cod_Internalname = "vCGES_COD" ;
         lblTextblockgrupo_des_Internalname = "TEXTBLOCKGRUPO_DES" ;
         edtavCgrupo_des_Internalname = "vCGRUPO_DES" ;
         lblTextblockgrupo_tip_Internalname = "TEXTBLOCKGRUPO_TIP" ;
         edtavCgrupo_tip_Internalname = "vCGRUPO_TIP" ;
         tblTable2_Internalname = "TABLE2" ;
         grpGroup1_Internalname = "GROUP1" ;
         bttBtn_cancel_Internalname = "BTN_CANCEL" ;
         tblTable4_Internalname = "TABLE4" ;
         tblTable3_Internalname = "TABLE3" ;
         grpGroup2_Internalname = "GROUP2" ;
         tblTable1_Internalname = "TABLE1" ;
         Form.Internalname = "FORM" ;
         subGrid1_Internalname = "GRID1" ;
      }

      public override void initialize_properties( )
      {
         init_default_properties( ) ;
         edtGrupo_Tip_Jsonclick = "" ;
         edtGrupo_Des_Jsonclick = "" ;
         edtGes_Cod_Jsonclick = "" ;
         edtGrupo_Cod_Jsonclick = "" ;
         edtavCgrupo_tip_Jsonclick = "" ;
         edtavCgrupo_des_Jsonclick = "" ;
         edtavCges_cod_Jsonclick = "" ;
         edtavCgrupo_cod_Jsonclick = "" ;
         edtGrupo_Des_Link = "" ;
         edtavLinkselection_Link = "" ;
         subGrid1_Class = "Grid" ;
         subGrid1_Backcolorstyle = 2 ;
         Form.Headerrawhtml = "" ;
         Form.Background = "" ;
         Form.Backcolor = (int)(0xFFFFFF) ;
         Form.Caption = "Selection List Gestores por Grupo" ;
         context.GX_msglist.DisplayMode = 1 ;
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
      }

      public override void initialize( )
      {
         gxfirstwebparm = "" ;
         gxfirstwebparm_bkp = "" ;
         AV7cGes_Cod = "" ;
         AV8cGrupo_Des = "" ;
         AV9cGrupo_Tip = "" ;
         AV11pGes_Cod = "" ;
         sDynURL = "" ;
         FormProcess = "" ;
         GX_FocusControl = "" ;
         Form = new GXWebForm();
         sPrefix = "" ;
         sEvt = "" ;
         EvtGridId = "" ;
         EvtRowId = "" ;
         sEvtType = "" ;
         edtavLinkselection_Internalname = "" ;
         edtGrupo_Cod_Internalname = "" ;
         edtGes_Cod_Internalname = "" ;
         edtGrupo_Des_Internalname = "" ;
         edtGrupo_Tip_Internalname = "" ;
         AV5LinkSelection = "" ;
         A270Ges_Cod = "" ;
         A273Grupo_Des = "" ;
         A275Grupo_Tip = "" ;
         Grid1Container = new GXWebGrid( context);
         scmdbuf = "" ;
         lV7cGes_Cod = "" ;
         lV8cGrupo_Des = "" ;
         lV9cGrupo_Tip = "" ;
         H002M2_A275Grupo_Tip = new String[] {""} ;
         H002M2_A273Grupo_Des = new String[] {""} ;
         H002M2_A270Ges_Cod = new String[] {""} ;
         H002M2_A271Grupo_Cod = new short[1] ;
         H002M3_AGRID1_nRecordCount = new int[1] ;
         sStyleString = "" ;
         ClassString = "" ;
         StyleString = "" ;
         subGrid1_Linesclass = "" ;
         GXt_char3 = "" ;
         GXt_char2 = "" ;
         GXt_char1 = "" ;
         Grid1Column = new GXWebColumn();
         GXt_char5 = "" ;
         GXt_char4 = "" ;
         TempTags = "" ;
         bttBtn_cancel_Jsonclick = "" ;
         lblTextblockgrupo_cod_Jsonclick = "" ;
         lblTextblockges_cod_Jsonclick = "" ;
         lblTextblockgrupo_des_Jsonclick = "" ;
         lblTextblockgrupo_tip_Jsonclick = "" ;
         BackMsgLst = new msglist();
         LclMsgLst = new msglist();
         Grid1Row = new GXWebRow();
         ROClassString = "" ;
         GXt_char6 = "" ;
         pr_default = new DataStoreProvider(context, new GeneXus.Programs.gx00i0__default(),
            new Object[][] {
                new Object[] {
               H002M2_A275Grupo_Tip, H002M2_A273Grupo_Des, H002M2_A270Ges_Cod, H002M2_A271Grupo_Cod
               }
               , new Object[] {
               H002M3_AGRID1_nRecordCount
               }
            }
         );
         /* GeneXus formulas. */
         context.Gx_err = 0 ;
      }

      private short nGotPars ;
      private short GxWebError ;
      private short nRC_Grid1 ;
      private short nGXsfl_36_idx=1 ;
      private short AV6cGrupo_Cod ;
      private short AV10pGrupo_Cod ;
      private short initialized ;
      private short gxajaxcallmode ;
      private short GRID1_nEOF ;
      private short wbEnd ;
      private short wbStart ;
      private short A271Grupo_Cod ;
      private short nDonePA ;
      private short subGrid1_Rows ;
      private short subGrid1_Backcolorstyle ;
      private short subGrid1_Titlebackstyle ;
      private short subGrid1_Collapsed ;
      private short nGXWrapped ;
      private short subGrid1_Backstyle ;
      private int Grid1_PageSize36 ;
      private int GRID1_nFirstRecordOnPage ;
      private int subGrid1_Islastpage ;
      private int GRID1_nCurrentRecord ;
      private int GRID1_nRecordCount ;
      private int subGrid1_Titlebackcolor ;
      private int subGrid1_Allbackcolor ;
      private int idxLst ;
      private int subGrid1_Backcolor ;
      private String gxfirstwebparm ;
      private String gxfirstwebparm_bkp ;
      private String sGXsfl_36_idx="0001" ;
      private String AV7cGes_Cod ;
      private String AV8cGrupo_Des ;
      private String AV9cGrupo_Tip ;
      private String AV11pGes_Cod ;
      private String sDynURL ;
      private String FormProcess ;
      private String GX_FocusControl ;
      private String sPrefix ;
      private String sEvt ;
      private String EvtGridId ;
      private String EvtRowId ;
      private String sEvtType ;
      private String edtavLinkselection_Internalname ;
      private String edtGrupo_Cod_Internalname ;
      private String edtGes_Cod_Internalname ;
      private String edtGrupo_Des_Internalname ;
      private String edtGrupo_Tip_Internalname ;
      private String A270Ges_Cod ;
      private String A273Grupo_Des ;
      private String A275Grupo_Tip ;
      private String edtavCgrupo_cod_Internalname ;
      private String scmdbuf ;
      private String lV7cGes_Cod ;
      private String lV8cGrupo_Des ;
      private String lV9cGrupo_Tip ;
      private String edtavCges_cod_Internalname ;
      private String edtavCgrupo_des_Internalname ;
      private String edtavCgrupo_tip_Internalname ;
      private String sStyleString ;
      private String tblTable1_Internalname ;
      private String ClassString ;
      private String StyleString ;
      private String grpGroup1_Internalname ;
      private String grpGroup2_Internalname ;
      private String tblTable3_Internalname ;
      private String subGrid1_Internalname ;
      private String subGrid1_Class ;
      private String subGrid1_Linesclass ;
      private String GXt_char3 ;
      private String GXt_char2 ;
      private String GXt_char1 ;
      private String edtavLinkselection_Link ;
      private String edtGrupo_Des_Link ;
      private String GXt_char5 ;
      private String GXt_char4 ;
      private String tblTable4_Internalname ;
      private String TempTags ;
      private String bttBtn_cancel_Internalname ;
      private String bttBtn_cancel_Jsonclick ;
      private String tblTable2_Internalname ;
      private String lblTextblockgrupo_cod_Internalname ;
      private String lblTextblockgrupo_cod_Jsonclick ;
      private String edtavCgrupo_cod_Jsonclick ;
      private String lblTextblockges_cod_Internalname ;
      private String lblTextblockges_cod_Jsonclick ;
      private String edtavCges_cod_Jsonclick ;
      private String lblTextblockgrupo_des_Internalname ;
      private String lblTextblockgrupo_des_Jsonclick ;
      private String edtavCgrupo_des_Jsonclick ;
      private String lblTextblockgrupo_tip_Internalname ;
      private String lblTextblockgrupo_tip_Jsonclick ;
      private String edtavCgrupo_tip_Jsonclick ;
      private String ROClassString ;
      private String edtGrupo_Cod_Jsonclick ;
      private String edtGes_Cod_Jsonclick ;
      private String edtGrupo_Des_Jsonclick ;
      private String edtGrupo_Tip_Jsonclick ;
      private String GXt_char6 ;
      private bool entryPointCalled ;
      private bool wbLoad ;
      private bool Rfr0gs ;
      private bool wbErr ;
      private bool returnInSub ;
      private String AV5LinkSelection ;
      private GXMasterPage MasterPageObj ;
      private GXWebGrid Grid1Container ;
      private GXWebRow Grid1Row ;
      private GXWebColumn Grid1Column ;
      private IGxDataStore dsDESARROLLO ;
      private IGxDataStore dssoporte_notebook ;
      private IGxDataStore dsDefault ;
      private IDataStoreProvider pr_default ;
      private String[] H002M2_A275Grupo_Tip ;
      private String[] H002M2_A273Grupo_Des ;
      private String[] H002M2_A270Ges_Cod ;
      private short[] H002M2_A271Grupo_Cod ;
      private int[] H002M3_AGRID1_nRecordCount ;
      private msglist BackMsgLst ;
      private msglist LclMsgLst ;
      private short aP0_pGrupo_Cod ;
      private String aP1_pGes_Cod ;
      private GXWebForm Form ;
   }

   public class gx00i0__default : DataStoreHelperBase, IDataStoreHelper
   {
      public ICursor[] getCursors( )
      {
         cursorDefinitions();
         return new Cursor[] {
          new ForEachCursor(def[0])
         ,new ForEachCursor(def[1])
       };
    }

    private static CursorDef[] def;
    private void cursorDefinitions( )
    {
       if ( def == null )
       {
          Object[] prmH002M2 ;
          prmH002M2 = new Object[] {
          new Object[] {"@AV6cGrupo_Cod",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@AV7cGes_Cod",SqlDbType.Char,15,0} ,
          new Object[] {"@AV8cGrupo_Des",SqlDbType.Char,20,0} ,
          new Object[] {"@AV9cGrupo_Tip",SqlDbType.Char,1,0}
          } ;
          Object[] prmH002M3 ;
          prmH002M3 = new Object[] {
          new Object[] {"@AV6cGrupo_Cod",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@AV7cGes_Cod",SqlDbType.Char,15,0} ,
          new Object[] {"@AV8cGrupo_Des",SqlDbType.Char,20,0} ,
          new Object[] {"@AV9cGrupo_Tip",SqlDbType.Char,1,0}
          } ;
          def= new CursorDef[] {
              new CursorDef("H002M2", "SELECT [Grupo_Tip], [Grupo_Des], [Ges_Cod], [Grupo_Cod] FROM [GPO_GES] WITH (NOLOCK) WHERE ([Grupo_Cod] >= @AV6cGrupo_Cod) AND ([Ges_Cod] like @AV7cGes_Cod) AND ([Grupo_Des] like @AV8cGrupo_Des) AND ([Grupo_Tip] like @AV9cGrupo_Tip) ORDER BY [Grupo_Cod], [Ges_Cod]  OPTION (FAST 11)",false, GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK, false, this,prmH002M2,11,0,false,false )
             ,new CursorDef("H002M3", "SELECT COUNT(*) FROM [GPO_GES] WITH (NOLOCK) WHERE ([Grupo_Cod] >= @AV6cGrupo_Cod) AND ([Ges_Cod] like @AV7cGes_Cod) AND ([Grupo_Des] like @AV8cGrupo_Des) AND ([Grupo_Tip] like @AV9cGrupo_Tip) ",false, GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK, false, this,prmH002M3,1,0,false,false )
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
                ((String[]) buf[0])[0] = rslt.getString(1, 1) ;
                ((String[]) buf[1])[0] = rslt.getString(2, 20) ;
                ((String[]) buf[2])[0] = rslt.getString(3, 15) ;
                ((short[]) buf[3])[0] = rslt.getShort(4) ;
                break;
             case 1 :
                ((int[]) buf[0])[0] = rslt.getInt(1) ;
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
                stmt.SetParameter(1, (short)parms[0]);
                stmt.SetParameter(2, (String)parms[1]);
                stmt.SetParameter(3, (String)parms[2]);
                stmt.SetParameter(4, (String)parms[3]);
                break;
             case 1 :
                stmt.SetParameter(1, (short)parms[0]);
                stmt.SetParameter(2, (String)parms[1]);
                stmt.SetParameter(3, (String)parms[2]);
                stmt.SetParameter(4, (String)parms[3]);
                break;
       }
    }

 }

}
