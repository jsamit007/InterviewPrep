Core / Basics

Angular architecture overview (Modules, Components, Templates, Services, DI)

Components: lifecycle hooks, inputs/outputs, view vs content children, change detection interaction

Templates & data binding: interpolation, property binding, event binding, two-way (ngModel)

Directives: structural (*ngIf, *ngFor) and attribute (custom directives)

Pipes: built-in pipes, custom pure/impure pipes

Dependency Injection (DI)

Providers scope: root, module, component, providedIn

Provider types: class, value, factory, useExisting

Hierarchical injector behavior and multi providers

Injection tokens, forwardRef

Change Detection & Performance

Zone.js basics vs OnPush strategy

Default vs OnPush change detection

markForCheck, detectChanges, ChangeDetectorRef

trackBy for *ngFor, avoiding expensive computations in templates

Lazy loading, preloading strategies

Virtual scroll, CDK optimizations

Forms

Template-driven forms: ngModel, validation, ngForm

Reactive forms: FormControl, FormGroup, FormArray, custom validators, async validators

Form performance, valueChanges, patchValue vs setValue

Routing & Navigation

Router basics: routes, child routes, auxiliary routes

Route guards: CanActivate, CanActivateChild, CanDeactivate, Resolve

Lazy loading modules, route preloading, router events, param vs queryParam

Route reuse strategies, scroll restoration

RxJS & Reactive Programming

Observables vs Promises, Subjects, BehaviorSubject, ReplaySubject, AsyncSubject

Operators: creation, transformation, filtering, combination, error handling (map, switchMap, mergeMap, concatMap, forkJoin, combineLatest, catchError, takeUntil)

Subscription management: async pipe, takeUntil, memory leak pitfalls

Hot vs cold observables

State Management

Component/local state patterns

Services as singletons for shared state

NgRx (store, actions, reducers, effects, selectors) — or alternatives (Akita, signal-based approaches)

When to use global state vs local

Component Communication Patterns

Parent ↔ child via @Input() / @Output()

Shared service approach with Subjects

@ViewChild, @ContentChild, dynamic component creation (ComponentFactoryResolver, ViewContainerRef)

Event buses and pitfalls

HTTP, Interceptors & Backend Integration

HttpClient: request/response types, typed responses

Interceptors: auth token handling, error handling, caching

Retry, backoff strategies, cancellation (takeUntil, AbortController)

Modules & Architecture

NgModule structure: declarations, imports, exports, providers, entryComponents

Feature modules vs Shared vs Core

Barrel (index) files, library packaging

Micro-frontend patterns (Module Federation)

Testing

Unit testing: TestBed, shallow vs integrated, component/service testing

Mocks, spies (spyOn), fakeAsync vs async, tick

E2E testing: Cypress or Playwright (Protractor deprecated)

Coverage and testing strategy

Build / Tooling / CI

Angular CLI usage, schematics

AOT vs JIT compilation

Differential loading / bundle formats, source maps

Optimizations: file replacements, budgets, bundle analysis (source-map-explorer)

CI pipelines and deployment basics

Styles / UI / Accessibility

View encapsulation modes, global styles

Component libraries: Angular Material, CDK, other UI libs

Accessibility (a11y): ARIA attributes, keyboard navigation, semantic HTML

Security

XSS in templates, bypassSecurityTrust* and risks

CSRF basics, secure storage of tokens, sameSite cookies recommendations

Input validation and server trust boundaries

Advanced Topics

Ivy runtime & compilation fundamentals

Angular Elements (web components)

Server-side rendering (Angular Universal)

Transfer state, hydration

Web Workers for heavy computations

Custom renderers (rare)

Design Patterns & Best Practices

Smart vs dumb components

Facade pattern for services

Command / CQRS-ish patterns on the client

Folder structure conventions and scalable app organization

Debugging & Troubleshooting

Common errors and stack traces, using Augury/DevTools

Performance profiling, memory leak detection

Source maps and diagnosing prod issues

Interview-Focused Practicals

Live coding tasks: create component, implement service, make reactive form, fetch data + show list with pagination

Whiteboard: architecture for a large app, lazy loading strategy, state management choice

Behavioral / system questions: tradeoffs between approaches, how you handled a tricky bug, testing approach
